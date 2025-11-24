using System;
using System.Media;

namespace GRANDT
{
    internal class MusicPlayer
    {
        private static SoundPlayer _player;

        /// <summary>
        /// Inicia la música de fondo en loop.
        /// </summary>
        public static void IniciarMusica()
        {
            try
            {
                // Ruta exacta del archivo .wav que me pasaste
                string rutaArchivo = @"C:\Users\agusc\OneDrive\Escritorio\5ta8va-GranDT\src\Resources\musica.wav";
                _player = new SoundPlayer(rutaArchivo);
                _player.Load();
                _player.PlayLooping(); // Reproduce en loop infinito
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al reproducir música: {ex.Message}");
            }
        }

        /// <summary>
        /// Detiene la música.
        /// </summary>
        public static void DetenerMusica()
        {
            _player?.Stop();
        }
    }
}
