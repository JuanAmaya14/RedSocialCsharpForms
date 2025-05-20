using System;
using MySql.Data.MySqlClient;

namespace ConexionAMySQL
{
    class ConexionBD
    {
        public ConexionBD()
        {
        }

        public MySqlConnection AbrirConexionMySQL()
        {
            try
            {
                var config = new ParametrosConexion("U");
                string cadenaMySQL = config.ObtenerCadenaConexion();

                var conexion = new MySqlConnection(cadenaMySQL);
                conexion.Open();
                Console.WriteLine("Conexión exitosa a la base de datos.");
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                throw;
            }
        }
    }
}
