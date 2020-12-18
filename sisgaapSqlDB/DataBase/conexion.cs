using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisgaapSqlDB.DataBase
{
    class conexion
    {
        public static string CadenaConexion
        {
            get { return "data source= HAZIELPRIALÉ\\SCORPIODIGITAL; initial catalog=BD_SISGAAP; integrated security = true"; }
            //get { return "data source= (Local); initial catalog=BD_SISGAAP; integrated security = true"; }
        }

    }
}
