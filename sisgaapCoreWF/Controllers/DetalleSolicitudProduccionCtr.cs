using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using sisgaapCore.Entities;
using sisgaapSqlDB.DataBase;

namespace sisgaapCoreWF.Controllers
{
    public class DetalleSolicitudProduccionCtr
    {
        DetalleSolicitudProduccionDat objDetalleSPdat;
        public DetalleSolicitudProduccionCtr()
        {
            objDetalleSPdat = new DetalleSolicitudProduccionDat();
        }
        public void RegistrarDetalleSP(DetalleSolicitudProduccion objDetalleSP)
        {
            bool correcto = true;
            if (objDetalleSP.cantidadSugerida <= 0)
            {
                objDetalleSP.error = 1; //cantidad invalidad!!
            }
            if (objDetalleSP.costoUnitario <= 0)
            {
                objDetalleSP.error = 2; //costo invalido!!
            }
            correcto = objDetalleSPdat.SelectRepuestoxDetalleSA(objDetalleSP) && !objDetalleSPdat.SelectRepuestoxDetalleSP(objDetalleSP);
            if (!correcto)
            {
                objDetalleSP.error = 3; //codigo de repuesto invalido!!
                return;
            }
            objDetalleSP.error = 77;
            objDetalleSPdat.InsertarDetalle_SP(objDetalleSP);
        }
        public void EliminarDetallesSP(DetalleSolicitudProduccion objDetalleSP)
        {
            objDetalleSPdat.DeleteDetalle_SP(objDetalleSP);
        }
        public void ActualizarDetalleSP(DetalleSolicitudProduccion objDetalleSP)
        {
            if (objDetalleSP.cantidadSugerida <= 0)
            {
                objDetalleSP.error = 1; //cantidad invalidad!!
            }
            objDetalleSP.error = 77;
            objDetalleSPdat.UpdateDetalle_SP(objDetalleSP);
        }
        public DataSet Detalles_SP_dataset(DetalleSolicitudProduccion detalleSP)
        {
            return objDetalleSPdat.DetalleSP_dataset(detalleSP);
        }
        public void EliminarAllDetalleSP(DetalleSolicitudProduccion objDetalleSP)
        {
            objDetalleSPdat.DeleteAllDetalle_SP(objDetalleSP);
        }
        public bool ExistenciaSA_SP(DetalleSolicitudProduccion objDetalleSP)
        {
            return objDetalleSPdat.SelectCodigoSAxDetalleSP(objDetalleSP);
        }
    }
}
