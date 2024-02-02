using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOG.IntegracionEmpresasParalelas.Entities
{
	public class eFiltro
	{
		public int fTodos { get; set; }
		public string FechaDesde { get; set; }
		public string FechaHasta { get; set; }
		public string DocDesde { get; set; }
		public string DocHasta { get; set; }
		public string DOCID { get; set; }
		public string UltimoDocumento { get; set; }
	}
}
