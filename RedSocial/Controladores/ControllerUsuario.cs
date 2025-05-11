using ConexionAMySQL;
using MySql.Data.MySqlClient;
using RedSocial.Modelos;
using System;
using System.Data;

namespace RedSocial
{

    class ControllerUsuario
    {
        private ConexionBD conexion = new ConexionBD();

        public bool Insertar(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_InsertarUsuario", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("p_telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("p_correo", usuario.Correo);
                    comando.Parameters.AddWithValue("p_contrasenha", usuario.Contrasenha);
                    comando.Parameters.AddWithValue("p_fechaCreacion", usuario.FechaCreacion);
                    comando.Parameters.AddWithValue("p_administrador", usuario.Administrador);


                    comando.ExecuteNonQuery();
                    MessageBoxes.MostrarMensajeConfirmacion("Usuario registrado correctamente, por favor inicie sesion");

                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBoxes.MostrarMensajeError("Error al registrar el usuario: " + ex.Message);
                return false;
            }
        }

        public bool Editar(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_ActualizarUsuario", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("p_idUsuario", usuario.IdUsuario);
                    comando.Parameters.AddWithValue("p_nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("p_telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("p_correo", usuario.Correo);
                    comando.Parameters.AddWithValue("p_contrasenha", usuario.Contrasenha);
                    comando.Parameters.AddWithValue("p_administrador", usuario.Administrador);

                    comando.ExecuteNonQuery();
                    MessageBoxes.MostrarMensajeConfirmacion("Usuario actualizado correctamente");
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBoxes.MostrarMensajeError("Error al actualizar el usuario: " + ex.Message);
                return false;
            }
        }

        public void Eliminar(int id)
        {
            using (MySqlConnection conn = conexion.AbrirConexionMySQL())
            using (MySqlCommand comando = new MySqlCommand("sp_EliminarUsuario", conn))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p_idUsuario", id);
                comando.ExecuteNonQuery();
            }
        }

        public Usuario IniciarSesion(string nombre, string contrasenha)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_InicioSesion", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_nombre", nombre);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (!reader.HasRows) return null;

                        DataTable tabla = new DataTable();
                        tabla.Load(reader);
                        DataRow row = tabla.Rows[0];

                        string hashAlmacenado = row["contrasenha"].ToString();

                        bool contrasenaValida = BCrypt.Net.BCrypt.Verify(contrasenha, hashAlmacenado);
                        if (!contrasenaValida) return null;

                        return new Usuario(
                            Convert.ToInt32(row["idUsuario"]),
                            row["nombre"].ToString(),
                            row["telefono"].ToString(),
                            row["correo"].ToString(),
                            row["contrasenha"].ToString(),
                            Convert.ToDateTime(row["fechaCreacion"]),
                            Convert.ToBoolean(row["administrador"])
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                return null;
            }
        }

        public Usuario MostrarNombre(string nombre)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_ObtenerUsuarioPorNombre", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_nombre", nombre);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (!reader.HasRows) return null;

                        DataTable tabla = new DataTable();
                        tabla.Load(reader);
                        DataRow row = tabla.Rows[0];

                        return new Usuario(
                            Convert.ToInt32(row["idUsuario"]),
                            row["nombre"].ToString(),
                            row["telefono"].ToString(),
                            row["correo"].ToString(),
                            row["contrasenha"].ToString(),
                            Convert.ToBoolean(row["administrador"]),
                            Convert.ToDateTime(row["fechaCreacion"])
                        );
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
