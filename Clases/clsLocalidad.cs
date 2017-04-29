using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Clases
{
    public class clsLocalidad
    {
        int idLocalidad;
        string nombreLocalidad;
       static SqlCommand comando;
       static SqlDataAdapter adaptador;
        public int IdLocalidad {
            get { return idLocalidad; }
            set { idLocalidad = value; }
        }
        public string NombreLocalidad {
            get { return nombreLocalidad; }
            set { nombreLocalidad = value; }
        }
        public static DataTable seleccionar()
        {
            DataTable tabla = new DataTable("Localidades");
            comando = new SqlCommand("select * from Localidad");
            try
            {
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(tabla);
            }
            catch (SqlException e) { }
            finally { clsConexion.closeCon(); }

            return tabla;
        }
    }
}
