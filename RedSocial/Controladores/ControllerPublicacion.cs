using ConexionAMySQL;
using MySql.Data.MySqlClient;
using RedSocial.Modelos;
using System;
using System.Data;

namespace RedSocial
{
    class ControllerPublicacion
    {
        private ConexionBD conexion = new ConexionBD();

        public DataTable Mostrar()
        {

            using (MySqlConnection conn = conexion.AbrirConexionMySQL())
            using (MySqlCommand comando = new MySqlCommand("SELECT * FROM View_ObtenerPublicaciones", conn))
            {
                comando.CommandType = CommandType.Text;
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }

        public string Insertar(Publicacion publicacion)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_InsertarPublicacion", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_idAutor", publicacion.IdAutor);
                    comando.Parameters.AddWithValue("p_contenido", publicacion.Contenido);
                    comando.Parameters.AddWithValue("p_fechaCreacion", publicacion.FechaCreacion);

                    comando.ExecuteNonQuery();
                    return "Publicacion registrada correctamente";
                }
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
        }

        public (string, bool) Editar(Publicacion publicacion)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_ActualizarPublicacion", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("p_idPublicacion", publicacion.IdPublicacion);
                    comando.Parameters.AddWithValue("p_contenido", publicacion.Contenido);

                    comando.ExecuteNonQuery();
                    return ("Fue actualizado correctamente.", true);
                }
            }
            catch (MySqlException ex)
            {
                return (ex.Message, false);
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection conn = conexion.AbrirConexionMySQL())
            using (MySqlCommand comando = new MySqlCommand("sp_EliminarPublicacion", conn))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p_idPublicacion", id);
                comando.ExecuteNonQuery();
            }
        }

        public DataTable MostrarNombre(string nombre)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_ObtenerPublicacionesPorAutorNombre", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_nombre", nombre);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        DataTable tabla = new DataTable();
                        tabla.Load(reader);
                        return tabla;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }

}
