using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clases
{
    class clsEmpleado
    {

        #region atributos

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        int idSucursal;

        public int IdSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }
        int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        #endregion


        static SqlCommand comando;
        static SqlDataAdapter adaptador;
        static DataTable empleados;

       public clsEmpleado(int IdEmpleado,
           string nombre,
           string apellido,
           string dni,
           string telefono,
           int IdSucursal,
           string tipo
           ,bool estado)
       {
           Nombre = nombre;
           Apellido = apellido;
           Dni = dni;
           Telefono = telefono;
           IdSucursal = idSucursal;
           Tipo = Tipo;
           Estado = estado;
       }

        public clsEmpleado() {}

        public static DataTable seleccionarEmpleados()
        {
            comando = new SqlCommand("select * from Empleado");
            try
            {
                empleados = new DataTable("Empleados");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(empleados);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return empleados;
        }



    }
}
