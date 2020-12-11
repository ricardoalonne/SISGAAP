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
    public class DetalleSolicitudAbastecimientoDat
    {
        SqlConnection conexionBD;
        public DetalleSolicitudAbastecimientoDat()
        {
            conexionBD = new SqlConnection(conexion.CadenaConexion);
        }
        public void InsertarDetalle_SA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            string insert = "INSERT INTO T_CE_Detalle_Solicitud_Abastecimiento VALUES('" + objDetalleSA.cantidadSolicitada +"','"+ objDetalleSA.codigoSolicitud +"','"+ objDetalleSA.codigoRepuesto+ "')";
            SqlCommand command = new SqlCommand(insert, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void DeleteDetalle_SA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            string delete = "DELETE T_CE_Detalle_Solicitud_Abastecimiento WHERE codigoSolicitud='" + objDetalleSA.codigoSolicitud + "' and codigoRepuesto='" + objDetalleSA.codigoRepuesto + "'";
            SqlCommand command = new SqlCommand(delete, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void UpdateDetalle_SA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            string update = "UPDATE T_CE_Detalle_Solicitud_Abastecimiento SET cantidad='" + objDetalleSA.cantidadSolicitada + "' WHERE codigoSolicitud='" + objDetalleSA.codigoSolicitud + "' and codigoRepuesto='" + objDetalleSA.codigoRepuesto+"'";
            SqlCommand command = new SqlCommand(update, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public DataTable DetalleSA(DetalleSolicitudAbastecimiento detallesa)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("SELECT*FROM v_detalle_sa where codigoSolicitud='" + detallesa.codigoSolicitud + "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
    }
}
