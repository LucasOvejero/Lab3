using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Merma
    {
        public int IdIngrediente{get;set;}
        public int IdBebida{get;set;}
        public int Cantidad { get; set; }
        public int IdEmpleado { get; set; }
        public int IdInformante { get; set; }
        public int IdSucursal { get; set; }
        public string Motivo { get; set; }


    }
}
