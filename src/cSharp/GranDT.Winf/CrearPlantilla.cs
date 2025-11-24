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
    public partial class CrearPlantilla : Form
    {
        private Usuario? _usuarioLogeado;
        private IRepoPlantilla? _repoPlantilla;
        private List<Equipo>? _equipos;

        public CrearPlantilla(GranDT.Core.Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogeado = usuario;
            DataGlobals.SetUsuario(_usuarioLogeado);
            _equipos = new List<Equipo>();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Inicializar repositorios
            IDbConnection conexion = Conexion.ObtenerConexion();
            _repoPlantilla = new RepoPlantilla(conexion);
            
            // Cargar equipos en el ComboBox
            CargarEquipos();
        }

        private void CrearPlantilla_Load(object sender, EventArgs e)
        {
            Form_Load(sender, e);
        }

        private void CargarEquipos()
        {
            try
            {
                // Por ahora, vamos a cargar equipos si existe RepoEquipo
                // Si no existe, podemos dejar el ComboBox vacío o con valores por defecto
                EquipoBox.Items.Clear();
                EquipoBox.Items.Add("Equipo 1");
                EquipoBox.Items.Add("Equipo 2");
                EquipoBox.Items.Add("Equipo 3");
                EquipoBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar equipos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(_usuarioLogeado);
            form6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionarPlantilla form9 = new SeleccionarPlantilla(_usuarioLogeado);
            form9.Show();
            this.Hide();
        }

        private void altaPlantilla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreBox.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre para la plantilla", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EquipoBox.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecciona un equipo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_usuarioLogeado == null)
                {
                    MessageBox.Show("Usuario no logeado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear nueva plantilla usando el namespace explícito
                GranDT.Core.Plantillas nuevaPlantilla = new GranDT.Core.Plantillas
                {
                    Nombre = NombreBox.Text.Trim(),
                    idUsuario = (int)_usuarioLogeado.IdUsuario,
                    idEquipo = (uint)(EquipoBox.SelectedIndex + 1), // Usar índice como ID por ahora
                    Presupuesto = 65000000, // Presupuesto fijo por ahora
                    MaxJugadores = 11 // Máximo de jugadores por defecto
                };

                // Guardar la plantilla
                if (_repoPlantilla == null)
                {
                    MessageBox.Show("Error: Repositorio no inicializado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idPlantilla = _repoPlantilla.AltaPlantilla(nuevaPlantilla);

                if (idPlantilla > 0)
                {
                    MessageBox.Show($"Plantilla creada exitosamente con ID: {idPlantilla}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Limpiar campos
                    NombreBox.Clear();
                    EquipoBox.SelectedIndex = 0;
                    
                    // Volver a SeleccionarPlantilla
                    SeleccionarPlantilla form9 = new SeleccionarPlantilla(_usuarioLogeado);
                    form9.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al crear la plantilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la plantilla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
