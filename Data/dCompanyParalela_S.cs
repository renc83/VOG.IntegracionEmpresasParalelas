using System;
using System.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dCompanyParalela_S
	{
        public eCompanyParalela BuscarEmpresaParalela(int idcompany)
        {
            eCompanyParalela empresa = new eCompanyParalela();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            try
            {
                SqlConnection SQLGP = ConexionSQL.AbreConexion(sysGlobales.conexionprincipal);
                string strcomandoE = "PR_COMPANYPARALELA_VOG_S";
                SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
                cmd.Parameters.AddWithValue("@ROW_ID", idcompany);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    empresa.ROW_ID = rdt["ROW_ID"].ToString().Trim();
                    empresa.Descripcion = rdt["Descripcion"].ToString().Trim();
                    empresa.Conexion = rdt["Conexion"].ToString().Trim();
                    empresa.Correo = rdt["Correo"].ToString().Trim();
                    empresa.BDDestino =rdt["BDDestino"].ToString();
                }
                rdt.Close();
                SQLGP.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error buscando datos: {ex.Message}");
            }
            return empresa;
        }

        public List<eCompanyParalela> ListarEmpresasParalelas()
        {
            List<eCompanyParalela> ListEmpresa = new List<eCompanyParalela>();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            SqlConnection SQLGP = ConexionSQL.AbreConexion(sysGlobales.conexionproductivo);
            string strcomandoE = "PR_COMPANYPARALELA_VOG_S";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    ListEmpresa.Add(new eCompanyParalela
                    {
                        ROW_ID = rdt["ROW_ID"].ToString().Trim(),
                        Descripcion = rdt["Descripcion"].ToString().Trim(),
                        Conexion = rdt["Conexion"].ToString().Trim(),
                        Correo = rdt["Correo"].ToString().Trim(),
                        BDDestino =rdt["BDDestino"].ToString()
                    });
                }
                rdt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error buscando datos: {ex.Message}");
            }
            SQLGP.Close();
            return ListEmpresa;
        }
    }
}
