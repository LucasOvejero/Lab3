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

        //Data Source=cdr\SQLEXPRESS; Lucas
        //Data Source=CDR410U007679\SQLEXPRESS; Nahuel
        static string conexion = @"Data Source=cdr\SQLEXPRESS;Initial Catalog=lab3; User ID =NaLu ; Password=1234";
 
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
            catch (SqlException x) { throw x; }
            return cnn;
        }
        static public void closeCon()
        {
            cnn.Close();
        }
        
        
    }
}
