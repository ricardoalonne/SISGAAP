using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisgaapCore.Entities{
    public class SolicitudProducción{
        public string codigoSolicitud { get; set; }
        public string asunto { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaEmision { get; set; }
        public DateTime fechaEntrega { get; set; }
        public string observacion { get; set; }
        public int totalRepuestos { get; set; }
        public double costoTotal { get; set; }
        public string estado { get; set; }
        public string redactor { get; set; }
        public int error { get; set; }
    }
}
