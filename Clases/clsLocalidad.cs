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
       static private DataTable localidades;
        public int IdLocalidad {
            get { return idLocalidad; }
            set { idLocalidad = value; }
        }
        public string NombreLocalidad {
            get { return nombreLocalidad; }
            set { nombreLocalidad = value; }
        }
        public static DataTable seleccionarLocalidad() 
        {
            localidades = new DataTable("Localidades");
            comando = new SqlCommand("select * from Localidad");
            try
            {
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(localidades);
            }
            catch (SqlException e) {
                throw e;
            }
            finally { clsConexion.closeCon(); }

            return localidades;
        }
        public static string insertarLocalidad(string localidad,int idProvincia) {
            string respuesta = "";
            comando = new SqlCommand();
            comando.CommandText = "insert into Localidad (NombreLocalidad,IdProvincia) values (@NombreLocalidad,@IdProvincia);select SCOPE_IDENTITY();";
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@NombreLocalidad", localidad);
            parametros[1] = new SqlParameter("@IdProvincia",idProvincia);
            try
            {
                comando.Parameters.AddRange(parametros);
                comando.Connection = clsConexion.getCon();
                int id = -1;
                id = Convert.ToInt32(comando.ExecuteScalar());
                if (id >= 0)
                {
                    respuesta = "La Localidad " + localidad + " insertada correctamente";
                    actualizar(id);
                }
            }
            catch (SqlException e)
            {
                respuesta = e.Message;
            }
            finally {
                clsConexion.closeCon();
            }
            return respuesta;
        }
        public static string[] getTodas() {
            List<string> lLocalidades = new List<string>();
            lLocalidades.Insert(lLocalidades.Count, "Todas");
            try
            {
                DataTable loc = new DataTable();
                adaptador = new SqlDataAdapter();
                comando = new SqlCommand("select NombreLocalidad from Localidad");
                comando.Connection = clsConexion.getCon();
                adaptador.SelectCommand = comando;
                adaptador.Fill(loc);
                foreach (DataRow r in loc.Rows)
                {
                    lLocalidades.Insert(lLocalidades.Count, r["NombreLocalidad"].ToString());
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return lLocalidades.ToArray();
        }
        public static string[] getLocPerProv(string prov) {
            List<string> lLocalidades = new List<string>();
            lLocalidades.Insert(lLocalidades.Count, "Todas");
            try
            {
                DataTable loc = new DataTable();
                adaptador = new SqlDataAdapter();
                comando = new SqlCommand("select NombreLocalidad from Localidad l JOIN Provincia p on (l.IdProvincia=p.IdProvincia) JOIN Sucursal s ON(s.IdLocalidad=l.IdLocalidad) where NombreProvincia='"+prov+"'");
                comando.Connection = clsConexion.getCon();
                adaptador.SelectCommand = comando;
                adaptador.Fill(loc);
                foreach (DataRow r in loc.Rows)
                {
                    lLocalidades.Insert(lLocalidades.Count, r["NombreLocalidad"].ToString());
                }
            }
            catch (SqlException e) {
                throw e;
            }
            return lLocalidades.ToArray();
        }

        private static void actualizar(int id) {
            comando.CommandText = "select * from Localidad where IdLocalidad="+id;
            adaptador.SelectCommand = comando;
            adaptador.Fill(localidades);
        }
    }
}
