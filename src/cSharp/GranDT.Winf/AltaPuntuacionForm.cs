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
    public partial class AltaPuntuacionForm : Form
    {
        private List<Futbolistas> _jugadores = new List<Futbolistas>();
        private IRepoFutbolista? _repo;

        public AltaPuntuacionForm()
        {
            InitializeComponent();
        }

        private void AltaPuntuacionForm_Load(object sender, EventArgs e)
        {
            try
            {
                IDbConnection conexion = Conexion.ObtenerConexion();
                _repo = new RepoFutbolista(conexion);

                _jugadores.Clear();

                // Obtener equipos y recorrer tipos para traer todos los jugadores
                var equipos = _repo.TraerEquipo().ToList();
                uint[] tipos = new uint[] { 1, 2, 3, 4 };

                if (equipos != null && equipos.Count > 0)
                {
                    foreach (var equipo in equipos)
                    {
                        foreach (var t in tipos)
                        {
                            var lista = _repo.TraerFutbolistasBasicoXTipoXEquipo(t, equipo.idEquipo).ToList();
                            foreach (var j in lista)
                            {
                                if (!_jugadores.Any(x => x.idFutbolista == j.idFutbolista))
                                    _jugadores.Add(j);
                            }
                        }
                    }
                }
                else
                {
                    // Fallback: intentar por tipos sin equipo
                    foreach (var t in tipos)
                    {
                        var lista = _repo.TraerFutbolistasBasicoXTipoXEquipo(t, 0).ToList();
                        foreach (var j in lista)
                        {
                            if (!_jugadores.Any(x => x.idFutbolista == j.idFutbolista))
                                _jugadores.Add(j);
                        }
                    }
                }

                JugadorComboBox.Items.Clear();
                foreach (var j in _jugadores.OrderBy(x => x.Apellido).ThenBy(x => x.Nombre))
                {
                    JugadorComboBox.Items.Add($"{j.Nombre} {j.Apellido}");
                }

                if (JugadorComboBox.Items.Count > 0)
                    JugadorComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando jugadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (JugadorComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un jugador", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtNota.Text, out decimal nota))
            {
                MessageBox.Show("Ingrese una nota válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fecha = dateTimePicker1.Value;

            try
            {
                var jugador = _jugadores[JugadorComboBox.SelectedIndex];
                var puntuacion = new Puntuacion { Nota = nota, FechaPartido = fecha };
                int id = _repo.AltaPuntuacion(puntuacion, jugador.idFutbolista);
                MessageBox.Show($"Puntuación guardada con id {id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SeleccionarPlantilla s = new SeleccionarPlantilla(DataGlobals.UsuarioLogueado);
                s.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando puntuación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SeleccionarPlantilla s = new SeleccionarPlantilla(DataGlobals.UsuarioLogueado);
            s.Show();
            this.Close();
        }
    }
}