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
	public class dSalesDocParaleloDet_S
	{
        public List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert> ListarDetFactParalelo(taSopHdrIvcInsert encabezado, clsServerConection conexionparalela)
        {
            List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert> Listado = new List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert>();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            SqlConnection SQLGP = ConexionSQL.AbreConexion(conexionparalela);
            string strcomandoE = "pr_SOP10200_VOG_S";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOPNUMBE", encabezado.SOPNUMBE);
            cmd.Parameters.AddWithValue("@CURNCYID", encabezado.CURNCYID);
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    Listado.Add(new taSopLineIvcInsert_ItemsTaSopLineIvcInsert
                    {
                        SOPNUMBE = rdt["SOPNUMBE"].ToString().Trim(),
                        CUSTNMBR = encabezado.CUSTNMBR.Trim(),
                        SOPTYPE = Convert.ToInt16(rdt["SOPTYPE"].ToString()),
                        DOCDATE = encabezado.DOCDATE.Trim(),
                        CURNCYID = encabezado.CURNCYID.Trim(),
                        LOCNCODE = rdt["LOCNCODE"].ToString().Trim(),
                        ITEMNMBR = rdt["ITEMNMBR"].ToString().Trim(),
                        ITEMDESC = rdt["ITEMDESC"].ToString(),
                        QUANTITY = Convert.ToDecimal(rdt["QUANTITY"].ToString()),
                        UNITPRCE = Convert.ToDecimal(rdt["UNITPRCE"].ToString()),
                        XTNDPRCE = Convert.ToDecimal(rdt["XTNDPRCE"].ToString()),
                        MRKDNAMT = Convert.ToDecimal(rdt["MRKDNAMT"].ToString()),
                        PRCLEVEL = rdt["PRCLEVEL"].ToString(),
                        LNITMSEQ = Convert.ToInt32(rdt["LNITMSEQ"].ToString()),
                        //COMMENT_1 = "",
                    });
                }
                rdt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error buscando datos: {ex.Message}");
            }
            SQLGP.Close();
            return Listado;
        }
    }
}
