﻿using ConexionAMySQL;
using MySql.Data.MySqlClient;
using RedSocial.Modelos;
using System.Data;

namespace RedSocial
{

    class ControllerComentario
    {
        private ConexionBD conexion = new ConexionBD();

        public DataTable Mostrar()
        {

            using (MySqlConnection conn = conexion.AbrirConexionMySQL())
            using (MySqlCommand comando = new MySqlCommand("SELECT * FROM View_ObtenerComentarios", conn))
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

        public bool Insertar(Comentario comentario)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_InsertarComentario", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_idPublicacion", comentario.IdPublicacion);
                    comando.Parameters.AddWithValue("p_idAutor", comentario.IdAutor);
                    comando.Parameters.AddWithValue("p_contenido", comentario.Contenido);
                    comando.Parameters.AddWithValue("p_fechaCreacion", comentario.FechaCreacion);

                    comando.ExecuteNonQuery();
                    MessageBoxes.MostrarMensajeConfirmacion("El comentario fue publicado correctamente");
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBoxes.MostrarMensajeError("Error al publicar el comentario: " + ex.Message);
                return false;
            }
        }

        public bool Editar(Publicacion publicacion)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_ActualizarComentario", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("p_idComentario", publicacion.IdPublicacion);
                    comando.Parameters.AddWithValue("p_contenido", publicacion.Contenido);

                    comando.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBoxes.MostrarMensajeError("Error al editar el comentario: " + ex.Message);
                return false;
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection conn = conexion.AbrirConexionMySQL())
            using (MySqlCommand comando = new MySqlCommand("sp_EliminarComentario", conn))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p_idComentario", id);
                comando.ExecuteNonQuery();
            }
        }
    }
}
