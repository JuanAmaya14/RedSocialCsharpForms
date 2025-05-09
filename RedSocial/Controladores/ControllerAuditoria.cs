using ConexionAMySQL;
using MySql.Data.MySqlClient;
using System.Data;

namespace RedSocial.Controladores
{
    class ControllerAuditoria
    {

        private ConexionBD conexion = new ConexionBD();

        public DataTable Mostrar()
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

        public DataTable MostrarPorId(int id)
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

    }
}
