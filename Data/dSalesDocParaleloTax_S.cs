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
	public class dSalesDocParaleloTax_S
	{
        public List<taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert> ListarTaxFactParalelo(taSopHdrIvcInsert encabezado, clsServerConection conexionparalela)
        {
            List<taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert> Listado = new List<taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert>();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            SqlConnection SQLGP = ConexionSQL.AbreConexion(conexionparalela);
            string strcomandoE = "pr_SOP10105_VOG_S";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOPNUMBE", encabezado.SOPNUMBE);
            cmd.Parameters.AddWithValue("@CURNCYID", encabezado.CURNCYID);
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    Listado.Add(new taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert
                    {
                        SOPNUMBE = rdt["SOPNUMBE"].ToString().Trim(),
                        CUSTNMBR = encabezado.CUSTNMBR.Trim(),
                        SOPTYPE = Convert.ToInt16(rdt["SOPTYPE"].ToString()),
                        LNITMSEQ = Convert.ToInt32(rdt["LNITMSEQ"].ToString()),
                        TAXDTLID = rdt["TAXDTLID"].ToString().Trim(),
                        SALESAMT = Convert.ToDecimal(rdt["TAXDTSLS"].ToString()),
                        STAXAMNT = Convert.ToDecimal(rdt["STAXAMNT"].ToString()),
                    }); ;
                }
                rdt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error buscando datos Tax: {ex.Message}");
            }
            SQLGP.Close();
            return Listado;
        }
    }
}
