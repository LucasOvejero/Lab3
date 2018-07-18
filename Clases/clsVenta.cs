using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes;
using System.Data;
using System.Data.SqlClient;
using Modelo;
namespace Clases
{
    public static class clsVenta
    {
        public static string vender(List<PanelPlato> productos,int IdSucursal,int IdEmpleado, out List<Producto>listaProductos){
            string resp="";
            listaProductos = new List<Producto>();
            SqlCommand comando=clsConexion.getCon().CreateCommand();
            SqlTransaction transaction = clsConexion.getCon().BeginTransaction("Registrar Venta");
            comando.Connection = clsConexion.getCon();
            comando.Transaction = transaction;
              try
            {
                string fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fff");

                comando.CommandText = string.Format("insert into EncabezadoVenta (Fecha,IdSucursal,IdEmpleado) values ('{0}',{1},{2});select SCOPE_IDENTITY();",fecha,IdSucursal,IdEmpleado);
               
                int nroVenta = int.Parse(comando.ExecuteScalar().ToString());
                foreach (PanelPlato p in productos)
                {
                    
                    
                    int cantidad = int.Parse(p.NudGramos.Value.ToString());
                    decimal totalCosto = cantidad * p.Costo;
                    decimal totalPrecio = cantidad * p.Precio;
                    comando.CommandText = string.Format("INSERT INTO DescripcionVenta(NroVenta,IdPlato,Costo,Precio,Cantidad)VALUES({0},{1},'{2}','{3}',{4})", nroVenta, p.Id, totalCosto.ToString().Replace(',', '.'), totalPrecio.ToString().Replace(',', '.'),cantidad);
                    if (p.EsBebida)
                        comando.CommandText = string.Format("INSERT INTO DescripcionVenta(NroVenta,IdBebida,Costo,Precio,Cantidad)VALUES({0},{1},'{2}','{3}',{4})", nroVenta, p.Id, totalCosto.ToString().Replace(',', '.'), totalPrecio.ToString().Replace(',', '.'), cantidad);
                    listaProductos.Add(new Producto() {Nombre=p.Nombre,Cantidad=cantidad,Precio=p.Precio });
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

        public static int numeroVenta() {
            int resp = 0;
            SqlCommand comando = new SqlCommand("SELECT NumeroTransaccion From Sucursal where IdSucursal=" + clsConexion.SucursalSession, clsConexion.getCon()) ;
            try
            {
                resp=int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (SqlException e) {
                throw e;
            }
            return resp;
        }

        public static string updateCUIT(string cuit) {
            string resp = "";
            string sqlString="";
            if (clsConexion.CUIT != string.Empty)
                sqlString = "UPDATE CUIT SET CUIT=" + cuit;
            else
                sqlString=string.Format("Insert into CUIT values ('{0}')",cuit);
            try
            {
                SqlCommand comando = new SqlCommand(sqlString, clsConexion.getCon());
                int af=comando.ExecuteNonQuery();
                if (af > 0)
                {
                    clsConexion.CUIT = cuit;
                }
            }
            catch (SqlException e)
            {
                resp = e.Message;
            }
            finally { clsConexion.closeCon(); }
            return resp;
        }
    }
}
