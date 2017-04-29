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
       static SqlCommand comando;
        static SqlDataAdapter adaptador= new SqlDataAdapter();
        public int IdProvincia{
            get { return idProvincia; }
            set { idProvincia = value; }
        }
        public string NombreProvincia {
            get { return nombreProvincia; }
            set { nombreProvincia = value; }
        }

        public static DataTable seleccionarProvincias() {
            DataTable prov = new DataTable("Provincias");
            comando = new SqlCommand("Select * from provincia");
            try
            {
                comando.Connection = clsConexion.getCon();
                adaptador.SelectCommand = comando;
                adaptador.Fill(prov);
            }
            catch (SqlException e) { }
            finally { clsConexion.closeCon(); }
            return prov;      
        }
    }
}
