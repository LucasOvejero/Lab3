using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Clases
{
    public static class clsDeposito
    {
        private static DataTable Deposito;
        private static SqlCommand comando;
        public static DataTable getDepositoPorSucursal(int idSucursal) {
            Deposito = new DataTable();
            try
            {
                comando = new SqlCommand("Select * from deposito where IdSucursal=@IdSucursal");

            }
            catch (SqlException e)
            {

                throw e;
            }
            finally {
                clsConexion.closeCon();
            }
            return Deposito;
        }
    }
}
