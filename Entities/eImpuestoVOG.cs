namespace VOG.IntegracionEmpresasParalelas.Entities
{
	public class eImpuestoVOG
	{
		public  string  NroDocumento 			  {get; set; }
		public  int		Tipo    					  {get; set; }
		public  string  NroControl  					  {get; set; }
		public  string  IdDoc   						  {get; set; }
		public  string  IdCorrNroControl    			  {get; set; }
		public  string  IdTipoDoc   					  {get; set; }
		public  string  DocDescripcion  				  {get; set; }
		public  string  Planilla    					  {get; set; }
		public  string  Expediente  					  {get; set; }
		public int		TipoTransaccion					  {get; set; }
		public  string  Sucursal    					  {get; set; }
		public  string  IdCliente   					  {get; set; }
		public  string  NomCliente  					  {get; set; }
		public int		TipoCliente 				  {get; set; }
		public  string  Rif 							  {get; set; }
		public  string  FechaDocumento  			  {get; set; }
		public  string  FechaContabilizacion    	  {get; set; }
		public  string  Adicional1  					  {get; set; }
		public  string  Adicional2  					  {get; set; }
		public  string  Adicional3  					  {get; set; }
		public  int  TipoDoc 					  {get; set; }
		public  string  Direccion1  					  {get; set; }
		public  string  Direccion2  					  {get; set; }
		public  string  Direccion3  					  {get; set; }
		public  string  Ciudad  						  {get; set; }
		public  string  Estado  						  {get; set; }
		public  string  Pais    						  {get; set; }
		public  string  Telefono1   					  {get; set; }
		public  string  Telefono2   					  {get; set; }
		public  string  Telefono3   					  {get; set; }
		public  string  Fax 							  {get; set; }
		public  string  Procedencia 					  {get; set; }
		public bool Generico    						  {get; set; }
		public bool Cargado 							  {get; set; }
		public decimal Miscelaneos 					  {get; set; }
		public decimal Flete   						  {get; set; }
		public  string  TipoContribuyente   			  {get; set; }
		public  bool  Especial    						  { get; set; }
	}
}
