using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOG.IntegracionEmpresasParalelas.Entities
{
	static class sysGlobales
	{
		public static clsServerConection conexionproductivo { get; set;}
		public static clsServerConection conexionparalela { get; set; }
		public static clsServerConection conexionprincipal { get; set; }
	}
}
