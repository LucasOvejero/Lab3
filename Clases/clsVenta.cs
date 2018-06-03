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
                    
                    //comando.CommandText = "Insert into Receta values (" + idPlato + "," + i.IdIngrediente + "," + i.Plato.NudGramos.Value.ToString() + ");";
                    int cantidad = int.Parse(p.NudGramos.Value.ToString());
                    comando.CommandText = string.Format("INSERT INTO DescripcionVenta(NroVenta,IdPlato,Costo,Precio)VALUES({0},{1},'{2}','{3}')", nroVenta, p.Id, p.Costo.ToString().Replace(',', '.'), p.Precio.ToString().Replace(',', '.'));
                    if (p.EsBebida)
                        comando.CommandText = string.Format("INSERT INTO DescripcionVenta(NroVenta,IdBebida,Costo,Precio)VALUES({0},{1},'{2}','{3}')", nroVenta, p.Id, p.Costo.ToString().Replace(',', '.'), p.Precio.ToString().Replace(',', '.'));
                    listaProductos.Add(new Producto() {Nombre=p.Nombre,Cantidad=cantidad,Precio=p.Precio });
                    for (int i = 0; i < cantidad; i++)
                    {
                        comando.ExecuteNonQuery();
                    }
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
    }
}
