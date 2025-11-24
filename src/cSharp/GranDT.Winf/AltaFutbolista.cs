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

            // Cargar tipos de jugadores
            CargarTiposJugadores();

            // Si hay una plantilla seleccionada, cargar futbolistas del equipo
            if (_plantillaSeleccionada != null && TipoComboBox.Items.Count > 0)
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
            if (_plantillaSeleccionada == null || _repoFutbolista == null)
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
                uint idEquipo = _plantillaSeleccionada.idEquipo;

                // Obtener futbolistas por tipo y equipo
                _futbolistasFiltrados = _repoFutbolista.TraerFutbolistasBasicoXTipoXEquipo(
                    tipoSeleccionado.idTipoJugador,
                    idEquipo
                ).ToList();

                // Actualizar el ComboBox de futbolistas
                Futbolista.Items.Clear();
                foreach (var futbolista in _futbolistasFiltrados)
                {
                    string nombreCompleto = $"{futbolista.Nombre} {futbolista.Apellido}";
                    if (!string.IsNullOrEmpty(futbolista.Apodo))
                    {
                        nombreCompleto += $" ({futbolista.Apodo})";
                    }
                    Futbolista.Items.Add(nombreCompleto);
                }

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
                Cotizacion = f.Cotizacion
            }).ToList();
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
    }
}
