using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisgaapCore.Entities
{
    public class DetalleSolicitudAbastecimiento
    {
        public string codigoSolicitud { get; set; }
        public string codigoRepuesto { get; set; }
        public int cantidadSolicitada { get; set; }
    }
}
