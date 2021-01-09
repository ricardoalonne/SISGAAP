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
    public class UsuarioDat
    {
        SqlConnection conexionBD;
        public UsuarioDat()
        {
            conexionBD = new SqlConnection(conexion.CadenaConexion);
        }
        public DataSet Usuario_dataset(Usuario objus)
        {
            DataSet dt = null;
            SqlCommand cmd = new SqlCommand("SELECT * from v_usuario where USUARIO='" + objus.codigoUsuario + "' and CONTRASEÑA='"+objus.password+"'", conexionBD);
            SqlDataAdapter daAdaptador = new SqlDataAdapter(cmd);
            dt = new DataSet();
            daAdaptador.Fill(dt);
            conexionBD.Close();
            return dt;
        }
        public void ObtenerUsuario(Usuario objusuario)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from T_CE_Usuario where codigoUsuario='" + objusuario.codigoUsuario + "' and password='"+objusuario.password+"'", conexionBD);
            conexionBD.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objusuario.numeroRol = (int)reader[3];
            }
            conexionBD.Close();
        }
    }
}
