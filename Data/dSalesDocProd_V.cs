using Microsoft.Dynamics.GP.eConnect.Serialization;
using System;
using System.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSalesDocProd_V
	{
        public clsMsjRespuesta ValidaDocVentas(eFacturasParalela Documento)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            clsServerConection Conexion = sysGlobales.conexionproductivo;
            SqlConnection SQLGP = ConexionSQL.AbreConexion(Conexion);
            string strcomandoE = "PR_SOPBDDOCPROD_VOG_V";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOPNUMBE", Documento.taSopHdrIvcInsert.SOPNUMBE);            
            cmd.Parameters.AddWithValue("@DOCID", Documento.taSopHdrIvcInsert.DOCID);
            cmd.Parameters.AddWithValue("@IDDOC", Documento.DatosImpuesto.IdDoc);
            cmd.Parameters.AddWithValue("@CUSTNMBR", Documento.taSopHdrIvcInsert.CUSTNMBR);
            cmd.Parameters.AddWithValue("@DOCDATE", Convert.ToDateTime(Documento.taSopHdrIvcInsert.DOCDATE).ToString("yyyyMMdd"));
            cmd.Parameters.AddWithValue("@NroControl", Documento.DatosImpuesto.NroControl);
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    respuesta.sMensaje = Convert.ToString(rdt["RESPUESTA"]).Trim();
                    respuesta.sError = Convert.ToInt16(rdt["ERROR"]);
                }
                rdt.Close();
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
