using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisgaapCore.Entities
{
    public class Personal
    {
        public int numDocumento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string fechaRemuneracion { get; set; }
        public string foto { get; set; }
        public string codigoUsuario { get; set; }
        public int error { get; set; }
    }
}
