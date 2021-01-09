using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisgaapCore.Entities
{
    public class Usuario
    {
        public string codigoUsuario { get; set; }
        public string password { get; set; }
        public bool estado { get; set; }
        public int numeroRol { get; set; }
        public int error { get; set; }
    }
}
