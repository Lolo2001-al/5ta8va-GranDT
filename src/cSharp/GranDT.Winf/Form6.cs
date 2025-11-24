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
    public partial class Form6 : Form
    {
        private Usuario? _usuarioLogeado;
        public Form6(Usuario usuario)
        {
            InitializeComponent();
            _usuarioLogeado = usuario;

            if (_usuarioLogeado == null)
            {
                MessageBox.Show("Usuario no logeado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionarPlantilla form9 = new SeleccionarPlantilla(_usuarioLogeado);
            form9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearPlantilla form8 = new CrearPlantilla(_usuarioLogeado);
            form8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(_usuarioLogeado);
            form5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
