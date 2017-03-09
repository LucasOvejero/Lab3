using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Clases
{
    public static class clsConexion
    {
        static string conexion = @"Data Source=cdr\sqlexpress ;Initial Catalog=lab3; User ID =NaLu ; Password=1234";
        static SqlConnection cnn = new SqlConnection(conexion);

        /*public clsConexion()
        {
            cnn = new SqlConnection(conexion);
        }*/

        static private SqlConnection getCon()
        {
            try { cnn.Open(); }
            catch (SqlException x) { }
            return cnn;
        }
        static private void closeCon()
        {
            cnn.Close();
        }
        static public int insertarBebida(clsBebida b)
        {
            int r = 0;
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("@Nombre", b.NombreBebida);
            parametros[1] = new SqlParameter("@Cantidad", b.Cantidad);
            parametros[2] = new SqlParameter("@Costo", b.Costo);
            parametros[3] = new SqlParameter("@Precio", b.Precio);
            parametros[4] = new SqlParameter("@Litros", b.Litros);
            parametros[5] = new SqlParameter("@Alcohol", b.Alcohol);
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "sp_IBebida";
            try
            {
                comando.Connection = getCon();
                comando.Parameters.AddRange(parametros);
                r = (Int32)comando.ExecuteScalar();
            }
            catch (NullReferenceException n) { }
            catch (SqlException x) { }
            finally
            { closeCon(); }
            return r;
        }
        static public DataTable seleccionarBebidas()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand("select * from Bebida");
            try
            {
                comando.Connection = getCon();
                da.SelectCommand = comando;
                da.Fill(dt);
            }
            catch (SqlException x) { }
            finally { closeCon(); }
            return dt;
        }
    }
}
