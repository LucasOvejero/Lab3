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
        private static DataTable Bebidas,Ingredientes;
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
                comando = new SqlCommand("Select i.IdIngrediente,NombreProducto,Stock from Deposito d join Sucursal s on(d.IdSucursal=s.IdSucursal) join Ingrediente i on (d.IdIngrediente=i.IdIngrediente) where Direccion=@Direccion; ");
                comando.Connection = clsConexion.getCon();
                SqlParameter dir = new SqlParameter("@Direccion", Direccion);
                comando.Parameters.Add(dir);
                ds = new DataSet("Deposito");
                adapter.SelectCommand = comando;
                adapter.Fill(Ingredientes);
                //recuperamos las bebidas de la sucursal
                comando.CommandText = "Select b.IdBebida,NombreBebida,Stock from Deposito d join Sucursal s on(d.IdSucursal=s.IdSucursal) join Bebida b on (d.IdBebida=b.IdBebida) where Direccion=@Direccion;";
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
    }
}
