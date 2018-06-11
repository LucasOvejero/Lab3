using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Clases
{
    public static class clsDeposito
    {
        private static DataTable Bebidas,Ingredientes, StockDeposito;
        private static SqlCommand comando;
        private static DataSet ds;
        private static SqlDataAdapter adapter;
        public static DataSet getDepositoPorDireccion(string Direccion) {
            Ingredientes = new DataTable("Ingredientes");
            adapter=new SqlDataAdapter();
            Bebidas = new DataTable("Bebidas") ;
            try
            {
                //recuperamos los ingredientes
                comando = new SqlCommand("Select i.IdIngrediente,d.IdSucursal,NombreProducto,Stock,0 as 'Agregar gr.' from Deposito d join Sucursal s on(d.IdSucursal=s.IdSucursal) join Ingrediente i on (d.IdIngrediente=i.IdIngrediente) where Direccion=@Direccion; ");
                comando.Connection = clsConexion.getCon();
                SqlParameter dir = new SqlParameter("@Direccion", Direccion);
                comando.Parameters.Add(dir);
                ds = new DataSet("Deposito");
                adapter.SelectCommand = comando;
                adapter.Fill(Ingredientes);
                //recuperamos las bebidas de la sucursal
                comando.CommandText = "Select b.IdBebida,d.IdSucursal,NombreBebida,Stock,0 as 'Agregar U.' from Deposito d join Sucursal s on(d.IdSucursal=s.IdSucursal) join Bebida b on (d.IdBebida=b.IdBebida) where Direccion=@Direccion;";
                adapter.SelectCommand = comando;
                adapter.Fill(Bebidas);
                ds.Tables.Add(Ingredientes);
                ds.Tables.Add(Bebidas);
            }
            catch (SqlException e)
            {

                throw e;
            }
            finally {
                clsConexion.closeCon();
            }
            return ds;
        }
        public static string actualizarBebidas(DataTable bebidas,string direccion,out DataTable nuevaTablaBebidas) {
            string resp = "";
            nuevaTablaBebidas = null;
            SqlTransaction transaction = clsConexion.getCon().BeginTransaction("ActualizarDeposito");
            try
            {
                SqlCommand comando = clsConexion.getCon().CreateCommand();

                comando.Connection = clsConexion.getCon();
                comando.Transaction = transaction;
                foreach (DataRow row in bebidas.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                       
                        int agregar = Int32.Parse(row["Agregar U."].ToString());
                        
                        int idSucursal = Int32.Parse(row["IdSucursal"].ToString());
                        int idBebida = Int32.Parse(row["IdBebida"].ToString());
                        comando.CommandText = string.Format("Update Deposito set Stock=Stock+{0} where IdSucursal={1} and IdBebida={2};", agregar, idSucursal, idBebida);
                        comando.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                comando = new SqlCommand();
                comando.Connection = clsConexion.getCon();
                comando.Parameters.Add(new SqlParameter("@Direccion", direccion));
                comando.CommandText = "Select b.IdBebida,d.IdSucursal,NombreBebida,Stock,0 as 'Agregar U.' from Deposito d join Sucursal s on(d.IdSucursal=s.IdSucursal) join Bebida b on (d.IdBebida=b.IdBebida) where Direccion=@Direccion;";
                adapter.SelectCommand = comando;
                nuevaTablaBebidas = new DataTable("Bebidas");
                adapter.Fill(nuevaTablaBebidas);
               
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

        public static string actualizarIngredientes(DataTable ingredientes, string direccion, out DataTable nuevaTablaIngredientes)
        {
            string resp = "";
            nuevaTablaIngredientes = null;
            SqlTransaction transaction = clsConexion.getCon().BeginTransaction("ActualizarDepositoI");
            try
            {
                SqlCommand comando = clsConexion.getCon().CreateCommand();

                comando.Connection = clsConexion.getCon();
                comando.Transaction = transaction;
                foreach (DataRow row in ingredientes.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        
                        int agregar = Int32.Parse(row["Agregar gr."].ToString());
                       
                        int idSucursal = Int32.Parse(row["IdSucursal"].ToString());
                        int idIngrediente = Int32.Parse(row["IdIngrediente"].ToString());
                        comando.CommandText = string.Format("Update Deposito set Stock=Stock+{0} where IdSucursal={1} and IdIngrediente={2};", agregar, idSucursal, idIngrediente);
                        comando.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                comando = new SqlCommand();
                comando.Connection = clsConexion.getCon();
                comando.Parameters.Add(new SqlParameter("@Direccion", direccion));
                comando.CommandText = "Select i.IdIngrediente,d.IdSucursal,NombreProducto,Stock,0 as 'Agregar gr.' from Deposito d join Sucursal s on(d.IdSucursal=s.IdSucursal) join Ingrediente i on (d.IdIngrediente=i.IdIngrediente) where Direccion=@Direccion;";
                adapter.SelectCommand = comando;
                nuevaTablaIngredientes = new DataTable("Ingredientes");
                adapter.Fill(nuevaTablaIngredientes);

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
            finally
            {
                clsConexion.closeCon();
            }
            return resp;
        }


        public static bool ObtenerStockIngrediente(int IdIngrediente, int cantidad)
        {
            comando = new SqlCommand("Select * From Deposito where IdIngrediente = " + IdIngrediente + " AND IdSucursal = " + clsConexion.SucursalSession + " AND Stock >" + cantidad + ";");
            try
            {
                StockDeposito = new DataTable("Deposito");
                comando.Connection = clsConexion.getCon();
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(StockDeposito);
                return StockDeposito.Rows.Count > 0;
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return false;

        }

        public static void migrar(int idDestino, int idIngrediente, int cantidad)
        {
            string query = "UPDATE Deposito SET Stock = Stock - " + cantidad + " WHERE IdIngrediente = " + idIngrediente + " AND IdSucursal = " + clsConexion.SucursalSession + ";";
            query += "UPDATE Deposito SET Stock = Stock + " + cantidad + " WHERE IdIngrediente = " + idIngrediente + " AND IdSucursal = " + idDestino + ";";
            comando = new SqlCommand(query);
            try
            {
                StockDeposito = new DataTable("Deposito");
                comando.Connection = clsConexion.getCon();
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(StockDeposito);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
        }

    }
}
