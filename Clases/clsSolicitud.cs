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

        public static DataTable MisSolcitudesRecibidasVigentes(int miId)
        {
            comando = new SqlCommand("select * from Solicitudes WHERE IdSolicitado = " + miId + " AND estado is NULL");
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

        public static DataTable MisSolcitudesPorRecibir(int miId)
        {
            comando = new SqlCommand("select * from Solicitudes WHERE IdSolicitado = " + miId + " AND estado = 1 AND recibido is NULL");
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

        public static DataTable MisSolcitudesRealizadasVigentes(int miId)
        {
            comando = new SqlCommand("select * from Solicitudes WHERE IdSolicitante = " + miId + " AND estado is NULL");
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

        public static int nuevaSolicitud(int idSolicitante, int idSolicitado, double costoTotal)
        {
            comando = new SqlCommand();
            comando.CommandText = "INSERT INTO Solicitudes (idSolicitante,idSolicitado,fechaInicio,costoTotal)" +
                "values (@idSolicitante,@idSolicitado,@fechaInicio,@costoTotal)" +
                "; select SCOPE_IDENTITY(); ";

            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@idSolicitante", idSolicitante);
            parametros[1] = new SqlParameter("@idSolicitado", idSolicitado);
            parametros[2] = new SqlParameter("@fechaInicio", DateTime.Now.ToString("yyyy-MM-dd"));
            parametros[3] = new SqlParameter("@costoTotal", costoTotal);

            try
            {
                comando.Parameters.AddRange(parametros);
                comando.Connection = clsConexion.getCon();
                int id = -1;
                id = Convert.ToInt32(comando.ExecuteScalar());
                if (id >= 0)
                {
                    return id;
                }
                return -1;
            }
            catch (SqlException e)
            {
                return -1;
            }
            finally
            {
                clsConexion.closeCon();
            }
        }

        public static void rechazarSolicitud(int id)
        {

            //UPDATE Solicitudes SET Estado = 0 , fechaFin = '2018-6-5' WHERE IdSolicitud = 1;
            string query = "UPDATE Solicitudes SET Estado = 0 , fechaFin = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE IdSolicitud = " + id;
            comando = new SqlCommand(query);

            try
            {

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
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string query = "UPDATE Solicitudes SET Estado = 1, fechaFin = '" + fecha + "' WHERE IdSolicitud = " + id;
            comando = new SqlCommand(query);
            try
            {
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                comando.ExecuteNonQuery();
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
        }

        public static void nuevoDetalleSolicitud(int IdSolicitud, int IdIngrediente, double cantidad)
        {

            string resp = "";
            comando = new SqlCommand();
            comando.CommandText = "INSERT INTO DetalleSolicitud (IdSolicitud,IdIngrediente,cantidad)" +
                "values (@IdSolicitud,@IdIngrediente,@cantidad)" +
                "; select SCOPE_IDENTITY(); ";

            SqlParameter[] parametros = new SqlParameter[3];
            parametros[0] = new SqlParameter("@IdSolicitud", IdSolicitud);
            parametros[1] = new SqlParameter("@IdIngrediente", IdIngrediente);
            parametros[2] = new SqlParameter("@cantidad", cantidad);

            try
            {
                comando.Parameters.AddRange(parametros);
                comando.Connection = clsConexion.getCon();

                comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                resp = e.Message;
            }
            finally
            {
                clsConexion.closeCon();
            }


        }

        public static DataTable obtenerIngredientesDeSolicitud(int SolicitudId)
        {

            comando = new SqlCommand("SELECT * FROM Ingrediente INNER JOIN DetalleSolicitud ON Ingrediente.IdIngrediente = DetalleSolicitud.IdIngrediente INNER JOIN Solicitudes ON Solicitudes.IdSolicitud = DetalleSolicitud.IdSolicitud WHERE Solicitudes.IdSolicitud = " + SolicitudId);
            try
            {
                solicitudes = new DataTable("DetalleSolicitud");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(solicitudes);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return solicitudes;

        }

        public static DataTable GetHistorial()
        {
            comando = new SqlCommand("SELECT * FROM Solicitudes WHERE fechaFin IS NOT NULL AND (IdSolicitante = " + clsConexion.SucursalSession + " OR IdSolicitado = " + clsConexion.SucursalSession + ")");
            try
            {
                solicitudes = new DataTable("Solicitud");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(solicitudes);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return solicitudes;
        }

        public static object Enviadas()
        {
            comando = new SqlCommand("SELECT * FROM Solicitudes WHERE fechaFin IS NOT NULL AND IdSolicitante = " + clsConexion.SucursalSession);
            try
            {
                solicitudes = new DataTable("Solicitud");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(solicitudes);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return solicitudes;
        }

        public static object Recibidas()
        {
            comando = new SqlCommand("SELECT * FROM Solicitudes WHERE fechaFin IS NOT NULL AND IdSolicitado = " + clsConexion.SucursalSession);
            try
            {
                solicitudes = new DataTable("Solicitud");
                comando.Connection = clsConexion.getCon();
                adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(solicitudes);
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return solicitudes;
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