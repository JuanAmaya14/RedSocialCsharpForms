using System;
using MySql.Data.MySqlClient;
using DotNetEnv;

namespace ConexionAMySQL
{
    class ConexionBD
    {
        public ConexionBD()
        {
            Env.Load();
        }

        public MySqlConnection AbrirConexionMySQL()
        {
            try
            {
                string host = Environment.GetEnvironmentVariable("MYSQL_HOST");
                string port = Environment.GetEnvironmentVariable("MYSQL_PORT");
                string database = Environment.GetEnvironmentVariable("MYSQL_DATABASE");
                string user = Environment.GetEnvironmentVariable("MYSQL_USER");
                string password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");

                string cadenaMySQL = $"Server={host};Port={port};Database={database};User={user};Password={password};";

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
