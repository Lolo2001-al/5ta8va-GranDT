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

        }
    }
}
