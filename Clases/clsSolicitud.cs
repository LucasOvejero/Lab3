using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Clases
{
    public class clsSolicitud
    {

        #region atributos

        public int IdSolicitud { get; set; }

        int idSolicitante;

        public int IdSolicitante
        {
            get { return idSolicitante; }
            set { idSolicitante = value; }
        }


        int idSolicitado;

        public int IdSolicitado
        {
            get { return idSolicitado; }
            set { idSolicitado = value; }
        }


        int idIngrediente;

        public int IdIngrediente
        {
            get { return idIngrediente; }
            set { idIngrediente = value; }
        }


        public double CantGramos { get; set; }


        public int Estado { get; set; }

        // Pendiente 0
        // Rechazada 1
        // Aceptada 2

        #endregion


        static SqlCommand comando;
        static SqlDataAdapter adaptador;
        static DataTable solicitudes;

        public clsSolicitud(int idSolicitante, int idSolicitado, int idIngrediente, double cantGramos, int estado)
        {
            this.idSolicitante = idSolicitante;
            this.idSolicitado = idSolicitado;
            this.idIngrediente = idIngrediente;
            this.CantGramos = cantGramos;
            this.Estado = estado;
        }

        public clsSolicitud() { }

        public static DataTable seleccionarTodasLasSolicitudes()
        {
            comando = new SqlCommand("select * from Solicitudes");
            try
            {
                solicitudes = new DataTable("Solicitudes");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(solicitudes);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return solicitudes;
        }
        public static DataTable MisSolcitudesRealizadasRecibidas(int miId)
        {
            comando = new SqlCommand("select * from Solicitudes WHERE IdSolicitado = " + miId);
            try
            {
                solicitudes = new DataTable("Solicitudes");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(solicitudes);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return solicitudes;
        }
        public static DataTable MisSolcitudesRealizadas(int miId)
        {
            comando = new SqlCommand("select * from Solicitudes WHERE IdSolicitante = " + miId);
            try
            {
                solicitudes = new DataTable("Solicitudes");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(solicitudes);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return solicitudes;
        }
        public static string nuevaSolicitud(int idSolicitante, int idSolicitado, int idIngrediente, double cantGramos, string estado)
        {


            string resp = "";
            comando = new SqlCommand();
            comando.CommandText = "INSERT INTO Solicitudes (idSolicitante,idSolicitado,idIngrediente,cantGramos,estado,fechaInicio)" +
                "values (@idSolicitante,@idSolicitado,@idIngrediente,@cantGramos,@estado,@fechaInicio)" +
                "; select SCOPE_IDENTITY(); ";

            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("@idSolicitante", idSolicitante);
            parametros[1] = new SqlParameter("@idSolicitado", idSolicitado);
            parametros[2] = new SqlParameter("@idIngrediente", idIngrediente);
            parametros[3] = new SqlParameter("@cantGramos", cantGramos);
            parametros[4] = new SqlParameter("@estado", estado);
            parametros[5] = new SqlParameter("@fechaInicio", DateTime.Today.ToShortDateString());
            try
            {
                comando.Parameters.AddRange(parametros);
                comando.Connection = clsConexion.getCon();
                int id = -1;
                id = Convert.ToInt32(comando.ExecuteScalar());
                if (id >= 0)
                {
                    resp = " Se inicio la solicitud correctamente, por la cantidad de " + cantGramos + " gramos.";
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

        public static void rechazarSolicitud(int id)
        {


            comando = new SqlCommand("UPDATE Solicitudes SET Estado = 1, fechaFin = " + DateTime.Today.ToShortDateString() + " WHERE IdSolicitud = " + id);
            try
            {
                solicitudes = new DataTable("Empleados");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(solicitudes);
                comando.ExecuteNonQuery();
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
        }

        public static void aceptarSolicitud(int id)
        {
            comando = new SqlCommand("UPDATE Empleado SET Estado = 2, fechaFin = " + DateTime.Today.ToShortDateString() + " WHERE IdSolicitud = " + id);
            try
            {
                solicitudes = new DataTable("Empleados");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                comando.ExecuteNonQuery();
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
        }

        /*
        public static DataTable joinSucursales()
        {
            comando = new SqlCommand(
                "select s.IdSucursal,Nombre,Apellido,DNI, e.Telefono \" Tel. Contacto \"" +
                ", s.Telefono \" Tel. Sucursal \" , Direccion \"Trabaja\", e.Tipo \" Puesto\" ,e.Estado " +
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
        }*/

    }
}