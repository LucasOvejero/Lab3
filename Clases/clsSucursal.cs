﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Clases
{
   public class clsSucursal
    {
       int idSucursal, idLocalidad;
       string direccion, telefono;
       bool estado;
      static SqlCommand comando;
      static SqlDataAdapter adaptador;
      static  DataTable sucursales;
       public int IdSucursal {
           get { return idSucursal; }
           set { idSucursal = value; }
       }
       public int IdLocalidad {
           get { return idLocalidad; }
           set { idLocalidad = value; }
       }
       public string Direccion {
           get { return direccion; }
           set { direccion = value; }
       }
       public string Telefono {
           get { return telefono; }
           set { telefono = value; }
       }
       public bool Estado {
           get { return estado; }
           set { estado = value; }
       }

       public clsSucursal(int idSucursal, int idLocalidad, string direccion, string telefono, bool estado)
       {
           this.idSucursal = idSucursal;
           this.idLocalidad = idLocalidad;
           this.estado = estado;
           this.direccion = direccion;
           this.telefono = telefono;
       }
       public clsSucursal() { }


       public static DataTable seleccionarSucursales() {
           comando = new SqlCommand("select IdManager,s.IdSucursal, s.Direccion,s.Telefono,  Nombre +' '+ Apellido AS Manager, s.Estado , IdLocalidad from Sucursal s  left outer join Empleado ON IdManager = IdEmpleado");
           try
           {
               sucursales = new DataTable("Sucursales");
               comando.Connection = clsConexion.getCon();
               adaptador = new SqlDataAdapter();
               adaptador.SelectCommand = comando;
               adaptador.Fill(sucursales);
           }
           catch (SqlException x) {
               throw x;
               }
           finally { clsConexion.closeCon(); }
           return sucursales;
       }
       public static string[] getPerLocProv(string localidad,string provincia) {
           List<string> LSucursales = new List<string>();

           try
           {
               DataTable sc = new DataTable();
               adaptador = new SqlDataAdapter();
               comando = new SqlCommand("Select Direccion from Sucursal where IdLocalidad in(select IdLocalidad from Localidad where NombreLocalidad='"+localidad+"' and IdProvincia in(select IdProvincia from Provincia where NombreProvincia='"+provincia+"'));");
               comando.Connection = clsConexion.getCon();
               adaptador.SelectCommand = comando;
               adaptador.Fill(sc);
               foreach (DataRow r in sc.Rows)
               {
                   LSucursales.Insert(LSucursales.Count, r["Direccion"].ToString());
               }

           }
           catch (SqlException e) { throw e; }
           return LSucursales.ToArray();
       }
       public static string[] getPerLoc(string localidad)
       {
           List<string> LSucursales = new List<string>();

           try
           {
               DataTable sc = new DataTable();
               adaptador = new SqlDataAdapter();
               comando = new SqlCommand("Select Direccion from Sucursal where IdLocalidad in(select IdLocalidad from Localidad where NombreLocalidad='" + localidad + "');");
               comando.Connection = clsConexion.getCon();
               adaptador.SelectCommand = comando;
               adaptador.Fill(sc);
               foreach (DataRow r in sc.Rows)
               {
                   LSucursales.Insert(LSucursales.Count, r["Direccion"].ToString());
               }

           }
           catch (SqlException e) { throw e; }
           return LSucursales.ToArray();
       }
       public static string[] getTodas(){
           List<string> LSucursales = new List<string>();
          
           try
           {
                DataTable sc=new DataTable();
                adaptador = new SqlDataAdapter();
                comando = new SqlCommand("Select Direccion from Sucursal");
               comando.Connection = clsConexion.getCon();
               adaptador.SelectCommand=comando;
               adaptador.Fill(sc);
               foreach (DataRow r in sc.Rows)
               {
                   LSucursales.Insert(LSucursales.Count, r["Direccion"].ToString());
               }

           }
           catch (SqlException e) { throw e; }
           return LSucursales.ToArray();
       }
       public static string[] getPerProv(string provincia) {
           List<string> lSuc = new List<string>();
           try
           {
               DataTable suc = new DataTable();
               comando = new SqlCommand("Select Direccion from Sucursal where IdLocalidad in(Select IdLocalidad from Provincia p JOIN Localidad l on(p.IdProvincia=l.IdProvincia) Where NombreProvincia='" + provincia + "') ");
               comando.Connection = clsConexion.getCon();
               adaptador.SelectCommand = comando;
               adaptador.Fill(suc);
               foreach (DataRow r in suc.Rows)
               {
                   lSuc.Insert(lSuc.Count, r["Direccion"].ToString());
               }
           }
           catch (SqlException e)
           {
               throw e;
           }
           finally {
               clsConexion.closeCon();
           }
           return lSuc.ToArray();
       }
       public static string insertarSucursal(string DireccionSucursal, string telefonoSucursal, int idLocalidad) {
           string resp = "";
           comando = new SqlCommand();
           comando.CommandText = "INSERT INTO Sucursal (Direccion,Telefono,IdLocalidad) values (@DireccionSucursal,@TelefonoSucursal,@IdLocalidad); select SCOPE_IDENTITY(); ";
           SqlParameter[] parametros = new SqlParameter[3];
           parametros[0] = new SqlParameter("@DireccionSucursal",DireccionSucursal);
           parametros[1] = new SqlParameter("@TelefonoSucursal", telefonoSucursal);
           parametros[2] = new SqlParameter("@IdLocalidad",idLocalidad);
           try
           {
               comando.Parameters.AddRange(parametros);
               comando.Connection = clsConexion.getCon();
               int id = -1;
               id = Convert.ToInt32(comando.ExecuteScalar());
               if (id >= 0)
               {
                   resp = "La Sucursal con la direccion " + DireccionSucursal + " con el telefono " + telefonoSucursal + " insertada correctamente";
                   comando.CommandText = "insert into Deposito (IdSucursal,Stock,IdBebida) select "+id+",0,IdBebida from Bebida;";//agrega el "deposito" de bebidas de esa sucursal inicializada en 0
                   comando.ExecuteNonQuery();
                   comando.CommandText="insert into Deposito (IdSucursal,Stock,IdIngrediente) select "+id+",0,IdIngrediente from Ingrediente";//Agrega al deposito los ingredientes inicializados en 0
                   comando.ExecuteNonQuery();
                   actualizar(id);
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


       private static void actualizar(int id) {
           try
           {
               comando.CommandText = "select * from Sucursal where IdSucursal=" + id;
               adaptador.SelectCommand = comando;
               adaptador.Fill(sucursales);
           }
           catch (SqlException e) {
               throw e;
           }
       }


       public static void darDeBaja(int id) {
           comando = new SqlCommand("UPDATE Sucursal SET Estado = 0 WHERE IdSucursal = " + id);
           try
           {
               sucursales = new DataTable("Sucursales");
               comando.Connection = clsConexion.getCon();
               adaptador = new SqlDataAdapter();
               adaptador.SelectCommand = comando;
               adaptador.Fill(sucursales);
               comando.ExecuteNonQuery();
           }
           catch (SqlException x) { Console.WriteLine(x.Message); }
           finally { clsConexion.closeCon(); }
       }

       public static void darDeAlta(int id)
       {
           comando = new SqlCommand("UPDATE Sucursal SET Estado = 1 WHERE IdSucursal = " + id);
           try
           {
               sucursales = new DataTable("Sucursales");
               comando.Connection = clsConexion.getCon();
               adaptador = new SqlDataAdapter();
               adaptador.SelectCommand = comando;
               comando.ExecuteNonQuery();
           }
           catch (SqlException x) { Console.WriteLine(x.Message); }
           finally { clsConexion.closeCon(); }
       }

       public static void actualizar(int id,string dir, int idManager,string tel)
       {
           comando = new SqlCommand("UPDATE Sucursal SET Direccion = '" + dir + "' , IdManager= "+ idManager +", Telefono = '" + tel + "' WHERE IdSucursal = " + id);
           try
           {
               sucursales = new DataTable("Sucursales");
               comando.Connection = clsConexion.getCon();
               adaptador = new SqlDataAdapter();
               adaptador.SelectCommand = comando;
               comando.ExecuteNonQuery();
           }
           catch (SqlException x) { Console.WriteLine(x.Message); }
           finally { clsConexion.closeCon(); }
       }


    }
}
