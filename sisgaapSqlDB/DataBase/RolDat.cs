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
    public class RolDat
    {
        SqlConnection conexionBD;
        public RolDat()
        {
            conexionBD = new SqlConnection(conexion.CadenaConexion);
        }
        public void ObtenerRol(Rol objrol)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from T_CE_Rol where numeroRol='" + objrol.numeroRol + "'", conexionBD);
            conexionBD.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objrol.nombreRol = (string)reader[1];
            }
            conexionBD.Close();
        }
    }
}
