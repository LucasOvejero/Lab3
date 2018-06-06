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
        //Data Source=CDR410U007679\SQLEXPRESS; Nahuel 
        static string conexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=lab3; User ID =NaLu ; Password=1234";

        public static int SucursalSession = -1;
        public static string Tipo = "cajero";
        public static int IdEmpleado = -1;

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
