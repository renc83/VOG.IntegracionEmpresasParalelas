using Microsoft.Dynamics.GP.eConnect.Serialization;
using System;
using System.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSalesDocProdStock_V
	{
        public decimal ValidaStockArticulos(string Articulo, string Almacen)
        {
            decimal respuesta = 0;
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            clsServerConection Conexion = sysGlobales.conexionproductivo;
            SqlConnection SQLGP = ConexionSQL.AbreConexion(Conexion);
            string strcomandoE = $" SELECT QTYONHND-ATYALLOC DISPONIBLE FROM IV00102 WHERE ITEMNMBR='{Articulo}' AND LOCNCODE='{Almacen}' ";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.Text;
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    respuesta = Convert.ToDecimal(rdt["DISPONIBLE"]);
                }
                rdt.Close();
            }
            catch (Exception ex)
            {
                respuesta = 0;
            }
            SQLGP.Close();
            return respuesta;
        }
    }
}
