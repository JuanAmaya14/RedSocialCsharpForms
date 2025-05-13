using ConexionAMySQL;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace RedSocial.Controladores
{
    class ControllerAuditoria
    {

        private ConexionBD conexion = new ConexionBD();

        public DataTable Mostrar()
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("SELECT * FROM View_ObtenerAuditorias", conn))
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
            catch (Exception ex)
            {
                MessageBoxes.MostrarMensajeError(ex.Message);
                return null;
            }
        }

        public DataTable MostrarPorId(int id)
        {
            try
            {
                using (MySqlConnection conn = conexion.AbrirConexionMySQL())
                using (MySqlCommand comando = new MySqlCommand("sp_ObtenerAuditoriasPorID", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("p_idUsuario", id);
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        DataTable tabla = new DataTable();
                        tabla.Load(reader);
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxes.MostrarMensajeError(ex.Message);
                return null;
            }
        }
    }
}
