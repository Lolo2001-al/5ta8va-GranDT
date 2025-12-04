using GranDT.Core;
using GranDT.Core.Repos;
using GranDT.Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRANDT
{
    public partial class edicionPlantilla : Form
    {
        private Plantillas? _plantillaSeleccionada;
        private IRepoPlantilla? _repoPlantilla;

        public edicionPlantilla(Plantillas plantilla)
        {
            InitializeComponent();
            _plantillaSeleccionada = plantilla;
            _repoPlantilla = new RepoPlantilla(Conexion.ObtenerConexion());
            CargarDGVFutbolistas(_plantillaSeleccionada.JugadoresEnPlantilla);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaFutbolista formAltaFutbolista = new AltaFutbolista(_plantillaSeleccionada);
            formAltaFutbolista.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void edicionPlantilla_Load(object sender, EventArgs e)
        {
            // Mostrar jugadores fichados en la plantilla usando TraerPlantillasPorIdUsuario
            try
            {
                if (_repoPlantilla != null && DataGlobals.EstaLogueado())
                {
                    // Obtener todas las plantillas del usuario logueado
                    var plantillasDelUsuario = _repoPlantilla.TraerPlantillasPorIdUsuario((int)DataGlobals.IdUsuarioLogueado);

                    // Filtrar la plantilla actual
                    var plantillaActual = plantillasDelUsuario.FirstOrDefault(p => p.idPlantilla == _plantillaSeleccionada?.idPlantilla);

                    if (plantillaActual?.JugadoresEnPlantilla != null)
                    {
                        /*var lista = plantillaActual.JugadoresEnPlantilla.Select(f => new
                        {
                            f.idFutbolista,
                            Nombre = f.Nombre,
                            Apellido = f.Apellido,
                            Apodo = f.Apodo ?? "",
                            FechaNacimiento = f.FechadeNacimiento.ToString("yyyy-MM-dd"),
                            Cotizacion = f.Cotizacion,
                            Nota = f.Nota,
                        }).ToList();*/

                        // Intentar encontrar un DataGridView llamado 'JugadoresDataGridView' o 'dataGridView1'
                        CargarDGVFutbolistas(plantillaActual.JugadoresEnPlantilla);

                        // Mostrar presupuesto, gastado y restante
                        decimal presupuesto = (decimal)(plantillaActual.Presupuesto);
                        decimal gastado = plantillaActual.JugadoresEnPlantilla.Sum(j => j.Cotizacion);
                        decimal restante = presupuesto - gastado;

                        // Intentar encontrar un Label llamado 'lblPresupuesto' en el diseñador
                        Label lblPresupuesto = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == "lblPresupuesto") ?? new Label();
                        lblPresupuesto.Text = $"Presupuesto: {presupuesto:C0}  Gastado: {gastado:C0}  Restante: {restante:C0}";

                        if (!this.Controls.Contains(lblPresupuesto))
                        {
                            lblPresupuesto.Dock = DockStyle.Top;
                            lblPresupuesto.Height = 30;
                            lblPresupuesto.TextAlign = ContentAlignment.MiddleCenter;
                            this.Controls.Add(lblPresupuesto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar jugadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDGVFutbolistas(IEnumerable<Futbolistas> lista)
        {
            DataGridView dgv = this.Controls.OfType<DataGridView>().FirstOrDefault() ?? new DataGridView();

            dgv.AutoGenerateColumns = true;
            dgv.DataSource = lista;

            // If the dgv was not part of the designer, add it to the form (this is a fallback)
            if (!this.Controls.Contains(dgv))
            {
                dgv.Dock = DockStyle.Fill;
                this.Controls.Add(dgv);
            }
        }
    }
}
