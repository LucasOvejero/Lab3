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
        static SqlCommand selectIngre;
        static SqlDataAdapter adaptadorIngredientes,adaptadorCategorias;
        static DataTable ingredientes, categorias;

        public static DataTable seleccionarIngredientes()
        {
            selectIngre = new SqlCommand("select * from Ingrediente i left outer  join CategoriaIngredientes c on(i.IdCategoria=c.IdCategoria)");
            try
            {
                ingredientes = new DataTable("Ingredientes");
                selectIngre.Connection = clsConexion.getCon();
                adaptadorIngredientes = new SqlDataAdapter();
                adaptadorIngredientes.SelectCommand = selectIngre;
                adaptadorIngredientes.Fill(ingredientes);
            }
            catch (SqlException x)
            {
                throw x;
            }
            finally
            {
                clsConexion.closeCon();
            }
            return ingredientes;
        }

        public static string insertarIngrediente(string nombre, double CostoXKilo, int IdCategoria)
        {
            string resp = "";
            comando = new SqlCommand();
            comando.CommandText = "INSERT INTO Ingrediente (NombreProducto,CostoxKG,IdCategoria) values (@NombreProducto,@Costo,@IdCategoria);Select SCOPE_IDENTITY();";
            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@NombreProducto", nombre);
            parametros[1] = new SqlParameter("@Costo", CostoXKilo);
            parametros[2] = new SqlParameter("@IdCategoria", IdCategoria);
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
            finally
            {
                clsConexion.closeCon();
            }

            return resp;
        }
        private static void actualizar(int id)
        {
            try
            {
                comando.CommandText = "select * from Ingrediente i left outer join CategoriaIngredientes c on(i.IdCategoria=c.IdCategoria) where IdIngrediente=" + id;
                adaptadorIngredientes.SelectCommand = comando;
                adaptadorIngredientes.Fill(ingredientes);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public static string actualizar(int id, string nombre, decimal precio,int idCategoria)
        {
            string resp = "";
            comando = new SqlCommand("UPDATE Ingrediente set NombreProducto=@Nombre, CostoxKg=@Precio, IdCategoria=@IdCategoria where IdIngrediente=@IdIngrediente");
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("Nombre", nombre);
            parametros[1] = new SqlParameter("Precio", precio);
            parametros[2] = new SqlParameter("IdIngrediente", id);
            parametros[3] = new SqlParameter("IdCategoria", idCategoria);
            try
            {
                comando.Connection = clsConexion.getCon();
                comando.Parameters.AddRange(parametros);
                if (comando.ExecuteNonQuery() > 0)
                {
                    resp = "El Ingrediente " + nombre + " actualizado correctamente";
                    ingredientes.Clear();
                    adaptadorIngredientes.Fill(ingredientes);
                }

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                clsConexion.closeCon();
            }

            return resp;
        }


        #region categorias
        public static string agregarCategoriaIngrediente(string Categoria)
        {
            string resp = "";
            adaptadorCategorias = new SqlDataAdapter();
            try
            {
                comando = new SqlCommand();
                comando.CommandText = "Insert into CategoriaIngredientes (Nombre) values (@NombreCategoria);Select SCOPE_IDENTITY();";
                comando.Parameters.Add(new SqlParameter("@NombreCategoria", Categoria));
                comando.Connection = clsConexion.getCon();
                int id = int.Parse(comando.ExecuteScalar().ToString());
                if (id >= 0)
                {
                    comando.CommandText = "select * from CategoriaIngredientes where IdCategoria=" + id;

                    adaptadorCategorias.SelectCommand = comando;
                    adaptadorCategorias.Fill(categorias);
                }
            }
            catch (SqlException e)
            {
                resp = e.Message;
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                clsConexion.closeCon();

            }
            return resp;
        }
        public static DataTable obtenerCategoriasIngredientes()
        {
            categorias = new DataTable();
            adaptadorCategorias = new SqlDataAdapter();
            try
            {
               SqlCommand comando = new SqlCommand();
                comando.CommandText = "select * from CategoriaIngredientes";
                comando.Connection = clsConexion.getCon();
                adaptadorCategorias.SelectCommand = comando;
                adaptadorCategorias.Fill(categorias);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                clsConexion.closeCon();
            }
            return categorias;
        }
        #endregion

    }
}