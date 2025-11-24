using System;
using System.Media;
using System.Windows.Forms;

namespace GRANDT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                string rutaArchivo = @"C:\Users\agusc\OneDrive\Escritorio\5ta8va-GranDT\src\Resources\musica.wav";
                SoundPlayer player = new SoundPlayer(rutaArchivo);
                player.Load(); // Carga el archivo
                player.Play(); // Reproduce una vez para probar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reproducir música: {ex.Message}");
            }

            Application.Run(new InicioSecion());
        }
    }
}

