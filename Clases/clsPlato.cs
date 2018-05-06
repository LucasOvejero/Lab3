using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Modelo;
using Componentes;

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

        public static string insertarPlato(string nombre, double precio, double costo, bool estado,int idCat,bool TACC,List<Ingrediente> ingredientes)
        {
            string resp = "";
            comando=clsConexion.getCon().CreateCommand();
            SqlTransaction transaction = clsConexion.getCon().BeginTransaction("Crear un plato");
            comando.Connection = clsConexion.getCon();
            comando.Transaction = transaction;
            try
            {
                comando.CommandText = "insert into Plato (Nombre,Precio,Costo,Estado,IdCategoria,TACC) values (@Nombre,@Precio,@Costo,@Estado,@IdCategoria,@TACC);select SCOPE_IDENTITY();";
                SqlParameter[] parametros = new SqlParameter[6];
                parametros[0] = new SqlParameter("@Nombre", nombre);
                parametros[1] = new SqlParameter("@Precio", precio);
                parametros[2] = new SqlParameter("@Costo", costo);
                parametros[3] = new SqlParameter("@Estado", estado);
                parametros[4] = new SqlParameter("@IdCategoria", idCat);
                parametros[5] = new SqlParameter("@TACC", TACC);
                comando.Parameters.AddRange(parametros);
                int idPlato = int.Parse(comando.ExecuteScalar().ToString());
                foreach (Ingrediente i in ingredientes)
                {
                    comando.CommandText = "Insert into Receta values (" + idPlato + "," + i.IdIngrediente + "," + i.Plato.NudGramos.Value.ToString() + ");";
                    //comando.Parameters.Add(new SqlParameter("@IdPlato",idPlato));
                    //comando.Parameters.Add(new SqlParameter("@IdIngrediente", i.IdIngrediente));
                    //comando.Parameters.Add(new SqlParameter("@Cantidad", i.Plato.NudGramos.Value.ToString()));
                    comando.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                resp += ex.Message;
                try
                {
                    transaction.Rollback();
                }
                catch (Exception e)
                {
                    resp += e.Message;
                }

            }
            finally {
                clsConexion.closeCon();
            }
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
