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
	public class dSalesDocParaleloImp_S
	{
        public eImpuestoVOG ListarImpFactParalelo(taSopHdrIvcInsert encabezado, clsServerConection conexionparalela)
        {
            eImpuestoVOG Listado = new eImpuestoVOG();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            SqlConnection SQLGP = ConexionSQL.AbreConexion(conexionparalela);
            string strcomandoE = "pr_IMPS0213_VOG_S";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SOPNUMBE", encabezado.SOPNUMBE);
            try
            {
                SqlDataReader rdt = cmd.ExecuteReader();
                while (rdt.Read())
                {
                    Listado.NroDocumento = rdt["NroDocumento"].ToString().Trim();
                    Listado.NroControl = rdt["NroControl"].ToString().Trim();
                    Listado.Tipo = Convert.ToInt16(rdt["Tipo"].ToString().Trim());
                    Listado.IdDoc = rdt["IdDoc"].ToString().Trim();
                    Listado.IdCorrNroControl = rdt["IdCorrNroControl"].ToString().Trim();
                    Listado.IdTipoDoc = rdt["IdTipoDoc"].ToString().Trim();
                    Listado.DocDescripcion = rdt["DocDescripcion"].ToString().Trim();
                    Listado.Planilla = rdt["Planilla"].ToString().Trim();
                    Listado.Expediente = rdt["Expediente"].ToString().Trim();
                    Listado.TipoTransaccion = Convert.ToInt16(rdt["TipoTransaccion"].ToString().Trim());
                    Listado.Sucursal = rdt["Sucursal"].ToString().Trim();
                    Listado.IdCliente = rdt["IdCliente"].ToString().Trim();
                    Listado.NomCliente = rdt["NomCliente"].ToString().Trim();
                    Listado.TipoCliente = Convert.ToInt32(rdt["TipoCliente"].ToString().Trim());
                    Listado.Rif = rdt["Rif"].ToString().Trim();
                    Listado.FechaDocumento = rdt["FechaDocumento"].ToString().Trim();
                    Listado.FechaContabilizacion = rdt["FechaContabilizacion"].ToString().Trim();
                    Listado.Adicional1 = rdt["Adicional1"].ToString().Trim();
                    Listado.Adicional2 = rdt["Adicional2"].ToString().Trim();
                    Listado.Adicional3 = rdt["Adicional3"].ToString().Trim();
                    Listado.TipoDoc = Convert.ToInt16(rdt["TipoDoc"].ToString().Trim());
                    Listado.Direccion1 = rdt["Direccion1"].ToString().Trim();
                    Listado.Direccion2 = rdt["Direccion2"].ToString().Trim();
                    Listado.Direccion3 = rdt["Direccion3"].ToString().Trim();
                    Listado.Ciudad = rdt["Ciudad"].ToString().Trim();
                    Listado.Estado = rdt["Estado"].ToString().Trim();
                    Listado.Pais = rdt["Pais"].ToString().Trim();
                    Listado.Telefono1 = rdt["Telefono1"].ToString().Trim();
                    Listado.Telefono2 = rdt["Telefono2"].ToString().Trim();
                    Listado.Telefono3 = rdt["Telefono3"].ToString().Trim();
                    Listado.Fax = rdt["Fax"].ToString().Trim();
                    Listado.Procedencia = rdt["Procedencia"].ToString().Trim();
                    Listado.Miscelaneos = Convert.ToDecimal(rdt["Miscelaneos"].ToString().Trim());
                    Listado.Flete = Convert.ToDecimal(rdt["Flete"].ToString().Trim());
                    Listado.TipoContribuyente = rdt["TipoContribuyente"].ToString().Trim();
                    Listado.Especial = Convert.ToBoolean(rdt["Especial"].ToString().Trim());
                    Listado.Generico = Convert.ToBoolean(rdt["Generico"].ToString().Trim());
                    Listado.Cargado = Convert.ToBoolean(rdt["Cargado"].ToString().Trim());
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
