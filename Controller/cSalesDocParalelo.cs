using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOG.IntegracionEmpresasParalelas.Entities;
using VOG.IntegracionEmpresasParalelas.Data;
using Microsoft.Dynamics.GP.eConnect.Serialization;

namespace VOG.IntegracionEmpresasParalelas.Controller
{
	public class cSalesDocParalelo
	{
        public List<eFacturasParalela> ListarFacturasParalelo(eFiltro filtro,clsServerConection conexionparalela)
        {
            List<eFacturasParalela> Listado = new List<eFacturasParalela>();
            dSalesDocParaleloEnc_S Encdatos = new dSalesDocParaleloEnc_S();
            dSalesDocParaleloDet_S Detdatos = new dSalesDocParaleloDet_S();
            dSalesDocParaleloTax_S Taxdatos = new dSalesDocParaleloTax_S();
            dSalesDocParaleloImp_S Impdatosvog = new dSalesDocParaleloImp_S();
            dSalesDocParaleloUserDef_S dUserDef = new dSalesDocParaleloUserDef_S();

            List<taSopHdrIvcInsert> ListEncabezados = Encdatos.ListarEncFactParalelo(filtro,conexionparalela);
			foreach (taSopHdrIvcInsert iEnc in ListEncabezados)
			{
                eFacturasParalela documento = new eFacturasParalela();
                documento.taSopHdrIvcInsert = iEnc;
                //buscar Detalle
                List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert> ListDet = new List<taSopLineIvcInsert_ItemsTaSopLineIvcInsert>();
                List<taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert> ListTax = new List<taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert>();
                taSopUserDefined rUserDef = new taSopUserDefined();
                ListDet = Detdatos.ListarDetFactParalelo(iEnc, conexionparalela);
                ListTax = Taxdatos.ListarTaxFactParalelo(iEnc, conexionparalela);
                rUserDef = dUserDef.ListarUserDefParalelo(iEnc, conexionparalela);
                //llena arreglo detalles 
                taSopLineIvcInsert_ItemsTaSopLineIvcInsert[] DetallesDocumento = new taSopLineIvcInsert_ItemsTaSopLineIvcInsert[ListDet.Count];
                for (int index = 0; index < ListDet.Count; index++)
                {
                    DetallesDocumento[index] = ListDet[index];
                }
                //llena detalles impuestos
                taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert[] taxesDocumento = new taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert[ListDet.Count];            
                for (int indexT = 0; indexT < ListTax.Count; indexT++)
                {
                    taxesDocumento[indexT] = ListTax[indexT];
                }
                documento.taSopLineIvcInsert_Items = DetallesDocumento;
                documento.taSopLineIvcTaxInsert_Items = taxesDocumento;
                documento.taSopUserDefined = rUserDef;
                //Buscar Impuesto
                documento.DatosImpuesto = Impdatosvog.ListarImpFactParalelo(iEnc, conexionparalela);
                Listado.Add(documento);
            }
            return Listado;
        }
    }
}
