using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using GranDT.Core;
using GranDT.Dapper;
using GranDT.Core.Repos;

namespace GRANDT
{
    public partial class AltaFutbolistaAdminForm : Form
    {
        private IRepoFutbolista? _repo;
        private List<TipoJugador> _tiposJugador = new List<TipoJugador>();
        private List<Equipo> _equipos = new List<Equipo>();

        public AltaFutbolistaAdminForm()
        {
            InitializeComponent();
        }

        private void AltaFutbolistaAdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                IDbConnection conexion = Conexion.ObtenerConexion();
                _repo = new RepoFutbolista(conexion);

                // Cargar tipos (si no hay SP para tipos, usar lista fija)
                _tiposJugador = new List<TipoJugador>
                {
                    new TipoJugador { idTipoJugador = 1, Nombre = "Arquero" },
                    new TipoJugador { idTipoJugador = 2, Nombre = "Defensor" },
                    new TipoJugador { idTipoJugador = 3, Nombre = "Mediocampista" },
                    new TipoJugador { idTipoJugador = 4, Nombre = "Delantero" }
                };

                TipoComboBox.DataSource = _tiposJugador;
                TipoComboBox.DisplayMember = "Nombre";
                TipoComboBox.ValueMember = "idTipoJugador";

                // Cargar equipos desde repo
                _equipos = _repo.TraerEquipo().ToList();
                EquipoComboBox.DataSource = _equipos;
                EquipoComboBox.DisplayMember = "Nombre";
                EquipoComboBox.ValueMember = "idEquipo";

                if (TipoComboBox.Items.Count > 0) TipoComboBox.SelectedIndex = 0;
                if (EquipoComboBox.Items.Count > 0) EquipoComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SeleccionarPlantilla s = new SeleccionarPlantilla(DataGlobals.UsuarioLogueado);
            s.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text?.Trim() ?? string.Empty;
            string apellido = txtApellido.Text?.Trim() ?? string.Empty;
            string apodo = txtApodo.Text?.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Ingrese nombre y apellido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCotizacion.Text, out decimal cotizacion))
            {
                MessageBox.Show("Ingrese una cotización válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fecha = dateTimePicker1.Value;

            try
            {
                if (_repo == null)
                {
                    MessageBox.Show("Repositorio no inicializado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                uint tipoId = Convert.ToUInt32(((TipoJugador)TipoComboBox.SelectedItem).idTipoJugador);
                uint equipoId = Convert.ToUInt32(((Equipo)EquipoComboBox.SelectedItem).idEquipo);

                Futbolistas futbolista = new Futbolistas
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Apodo = string.IsNullOrWhiteSpace(apodo) ? null : apodo,
                    FechadeNacimiento = fecha,
                    Cotizacion = cotizacion,
                    idTipoJugador = tipoId,
                    idEquipo = equipoId
                };

                int id = _repo.AltaFutbolista(futbolista);
                MessageBox.Show($"Futbolista creado con id {id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SeleccionarPlantilla s = new SeleccionarPlantilla(DataGlobals.UsuarioLogueado);
                s.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear futbolista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
