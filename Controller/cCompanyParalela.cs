using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.Data;
using System.Data.SqlClient;
using VOG.IntegracionEmpresasParalelas.SysFunctions;

namespace VOG.IntegracionEmpresasParalelas.Controller
{
	public class cCompanyParalela
	{
		public List<eCompanyParalela> ListarEmpresasParalelas()
		{
			List<eCompanyParalela> ListParalelas = new List<eCompanyParalela>();
			dCompanyParalela_S datos = new dCompanyParalela_S();
			ListParalelas = datos.ListarEmpresasParalelas();
			return ListParalelas;
		}

		public eCompanyParalela BuscarEmpresaParalela(int idcompany)
		{
			eCompanyParalela empresa = new eCompanyParalela();
			dCompanyParalela_S datos = new dCompanyParalela_S();
			empresa = datos.BuscarEmpresaParalela(idcompany);
			return empresa;
		}

		public clsMsjRespuesta GuardaEmpresaParalela(eCompanyParalela compania)
		{
			clsMsjRespuesta respuesta = new clsMsjRespuesta();
			if (compania.ROW_ID == "0" || String.IsNullOrEmpty(compania.ROW_ID))
			{
				dCompanyParalela_I datos = new dCompanyParalela_I();
				respuesta = datos.InsertEmpresaParalela(compania);
			}
			else
			{
				dCompanyParalela_U datos = new dCompanyParalela_U();
				respuesta = datos.UpdateEmpresaParalela(compania);
			}
			return respuesta;
		}

		public clsMsjRespuesta EliminaEmpresaParalela(int ROW_ID)
		{
			clsMsjRespuesta respuesta = new clsMsjRespuesta();
				dCompanyParalela_D datos = new dCompanyParalela_D();
				respuesta = datos.EliminaEmpresaParalela(ROW_ID);
			return respuesta;
		}

		public clsMsjRespuesta ValidaConexion(clsServerConection DatosConexion) {
			sysConexionSQL ConexionSQL = new sysConexionSQL();
			clsMsjRespuesta respuesta = new clsMsjRespuesta();
			SqlConnection SQLGP = ConexionSQL.AbreConexion(DatosConexion);
			if (SQLGP == null)
			{
				respuesta.sMensaje = "Error en Conexion.";
				respuesta.sError = 1;
			}
			else {
				respuesta.sMensaje = "Conexion Correcta.";
				respuesta.sError = 0;
			}
			return respuesta;
		}
	}
}
