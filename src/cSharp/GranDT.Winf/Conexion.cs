using System.Data;
using MySqlConnector;

namespace GRANDT
{
    /// <summary>
    /// Clase para gestionar la conexión a la base de datos MySQL.
    /// Proporciona una conexión reutilizable con cadena de conexión por defecto.
    /// </summary>
    public class Conexion
    {
        private const string _cadena = "Server=localhost;User ID=root;Password=root;Database=5to_GranDT;";
        
        public static IDbConnection ObtenerConexion()
        {
            return new MySqlConnection(_cadena);
        }

        public static IDbConnection ObtenerConexion(string cadena)
        {
            return new MySqlConnection(cadena);
        }
    }
}
