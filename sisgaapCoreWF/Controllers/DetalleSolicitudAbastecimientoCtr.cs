using System;
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
                return;
            }
            else if (objDetalleSAdat.SelectRepuestoxDetalleSAxSolicitud(objDetalleSA))
            {
                objDetalleSA.error = 2;//repuesto ya ingresado anteriormente!!
                return;
            }
            objDetalleSA.error = 77;
            objDetalleSAdat.InsertarDetalle_SA(objDetalleSA);
        }
        public void EliminarDetallesSA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            objDetalleSAdat.DeleteDetalle_SA(objDetalleSA);
        }
        public void ActualizarDetalleSA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            if (objDetalleSA.cantidadSolicitada <= 0)
            {
                objDetalleSA.error = 1; //cantidad invalidad!!
            }
            objDetalleSA.error = 88;
            objDetalleSAdat.UpdateDetalle_SA(objDetalleSA);
        }
        public DataSet Detalles_SA_dataset(DetalleSolicitudAbastecimiento detalleSA)
        {
            return objDetalleSAdat.DetalleSA_dataset(detalleSA);
        }
        public void EliminarAllDetalleSA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            objDetalleSAdat.DeleteAllDetalle_SA(objDetalleSA);
        }
        public DataTable Detalle_SA_datatable(DetalleSolicitudAbastecimiento detalleSA)
        {
            return objDetalleSAdat.DetalleSA(detalleSA);
        }
    }
}
