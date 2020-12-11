﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using sisgaapCore.Entities;
using sisgaapSqlDB.DataBase;

namespace sisgaapCoreWF.Controllers
{
    class DetalleSolicitudProduccionCtr
    {
        DetalleSolicitudProduccionDat objDetalleSPdat;
        public DetalleSolicitudProduccionCtr()
        {
            objDetalleSPdat = new DetalleSolicitudProduccionDat();
        }
        public void RegistrarDetalleSP(DetalleSolicitudProduccion objDetalleSP)
        {
            if (objDetalleSP.cantidadSugerida <= 0)
            {
                objDetalleSP.error = 1; //cantidad invalidad!!
            }
            objDetalleSP.error = 77;
            objDetalleSPdat.InsertarDetalle_SP(objDetalleSP);
        }
        public void EliminarDetallesSP(DetalleSolicitudProduccion objDetalleSP)
        {
            objDetalleSPdat.DeleteDetalle_SP(objDetalleSP);
        }
        public void ActualizarDetalleSA(DetalleSolicitudProduccion objDetalleSP)
        {
            if (objDetalleSP.cantidadSugerida <= 0)
            {
                objDetalleSP.error = 1; //cantidad invalidad!!
            }
            objDetalleSP.error = 77;
            objDetalleSPdat.UpdateDetalle_SP(objDetalleSP);
        }
    }
}
