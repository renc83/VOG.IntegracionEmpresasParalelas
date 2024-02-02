using Microsoft.Dynamics.GP.eConnect.Serialization;
using System;
using System.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSalesDocProdTax_I
	{
        public clsMsjRespuesta InsertTaxDocVentas(taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert Documento)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            clsServerConection Conexion = sysGlobales.conexionproductivo;
            SqlConnection SQLGP = ConexionSQL.AbreConexion(Conexion);
            string strcomandoE = "taSopLineIvcTaxInsert";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@I_vSOPTYPE", Documento.SOPTYPE);
            cmd.Parameters.AddWithValue("@I_vSOPNUMBE", Documento.SOPNUMBE);
            cmd.Parameters.AddWithValue("@I_vCUSTNMBR", Documento.CUSTNMBR);
            cmd.Parameters.AddWithValue("@I_vLNITMSEQ", Documento.LNITMSEQ);
            cmd.Parameters.AddWithValue("@I_vTAXDTLID", Documento.TAXDTLID);
            cmd.Parameters.AddWithValue("@I_vSALESAMT", Documento.SALESAMT);
            cmd.Parameters.AddWithValue("@I_vTDTTXSLS", Documento.SALESAMT);
            cmd.Parameters.AddWithValue("@I_vSTAXAMNT", Documento.STAXAMNT);
            cmd.Parameters.AddWithValue("@I_vTXDTOTTX", Documento.STAXAMNT);

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
