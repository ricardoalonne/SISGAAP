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
    public class RolCtr
    {
        RolDat objRoldat;
        public RolCtr()
        {
            objRoldat = new RolDat();
        }
        public void CargarRol(Rol objRol)
        {
            objRoldat.ObtenerRol(objRol);
        }
    }
}
