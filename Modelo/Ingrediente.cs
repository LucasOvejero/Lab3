using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes;
namespace Modelo
{
    public class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string NombreProducto { get; set; }
        public double CostoxKg { get; set; }
        public string Categoria { get; set; }
        public int IdCategoria { get;set; }
        public PanelPlato Plato { get; set; }
        
    }
}
