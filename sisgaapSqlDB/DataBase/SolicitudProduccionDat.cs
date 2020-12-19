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
    public class SolicitudProduccionDat
    {
        SqlConnection conexionBD;
        public SolicitudProduccionDat()
        {
            conexionBD = new SqlConnection(conexion.CadenaConexion);
        }
        public void InsertarSolicitudProduccion(SolicitudProducción objSP)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_sprod", conexionBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@asunto", objSP.asunto);
            cmd.Parameters.AddWithValue("@descripcion", objSP.descripcion);
            cmd.Parameters.AddWithValue("@fechaEntrega", objSP.fechaEntrega);
            cmd.Parameters.AddWithValue("@observacion", objSP.observacion);
            cmd.Parameters.AddWithValue("@costoTotal", objSP.costoTotal);
            cmd.Parameters.AddWithValue("@totalRep", objSP.totalRepuestos);
            cmd.Parameters.AddWithValue("@redactor", objSP.redactor);
            conexionBD.Open();
            cmd.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void UpdateSolicitudProduccion(SolicitudProducción objSP)
        {
            string update = "UPDATE T_CE_Solicitud_Produccion SET asunto='" + objSP.asunto + "', observacion='" + objSP.observacion + ",descripcion='" + objSP.descripcion + "', fechaEntrega='" + objSP.fechaEntrega + "' Where codigoSolicitud='" + objSP.codigoSolicitud + "'";
            SqlCommand command = new SqlCommand(update, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void DeleteSolicitudProduccion(SolicitudProducción objSP)
        {
            string delete = "DELETE T_CE_Solicitud_Produccion WHERE codigoSolicitud='" + objSP.codigoSolicitud + "'";
            SqlCommand command = new SqlCommand(delete, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }

        public DataTable SP(SolicitudProducción objSP)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("SELECT*FROM v_sp where Solicitud='" + objSP.codigoSolicitud + "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public DataTable select_SP()
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("SELECT*FROM v_sp", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public DataTable select_SPxCB(string dato, string letra)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("SP_consultar_SProd", conexionBD);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@letra", letra);
            command.Parameters.AddWithValue("@cb", dato);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public string TraerCodigoSP()
        {
            string codigo = "";
            SqlCommand cmd = new SqlCommand("ultimo_codigo_sp ", conexionBD);
            cmd.CommandType = CommandType.StoredProcedure;
            conexionBD.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                codigo = (string)reader[0];

            }
            conexionBD.Close();
            return codigo;
        }
    }
}
