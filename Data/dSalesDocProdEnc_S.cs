using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSalesDocProdEnc_S
	{
		public List<eFacturasProductivo> ListarUltFacturasProductivo()
        {
            List<eFacturasProductivo> Listado = new List<eFacturasProductivo>();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            SqlConnection SQLGP = ConexionSQL.AbreConexion(sysGlobales.conexionproductivo);
            string strcomandoE = "pl_BuscarEncSopProd_VOG";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    Listado.Add(new eFacturasProductivo
                    {
                        DOCID = rdt["DOCID"].ToString().Trim(),
                        SOPNUMBE = rdt["SOPNUMBE"].ToString().Trim(),
                        DOCDATE = rdt["DOCDATE"].ToString().Trim(),
                        SOPTYPE = Convert.ToInt32(rdt["SOPTYPE"].ToString()),
                        LASTSOPNUMBE = rdt["SOPNUMBE"].ToString().Trim(),
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
