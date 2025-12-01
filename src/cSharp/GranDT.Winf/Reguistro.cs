
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
    public partial class Reguistro : Form
    {
        private IRepoUsuario _repoUsuario;

        public Reguistro()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Inicializar el repositorio
            IDbConnection conexion = Conexion.ObtenerConexion();
            _repoUsuario = new RepoUsuario(conexion);
        }

        private void Reguistro_Load(object sender, EventArgs e)
        {
            Form_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(NombreBox.Text) ||
                string.IsNullOrWhiteSpace(ApellidoBox.Text) ||
                string.IsNullOrWhiteSpace(EmailBox.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(NacimientoBox.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar formato de fecha
            if (!DateTime.TryParse(NacimientoBox.Text, out DateTime fechaNacimiento))
            {
                MessageBox.Show("Formato de fecha inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Crear nuevo usuario
                Usuario nuevoUsuario = new Usuario
                {
                    Nombre = NombreBox.Text.Trim(),
                    Apellido = ApellidoBox.Text.Trim(),
                    Email = EmailBox.Text.Trim(),
                    FechadeNacimiento = fechaNacimiento,
                    Contrasena = textBox1.Text,
                    esAdmin = false
                };

                // Registrar el usuario
                int idUsuario = _repoUsuario.AltaUsuario(nuevoUsuario);

                if (idUsuario > 0)
                {
                    MessageBox.Show($"Usuario registrado exitosamente con ID: {idUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Limpiar campos
                    LimpiarCampos();
                    
                    // Volver al formulario de inicio de sesión
                    InicioSecion formLogin = new InicioSecion();
                    formLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            NombreBox.Clear();
            ApellidoBox.Clear();
            EmailBox.Clear();
            textBox1.Clear();
            NacimientoBox.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSecion form1 = new InicioSecion();
            form1.Show();
            this.Hide();
        }
    }
}