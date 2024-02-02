using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dCompanyParalela_D
	{
        public clsMsjRespuesta EliminaEmpresaParalela(int ROW_ID)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            try
            {
                SqlConnection SQLGP = ConexionSQL.AbreConexion(sysGlobales.conexionprincipal);
                string strcomandoE = "PR_COMPANYPARALELA_VOG_D";
                SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
                cmd.Parameters.AddWithValue("@ROW_ID", ROW_ID);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    respuesta.sMensaje = Convert.ToString(rdt["RESPUESTA"]).Trim();
                    respuesta.sError = Convert.ToInt16(rdt["ERROR"]);
                }
                rdt.Close();
                SQLGP.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error buscando datos: {ex.Message}");
            }
            return respuesta;
        }
    }
}
