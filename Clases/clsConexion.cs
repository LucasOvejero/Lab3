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
        //Data Source=CDR410U007679\SQLEXPRESS; Nahuel @"Data Source=(localdb)\MSSQLLocalDB;

        static string conexion = @"Data Source=cdr\SQLEXPRESS;Initial Catalog=lab3; User ID =NaLu ; Password=12345";
        //static string conexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=lab3; User ID =NaLu ; Password=1234";


        public static string NombreSucursal { get; set; }
        public static int SucursalSession = -1;
        public static string Tipo = "cajero";
        static SqlConnection cnn = new SqlConnection(conexion);

        public static string IdEmpleado { get; internal set; }
        public static string NombreCompleto { get; internal set; }

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
