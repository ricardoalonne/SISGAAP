using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisgaapCore.Entities
{
    public class DetalleSolicitudProduccion{
        public string codigoSolicitud { get; set; }
        public string codigoRepuesto { get; set; }
        public string Detalle_Solicitud_Abastecimiento_codigoSolicitud { get; set; }
        public double costoUnitario { get; set; }
        public int cantidadSugerida { get; set; }
        public int error { get; set; }
    }
}
