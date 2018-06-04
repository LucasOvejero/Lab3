using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Plato
    {
        public int IdPlato { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; }
        public bool TACC { get; set; }
        public decimal Costo { get; set; }
        public bool Estado { get; set; }
        public int IdCategoria { get; set; }
    }
}
