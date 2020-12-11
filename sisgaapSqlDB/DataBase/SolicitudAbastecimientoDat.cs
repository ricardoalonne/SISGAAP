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
            cmd.Parameters.AddWithValue("@observacion", objSA.observacion);
            cmd.Parameters.AddWithValue("@totalRep", objSA.totalRepuestos);
            cmd.Parameters.AddWithValue("@redactor", objSA.redactor);
            conexionBD.Open();
            cmd.ExecuteNonQuery();
            conexionBD.Close();
        }
    }
}
