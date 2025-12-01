using GranDT.Core;
using GranDT.Core.Repos;
using GranDT.Dapper;
using System.Data;

namespace GRANDT
{
    public partial class InicioSecion : Form
    {
        private IRepoUsuario _repoUsuario;
        private Usuario? _usuarioLogeado;

        public InicioSecion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar el repositorio
            IDbConnection conexion = Conexion.ObtenerConexion();
            _repoUsuario = new RepoUsuario(conexion);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSecion_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text.Trim();
            string contrasena = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _usuarioLogeado = _repoUsuario.LoginUsuario(email, contrasena);

                if (_usuarioLogeado != null)
                {
                    DataGlobals.SetUsuario(_usuarioLogeado);

                    MessageBox.Show($"Bienvenido {_usuarioLogeado.Nombre}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Pasar el usuario logeado a la siguiente pantalla
                    SeleccionarPlantilla formSeleccionar = new SeleccionarPlantilla(_usuarioLogeado);
                    formSeleccionar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email o contraseña incorrectos", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSecion_Click(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reguistro form2 = new Reguistro();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
