using System;
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
      static  DataTable tabla;
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
           comando = new SqlCommand("select * from Sucursal");
           try
           {
               tabla = new DataTable("Sucursales");
               comando.Connection = clsConexion.getCon();
               adaptador = new SqlDataAdapter();
               adaptador.SelectCommand = comando;
               adaptador.Fill(tabla);
           }
           catch (SqlException x) { }
           finally { clsConexion.closeCon(); }
           return tabla;
       }

    }
}
