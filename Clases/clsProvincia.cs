using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Clases
{
    public class clsProvincia
    {
        int idProvincia;
        string nombreProvincia;
       static SqlCommand comando=new SqlCommand();
        static SqlDataAdapter adaptador= new SqlDataAdapter();
        static private DataTable provincias;
        public int IdProvincia{
            get { return idProvincia; }
            set { idProvincia = value; }
        }
        public string NombreProvincia {
            get { return nombreProvincia; }
            set { nombreProvincia = value; }
        }

        public static DataTable seleccionarProvincias() {
             provincias = new DataTable("Provincias");
            
            try
            {
                comando.Connection = clsConexion.getCon();
                comando.CommandText = "select * from Provincia";
                adaptador.SelectCommand = comando;
                adaptador.Fill(provincias);
            }
            catch (SqlException e) {
            
            }
            finally { clsConexion.closeCon(); }
            return provincias;      
        }
        public static string insertProvincia(string Nombre) {
            string respuesta="";
            comando = new SqlCommand();
            SqlParameter paramNombre=new SqlParameter("@NombreProvincia",Nombre);
            comando.CommandText = "insert into Provincia (NombreProvincia) values (@NombreProvincia);select SCOPE_IDENTITY();";
            try
            {
                comando.Parameters.Add(paramNombre);
                comando.Connection = clsConexion.getCon();
                int id = Convert.ToInt32(comando.ExecuteScalar());
                if (id > 0)
                {
                    actualizar(id);
                    respuesta = "La Provincia " + Nombre + " ingresada correctamente";
                }
            }
            catch (SqlException e)
            {
                if (e.Class == 14)
                    respuesta = "No se puede ingresar dos veces la misma provincia";
            }

            return respuesta;
        }
        private static void actualizar(int id) {
            comando.CommandText = "Select * from Provincia where IdProvincia=" + id;
            adaptador.SelectCommand =comando ;
            adaptador.Fill(provincias);
            clsConexion.closeCon();
        }
    }
}
