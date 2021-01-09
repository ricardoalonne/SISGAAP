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
    public class PersonalDat
    {
        SqlConnection conexionBD;
        public PersonalDat()
        {
            conexionBD = new SqlConnection(conexion.CadenaConexion);
        }
        public void ObtenerPersonal(Personal objpersonal)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from T_CE_Personal where codigoUsuario='" + objpersonal.codigoUsuario + "'", conexionBD);
            conexionBD.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objpersonal.nombres = (string)reader[1];
                objpersonal.apellidos = (string)reader[2];
                objpersonal.correo = (string)reader[3];
            }
            conexionBD.Close();
        }
    }
}
