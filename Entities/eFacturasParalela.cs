using Microsoft.Dynamics.GP.eConnect.Serialization;

namespace VOG.IntegracionEmpresasParalelas.Entities
{
	public class eFacturasParalela: SOPTransactionType
	{
		public eImpuestoVOG DatosImpuesto { get; set; }
	}
}
