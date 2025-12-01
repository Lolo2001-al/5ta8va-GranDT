using GranDT.Core;
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
        private Usuario? _usuarioLogeado;
        private Plantillas? _plantillaSeleccionada;

        public edicionPlantilla(Plantillas plantilla)
        {
            InitializeComponent();
            _plantillaSeleccionada = plantilla;
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
            // Mostrar jugadores fichados en la plantilla si están cargados
            try
            {
                if (_plantillaSeleccionada?.JugadoresEnPlantilla != null)
                {
                    var lista = _plantillaSeleccionada.JugadoresEnPlantilla.Select(f => new
                    {
                        f.idFutbolista,
                        Nombre = f.Nombre,
                        Apellido = f.Apellido,
                        Apodo = f.Apodo ?? "",
                        FechaNacimiento = f.FechadeNacimiento.ToString("yyyy-MM-dd"),
                        Cotizacion = f.Cotizacion
                    }).ToList();

                    // Intentar encontrar un DataGridView llamado 'JugadoresDataGridView' o 'dataGridView1'
                    DataGridView dgv = this.Controls.OfType<DataGridView>().FirstOrDefault() ?? new DataGridView();

                    dgv.DataSource = null;
                    dgv.AutoGenerateColumns = true;
                    dgv.DataSource = lista;

                    // If the dgv was not part of the designer, add it to the form (this is a fallback)
                    if (!this.Controls.Contains(dgv))
                    {
                        dgv.Dock = DockStyle.Fill;
                        this.Controls.Add(dgv);
                    }

                    // Mostrar presupuesto, gastado y restante
                    decimal presupuesto = (decimal)(_plantillaSeleccionada.Presupuesto);
                    decimal gastado = _plantillaSeleccionada.JugadoresEnPlantilla.Sum(j => j.Cotizacion);
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar jugadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
