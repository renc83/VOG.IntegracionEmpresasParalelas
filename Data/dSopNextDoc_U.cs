using Microsoft.Dynamics.GP.eConnect.Serialization;
using System;
using System.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSopNextDoc_U
	{
//EXEC PR_SOPNEXTNUMBER_VOG_I
// @SOPNUMBE		='A-FAC-00001038'
//,@DOCID		='A-FACTURA'
//,@IDDOC   	='A-FAC'
		public clsMsjRespuesta NextSopDocVentas(string sopnumbe, string docid, string iddoc)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            clsServerConection Conexion = sysGlobales.conexionproductivo;
            SqlConnection SQLGP = ConexionSQL.AbreConexion(Conexion);
            string strcomandoE = "PR_SOPNEXTNUMBER_VOG_I";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOPNUMBE", sopnumbe);
            cmd.Parameters.AddWithValue("@DOCID", docid);
            cmd.Parameters.AddWithValue("@IDDOC", iddoc);
            int iRes;
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    respuesta.sMensaje = Convert.ToString(rdt["RESPUESTA"]).Trim();
                    respuesta.sError = Convert.ToInt16(rdt["ERROR"]);
                }
            }
            catch (Exception ex)
            {
                respuesta.sMensaje = ex.Message;
                respuesta.sError = 1;

            }
            SQLGP.Close();
            return respuesta;
        }
    }
}
