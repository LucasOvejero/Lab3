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
        int cantidad,idCategoria;
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
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
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
        DataTable categorias;
        SqlCommand comando;
        public int insertarBebida()
        {
            int r = 0;
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("@Nombre", NombreBebida);
            parametros[1] = new SqlParameter("@Costo", Costo);
            parametros[2] = new SqlParameter("@Precio", Precio);
            parametros[3] = new SqlParameter("@Litros", Litros);
            parametros[4] = new SqlParameter("@Alcohol", Alcohol);
            parametros[5] = new SqlParameter("@IdCategoria", IdCategoria);
            comando = new SqlCommand();

            comando.CommandText = "INSERT INTO Bebida (NombreBebida,Costo,Precio,Litros,Alcohol,IdCategoria) values (@Nombre,@Costo,@Precio,@Litros,@Alcohol,@IdCategoria); select SCOPE_IDENTITY(); ";
            try
            {
                comando.Connection = clsConexion.getCon();
                comando.Parameters.AddRange(parametros);
                r = Convert.ToInt32(comando.ExecuteScalar());
                if (r >= 0)
                {
                    comando.CommandText = "insert into Deposito (IdSucursal,Stock,IdBebida) select Distinct(IdSucursal),0," + r + " from Sucursal";
                    comando.ExecuteNonQuery();
                }
            }
            catch (NullReferenceException n) { throw n; }
            catch (SqlException x) { throw x; }
            finally
            { clsConexion.closeCon(); }
            return r;
        }
        public DataTable seleccionarBebidas()
        {

            dt.Clear();
           
           comando = new SqlCommand("select IdBebida,NombreBebida,Costo,Precio,Litros,Alcohol,Estado"+
               ",b.IdCategoria,Nombre as Categoria from Bebida b left outer join CategoriaBebidas c on (b.IdCategoria=c.IdCategoria)");
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
        public void UpdateEstadoBebida(int IdBebida,bool EstadoActual)
        {
            int estado= EstadoActual?0:1;   
            comando = new SqlCommand("update Bebida set Estado ="+estado+" where IdBebida=" + IdBebida);
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
            comando = new SqlCommand("update Bebida set NombreBebida=@Nombre, Costo=@Costo, Precio=@Precio, Litros=@Litros, Alcohol=@Alcohol,IdCategoria=@IdCategoria where IdBebida=@IdBebida");
            SqlParameter[] parametros = new SqlParameter[7];
            parametros[0] = new SqlParameter("@Nombre", NombreBebida);
            parametros[1] = new SqlParameter("@Costo", Costo);
            parametros[2] = new SqlParameter("@Precio", Precio);
            parametros[3] = new SqlParameter("@Litros", Litros);
            parametros[4] = new SqlParameter("@Alcohol", Alcohol);
            parametros[5] = new SqlParameter("@IdBebida", IdBebida);
            parametros[6] = new SqlParameter("@IdCategoria", IdCategoria);
            try
            {
                comando.Parameters.AddRange(parametros);
                comando.Connection = clsConexion.getCon();
                comando.ExecuteNonQuery();
            }
            catch (SqlException e) { throw e; }
            catch (Exception ex) { throw ex; }
            finally { clsConexion.closeCon(); }
        }
        #region categorias
        public  string agregarCategoria(string Categoria)
        {
            string resp = "";
             SqlDataAdapter adaptadorCategorias = new SqlDataAdapter();
            try
            {
                comando = new SqlCommand();
                comando.CommandText = "Insert into CategoriaBebidas (Nombre) values (@NombreCategoria);Select SCOPE_IDENTITY();";
                comando.Parameters.Add(new SqlParameter("@NombreCategoria", Categoria));
                comando.Connection = clsConexion.getCon();
                int id = int.Parse(comando.ExecuteScalar().ToString());
                if (id >= 0)
                {
                    comando.CommandText = "select * from CategoriaBebidas where IdCategoria=" + id;

                    adaptadorCategorias.SelectCommand = comando;
                    adaptadorCategorias.Fill(categorias);
                }
            }
            catch (SqlException e)
            {
                resp = e.Message;
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                clsConexion.closeCon();

            }
            return resp;
        }
        public DataTable obtenerCategorias()
        {
            categorias = new DataTable();
            SqlDataAdapter adaptadorCategorias = new SqlDataAdapter();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "select * from CategoriaBebidas";
                comando.Connection = clsConexion.getCon();
                adaptadorCategorias.SelectCommand = comando;
                adaptadorCategorias.Fill(categorias);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                clsConexion.closeCon();
            }
            return categorias;
        }
        #endregion
    }
}
