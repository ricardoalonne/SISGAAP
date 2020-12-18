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
    public class RepuestoCtr
    {
        RepuestoDat objRepuestoDat;
        public RepuestoCtr()
        {
            objRepuestoDat = new RepuestoDat();
        }
        public void RegistrarRepuesto(Repuesto objRepuesto)
        {
            if (objRepuesto.nombreRepuesto.Length > 50)
            {
                objRepuesto.error = 1;//Nombre no puede superar los 50 caracteres
                return;
            }
            if (objRepuesto.descripcion.Length > 50)
            {
                objRepuesto.error = 2;//Descripción no puede superar los 50 caracteres
                return;
            }
            if (objRepuesto.marca.Length > 50)
            {
                objRepuesto.error = 3;//Marca no puede superar los 50 caracteres
                return;
            }
            if (objRepuesto.modelo.Length > 50)
            {
                objRepuesto.error = 4;//Nombre no puede superar los 50 caracteres
                return;
            }
            objRepuesto.error = 77;
            objRepuestoDat.InsertRepuesto(objRepuesto);
        }
        public void ActualizarRepuesto(Repuesto objRepuesto)
        {
            if (objRepuesto.nombreRepuesto.Length > 50)
            {
                objRepuesto.error = 1;//Nombre no puede superar los 50 caracteres
                return;
            }
            if (objRepuesto.descripcion.Length > 50)
            {
                objRepuesto.error = 2;//Descripción no puede superar los 50 caracteres
                return;
            }
            if (objRepuesto.marca.Length > 50)
            {
                objRepuesto.error = 3;//Marca no puede superar los 50 caracteres
                return;
            }
            if (objRepuesto.modelo.Length > 50)
            {
                objRepuesto.error = 4;//Nombre no puede superar los 50 caracteres
                return;
            }
            objRepuesto.error = 77;
            objRepuestoDat.UpdateRepuesto(objRepuesto);
        }
        public void EliminarRepuesto(Repuesto objRepuesto)
        {
            bool correcto = true;
            correcto = !objRepuestoDat.SelectRepuestoxDetalleSA(objRepuesto) | !objRepuestoDat.SelectRepuestoxDetalleSP(objRepuesto);
            if (!correcto)
            {
                objRepuesto.error = 1;
                return;
            }
            objRepuesto.error = 77;
            objRepuestoDat.DeleteRepuesto(objRepuesto);
        }
        public DataTable Lista_de_RepuestosxCodigo(Repuesto objRepuesto)
        {
            return objRepuestoDat.DTableSelectRepuestosxCodigo(objRepuesto);
        }
        public DataTable ListarTodosRepuestos()
        {
            return objRepuestoDat.DTableSelectAllRepuestos();
        }
        public bool ExistenciaRepuesto(Repuesto objRepuesto)
        {
            return objRepuestoDat.SelectRepuestoxCodigo(objRepuesto);
        }
    }
}
