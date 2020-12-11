﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sisgaapCore.Entities;
using sisgaapSqlDB.DataBase;

namespace sisgaapCoreWF.Controllers
{
    public class DetalleSolicitudAbastecimientoCtr
    {
        DetalleSolicitudAbastecimientoDat objDetalleSAdat;
        public  DetalleSolicitudAbastecimientoCtr()
        {
            objDetalleSAdat = new DetalleSolicitudAbastecimientoDat();
        }
        public void RegistrarDetalleSA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            if (objDetalleSA.cantidadSolicitada <= 0)
            {
                objDetalleSA.error = 1; //cantidad invalidad!!
            }
            objDetalleSA.error = 77;
            objDetalleSAdat.InsertarDetalle_SA(objDetalleSA);
        }
    }
}
