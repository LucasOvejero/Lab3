using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clases
{
    public class clsEmpleado
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


        public static bool logeo(string usuario,string clave) {
            bool valid = false;
            comando = new SqlCommand("select * from Empleado where Usuario = '" + usuario + "' AND Clave = '" + clave + "'" );
            try
            {
                empleados = new DataTable("Empleados");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(empleados);

                valid = empleados.Columns.Count > 0;
                //

                clsConexion.Tipo = empleados.Rows[0]["Tipo"].ToString();
                clsConexion.IdEmpleado = empleados.Rows[0]["IdEmpleado"].ToString();
                clsConexion.NombreCompleto =  empleados.Rows[0]["Nombre"].ToString() + " " +  empleados.Rows[0]["Apellido"].ToString(); ;
                clsConexion.SucursalSession = Convert.ToInt32(empleados.Rows[0]["IdSucursal"].ToString());

            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }

            return valid;
        }

        public static string insertarEmpleado(string nombre,
            string apellido,
            string dni,
            string telefono,
            int IdSucursal,
            string tipo,
            bool estado,
            string username,
            string pass
            )
        {
            int activo;
            string tipoX = tipo;
            activo = estado ? 1 : 0;
            string resp = "";
            comando = new SqlCommand();
            comando.CommandText = "INSERT INTO Empleado (Nombre,Apellido,DNI,Telefono,IdSucursal,Tipo,Estado,Usuario,Clave  )"+
                "values (@nombre,@apellido,@dni,@telefono,@IdSucursal,@tipo,@estado,@username,@pass)"+
                "; select SCOPE_IDENTITY(); ";

            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter("@nombre", nombre);
            parametros[1] = new SqlParameter("@apellido", apellido);
            parametros[2] = new SqlParameter("@dni", dni);
            parametros[3] = new SqlParameter("@telefono", telefono);
            parametros[4] = new SqlParameter("@IdSucursal", IdSucursal);
            parametros[5] = new SqlParameter("@tipo", tipoX);
            parametros[6] = new SqlParameter("@estado", estado);
            parametros[7] = new SqlParameter("@username", username);
            parametros[8] = new SqlParameter("@pass", pass);
            try
            {
                comando.Parameters.AddRange(parametros);
                comando.Connection = clsConexion.getCon();
                int id = -1;
                id = Convert.ToInt32(comando.ExecuteScalar());
                if (id >= 0)
                {
                    resp = "El empleado " + nombre + ", " + apellido + ", DNI N° :" + dni + " fue insertado correctamente";
                }
            }
            catch (SqlException e)
            {
                resp = e.Message;
            }
            finally
            {
                clsConexion.closeCon();
            }

            return resp;
        }


        public static void darDeBaja(int id)
        {
            comando = new SqlCommand("UPDATE Empleado SET Estado = 0 WHERE IdEmpleado = " + id);
            try
            {
                empleados = new DataTable("Empleados");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(empleados);
                comando.ExecuteNonQuery();
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
        }

        public static void darDeAlta(int id)
        {
            comando = new SqlCommand("UPDATE Empleado SET Estado = 1 WHERE IdEmpleado = " + id);
            try
            {
                empleados = new DataTable("Empleados");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                comando.ExecuteNonQuery();
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
        }

        public static DataTable joinSucursales() {
            comando = new SqlCommand(
                "select s.IdSucursal,Nombre,Apellido,DNI, e.Telefono \" Tel. Contacto \"" +
                ", s.Telefono \" Tel. Sucursal \" , Direccion \"Trabaja\", e.Tipo \" Puesto\" ,e.Estado "+
                "from Empleado e Join Sucursal s ON (e.IdSucursal = s.IdSucursal)"
                );
            try
            {
                empleados = new DataTable("JoinSucursal");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(empleados);
            }
            catch (SqlException x) { throw x; }
            finally { clsConexion.closeCon(); }
            return empleados;
        }

        public static void ascenderAManager(int idSucursal,int IdEmpleado) {

            degradarManager(idSucursal);

            comando = new SqlCommand("UPDATE Empleado SET Tipo = 'Manager' WHERE IdEmpleado = " + IdEmpleado + " AND IdSucursal = " + idSucursal);
            try
            {
                empleados = new DataTable("Empleados");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(empleados);
                comando.ExecuteNonQuery();
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }



        }

        private static void degradarManager(int idSucursal) {
            comando = new SqlCommand("UPDATE Empleado SET Tipo = 'Sin Asignar' WHERE IdSucursal = " + idSucursal + " AND Tipo = 'Manager'");
            try
            {
                empleados = new DataTable("Empleados");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(empleados);
                comando.ExecuteNonQuery();
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }


        }

        //podria ser activos NO MANAGERS
        public static DataTable selectActivos()
        {
            comando = new SqlCommand("select * from Empleado where ESTADO = 1");
            try
            {
                empleados = new DataTable("Activos");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(empleados);
            }
            catch (SqlException x) { throw x; }
            finally { clsConexion.closeCon(); }
            return empleados;

        }
            
        
    }
}
