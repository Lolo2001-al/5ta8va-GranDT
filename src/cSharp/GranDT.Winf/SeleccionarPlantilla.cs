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
    public partial class SeleccionarPlantilla : Form
    {
        private Usuario? _usuarioLogeado;
        private IRepoPlantilla? _repoPlantilla;
        private List<Plantillas>? _plantillasUsuario;

        private void VerificarUsuarioLogueado()
        {
            if (!DataGlobals.EstaLogueado())
            {
                MessageBox.Show("Usuario no logeado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InicioSecion f = new InicioSecion();
                f.Show();
                this.Close();
            }
        }
        public SeleccionarPlantilla()
        {
            InitializeComponent();
            _plantillasUsuario = new List<Plantillas>();
        }

        public SeleccionarPlantilla(GranDT.Core.Usuario usuario)
        {
            InitializeComponent();
            DataGlobals.SetUsuario(usuario);
            _usuarioLogeado = usuario;
            _plantillasUsuario = new List<Plantillas>();
            VerificarUsuarioLogueado();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Inicializar el repositorio de plantillas
            IDbConnection conexion = Conexion.ObtenerConexion();
            _repoPlantilla = new RepoPlantilla(conexion);

            // Cargar las plantillas del usuario logeado
            CargarPlantillas();

            // Mostrar botones de administración si el usuario es admin
            if (_usuarioLogeado != null && _usuarioLogeado.esAdmin)
            {
                btnAltaEquipo.Visible = true;
                btnAltaJugadorAdmin.Visible = true;
                btnAltaPuntuacion.Visible = true;
            }
            else
            {
                btnAltaEquipo.Visible = false;
                btnAltaJugadorAdmin.Visible = false;
                btnAltaPuntuacion.Visible = false;
            }
        }

        private void SeleccionarPlantilla_Load(object sender, EventArgs e)
        {
            Form_Load(sender, e);
        }

        private void CargarPlantillas()
        {
            try
            {
                if (_usuarioLogeado == null)
                {
                    MessageBox.Show("Error: Usuario no logeado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_repoPlantilla == null)
                {
                    MessageBox.Show("Error: Repositorio no inicializado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _plantillasUsuario = _repoPlantilla.TraerPlantillasPorIdUsuario((int)_usuarioLogeado.IdUsuario).ToList();

                PlantillaComboBox.Items.Clear();

                if (_plantillasUsuario == null || _plantillasUsuario.Count == 0)
                {
                    PlantillaComboBox.Items.Add("No hay plantillas disponibles");
                    PlantillaComboBox.SelectedIndex = 0;
                    PlantillaComboBox.Enabled = false;
                }
                else
                {
                    foreach (var plantilla in _plantillasUsuario)
                    {
                        PlantillaComboBox.Items.Add($"{plantilla.Nombre} - {plantilla.Equipo?.Nombre ?? "Sin Equipo"}");
                    }
                    PlantillaComboBox.SelectedIndex = 0;
                    PlantillaComboBox.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar plantillas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearPlantilla form8 = new CrearPlantilla(_usuarioLogeado);
            form8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(_usuarioLogeado);
            form6.Show();
            this.Hide();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Plantillas plantillaSeleccionada = _plantillasUsuario[PlantillaComboBox.SelectedIndex];
            AltaFutbolista formAltaFutbolista = new AltaFutbolista(plantillaSeleccionada);
            formAltaFutbolista.Show();
            this.Hide();
        }

        // Admin button handlers
        private void btnAltaEquipo_Click(object? sender, EventArgs e)
        {
            AltaEquipoForm f = new AltaEquipoForm();
            f.Show();
            this.Hide();
        }

        private void btnAltaJugadorAdmin_Click(object? sender, EventArgs e)
        {
            // Open the admin AltaFutbolista form
            AltaFutbolistaAdminForm f = new AltaFutbolistaAdminForm();
            f.Show();
            this.Hide();
        }

        private void btnAltaPuntuacion_Click(object? sender, EventArgs e)
        {
            AltaPuntuacionForm f = new AltaPuntuacionForm();
            f.Show();
            this.Hide();
        }
    }
}
