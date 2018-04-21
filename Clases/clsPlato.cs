using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clases
{
    public class clsPlato
    {
        static SqlCommand comando;
        static SqlCommand selectPlato;
        static SqlDataAdapter adaptadorPlatos,adaptadorCategorias;
        static DataTable platos, categorias;

        public static DataTable seleccionarPlato()
        {
            throw new NotImplementedException();
        }

        public static string insertarPlato(string nombre, double precio, double costo, bool estado,int idCat,bool TACC,)
        {
            string resp = "";
            return resp;
        }
        private static void actualizar(int id)
        {
            try
            {
                comando.CommandText = "select * from Ingrediente i left outer join CategoriaIngredientes c on(i.IdCategoria=c.IdCategoria) where IdIngrediente=" + id;
                adaptadorPlatos.SelectCommand = comando;
                adaptadorPlatos.Fill(platos);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public static DataTable seleccionarCategorias() {
            categorias = new DataTable();
            try
            {
                comando = new SqlCommand("select * from CategoriaPlatos");
                comando.Connection = clsConexion.getCon();
                adaptadorCategorias = new SqlDataAdapter();
                adaptadorCategorias.SelectCommand = comando;
                adaptadorCategorias.Fill(categorias);

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally { 
                clsConexion.closeCon();
            }
            return categorias;
        }
        public static string insertarCategoria(string categoria)
        {
            string resp="";
            try
            {
                comando = new SqlCommand("Insert into CategoriaPlatos (Nombre) values (@NombreCategoria);Select SCOPE_IDENTITY();", clsConexion.getCon());
                comando.Parameters.Add(new SqlParameter("@NombreCategoria", categoria));
                int id = int.Parse(comando.ExecuteScalar().ToString());
                if (id >= 0)
                {
                    comando.CommandText = "select * from CategoriaPlatos where IdCategoria=" + id;
                    adaptadorCategorias.SelectCommand = comando;
                    adaptadorCategorias.Fill(categorias);
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
