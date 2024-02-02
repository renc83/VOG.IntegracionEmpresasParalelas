using Microsoft.Dynamics.GP.eConnect.Serialization;
using System;
using System.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSalesDocProdUserDef_I
	{
        public clsMsjRespuesta InsertUserDefDocVentas(taSopUserDefined Documento)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            clsServerConection Conexion = sysGlobales.conexionproductivo;
            SqlConnection SQLGP = ConexionSQL.AbreConexion(Conexion);
            string strcomandoE = "taSopUserDefined";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@I_vSOPTYPE", Documento.SOPTYPE);
            cmd.Parameters.AddWithValue("@I_vSOPNUMBE", Documento.SOPNUMBE);
            cmd.Parameters.AddWithValue("@I_vUSERDEF1", Documento.USERDEF1);
            cmd.Parameters.AddWithValue("@I_vUSERDEF2", Documento.USERDEF2);
            cmd.Parameters.AddWithValue("@I_vUSRDEF03", Documento.USRDEF03);
            cmd.Parameters.AddWithValue("@I_vUSRDEF04", Documento.USRDEF04);
            cmd.Parameters.AddWithValue("@I_vUSRDEF05", Documento.USRDEF05);
            cmd.Parameters.AddWithValue("@I_vUSRDEFND1", Documento.USRDEFND1);
            cmd.Parameters.AddWithValue("@I_vUSRDEFND2", Documento.USRDEFND2);
            cmd.Parameters.AddWithValue("@I_vUSRDEFND3", Documento.USRDEFND3);
            cmd.Parameters.AddWithValue("@I_vUSRDEFND4", Documento.USRDEFND4);
            cmd.Parameters.AddWithValue("@I_vUSRDEFND5", Documento.USRDEFND5);

            cmd.Parameters.Add("@O_iErrorState", SqlDbType.Int, 10);
            cmd.Parameters["@O_iErrorState"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@oErrString", SqlDbType.VarChar, 100);
            cmd.Parameters["@oErrString"].Direction = ParameterDirection.Output;
            int iRes;
            try
            {
                iRes = cmd.ExecuteNonQuery();
                respuesta.sError = Convert.ToInt32(cmd.Parameters["@O_iErrorState"].Value);
                respuesta.sMensaje = cmd.Parameters["@oErrString"].Value.ToString();
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
