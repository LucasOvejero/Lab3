using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Modelo;
namespace Clases
{
    public static class clsMerma
    {
        
        static DataTable merma;
        static SqlDataAdapter adapter;
        public static string InsertMerma(Merma merma) {
            string resp = "";

            try
            {
                SqlTransaction transaction = clsConexion.getCon().BeginTransaction("InsertarMerma");
                string[] elementos = new string[6] { merma.IdSucursal.ToString(), merma.IdEmpleado.ToString(), merma.IdIngrediente.ToString(), merma.Cantidad.ToString(), merma.Motivo, merma.IdInformante.ToString() };
                string sql = string.Format("Insert Into Merma(IdSucursal,IdEmpleado,IdIngrediente,Cantidad,Motivo,IdInformante) Values ({0},{1},{2},{3},'{4}',{5});Select SCOPE_IDENTITY();", elementos);
                string actualizarStock= string.Format("Update Deposito set Stock=Stock-{0} where IdIngrediente={1} and IdSucursal={2}",merma.Cantidad,merma.IdIngrediente,merma.IdSucursal);
                if (merma.IdIngrediente == -1) {
                    elementos = new string[6] { merma.IdSucursal.ToString(), merma.IdEmpleado.ToString(), merma.IdBebida.ToString(), merma.Cantidad.ToString(), merma.Motivo, merma.IdInformante.ToString() };
                    sql = string.Format("Insert Into Merma(IdSucursal,IdEmpleado,IdBebida,Cantidad,Motivo,IdInformante) Values ({0},{1},{2},{3},'{4}',{5});Select SCOPE_IDENTITY();", elementos);
                    actualizarStock= string.Format("Update Deposito set Stock=Stock-{0} where IdBebida={1} and IdSucursal={2}",merma.Cantidad,merma.IdBebida,merma.IdSucursal);
                }
                SqlCommand comando = new SqlCommand(sql, clsConexion.getCon());
                comando.Transaction = transaction;
                int id = Convert.ToInt32(comando.ExecuteScalar().ToString());
                comando.CommandText = actualizarStock;
                comando.ExecuteNonQuery();
                comando.Transaction.Commit();
            
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
        public static DataTable getMerma(int IdSucursal) {
             merma= new DataTable("Merma");
             string elMostro = "select Fecha, e.Apellido+' '+e.Nombre+' '+e.Dni as Informante," +
            "Case when em.IdEmpleado is null then 'Nadie'else em.Apellido+' '+em.Nombre+' '+em.Dni end Causante, case when b.IdBebida is null then i.NombreProducto else b.NombreBebida end Producto, Cantidad," +
            "Motivo "+
             "from Merma m inner join Empleado e on(m.IdInformante=e.IdEmpleado) left outer join Empleado em "+
             "on(m.IdEmpleado=em.IdEmpleado) left join Ingrediente i on (m.IdIngrediente=i.IdIngrediente) left join Bebida b on(m.IdBebida=b.IdBebida) where m.IdSucursal=" + IdSucursal + " Order by Fecha desc";
            try {
                SqlCommand comando = new SqlCommand(elMostro, clsConexion.getCon());
                adapter = new SqlDataAdapter(comando);
                adapter.Fill(merma);
            }
            catch(SqlException e){
                throw e;
            }
            finally { clsConexion.closeCon(); }
            return merma;
        }
        private static void actualizar(int id,SqlCommand comando)
        {
            try
            {

                comando.CommandText = "select  e.Apellido+' '+e.Nombre as Informante,"+
            "Case when em.IdEmpleado is null then 'Nadie'else em.Apellido+' '+em.Nombre end Causante,"+
            "Motivo,Fecha,"+
            "case when b.IdBebida is null then i.NombreProducto else b.NombreBebida end Producto, Cantidad "+
             "from Merma m inner join Empleado e on(m.IdInformante=e.IdEmpleado) left outer join Empleado em "+
             "on(m.IdEmpleado=em.IdEmpleado) left join Ingrediente i on (m.IdIngrediente=i.IdIngrediente) left join Bebida b on(m.IdBebida=b.IdBebida) where m.IdSucursal="+id;
            
                adapter.SelectCommand = comando;
                adapter.Fill(merma);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
