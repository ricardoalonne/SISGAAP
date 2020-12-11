using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using sisgaapCore.Entities;

namespace sisgaapSqlDB.DataBase
{
    public class DetalleSolicitudProduccionDat
    {
        SqlConnection conexionBD;
        public DetalleSolicitudProduccionDat()
        {
            conexionBD = new SqlConnection(conexion.CadenaConexion);
        }
        public void InsertarDetalle_SP(DetalleSolicitudProduccion objDetalleSP)
        {
            string insert = "INSERT INTO T_CE_Detalle_Solicitud_Produccion VALUES(" + objDetalleSP.cantidadSugerida + "," + objDetalleSP.costoUnitario + "','" + objDetalleSP.codigoSolicitud+"','" + objDetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud +"','" + objDetalleSP.codigoRepuesto + "')";
            SqlCommand command = new SqlCommand(insert, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void DeleteDetalle_SP(DetalleSolicitudProduccion objDetalleSP)
        {
            string delete = "DELETE T_CE_Detalle_Solicitud_Produccion WHERE codigoSolicitud='" + objDetalleSP.codigoSolicitud + "' and codigoRepuesto='" + objDetalleSP.codigoRepuesto + "' and T_CE_Detalle_Solicitud_Abastecimiento_codigoSolicitud ='" + objDetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud + "'";
            SqlCommand command = new SqlCommand(delete, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void UpdateDetalle_SP(DetalleSolicitudProduccion objDetalleSP)
        {
            string update = "UPDATE T_CE_Detalle_Solicitud_Produccion SET cantidadSugerida='" + objDetalleSP.cantidadSugerida +", costoUnitario="+objDetalleSP.costoUnitario+ "WHERE codigoSolicitud='" + objDetalleSP.codigoSolicitud + "' and codigoRepuesto='" + objDetalleSP.codigoRepuesto + "' and T_CE_Detalle_Solicitud_Abastecimiento_codigoSolicitud ='" + objDetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud + "'";
            SqlCommand command = new SqlCommand(update, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public DataTable DetalleSP(DetalleSolicitudProduccion objDetalleSP)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("select Repuesto,Nombre,Cantidad,Costo from v_detalle_sp where Solicitud ='" + objDetalleSP.codigoSolicitud + "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
    }
}
