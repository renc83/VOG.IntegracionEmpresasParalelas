using Microsoft.Dynamics.GP.eConnect.Serialization;
using System;
using System.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSalesDocProdDet_I
	{
		public clsMsjRespuesta InsertLineaDocVentas(taSopLineIvcInsert_ItemsTaSopLineIvcInsert Documento) {
			clsMsjRespuesta respuesta = new clsMsjRespuesta();
			sysConexionSQL ConexionSQL = new sysConexionSQL();
			clsServerConection Conexion = sysGlobales.conexionproductivo;
			SqlConnection SQLGP = ConexionSQL.AbreConexion(Conexion);
			string strcomandoE = "taSopLineIvcInsert";
            decimal subtotalp = Documento.QUANTITY * Documento.UNITPRCE;
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
			cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@I_vSOPTYPE",  Documento.SOPTYPE);
            cmd.Parameters.AddWithValue("@I_vSOPNUMBE", Documento.SOPNUMBE);
            cmd.Parameters.AddWithValue("@I_vCUSTNMBR", Documento.CUSTNMBR);
            cmd.Parameters.AddWithValue("@I_vDOCDATE",  Convert.ToDateTime(Documento.DOCDATE).ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@I_vLOCNCODE", Documento.LOCNCODE);
            cmd.Parameters.AddWithValue("@I_vITEMNMBR", Documento.ITEMNMBR);
            cmd.Parameters.AddWithValue("@I_vUNITPRCE", Documento.UNITPRCE);
            cmd.Parameters.AddWithValue("@I_vPRCLEVEL", Documento.PRCLEVEL);
            cmd.Parameters.AddWithValue("@I_vXTNDPRCE", subtotalp);
            cmd.Parameters.AddWithValue("@I_vQUANTITY", Documento.QUANTITY);
            cmd.Parameters.AddWithValue("@I_vCOMMENT_1",Documento.COMMENT_1);
            cmd.Parameters.AddWithValue("@I_vCURNCYID", Documento.CURNCYID);
            cmd.Parameters.AddWithValue("@I_vLNITMSEQ", Documento.LNITMSEQ);

            cmd.Parameters.Add("@O_iErrorState", SqlDbType.Int, 10);
            cmd.Parameters["@O_iErrorState"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@oErrString", SqlDbType.VarChar, 100);
            cmd.Parameters["@oErrString"].Direction = ParameterDirection.Output;
            int iRes;
            try
            {
                iRes = cmd.ExecuteNonQuery();
                respuesta.sError =Convert.ToInt32(cmd.Parameters["@O_iErrorState"].Value);
                respuesta.sMensaje = cmd.Parameters["@oErrString"].Value.ToString();
            }
            catch (Exception ex){
                respuesta.sMensaje = ex.Message;
                respuesta.sError = 1;

            }
            SQLGP.Close();
            return respuesta;
		}
	}
}
