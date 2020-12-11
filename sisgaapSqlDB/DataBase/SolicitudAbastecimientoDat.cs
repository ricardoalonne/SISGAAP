using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using sisgaapCore;

namespace sisgaapSqlDB.DataBase
{
    public class SolicitudAbastecimientoDat
    {
        SqlConnection conexionBD;
        public SolicitudAbastecimientoDat()
        {
            conexionBD = new SqlConnection(conexion.CadenaConexion);
        }
        public void InsertarSolicitudAbastecimiento(SolicitudAbastecimiento objSA)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_sa ", conexionBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@asunto", objSA.asunto);
            cmd.Parameters.AddWithValue("@descripcion", objSA.descripcion);
            cmd.Parameters.AddWithValue("@fechaEntrega", objSA.fechaEntrega);
            cmd.Parameters.AddWithValue("@observacion", objSA.observacion);
            cmd.Parameters.AddWithValue("@totalRep", objSA.totalRepuestos);
            cmd.Parameters.AddWithValue("@redactor", objSA.redactor);
            conexionBD.Open();
            cmd.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void UpdateSolicitudAbastecimiento(SolicitudAbastecimiento objSA)
        {
            string update = "UPDATE T_CE_Solicitud_Abastecimiento SET asunto='" + objSA.asunto + "', observacion='" + objSA.observacion +",descripcion='"+objSA.descripcion+ "', fechaEntrega='" + objSA.fechaEntrega+"' Where codigoSolicitud='"+objSA.codigoSolicitud+"'";
            SqlCommand command = new SqlCommand(update, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void DeleteSolicitudAbastecimiento(SolicitudAbastecimiento objSA)
        {
            string delete = "DELETE T_CE_Solicitud_Abastecimiento WHERE codigoSolicitud='" + objSA.codigoSolicitud + "'";
            SqlCommand command = new SqlCommand(delete, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public DataTable SA(SolicitudAbastecimiento sa)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("SELECT*FROM v_sa where codigoSolicitud='" + sa.codigoSolicitud + "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public DataTable select_SA()
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("SELECT*FROM v_sa", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
    }
}
