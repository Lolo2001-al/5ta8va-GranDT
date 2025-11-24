using System;
using System.IO;
using System.Media;

namespace GRANDT
{
    internal static class MusicPlayer
    {
        private static SoundPlayer _player;

        /// <summary>
        /// Inicia la música de fondo en bucle desde la carpeta Resources del proyecto.
        /// </summary>
        /// <param name="nombreArchivo">Nombre del archivo .wav (ej: "musica.wav")</param>
        public static void IniciarMusica(string nombreArchivo)
        {
            // Construimos la ruta completa del archivo dentro de Resources
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", nombreArchivo);

            // Verificamos que el archivo exista
            if (!File.Exists(ruta))
            {
                throw new FileNotFoundException($"No se encontró el archivo de música en: {ruta}");
            }

            // Creamos el reproductor y reproducimos en bucle
            _player = new SoundPlayer(ruta);
            _player.PlayLooping();
        }

        /// <summary>
        /// Detiene la música de fondo.
        /// </summary>
        public static void DetenerMusica()
        {
            if (_player != null)
            {
                _player.Stop();
                _player.Dispose();
                _player = null;
            }
        }
    }
}
