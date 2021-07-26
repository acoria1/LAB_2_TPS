using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class ModeloDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand command;

        static ModeloDAO()
        {
            conexion = new SqlConnection(Globals.pathDataBase);
            command = new SqlCommand();
            command.Connection = conexion;
        }       

        public static void Insert(Modelo m)
        {
            command.CommandText = "insert into Modelo (Identificador,Descripcion,Alto,Ancho,Profundidad) " +
                "VALUES(@Identificador, @Descripcion, @Alto,@Ancho,@Profundidad)";
            command.Parameters.AddWithValue("@Identificador", m.Identificador);
            command.Parameters.AddWithValue("@Descripcion", m.Nombre);
            command.Parameters.AddWithValue("@Alto", m.Alto);
            command.Parameters.AddWithValue("@Ancho", m.Ancho);
            command.Parameters.AddWithValue("@Profundidad", m.Profundidad);

            Ejecutar();
        }

        public static void Ejecutar()
        {
            try
            {
                conexion.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    command.Parameters.Clear();
                    conexion.Close();
                }
            }
        }
    }
}
