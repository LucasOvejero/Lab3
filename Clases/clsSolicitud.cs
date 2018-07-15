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

        public static void marcarRecibida(int idSolicitud)
        {
            string query = "UPDATE Solicitudes SET recibido = 1, fechaFin = '" + DateTime.Now.ToString("yyyy-MM-dd") +"' WHERE IdSolicitud = " + idSolicitud;
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

        public static DataTable MisSolcitudesRecibidasVigentes(int miId)
        {
            //select so.fechaInicio,so.fechaFin, so.costoTotal,su.NombreInterno as "Desde", su.Telefono from Solicitudes so JOIN Sucursal su on so.IdSolicitante = su.IdSucursal  WHERE IdSolicitado = 1  AND so.estado is NULL
            string consulta = "select so.fechaInicio, so.IdSolicitud, so.costoTotal,su.NombreInterno as \"Desde\", su.Telefono, so.fechaEnvio as \"Enviado\" from Solicitudes so JOIN Sucursal su on so.IdSolicitante = su.IdSucursal  WHERE IdSolicitado = " + miId + "  AND so.estado is NULL";
            comando = new SqlCommand(consulta);
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

        public static void marcarInconveniente(int idSolicitud,string obs)
        {
            string query = "UPDATE Solicitudes SET recibido = 0 ,observacion = '"+obs+ "' , fechaFin = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  WHERE IdSolicitud = " + idSolicitud;
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

        public static DataTable MisSolcitudesPorRecibir()
        {

            string query = "select so.fechaInicio, so.IdSolicitud, so.costoTotal,su.NombreInterno as \"Desde\", su.Telefono "
                                + "from Solicitudes so JOIN Sucursal su on so.IdSolicitado = su.IdSucursal "
                                + "WHERE IdSolicitante = " + clsConexion.SucursalSession + " AND so.estado = 1 AND so.recibido is NULL";
            comando = new SqlCommand(query);
            //comando = new SqlCommand("select * from Solicitudes WHERE IdSolicitado = " + clsConexion.SucursalSession + " AND estado = 1 AND recibido is NULL");
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
            //comando = new SqlCommand("select * from Solicitudes WHERE IdSolicitante = " + miId + " AND estado is NULL AND recibido is null");          
            string consulta = "select so.fechaInicio, so.IdSolicitud, so.costoTotal,su.NombreInterno as \"Para\", su.Telefono from Solicitudes so JOIN Sucursal su on so.IdSolicitado = su.IdSucursal  WHERE IdSolicitante = " + miId + "  AND so.estado is NULL";
            comando = new SqlCommand(consulta);
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

        public static string CountEnCamino()
        {
            string query = "SELECT COUNT(*) Cantidad FROM Solicitudes WHERE estado = 1 AND recibido is NULL AND IdSolicitante =  " + clsConexion.SucursalSession;
            comando = new SqlCommand(query);
            try
            {
                solicitudes = new DataTable("Solicitudes");
                comando.Connection = clsConexion.getCon();
                int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                if (cantidad == 0)
                {
                    return "No hay solicitudes en camino";
                }
                else
                {
                    return "Solicitudes en camino: " + cantidad;
                }
            }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally { clsConexion.closeCon(); }
            return "";
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
            string query = "UPDATE Solicitudes SET Estado = 1, fechaEnvio = '" + fecha + "' WHERE IdSolicitud = " + id;
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
            //si es admin
            string query = "";
            if (clsConexion.SucursalSession == -1)
            {

                query = "SELECT  t2.IdSolicitud , t2.estado t1.k Solicitante, t2.k Solicitado, t2.fechaInicio Inicio,t2.fechaEnvio Envio, t2.fechaFin \"Fin\", t2.costoTotal Monto,t2.recibido Recibido,t2.observacion Observaciones FROM "
                       + " (SELECT su.NombreInterno as k, so.IdSolicitud, so.IdSolicitante FROM Solicitudes so JOIN Sucursal su on so.IdSolicitante = su.IdSucursal) t1"
                       + " JOIN (SELECT su.NombreInterno as k, so.estado , so.IdSolicitud, so.IdSolicitante, so.fechaInicio, so.fechaEnvio, so.costoTotal, so.fechaFin, so.observacion, so.recibido FROM Solicitudes so JOIN Sucursal su on so.IdSolicitado = su.IdSucursal) t2"
                       + " on t1.IdSolicitud = t2.IdSolicitud";
            }
            else
            {
                query = "SELECT  t2.IdSolicitud , t2.estado, t1.k Solicitante, t2.k Solicitado, t2.fechaInicio Inicio,t2.fechaEnvio Envio, t2.fechaFin \"Fin\", t2.costoTotal Monto,t2.recibido Recibido,t2.observacion Observaciones FROM "
            + " (SELECT su.NombreInterno as k, so.IdSolicitud, so.IdSolicitante FROM Solicitudes so JOIN Sucursal su on so.IdSolicitante = su.IdSucursal) t1"
            + " JOIN (SELECT su.NombreInterno as k,so.estado, so.IdSolicitud, so.IdSolicitante, so.fechaInicio, so.fechaEnvio, so.costoTotal, so.fechaFin, so.observacion, so.recibido FROM Solicitudes so JOIN Sucursal su on so.IdSolicitado = su.IdSucursal) t2"
            + " on t1.IdSolicitud = t2.IdSolicitud WHERE t2.IdSolicitante = " + clsConexion.SucursalSession + " OR t1.IdSolicitante = " + clsConexion.SucursalSession + "; ";

            }
            comando = new SqlCommand(query);
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
            comando = new SqlCommand("SELECT * FROM Solicitudes JOIN Sucursal on IdSolicitado = IdSucursal WHERE fechaEnvio IS NOT NULL AND IdSolicitante = " + clsConexion.SucursalSession);
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
            comando = new SqlCommand("SELECT * FROM Solicitudes JOIN Sucursal on IdSolicitado = IdSucursal WHERE fechaEnvio IS NOT NULL AND IdSolicitado = " + clsConexion.SucursalSession);
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