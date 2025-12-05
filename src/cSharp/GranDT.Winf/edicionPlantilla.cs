using Dapper;
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
            // Mostrar jugadores fichados en la plantilla usando una consulta directa si es necesario
            try
            {
                if (_repoPlantilla != null && DataGlobals.EstaLogueado() && _plantillaSeleccionada != null)
                {
                    // Intentar obtener los futbolistas directamente desde la BD usando Dapper
                    IEnumerable<Futbolistas> jugadores = Enumerable.Empty<Futbolistas>();

                    try
                    {
                        using (var conn = Conexion.ObtenerConexion())
                        {
                            // Este SP devuelve filas planas con datos de plantilla + futbolista.
                            // Consultamos el mismo SP pero mapeamos solo a Futbolistas; Dapper ignorará columnas extras.
                            jugadores = conn.Query<Futbolistas>(
                                "PlantillasPorIdUsuarioJ",
                                new { UnidPlantilla = _plantillaSeleccionada.idPlantilla },
                                commandType: CommandType.StoredProcedure
                            ).ToList();
                        }
                    }
                    catch
                    {
                        // Si la consulta directa falla, intentamos usar el repo como respaldo
                        var plantillasRepo = _repoPlantilla.TraerPlantillasPorIdUsuarioJ(_plantillaSeleccionada.idPlantilla);
                        var plantillaRepo = plantillasRepo.FirstOrDefault();
                        if (plantillaRepo?.JugadoresEnPlantilla != null)
                        {
                            jugadores = plantillaRepo.JugadoresEnPlantilla;
                        }
                    }

                    // Asegurar que la plantilla seleccionada tenga la colección actualizada
                    _plantillaSeleccionada.JugadoresEnPlantilla = jugadores ?? new List<Futbolistas>();

                    // Mostrar todos los futbolistas de la plantilla en el DataGridView (solo lectura)
                    CargarDGVFutbolistas(_plantillaSeleccionada.JugadoresEnPlantilla);

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

        private void CargarDGVFutbolistas(IEnumerable<Futbolistas> lista)
        {
            DataGridView dgv = this.Controls.OfType<DataGridView>().FirstOrDefault() ?? new DataGridView();

            // Definir columnas explícitas en modo solo lectura para mostrar Nombre, Apodo y Cotización
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "idFutbolista", DataPropertyName = "idFutbolista", HeaderText = "ID", ReadOnly = true, Visible = false });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", DataPropertyName = "Nombre", HeaderText = "Nombre", ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Apodo", DataPropertyName = "Apodo", HeaderText = "Apodo", ReadOnly = true });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cotizacion", DataPropertyName = "Cotizacion", HeaderText = "Cotización", ReadOnly = true });

            var source = lista.Select(f => new
            {
                f.idFutbolista,
                Nombre = f.Nombre,
                Apodo = f.Apodo ?? string.Empty,
                Cotizacion = f.Cotizacion
            }).ToList();

            dgv.DataSource = source;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            if (!this.Controls.Contains(dgv))
            {
                dgv.Dock = DockStyle.Fill;
                this.Controls.Add(dgv);
            }
        }
    }
}
