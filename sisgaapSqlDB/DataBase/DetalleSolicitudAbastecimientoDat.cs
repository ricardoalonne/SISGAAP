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
        public void DeleteAllDetalle_SA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            string delete = "DELETE T_CE_Detalle_Solicitud_Abastecimiento WHERE codigoSolicitud='" + objDetalleSA.codigoSolicitud+"'";
            SqlCommand command = new SqlCommand(delete, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void UpdateDetalle_SA(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            string update = "UPDATE T_CE_Detalle_Solicitud_Abastecimiento SET cantidadSolicitada='" + objDetalleSA.cantidadSolicitada + "' WHERE codigoSolicitud='" + objDetalleSA.codigoSolicitud + "' and codigoRepuesto='" + objDetalleSA.codigoRepuesto+"'";
            SqlCommand command = new SqlCommand(update, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public DataTable DetalleSA(DetalleSolicitudAbastecimiento detallesa)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("select Codigo,Repuesto,Cantidad from v_detalle_sa where Solicitud ='" + detallesa.codigoSolicitud + "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public DataSet DetalleSA_dataset(DetalleSolicitudAbastecimiento detallesa)
        {
            DataSet dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("select Codigo,Repuesto,Marca,Modelo,Cantidad from v_detalle_sa where Solicitud ='" + detallesa.codigoSolicitud + "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataSet();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public bool SelectRepuestoxDetalleSAxSolicitud(DetalleSolicitudAbastecimiento objDetalleSA)
        {
            string Select = "select * from v_detalle_sa WHERE Codigo ='" + objDetalleSA.codigoRepuesto + "' and Solicitud='"+objDetalleSA.codigoSolicitud+"'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objDetalleSA.codigoRepuesto = (string)reader[1];
            }
            conexionBD.Close();
            return hayRegistros;
        }
    }
}
