using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GranDT.Core;
using GranDT.Core.Repos;
using GranDT.Dapper;

namespace GRANDT
{
    public partial class AltaFutbolista : Form
    {
        private Usuario? _usuarioLogeado;
        private Plantillas? _plantillaSeleccionada;
        private IRepoFutbolista? _repoFutbolista;
        private IRepoPlantilla? _repoPlantilla;
        private List<TipoJugador> _tiposJugador;
        private List<Futbolistas>? _futbolistasFiltrados;

        public AltaFutbolista()
        {
            InitializeComponent();
            _tiposJugador = new List<TipoJugador>();
        }

        public AltaFutbolista(Plantillas plantilla)
        {
            InitializeComponent();
            _plantillaSeleccionada = plantilla;
            _tiposJugador = new List<TipoJugador>();
            _futbolistasFiltrados = new List<Futbolistas>();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Inicializar el repositorio
            IDbConnection conexion = Conexion.ObtenerConexion();
            _repoFutbolista = new RepoFutbolista(conexion);
            _repoPlantilla = new RepoPlantilla(conexion);

            // Cargar tipos de jugadores
            CargarTiposJugadores();

            // Si hay una plantilla seleccionada o no, cargar futbolistas (mostramos todos)
            if (TipoComboBox.Items.Count > 0)
            {
                TipoComboBox.SelectedIndex = 0;
                ActualizarFutbolistas();
            }
        }

        private void CargarTiposJugadores()
        {
            // Cargar los tipos de jugadores (Arquero, Defensor, Mediocampista, Delantero)
            _tiposJugador = new List<TipoJugador>
            {
                new TipoJugador { idTipoJugador = 1, Nombre = "Arquero" },
                new TipoJugador { idTipoJugador = 2, Nombre = "Defensor" },
                new TipoJugador { idTipoJugador = 3, Nombre = "Mediocampista" },
                new TipoJugador { idTipoJugador = 4, Nombre = "Delantero" }
            };

            TipoComboBox.Items.Clear();
            foreach (var tipo in _tiposJugador)
            {
                TipoComboBox.Items.Add(tipo.Nombre);
            }
        }

        private void ActualizarFutbolistas()
        {
            if (_repoFutbolista == null)
            {
                return;
            }

            if (TipoComboBox.SelectedIndex < 0 || TipoComboBox.SelectedIndex >= _tiposJugador.Count)
            {
                return;
            }

            try
            {
                TipoJugador tipoSeleccionado = _tiposJugador[TipoComboBox.SelectedIndex];
                uint idEquipo = 0; // 0 => todos los equipos

                // Obtener futbolistas por tipo y equipo (0 para todos los equipos)
                _futbolistasFiltrados = _repoFutbolista.TraerFutbolistasBasicoXTipoXEquipo(
                    tipoSeleccionado.idTipoJugador,
                    idEquipo
                ).ToList();



                // Actualizar el DataGridView
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar futbolistas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView()
        {
            if (_futbolistasFiltrados == null)
            {
                return;
            }

            FutbolistasDataGridView.DataSource = null;
            FutbolistasDataGridView.AutoGenerateColumns = true;
            FutbolistasDataGridView.DataSource = _futbolistasFiltrados.Select(f => new
            {
                f.idFutbolista,
                Nombre = f.Nombre,
                Apellido = f.Apellido,
                Apodo = f.Apodo ?? "",
                FechaNacimiento = f.FechadeNacimiento.ToString("yyyy-MM-dd"),
                Cotizacion = f.Cotizacion,
                Nota = f.Nota,
            }).ToList();

            // Allow selecting multiple rows so user can fichar varios jugadores a la vez
            FutbolistasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FutbolistasDataGridView.MultiSelect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(DataGlobals.UsuarioLogueado);
            form6.Show();
            this.Hide();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            ActualizarFutbolistas();
        }

        private void TipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarFutbolistas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edicionPlantilla edicionPlantilla = new edicionPlantilla(_plantillaSeleccionada);
            edicionPlantilla.Show();
            this.Hide();
        }

        private void Fichar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_repoPlantilla == null)
                {
                    MessageBox.Show("Error: repositorio de plantillas no inicializado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_plantillaSeleccionada == null)
                {
                    MessageBox.Show("Seleccione primero una plantilla válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRows = FutbolistasDataGridView.SelectedRows.Cast<DataGridViewRow>().ToList();
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione uno o más jugadores para fichar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal presupuesto = (decimal)(_plantillaSeleccionada.Presupuesto);
                decimal gastoActual = 0m;
                if (_plantillaSeleccionada.JugadoresEnPlantilla != null)
                {
                    gastoActual = _plantillaSeleccionada.JugadoresEnPlantilla.Sum(j => j.Cotizacion);
                }

                int signedCount = 0;
                var failedDueBudget = new List<string>();
                var alreadyInPlantilla = new List<string>();

                foreach (var row in selectedRows)
                {
                    int idFutbolista = 0;
                    var boundItem = row.DataBoundItem;
                    if (boundItem != null)
                    {
                        dynamic d = boundItem;
                        idFutbolista = (int)d.idFutbolista;
                    }
                    else
                    {
                        idFutbolista = Convert.ToInt32(row.Cells[0].Value);
                    }

                    var jugadorObj = _futbolistasFiltrados?.FirstOrDefault(f => f.idFutbolista == idFutbolista);
                    if (jugadorObj == null)
                    {
                        // intentar continuar con el siguiente
                        continue;
                    }

                    string nombre = $"{jugadorObj.Nombre} {jugadorObj.Apellido}";

                    // comprobar si ya está en la plantilla
                    if (_plantillaSeleccionada.JugadoresEnPlantilla != null && _plantillaSeleccionada.JugadoresEnPlantilla.Any(f => f.idFutbolista == idFutbolista))
                    {
                        alreadyInPlantilla.Add(nombre);
                        continue;
                    }

                    // comprobar presupuesto
                    if (gastoActual + jugadorObj.Cotizacion > presupuesto)
                    {
                        failedDueBudget.Add(nombre);
                        continue;
                    }

                    // Dar de alta jugador en la plantilla (no titular por defecto)
                    _repoPlantilla.AltaJugadorEnPlantilla(idFutbolista, _plantillaSeleccionada.idPlantilla, false);

                    // Actualizar la colección local de jugadores en la plantilla
                    var lista = _plantillaSeleccionada.JugadoresEnPlantilla?.ToList() ?? new List<Futbolistas>();
                    lista.Add(jugadorObj);
                    _plantillaSeleccionada.JugadoresEnPlantilla = lista;

                    gastoActual += jugadorObj.Cotizacion;
                    signedCount++;
                }

                var mensajes = new List<string>();
                if (signedCount > 0) mensajes.Add($"Jugadores fichados: {signedCount}");
                if (alreadyInPlantilla.Count > 0) mensajes.Add($"Ya estaban en la plantilla: {string.Join(", ", alreadyInPlantilla)}");
                if (failedDueBudget.Count > 0) mensajes.Add($"No se ficharon por presupuesto: {string.Join(", ", failedDueBudget)}");

                MessageBox.Show(string.Join("\n", mensajes), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al fichar jugador(es): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FutbolistasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
