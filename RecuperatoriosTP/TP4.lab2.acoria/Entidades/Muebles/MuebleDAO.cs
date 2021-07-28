using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades.Muebles
{
    public class MuebleDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand command;

        static MuebleDAO()
        {
            conexion = new SqlConnection(Globals.pathDataBase);
            command = new SqlCommand();
            command.Connection = conexion;
        }

        public static string GetDetalleMueble(Mueble m)
        {
            StringBuilder sb = new StringBuilder();
            command.CommandText = $"SELECT Descripcion,Alto,Ancho,Profundidad FROM Modelo where Modelo.Identificador = @id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", m.IDModelo);
            try
            {
                conexion.Open();
                SqlDataReader oDr = command.ExecuteReader();

                while (oDr.Read())
                {
                    sb.AppendLine(oDr["Descripcion"].ToString());
                    sb.AppendLine($"Alto: {oDr["Alto"].ToString()}cm");
                    sb.AppendLine($"Ancho: {oDr["Ancho"].ToString()}cm");
                    sb.AppendLine($"Profundidad: {oDr["Profundidad"].ToString()}cm");
                }
                return sb.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
        }

        public static DataSet GetMueblesFromDB(string orderColumn, bool ascending)
        {
            string order = "DESC";
            DataSet ds = new DataSet();
            if (ascending)
            {
                order = "ASC";
            }
            try
            {
                string select = $"select md.Descripcion,mb.Guid,mb.IdModelo,mb.FechaDeFabricacion, " +
                $"mb.FechaDeEnvio,mb.Color,md.Alto, md.Ancho," +
                $" md.Profundidad " +
                $"from Mueble mb " +
                $"inner join " +
                $"Modelo md " +
                $"on mb.IdModelo = md.Identificador " +
                $"order by {orderColumn} {order}";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conexion);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);               
                dataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }          
            return ds;
        }

        public static int GetCountMuebles()
        {
            int i = -1;
            command.Parameters.Clear();
            command.CommandText = $"select COUNT(*) as Count from Mueble";
            try
            {                
                conexion.Open();
                SqlDataReader oDr = command.ExecuteReader();

                while (oDr.Read())
                {
                    i = (int)oDr["Count"];
                }                
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return i;
        }

        public static void Insert(Mueble m)
        {
            command.CommandText = "INSERT INTO Mueble" +
                "(Guid,IdModelo,FechaDeFabricacion,FechaDeEnvio,Color) " +
                "VALUES(@Guid, @IdModelo, @FechaDeFabricacion,GETDATE(),@Color)";
            command.Parameters.AddWithValue("@Guid", m.CodigoGuid.ToString());
            command.Parameters.AddWithValue("@IdModelo", m.IDModelo);
            command.Parameters.AddWithValue("@FechaDeFabricacion", m.FechaDeFabricacion);
            command.Parameters.AddWithValue("@Color", m.Color.ToString());
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
