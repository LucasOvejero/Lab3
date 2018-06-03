using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Producto
    {
        public int Cantidad { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }
    }
}
