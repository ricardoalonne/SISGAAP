using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sisgaapCore;
using sisgaapSqlDB.DataBase;

namespace sisgaapCoreWF.Controllers
{
    public class SolicitudAbastecimientoCtr
    {
        SolicitudAbastecimientoDat objSAdat;
        public SolicitudAbastecimientoCtr()
        {
            objSAdat = new SolicitudAbastecimientoDat();
        }
        public void RegistrarSA(SolicitudAbastecimiento objSA)
        {
            DateTime fechaEntrega = objSA.fechaEntrega;
            if (fechaEntrega <= DateTime.Now)
            {
                objSA.error = 1;//fecha Invalida!!
                return;
            }
            else if (objSA.descripcion.Length>50)
            {
                objSA.error = 2; //Descripción supero los 50 caracteres!!
                return;
            }
            else if (objSA.asunto.Length > 50)
            {
                objSA.error = 3; //Asunto supero los 50 caracteres!!
                return;
            }
            else if (objSA.observacion.Length > 50)
            {
                objSA.error = 4; //observación supero los 50 caracteres!!
                return;
            }
            objSA.error = 77;
            objSAdat.InsertarSolicitudAbastecimiento(objSA);
        }
        public void EliminarSA(SolicitudAbastecimiento objSA)
        {
            objSAdat.DeleteSolicitudAbastecimiento(objSA);
        }
        public void ActualizarSA(SolicitudAbastecimiento objSA)
        {
            DateTime fechaEntrega = objSA.fechaEntrega;
            if (fechaEntrega <= DateTime.Now)
            {
                objSA.error = 1;//fecha Invalida!!
                return;
            }
            else if (objSA.descripcion.Length > 50)
            {
                objSA.error = 2; //Descripción supero los 50 caracteres!!
                return;
            }
            else if (objSA.asunto.Length > 50)
            {
                objSA.error = 3; //Asunto supero los 50 caracteres!!
                return;
            }
            else if (objSA.observacion.Length > 50)
            {
                objSA.error = 4; //observación supero los 50 caracteres!!
                return;
            }
            objSA.error = 77;
            objSAdat.UpdateSolicitudAbastecimiento(objSA);
        }
    }
}
