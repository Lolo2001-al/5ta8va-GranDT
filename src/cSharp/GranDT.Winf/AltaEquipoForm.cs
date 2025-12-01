using System;
using System.Data;
using System.Windows.Forms;
using GranDT.Core;
using GranDT.Dapper;

namespace GRANDT
{
    public partial class AltaEquipoForm : Form
    {
        public AltaEquipoForm()
        {
            InitializeComponent();
        }

        private void AltaEquipoForm_Load(object sender, EventArgs e)
        {

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
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese un nombre de equipo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                IDbConnection conexion = Conexion.ObtenerConexion();
                var repo = new RepoFutbolista(conexion);
                var idNuevo = repo.AltaEquipo(nombre);
                MessageBox.Show($"Equipo creado con id {idNuevo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SeleccionarPlantilla s = new SeleccionarPlantilla(DataGlobals.UsuarioLogueado);
                s.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}