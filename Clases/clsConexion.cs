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
        static string conexion = @"Data Source=cdr\sqlexpress ;Initial Catalog=lab3; User ID =NaLu ; Password=12345";
        static SqlConnection cnn = new SqlConnection(conexion);

        /*public clsConexion()
        {
            cnn = new SqlConnection(conexion);
        }*/

        static public SqlConnection getCon()
        {
            try {
                if(cnn.State!= ConnectionState.Open)
                    cnn.Open();
                }
            catch (SqlException x) { }
            return cnn;
        }
        static public void closeCon()
        {
            cnn.Close();
        }
        
        
    }
}
