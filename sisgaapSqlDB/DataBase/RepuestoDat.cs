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
    public class RepuestoDat
    {
        SqlConnection conexionBD;
        public RepuestoDat()
        {
            conexionBD = new SqlConnection(conexion.CadenaConexion);
        }
        public void InsertRepuesto(Repuesto objRepuesto)
        {
            SqlCommand cmd = new SqlCommand("sp_insert_Repuesto", conexionBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", objRepuesto.nombreRepuesto);
            cmd.Parameters.AddWithValue("@descripcion", objRepuesto.descripcion);
            cmd.Parameters.AddWithValue("@marca", objRepuesto.marca);
            cmd.Parameters.AddWithValue("@modelo", objRepuesto.modelo);
            cmd.Parameters.AddWithValue("@precio", objRepuesto.precioVenta);
            cmd.Parameters.AddWithValue("@cantidad", objRepuesto.cantidad);
            cmd.Parameters.AddWithValue("@cantidadminima", objRepuesto.cantidadMinima);
            cmd.Parameters.AddWithValue("@categoria", objRepuesto.codigoCategoria);
            cmd.Parameters.AddWithValue("@calidad", objRepuesto.calidad);
            cmd.Parameters.AddWithValue("@condicion", objRepuesto.condicion);
            conexionBD.Open();
            cmd.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void DeleteRepuesto(Repuesto objRepuesto)
        {
            string delete = "DELETE T_CE_Repuesto WHERE codigoRepuesto='" + objRepuesto.codigoRepuesto + "'";
            SqlCommand command = new SqlCommand(delete, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public void UpdateRepuesto(Repuesto objRepuesto)
        {
            string update = "UPDATE T_CE_Repuesto SET nombreRepuesto='" + objRepuesto.nombreRepuesto + ",descripcion='" + objRepuesto.descripcion + "', marca='" + objRepuesto.marca + "', modelo='" + objRepuesto.modelo + "' Where codigoRepuesto='" +objRepuesto.codigoRepuesto + "'";
            SqlCommand command = new SqlCommand(update, conexionBD);
            conexionBD.Open();
            command.ExecuteNonQuery();
            conexionBD.Close();
        }
        public bool SelectRepuestoxDetalleSA(Repuesto objRepuesto)
        {
            string Select = "select * from T_CE_Detalle_Solicitud_Abastecimiento WHERE codigoRepuesto ='" + objRepuesto.codigoRepuesto + "'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objRepuesto.codigoRepuesto = (string)reader[2];
            }
            conexionBD.Close();
            return hayRegistros;
        }
        public bool SelectRepuestoxDetalleSP(Repuesto objRepuesto)
        {
            string Select = "select * from T_CE_Detalle_Solicitud_Produccion WHERE codigoRepuesto ='" + objRepuesto.codigoRepuesto + "'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objRepuesto.codigoRepuesto = (string)reader[4];
            }
            conexionBD.Close();
            return hayRegistros;
        }
        public bool SelectRepuestoxCodigo(Repuesto objRepuesto)
        {
            string Select = "select * from T_CE_Repuesto WHERE codigoRepuesto ='" + objRepuesto.codigoRepuesto + "'";
            SqlCommand unComando = new SqlCommand(Select, conexionBD);
            conexionBD.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objRepuesto.codigoRepuesto = (string)reader[0];
                objRepuesto.nombreRepuesto = (string)reader[1];
                objRepuesto.descripcion = (string)reader[2];
                objRepuesto.marca = (string)reader[3];
                objRepuesto.modelo = (string)reader[4];
                objRepuesto.precioVenta = double.Parse(reader[5].ToString());
                objRepuesto.estado = (string)reader[6];
                objRepuesto.cantidad = (int)reader[7];
                objRepuesto.cantidadMinima = (int)reader[8];
                objRepuesto.calidad = (string)reader[9];
                objRepuesto.condicion = (bool)reader[10];
                objRepuesto.codigoCategoria = (string)reader[11];
            }
            conexionBD.Close();
            return hayRegistros;
        }
        public DataTable DTableSelectRepuestosxCodigo(Repuesto objRepuesto)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("select * from v_Repuestos where Codigo = '" + objRepuesto.codigoRepuesto+ "'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public DataTable DTableSelectAllRepuestos()
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("select * from v_Repuestos", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public DataTable select_RxCB(string dato, string letra)
        {
            DataTable dt = null;
            conexionBD.Open();
            SqlCommand command = new SqlCommand("SP_consultar_repuesto", conexionBD);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@letra", letra);
            command.Parameters.AddWithValue("@cb", dato);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
            dt = new DataTable();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
    }
}
