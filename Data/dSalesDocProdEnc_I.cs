using Microsoft.Dynamics.GP.eConnect.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSalesDocProdEnc_I
	{
        public clsMsjRespuesta InsertEncDocVentas(taSopHdrIvcInsert Documento)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            clsServerConection Conexion = sysGlobales.conexionproductivo;

            Documento.DEFPRICING = 1; //calcula el subtotal
            Documento.CKHOLD = 0; //valida estado suspendido
            Documento.DEFTAXSCHDS = 1; //impuestos por defecto
            Documento.CREATETAXES = 1; //crea los impuestos


            SqlConnection SQLGP = ConexionSQL.AbreConexion(Conexion);
            string strcomandoE = "taSopHdrIvcInsert";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@I_vSOPTYPE", Documento.SOPTYPE);
            cmd.Parameters.AddWithValue("@I_vDOCID", Documento.DOCID);
            cmd.Parameters.AddWithValue("@I_vSOPNUMBE", Documento.SOPNUMBE);
            cmd.Parameters.AddWithValue("@I_vLOCNCODE", Documento.LOCNCODE);
            cmd.Parameters.AddWithValue("@I_vDOCDATE",  Convert.ToDateTime(Documento.DOCDATE).ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@I_vBACHNUMB", Documento.BACHNUMB);
            cmd.Parameters.AddWithValue("@I_vCSTPONBR", Documento.CSTPONBR);
            cmd.Parameters.AddWithValue("@I_vCURNCYID", Documento.CURNCYID);
            cmd.Parameters.AddWithValue("@I_vCOMMENT_1", Documento.COMMENT_1);
            cmd.Parameters.AddWithValue("@I_vCOMMENT_2", Documento.COMMENT_2);
            cmd.Parameters.AddWithValue("@I_vCOMMENT_3", Documento.COMMENT_3);
            cmd.Parameters.AddWithValue("@I_vCOMMENT_4", Documento.COMMENT_4);
            cmd.Parameters.AddWithValue("@I_vNOTETEXT", Documento.NOTETEXT);
            cmd.Parameters.AddWithValue("@I_vCUSTNMBR", Documento.CUSTNMBR);
            cmd.Parameters.AddWithValue("@I_vDEFPRICING", Documento.DEFPRICING);
            cmd.Parameters.AddWithValue("@I_vCKHOLD", Documento.CKHOLD);
            cmd.Parameters.AddWithValue("@I_vDEFTAXSCHDS", Documento.DEFTAXSCHDS);
            cmd.Parameters.AddWithValue("@I_vCREATETAXES", Documento.CREATETAXES);
            cmd.Parameters.AddWithValue("@I_vTRDISAMT", Documento.TRDISAMT);
            

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
