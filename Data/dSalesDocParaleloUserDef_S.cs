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
	public class dSalesDocParaleloUserDef_S
	{
        public taSopUserDefined ListarUserDefParalelo(taSopHdrIvcInsert encabezado, clsServerConection conexionparalela)
        {
            taSopUserDefined Listado = new taSopUserDefined();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            SqlConnection SQLGP = ConexionSQL.AbreConexion(conexionparalela);
            string strcomandoE = "pr_SOP10106_VOG_S";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOPNUMBE", encabezado.SOPNUMBE);
            cmd.Parameters.AddWithValue("@CURNCYID", encabezado.CURNCYID);
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    Listado.SOPNUMBE = rdt["SOPNUMBE"].ToString().Trim();
                    Listado.SOPTYPE = Convert.ToInt16(rdt["SOPTYPE"].ToString());
                    Listado.USERDEF1 = rdt["USERDEF1"].ToString().Trim();
                    Listado.USERDEF2 = rdt["USERDEF2"].ToString().Trim();
                    Listado.USRDEF03 = rdt["USRDEF03"].ToString().Trim();
                    Listado.USRDEF04 = rdt["USRDEF04"].ToString().Trim();
                    Listado.USRDEF05 = rdt["USRDEF05"].ToString().Trim();
                    Listado.USRDEFND1 = rdt["COMMENT_1"].ToString().Trim();
                    Listado.USRDEFND2 = rdt["COMMENT_2"].ToString().Trim();
                    Listado.USRDEFND3 = rdt["COMMENT_3"].ToString().Trim();
                    Listado.USRDEFND4 = rdt["COMMENT_4"].ToString().Trim();
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
