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
    public class PersonalCtr
    {
        PersonalDat objPersonaldat;
        public PersonalCtr()
        {
            objPersonaldat = new PersonalDat();
        }
        public void CargarPersonal(Personal objPersonal)
        {
            objPersonaldat.ObtenerPersonal(objPersonal);
        }
    }
}
