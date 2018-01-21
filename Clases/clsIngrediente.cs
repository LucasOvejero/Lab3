using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clases
{
    public static class clsIngrediente
    {

        static SqlCommand comando;
        static SqlDataAdapter adaptador;
        static DataTable ingredientes;

        public static DataTable seleccionarIngredientes() {
            comando = new SqlCommand("select * from Ingrediente");
            try
            {
                ingredientes = new DataTable("Ingredientes");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(ingredientes);
            }
            catch (SqlException x)
            {
                throw x;
            }
            finally {
                clsConexion.closeCon();
            }
            return ingredientes;
        }
      
        public static string insertarIngrediente(string nombre, double CostoXKilo) {
            string resp="";
            comando = new SqlCommand();
            comando.CommandText = "INSERT INTO Ingrediente (NombreProducto,CostoxKG) values (@NombreProducto,@Costo);Select SCOPE_IDENTITY();";
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@NombreProducto",nombre);
            parametros[1] = new SqlParameter("@Costo", CostoXKilo);
            try
            {
                comando.Parameters.AddRange(parametros);
                comando.Connection = clsConexion.getCon();
                int id = -1;
                id = Convert.ToInt32(comando.ExecuteScalar());
                if (id >= 0)
                {
                    resp = "Se ha insertado el ingrediente " + nombre + " correctamente";
                    comando.CommandText = "insert into Deposito (IdSucursal,Stock,IdIngrediente) select Distinct(IdSucursal),0," + id + " from Sucursal";
                    comando.ExecuteNonQuery();
                    actualizar(id);
                }

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally {
                clsConexion.closeCon();
            }
                
            return resp;
        }
        private static void actualizar(int id){
            try
            {
                comando.CommandText = "select * from Ingrediente where IdIngrediente=" + id;
                adaptador.SelectCommand = comando;
                adaptador.Fill(ingredientes);
            }
            catch (SqlException e) {
                throw e;
            }
        }
        public static string actualizar(int id,string nombre, double precio){
            string resp = "";
            comando = new SqlCommand("UPDATE Ingrediente set NombreProducto="+nombre+", PrecioxKilo="+precio+ " where IdIngrediente="+id);
            try
            {
                comando.Connection = clsConexion.getCon();
                if (comando.ExecuteNonQuery() > 0)
                {
                    resp = "Actualizado correctamente";
                }
                
            }
            catch (SqlException e)
            {
                resp = e.Message;
            }
            finally {
                clsConexion.closeCon();
            }
            
            return resp;
        }

    }
}
