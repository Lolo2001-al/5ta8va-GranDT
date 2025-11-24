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
 
    public partial class Form5 : Form
    {
        private Usuario? _usuarioLogeado;
        public Form5(Usuario usuario)
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
            Form6 form6 = new Form6(_usuarioLogeado);
            form6.Show();
            this.Hide();
        }
    }
}
