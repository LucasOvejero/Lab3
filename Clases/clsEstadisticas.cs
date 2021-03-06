﻿using System;
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
                MinMax[0] = tabla.Rows[0]["minimo"] is DBNull ? 2018 : tabla.Rows[0].Field<int>("minimo");
                MinMax[1] = tabla.Rows[0]["maximo"] is DBNull?2018:tabla.Rows[0].Field<int>("maximo");
                
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
        public static DataTable getVentas(DateTime desde, DateTime hasta, int IdSucursal)
        {
            DataTable ventas = new DataTable("Ventas");
            try
            {
                string sqlText = "select COUNT(*) Cantidad,sum(Costo) Costo,sum(Precio) Precio,sum(Precio)-sum(Costo) Ganancia,s.NombreInterno as Nombre from DescripcionVenta d inner join EncabezadoVenta e on (d.NroVenta=e.NroVenta) inner join Sucursal s on(e.IdSucursal=s.IdSucursal) where e.IdSucursal=" + IdSucursal + " and CAST(Fecha as date) between Cast('" + desde.ToShortDateString() + "' as Date) and CAST('" + hasta.ToShortDateString() + "' as date) group by NombreInterno;";
            

                SqlCommand comando = new SqlCommand(sqlText, clsConexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(ventas);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
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

        public static DataTable BebidasMasVendidasSuc(DateTime desde, DateTime hasta, int IdSucursal) {
            DataTable BMVS = new DataTable("BMVS");
       
            string idSQL = " and IdSucursal=" + IdSucursal;
            string betweenDates=" and CAST(Fecha as date) between Cast('" + desde.ToShortDateString() + "' as Date) and CAST('" + hasta.ToShortDateString() + "' as date) ";
            string sql = string.Format("Select NombreBebida as Nombre, Cantidad, b.IdBebida from Bebida b inner join " +
                 "(select SUM(Cantidad) Cantidad, IdBebida from DescripcionVenta inner join EncabezadoVenta e on (DescripcionVenta.NroVenta=e.NroVenta) where IdBebida is not null {0} {1} group by IdBebida ) " +
                "g on (b.IdBebida=g.IdBebida)  order by Cantidad desc;", idSQL,betweenDates );
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

        public static DataTable PlatosMasVendidosSuc(DateTime desde, DateTime hasta, int IdSucursal)
        {
            DataTable PMV = new DataTable("PMV");
            string idSQL = " and IdSucursal=" + IdSucursal;
            string betweenDates = " and CAST(Fecha as date) between Cast('" + desde.ToShortDateString() + "' as Date) and CAST('" + hasta.ToShortDateString() + "' as date) ";
           
            string sql = string.Format("select  Nombre, Cantidad, p.IdPlato from Plato p inner join " +
                "(select SUM(Cantidad) Cantidad,IdPlato from DescripcionVenta inner join EncabezadoVenta e on (DescripcionVenta.NroVenta=e.NroVenta) where IdPlato is not null {0} {1}  group by IdPlato ) " +
                "g on(p.IdPlato=g.IdPlato) order by Cantidad Desc;", idSQL, betweenDates);
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
        public static DataTable getVentasXEmpleado(int IdEmpleado,int IdSucursal, DateTime fecha) {
            DataTable graficos = new DataTable("Graficos");
            try
            {
                string sqlString = string.Format("select SUM (Precio) as Total,SUM(Precio-Costo) as Ganancia, DAY(Fecha) Dia from DescripcionVenta d inner join EncabezadoVenta v on(d.NroVenta=v.NroVenta) where IdEmpleado={0} and IdSucursal={1} and YEAR(Fecha)={2} and MONTH(Fecha)={3} and DAY(Fecha)={4} group by DAY(Fecha);", IdEmpleado, IdSucursal, fecha.Year, fecha.Month, fecha.Day);
                SqlCommand comando = new SqlCommand(sqlString,clsConexion.getCon());
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(graficos);
            }
            catch (SqlException e)
            {

            }
            finally { clsConexion.closeCon(); }
            return graficos;
        }
        public static DataTable getVentasXEmpleado(DateTime desde, DateTime hasta, int IdSucursal,int IdEmpleado)
        {
            DataTable graficos = new DataTable("Graficos");
            try
            {
                string betweenDates = " and CAST(Fecha as date) between Cast('" + desde.ToShortDateString() + "' as Date) and CAST('" + hasta.ToShortDateString() + "' as date) ";
                string sqlString = string.Format("select SUM (Precio) as Total,SUM(Precio-Costo) as Ganancia, DAY(Fecha) Dia from DescripcionVenta d inner join EncabezadoVenta v on(d.NroVenta=v.NroVenta) where IdEmpleado={0} and IdSucursal={1} {2}  group by DAY(Fecha);", IdEmpleado, IdSucursal, betweenDates);
                SqlCommand comando = new SqlCommand(sqlString, clsConexion.getCon());
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(graficos);
            }
            catch (SqlException e)
            {

            }
            finally { clsConexion.closeCon(); }
            return graficos;
        }
        public static DataTable getVentasPInforme(DateTime desde, DateTime hasta)
        {
            DataTable graficos = new DataTable("VentasPInforme");
            string sqlString = "select sum(Precio) Recaudado,sum(Precio)-sum(Costo) Ganancia,CAST(s.IdSucursal as nvarchar(10))+'-'+s.NombreInterno as Nombre from DescripcionVenta d inner join EncabezadoVenta e on (d.NroVenta=e.NroVenta) inner join Sucursal s on(e.IdSucursal=s.IdSucursal) where  CAST(Fecha as date) between Cast('" + desde.ToShortDateString() + "' as Date) and CAST('" + hasta.ToShortDateString() + "' as date) group by NombreInterno,s.IdSucursal;";
            try
            {
                SqlCommand comando = new SqlCommand(sqlString, clsConexion.getCon());
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(graficos);
            }
            catch (SqlException e)
            {

            }
            finally { clsConexion.closeCon(); }
            return graficos;
        }


        public static DataTable getVentasPVendedor(DateTime desde, DateTime hasta,int IdEmpleado,int IdSucursal) {
            DataTable graficos = new DataTable("VentasVendedor");
            string sqlString = string.Format("select e.Nombre+' '+e.Apellido+' DNI: '+e.Dni Vendedor, case when b.IdBebida is null then p.Nombre else b.NombreBebida end Producto, COUNT (d.Costo) as Cantidad, d.Precio  from DescripcionVenta d inner join EncabezadoVenta v on(d.NroVenta=v.NroVenta) inner join Empleado e on (v.IdEmpleado=e.IdEmpleado) left join Plato p on (p.IdPlato=d.IdPlato) left join Bebida b on(d.IdBebida=b.IdBebida) where v.IdEmpleado={0} and v.IdSucursal={1}  and CAST(Fecha as date) between Cast('{2}' as Date) and CAST('{3}' as date)   group by b.NombreBebida,p.Nombre,b.IdBebida,p.IdPlato,d.Precio,e.Nombre,e.Apellido,e.Dni;", IdEmpleado, IdSucursal, desde.ToShortDateString(), hasta.ToShortDateString());
            try
            {
                SqlCommand comando = new SqlCommand(sqlString, clsConexion.getCon());
                SqlDataAdapter adap = new SqlDataAdapter(comando);
                adap.Fill(graficos);
            }
            catch (SqlException e) { }

            finally { clsConexion.closeCon(); }
            
            return graficos;
        } //select  case when b.IdBebida is null then p.Nombre else b.NombreBebida end Producto, COUNT (d.Costo) as Cantidad, d.Precio  from DescripcionVenta d inner join EncabezadoVenta v on(d.NroVenta=v.NroVenta) inner join Empleado e on (v.IdEmpleado=e.IdEmpleado) left join Plato p on (p.IdPlato=d.IdPlato) left join Bebida b on(d.IdBebida=b.IdBebida) where v.IdEmpleado=6 and v.IdSucursal=2  and CAST(Fecha as date) between Cast('25/07/2018' as Date) and CAST('26/07/2018' as date)   group by b.NombreBebida,p.Nombre,b.IdBebida,p.IdPlato,d.Precio;
    }
}
