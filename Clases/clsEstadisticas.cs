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
        public static DataTable BebidasMasVendidasSuc(int anio, int mes, int IdSucursal, Nullable<int> hoy)
        {
            DataTable BMVS = new DataTable("BMVS");
            string mesSQL="";
            string anioSQL=" and YEAR(Fecha)="+anio;
            string diaSQL="";
            string idSQL = " and IdSucursal=" + IdSucursal;
            if (mes != 0)
                mesSQL = " and MONTH(Fecha)=" + mes;
            if(hoy!=null)
                diaSQL=" and DAY(Fecha)=" + hoy;
            string sql =string.Format( "Select NombreBebida as Nombre, Cantidad, b.IdBebida from Bebida b inner join " +
                 "(select SUM(Cantidad) Cantidad, IdBebida from DescripcionVenta inner join EncabezadoVenta e on (DescripcionVenta.NroVenta=e.NroVenta) where IdBebida is not null {0} {1} {2} {3} group by IdBebida ) " +
                "g on (b.IdBebida=g.IdBebida)  order by Cantidad desc;",idSQL,mesSQL,anioSQL,diaSQL);
            try
            {
                SqlCommand comando = new SqlCommand(sql, clsConexion.getCon());
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(BMVS);
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally { clsConexion.closeCon(); }
            return BMVS;
        }
        public static DataTable PlatosMasVendidosSuc(int anio, int mes, int IdSucursal, Nullable<int> hoy)
        {
            DataTable PMV = new DataTable("PMV");
            string mesSQL = "";
            string anioSQL = " and YEAR(Fecha)=" + anio;
            string diaSQL = "";
            string idSQL = " and IdSucursal=" + IdSucursal;
            if (mes != 0)
                mesSQL = " and MONTH(Fecha)=" + mes;
            if (hoy != null)
                diaSQL = " and DAY(Fecha)=" + hoy;
            string sql = string.Format("select  Nombre, Cantidad, p.IdPlato from Plato p inner join "+
                "(select SUM(Cantidad) Cantidad,IdPlato from DescripcionVenta inner join EncabezadoVenta e on (DescripcionVenta.NroVenta=e.NroVenta) where IdPlato is not null {0} {1} {2} {3} group by IdPlato ) "+
                "g on(p.IdPlato=g.IdPlato) order by Cantidad Desc;", idSQL, mesSQL, anioSQL, diaSQL);
            try
            {
                SqlCommand comando = new SqlCommand(sql, clsConexion.getCon());
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(PMV);
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally { clsConexion.closeCon(); }
            return PMV;
        }

    }
}
