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
            string insert = "INSERT INTO T_CE_Detalle_Solicitud_Produccion VALUES(" + objDetalleSP.cantidadSugerida + "," + objDetalleSP.costoUnitario + ",'" + objDetalleSP.codigoSolicitud+"','" + objDetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud +"','" + objDetalleSP.codigoRepuesto + "')";
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
            SqlCommand command = new SqlCommand("select * from v_detalle_sp where Solicitud ='" + objDetalleSP.codigoSolicitud + "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public DataSet DetalleSP_dataset(DetalleSolicitudProduccion detallesp)
        {
            DataSet dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("select Repuesto,Nombre,Marca,Modelo,[Cantidad Solicitada],[Cantidad Sugerida],Costo from v_detalle_sp where Solicitud ='" + detallesp.codigoSolicitud + "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataSet();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public void DeleteAllDetalle_SP(DetalleSolicitudProduccion objDetalleSP)
        {
            string delete = "DELETE T_CE_Detalle_Solicitud_Produccion WHERE codigoSolicitud='" + objDetalleSP.codigoSolicitud + "' and T_CE_Detalle_Solicitud_Abastecimiento_codigoSolicitud='" + objDetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud + "'";
            SqlCommand command = new SqlCommand(delete, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public bool SelectRepuestoxDetalleSP(DetalleSolicitudProduccion objDetalleSP)
        {
            string Select = "select * from T_CE_Detalle_Solicitud_Produccion WHERE codigoRepuesto ='" + objDetalleSP.codigoRepuesto + "' and codigoSolicitud='" + objDetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud + "'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objDetalleSP.codigoRepuesto = (string)reader[4];
            }
            conexionBD.Close();
            return hayRegistros;
        }
        public bool SelectRepuestoxDetalleSA(DetalleSolicitudProduccion objDetalleSP)
        {
            string Select = "select * from T_CE_Detalle_Solicitud_Abastecimiento WHERE codigoRepuesto ='" + objDetalleSP.codigoRepuesto + "' and codigoSolicitud='"+objDetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud + "'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objDetalleSP.codigoRepuesto = (string)reader[2];
            }
            conexionBD.Close();
            return hayRegistros;
        }
        public bool SelectCodigoSAxDetalleSP(DetalleSolicitudProduccion objDetalleSP)
        {
            string Select = "select * from T_CE_Detalle_Solicitud_Produccion WHERE codigoSolicitud='" + objDetalleSP.codigoSolicitud + "' and T_CE_Detalle_Solicitud_Abastecimiento_codigoSolicitud='"+objDetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud+"'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objDetalleSP.codigoRepuesto = (string)reader[2];
            }
            conexionBD.Close();
            return hayRegistros;
        }
    }
}
