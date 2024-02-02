using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOG.IntegracionEmpresasParalelas.Entities
{
	public class eCompanyParalela
	{
		public string ROW_ID	   {get; set; }
		public string Descripcion	{get; set; }	
		public string Conexion		{get; set; }
		public string Correo		{get; set; }	
		public int Estatus		{get; set; }
		public string Usuario { get; set; }
		public string BDDestino { get; set; }
	}
}
