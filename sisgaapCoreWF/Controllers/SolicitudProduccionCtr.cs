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
    public class SolicitudProduccionCtr
    {
        SolicitudProduccionDat objSPdat;
        public SolicitudProduccionCtr()
        {
            objSPdat = new SolicitudProduccionDat();
        }
        public void RegistrarSP(SolicitudProducción objSP)
        {
            DateTime fechaEntrega = objSP.fechaEntrega;
            if (fechaEntrega <= DateTime.Now)
            {
                objSP.error = 1;//fecha Invalida!!
                return;
            }
            else if (objSP.descripcion.Length > 50)
            {
                objSP.error = 2; //Descripción supero los 50 caracteres!!
                return;
            }
            else if (objSP.asunto.Length > 50)
            {
                objSP.error = 3; //Asunto supero los 50 caracteres!!
                return;
            }
            else if (objSP.observacion.Length > 50)
            {
                objSP.error = 4; //observación supero los 50 caracteres!!
                return;
            }
            objSP.error = 77;
            objSPdat.InsertarSolicitudProduccion(objSP);
        }
        public void EliminarSP(SolicitudProducción objSP)
        {
            objSPdat.DeleteSolicitudProduccion(objSP);
        }
        public void ActualizarSP(SolicitudProducción objSP)
        {
            DateTime fechaEntrega = objSP.fechaEntrega;
            if (fechaEntrega <= DateTime.Now)
            {
                objSP.error = 1;//fecha Invalida!!
                return;
            }
            else if (objSP.descripcion.Length > 50)
            {
                objSP.error = 2; //Descripción supero los 50 caracteres!!
                return;
            }
            else if (objSP.asunto.Length > 50)
            {
                objSP.error = 3; //Asunto supero los 50 caracteres!!
                return;
            }
            else if (objSP.observacion.Length > 50)
            {
                objSP.error = 4; //observación supero los 50 caracteres!!
                return;
            }
            objSP.error = 88;
            objSPdat.UpdateSolicitudProduccion(objSP);
        }
        public DataTable ConsultaSolicitudProduccion(string dato, string letra)
        {
            return objSPdat.select_SPxCB(dato, letra);
        }
        public DataTable ListarSolicitudesProduccion()//retorna una tabla con todas las solicitudes de produccion
        {
            return objSPdat.select_SP();
        }
        public string TraerUltimoCodigoSP()
        {
            return objSPdat.TraerCodigoSP();
        }
        public void CargarSP(SolicitudProducción objSP)
        {
            objSPdat.ObtenerSP(objSP);
        }
    }
}
