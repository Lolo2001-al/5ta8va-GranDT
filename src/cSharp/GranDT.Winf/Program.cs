using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace GRANDT
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MusicPlayer.IniciarMusica("musica.wav");
            Application.Run(new InicioSecion());
        }
    }
}
