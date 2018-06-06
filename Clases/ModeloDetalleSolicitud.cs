using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class ModeloDetalleSolicitud
    {

        List<ModeloDetalleSolicitud> Solicitudes;


        public int IdSolicitud { get; set; }
        public int IdIngrediente { get; set; }
        public string NombreIngrediente { get; set;}
        public decimal CantidadKg { get; set; }

        public ModeloDetalleSolicitud(int IdSol)
        {
            this.IdSolicitud = IdSol;
            Solicitudes = new List<ModeloDetalleSolicitud>();
        }

        public void Cargar(int IdIngrediente, string NombreIngrediente, decimal CantidadKg) {

            ModeloDetalleSolicitud UnaSolicitud = new ModeloDetalleSolicitud(IdSolicitud);

            UnaSolicitud.IdIngrediente = IdIngrediente;
            UnaSolicitud.NombreIngrediente = NombreIngrediente;
            UnaSolicitud.CantidadKg = CantidadKg;

            Solicitudes.Add(UnaSolicitud);

            UnaSolicitud = null;           

        }



    }
}
