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

        public SeleccionarPlantilla()
        {
            InitializeComponent();
            _plantillasUsuario = new List<Plantillas>();
        }

        public SeleccionarPlantilla(GranDT.Core.Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogeado = usuario;
            _plantillasUsuario = new List<Plantillas>();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Inicializar el repositorio de plantillas
            IDbConnection conexion = Conexion.ObtenerConexion();
            _repoPlantilla = new RepoPlantilla(conexion);

            // Cargar las plantillas del usuario logeado
            CargarPlantillas();
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
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void Seleccionarplantilla_Click(object sender, EventArgs e)
        {
            if (PlantillaComboBox.SelectedIndex < 0 || _plantillasUsuario == null || _plantillasUsuario.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una plantilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Plantillas plantillaSeleccionada = _plantillasUsuario[PlantillaComboBox.SelectedIndex];
            
            // Abrir AltaFutbolista con la plantilla seleccionada
            AltaFutbolista formAltaFutbolista = new AltaFutbolista(plantillaSeleccionada);
            formAltaFutbolista.Show();
            this.Hide();
        }
    }
}
