using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clases
{
    public static class clsEstadisticas
    {

        public static int[] getMaxMinYear() {
            int[] MinMax = new int[2];
            
            try
            {
                SqlCommand comando = new SqlCommand("select MAX(YEAR(Fecha)) maximo,MIN(YEAR(Fecha)) minimo from EncabezadoVenta ;", clsConexion.getCon());
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                MinMax[0] = tabla.Rows[0].Field<int>("minimo");
                MinMax[1] = tabla.Rows[0].Field<int>("maximo");
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally {
                clsConexion.closeCon();
            }

            return MinMax;
        }
        public static DataTable getVentas(int anio, int mes,int IdSucursal,Nullable<int>hoy)
        {
            DataTable ventas = new DataTable("Ventas");
            try
            {
                string sqlText="select COUNT(*) Cantidad,sum(Costo) Costo,sum(Precio) Precio,sum(Precio)-sum(Costo) Ganancia,MONTH(Fecha) Mes from DescripcionVenta d inner join EncabezadoVenta e on (d.NroVenta=e.NroVenta) where e.IdSucursal="+IdSucursal+" and YEAR(Fecha)="+anio;
                if (mes != 0)
                    sqlText += " and MONTH(Fecha)=" + mes;
                if (hoy != null)
                    sqlText += " and DAY(Fecha)=" + hoy;
                    sqlText += " group by MONTH(Fecha)";

                SqlCommand comando = new SqlCommand(sqlText, clsConexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(ventas);
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally {
                clsConexion.closeCon();
            }
            return ventas;
        }
    }
}
