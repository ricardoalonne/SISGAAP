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
            string update = "UPDATE T_CE_Solicitud_Abastecimiento SET asunto='" + objSA.asunto + "', observacion='" + objSA.observacion +"',descripcion='"+objSA.descripcion+ "', fechaEntrega='" + objSA.fechaEntrega.Date.ToString("yyyy/MM/dd")+"' Where codigoSolicitud='"+objSA.codigoSolicitud+"'";
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
            SqlCommand command = new SqlCommand("SELECT*FROM v_sa where Solicitud='" + sa.codigoSolicitud + "'", conexionBD);
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
            foreach (DataRow row in dt.Rows){
                row["Emision"] = DateTime.Parse(row["Emision"].ToString()).ToShortDateString();
                row["Entrega"] = DateTime.Parse(row["Entrega"].ToString()).ToShortDateString();
            }
            return dt;
        }
        public DataTable select_SAxCB(string dato,string letra)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("SP_consultar_SA", conexionBD);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@letra",letra );
            command.Parameters.AddWithValue("@cb", dato);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public string TraerCodigoSA()
        {
            string codigo="";
            SqlCommand cmd = new SqlCommand("ultimo_codigo_sa ", conexionBD);
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
        public void ObtenerSA(SolicitudAbastecimiento objsa)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from T_CE_Solicitud_Abastecimiento where codigoSolicitud='"+objsa.codigoSolicitud+"'", conexionBD);
            conexionBD.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objsa.asunto = (string)reader[1];
                objsa.redactor = (string)reader[8];
                objsa.descripcion = (string)reader[2];
                objsa.observacion = (string)reader[5];
                objsa.fechaEntrega = (DateTime)reader[4];

            }
            conexionBD.Close();
        }
        public void ObtenerUltimoSA(SolicitudAbastecimiento objsa)
        {
            SqlCommand cmd = new SqlCommand("ultimo_codigo_sa ", conexionBD);
            cmd.CommandType = CommandType.StoredProcedure;
            conexionBD.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objsa.asunto = (string)reader[1];
                objsa.redactor = (string)reader[8];
                objsa.descripcion = (string)reader[2];
                objsa.observacion = (string)reader[5];
                objsa.fechaEntrega = (DateTime)reader[4];

            }
            conexionBD.Close();
        }
        public bool SelectSolicitudxCodigo(SolicitudAbastecimiento objsa)
        {
            string Select = "select * from T_CE_Solicitud_Abastecimiento WHERE codigoSolicitud ='" + objsa.codigoSolicitud + "'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objsa.codigoSolicitud = (string)reader[0];
                objsa.asunto = (string)reader[1];
                objsa.descripcion = (string)reader[2];
                objsa.fechaEntrega = (DateTime)reader[4];
                objsa.observacion = (string)reader[5];
                objsa.totalRepuestos = (int)reader[6];
                objsa.estado = (string)reader[7];
                objsa.redactor = (string)reader[8];
            }
            conexionBD.Close();
            return hayRegistros;
        }
        public bool SelectCodigoSAxSP(SolicitudAbastecimiento objsa)
        {
            string Select = "select * from T_CE_Detalle_Solicitud_Produccion WHERE T_CE_Detalle_Solicitud_Abastecimiento_codigoSolicitud='" + objsa.codigoSolicitud + "'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objsa.codigoSolicitud = (string)reader[3];
            }
            conexionBD.Close();
            return hayRegistros;
        }

        public void GuardarActualizacion_SA(SolicitudAbastecimiento objsa)
        {
            string update = "UPDATE T_CE_Solicitud_Abastecimiento SET asunto='" + objsa.asunto + "' WHERE codigoSolicitud='" + objsa.codigoSolicitud + "'";
            SqlCommand command = new SqlCommand(update, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
    }
}
