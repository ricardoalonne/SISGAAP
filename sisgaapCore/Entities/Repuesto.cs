using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisgaapCore.Entities{
    public class Repuesto{
        public string codigoRepuesto { get; set; }
        public string nombreRepuesto { get; set; }
        public string descripcion { get; set; }
        public double precioVenta { get; set; }
        public string estado { get; set; }
        public int cantidad { get; set; }
        public int cantidadMinima { get; set; }
        public string codigoCategoria { get; set; }
    }
}
