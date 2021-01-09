using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sisgaapCore.Entities;
using System.Data.SqlClient;
using System.Data;
using sisgaapSqlDB.DataBase;

namespace sisgaapCoreWF.Controllers
{
    public class UsuarioCtr
    {
        UsuarioDat objUsuariodat;
        public UsuarioCtr()
        {
            objUsuariodat = new UsuarioDat();
        }
        public DataSet Usuario_dataset(Usuario usuario)
        {
            return objUsuariodat.Usuario_dataset(usuario);
            //usuario.error = 77;
        }
        public void CargarUsuario(Usuario objUsuario)
        {
            objUsuariodat.ObtenerUsuario(objUsuario);
        }
    }
}
