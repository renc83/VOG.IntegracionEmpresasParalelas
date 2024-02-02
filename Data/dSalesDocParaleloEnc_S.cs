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
	public class dSalesDocParaleloEnc_S
	{
        public List<taSopHdrIvcInsert> ListarEncFactParalelo(eFiltro Filtros, clsServerConection conexionparalela)
        {
            List<taSopHdrIvcInsert> Listado = new List<taSopHdrIvcInsert>();
            string strFiltro = " ";
            if (Filtros.fTodos == 1) { strFiltro += ""; }
            else
            {
                if (!String.IsNullOrEmpty(Filtros.FechaDesde) && !String.IsNullOrEmpty(Filtros.FechaHasta))
                {
                    strFiltro += String.Format(" and R.DOCDATE BETWEEN ('{0}') AND ('{1}')", Filtros.FechaDesde, Filtros.FechaHasta);
                }
                if (!String.IsNullOrEmpty(Filtros.DocDesde))
                {
                    strFiltro += $" and R.SOPNUMBE>='{Filtros.DocDesde}'";
                }
                if (!String.IsNullOrEmpty(Filtros.DocHasta))
                {
                    strFiltro += $" and R.SOPNUMBE<='{Filtros.DocHasta}'";
                }
            }
            if (!String.IsNullOrEmpty(Filtros.UltimoDocumento))
            {
                strFiltro += $" and R.SOPNUMBE>'{Filtros.UltimoDocumento}'";
            }

            sysConexionSQL ConexionSQL = new sysConexionSQL();
            SqlConnection SQLGP = ConexionSQL.AbreConexion(conexionparalela);
            string strcomandoE = "pr_SOP10100_VOG_S";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DOCID", Filtros.DOCID);
            cmd.Parameters.AddWithValue("@FILTRO", strFiltro);
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    Listado.Add(new taSopHdrIvcInsert
                    {
                        DOCID     = rdt["DOCID"].ToString().Trim(),
                        SOPNUMBE  = rdt["SOPNUMBE"].ToString().Trim(),
                        DOCDATE   = rdt["DOCDATE"].ToString().Trim(),
                        SOPTYPE   = Convert.ToInt16(rdt["SOPTYPE"].ToString()),
                        CUSTNMBR  = rdt["CUSTNMBR"].ToString().Trim(),
                        CUSTNAME  = rdt["CUSTNAME"].ToString().Trim(),
                        BACHNUMB  = rdt["BACHNUMB"].ToString().Trim(),
                        SLPRSNID  = rdt["SLPRSNID"].ToString().Trim(),
                        CURNCYID  = rdt["CURNCYID"].ToString().Trim(),
                        LOCNCODE  = rdt["LOCNCODE"].ToString().Trim(),
                        SHIPMTHD  = rdt["SHIPMTHD"].ToString().Trim(),
                        COMMENT_1 = rdt["COMMENT_1"].ToString().Trim(),
                        COMMENT_2 = rdt["COMMENT_2"].ToString().Trim(),
                        COMMENT_3 = rdt["COMMENT_3"].ToString().Trim(),
                        COMMENT_4 = rdt["COMMENT_4"].ToString().Trim(),
                        PYMTRMID  = rdt["PYMTRMID"].ToString().Trim(),
                        CSTPONBR  = rdt["CSTPONBR"].ToString().Trim(),
                        TXRGNNUM  = rdt["TXRGNNUM"].ToString().Trim(),
                        TRDISAMT  = Convert.ToDecimal(rdt["TRDISAMT"].ToString()),
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
