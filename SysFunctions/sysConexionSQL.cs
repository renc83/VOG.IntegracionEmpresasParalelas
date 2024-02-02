using System;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;

namespace VOG.IntegracionEmpresasParalelas.SysFunctions
{
	public class sysConexionSQL
	{
        public SqlConnection AbreConexion(clsServerConection Conexion)
        {
            string strID = Conexion.UsuarioID;
            string strPassword = Conexion.Password;
            string strDatabase = Conexion.DatabaseName;
            string strSource = Conexion.ServerName;
            try
            {
                SqlConnection SqlC = new SqlConnection("Data Source=" + strSource + ";Initial Catalog=" + strDatabase +
                                                        ";user ID = " + strID + ";Password=" + strPassword + "");
                SqlC.Open();
                return SqlC;
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"Error de Conexion:{Ex.Message}");
                return null;
            }
        }
    }
}
