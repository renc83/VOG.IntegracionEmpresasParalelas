using System;
using System.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Data
{
	public class dSalesDocProdImp_I
	{
        public clsMsjRespuesta InsertImpDocVentas(eImpuestoVOG Documento)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            sysConexionSQL ConexionSQL = new sysConexionSQL();
            clsServerConection Conexion = sysGlobales.conexionproductivo;
            SqlConnection SQLGP = ConexionSQL.AbreConexion(Conexion);
            string strcomandoE = "PR_IMPS0213_VOG_I";
            SqlCommand cmd = new SqlCommand(strcomandoE, SQLGP);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NumeroDocumento",  Documento.NroDocumento);
            cmd.Parameters.AddWithValue("@Tipo", Documento.Tipo);
            cmd.Parameters.AddWithValue("@IdDoc", Documento.IdDoc);
            cmd.Parameters.AddWithValue("@NroControl",  Documento.NroControl);
            cmd.Parameters.AddWithValue("@IdCorrNroControl", Documento.IdCorrNroControl);
            cmd.Parameters.AddWithValue("@IdTipoDoc", Documento.IdTipoDoc);
            cmd.Parameters.AddWithValue("@DocDescripcion", Documento.DocDescripcion);
            cmd.Parameters.AddWithValue("@Planilla", Documento.Planilla);
            cmd.Parameters.AddWithValue("@Expediente", Documento.Expediente);
            cmd.Parameters.AddWithValue("@TipoTransaccion", Documento.TipoTransaccion);
            cmd.Parameters.AddWithValue("@Sucursal", Documento.Sucursal);
            cmd.Parameters.AddWithValue("@IdCliente", Documento.IdCliente);
            cmd.Parameters.AddWithValue("@NomCliente", Documento.NomCliente);
            cmd.Parameters.AddWithValue("@TipoCliente", Documento.TipoCliente);
            cmd.Parameters.AddWithValue("@Rif", Documento.Rif);
            cmd.Parameters.AddWithValue("@FechaDocumentoC", Convert.ToDateTime(Documento.FechaDocumento).ToString("yyyyMMdd") );
            cmd.Parameters.AddWithValue("@Adicional1", Documento.Adicional1);
            cmd.Parameters.AddWithValue("@Adicional2", Documento.Adicional2);
            cmd.Parameters.AddWithValue("@Adicional3", Documento.Adicional3);
            cmd.Parameters.AddWithValue("@TipoDoc", Documento.TipoDoc);
            cmd.Parameters.AddWithValue("@Direccion1", Documento.Direccion1);
            cmd.Parameters.AddWithValue("@Direccion2", Documento.Direccion2);
            cmd.Parameters.AddWithValue("@Direccion3", Documento.Direccion3);
            cmd.Parameters.AddWithValue("@Ciudad", Documento.Ciudad);
            cmd.Parameters.AddWithValue("@Estado", Documento.Estado);
            cmd.Parameters.AddWithValue("@Pais", Documento.Pais);
            cmd.Parameters.AddWithValue("@Telefono1", Documento.Telefono1);
            cmd.Parameters.AddWithValue("@Telefono2", Documento.Telefono2);
            cmd.Parameters.AddWithValue("@Telefono3", Documento.Telefono3);
            cmd.Parameters.AddWithValue("@Fax", Documento.Fax);
            cmd.Parameters.AddWithValue("@Procedencia", Documento.Procedencia);
            cmd.Parameters.AddWithValue("@Generico", Documento.Generico);
            cmd.Parameters.AddWithValue("@Cargado", Documento.Cargado);
            cmd.Parameters.AddWithValue("@TipoContribuyente", Documento.TipoContribuyente);
            cmd.Parameters.AddWithValue("@Especial", Documento.Especial);
            cmd.Parameters.AddWithValue("@Miscelaneos", Documento.Miscelaneos);
            cmd.Parameters.AddWithValue("@Flete", Documento.Flete);
            int iRes;
            try
            {
                iRes = cmd.ExecuteNonQuery();
                respuesta.sError = 0;
                respuesta.sMensaje = "Registro Procesado";
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
