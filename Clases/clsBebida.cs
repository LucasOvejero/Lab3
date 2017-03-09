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

        public clsBebida(String nombre, int cantidad, bool alcohol, decimal costo, decimal precio, decimal litros)
        {
            nombreBebida = nombre;
            this.cantidad = cantidad;
            this.alcohol = alcohol;
            this.costo = costo;
            this.precio = precio;
            this.litros = litros;

        }
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
       
    }
}
