using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Clases
{
    public  class clsBebida
    {
        String nombreBebida;
        int cantidad;
        bool alcohol;
        decimal costo, precio, litros;
        #region constructor y propiedades
        public clsBebida(String nombre, int cantidad, bool alcohol, decimal costo, decimal precio, decimal litros)
        {
            nombreBebida = nombre;
            this.cantidad = cantidad;
            this.alcohol = alcohol;
            this.costo = costo;
            this.precio = precio;
            this.litros = litros;
        }
        public clsBebida() { }
        public decimal Litros
        {
            get { return litros; }
            set { litros = value; }
        }
        public bool Alcohol
        {
            get { return alcohol; }
            set { alcohol = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }      
        public String NombreBebida
        {
            get { return nombreBebida; }
            set { nombreBebida = value; }
        }
        DataTable dt = new DataTable();
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        #endregion
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand comando;
        public int insertarBebida()
        {
            int r = 0;
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("@Nombre", NombreBebida);
            parametros[1] = new SqlParameter("@Costo", Costo);
            parametros[2] = new SqlParameter("@Precio", Precio);
            parametros[3] = new SqlParameter("@Litros", Litros);
            parametros[4] = new SqlParameter("@Alcohol", Alcohol);
            comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "sp_IBebida";
            try
            {
                comando.Connection = clsConexion.getCon();
                comando.Parameters.AddRange(parametros);
                r = (Int32)comando.ExecuteNonQuery();
            }
            catch (NullReferenceException n) { Console.WriteLine(n.Message); }
            catch (SqlException x) { Console.WriteLine(x.Message); }
            finally
            { clsConexion.closeCon(); }
            return r;
        }
        public DataTable seleccionarBebidas()
        {

            dt.Clear();
           
           comando = new SqlCommand("select * from Bebida");
            try
            {
                comando.Connection = clsConexion.getCon();
                da.SelectCommand = comando;
                da.Fill(dt);
            }
            catch (SqlException x) { throw x; }
            finally { clsConexion.closeCon(); }
            return dt;
        }
        public void eliminarBebida(int IdBebida)
        {
            
            comando = new SqlCommand("delete from Bebida where IdBebida=" + IdBebida);
            try
            {
                comando.Connection = clsConexion.getCon();
                comando.ExecuteNonQuery();
            }
            catch (SqlException e) { Console.WriteLine(e.Message);  }
            finally { clsConexion.closeCon(); }
           
        }
        public void modificarBebida(int IdBebida)
        {
            comando = new SqlCommand("update Bebida set NombreBebida=@Nombre, Costo=@Costo, Precio=@Precio, Litros=@Litros, Alcohol=@Alcohol where IdBebida=@IdBebida");
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("@Nombre", NombreBebida);
            parametros[1] = new SqlParameter("@Costo", Costo);
            parametros[2] = new SqlParameter("@Precio", Precio);
            parametros[3] = new SqlParameter("@Litros", Litros);
            parametros[4] = new SqlParameter("@Alcohol", Alcohol);
            parametros[5] = new SqlParameter("@IdBebida", IdBebida);
            try
            {
                comando.Connection = clsConexion.getCon();
                comando.ExecuteNonQuery();
            }
            catch (SqlException e) { Console.WriteLine(e.Message); }
            finally { clsConexion.closeCon(); }
        }
    }
}
