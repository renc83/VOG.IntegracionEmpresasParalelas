using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOG.IntegracionEmpresasParalelas.Entities
{
	public class clsDataJson
	{
		public string ServerName { get; set; }
		public string DatabaseName { get; set; }
		public string UsuarioID { get; set; }
		public string Password { get; set; }
		public string RutaTxt { get; set; }
		public string DestinatarioCorreo { get; set; }
		public string DataBaseProductivo { get; set; }
		public SMTPData SMTP { get; set; }
		//public entFiltros Filtros { get; set; }
	}
}
