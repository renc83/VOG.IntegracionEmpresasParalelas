using Microsoft.Dynamics.GP.eConnect.Serialization;
using System.Collections.Generic;
using VOG.IntegracionEmpresasParalelas.Data;
using VOG.IntegracionEmpresasParalelas.Entities;

namespace VOG.IntegracionEmpresasParalelas.Controller
{
	public class cSalesDocProductivo
    {
        public List<eFacturasProductivo> ListarUltFacturasProductivo()
        {
            List<eFacturasProductivo> Listado = new List<eFacturasProductivo>();
            dSalesDocProdEnc_S datos = new dSalesDocProdEnc_S();
            Listado = datos.ListarUltFacturasProductivo();
            return Listado;
        }

        public clsMsjRespuesta ProcesarDocumentos(eFacturasParalela ListDatos)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            clsMsjRespuesta respuestaF = new clsMsjRespuesta();
            dSalesDocProdDet_I dRenglon = new dSalesDocProdDet_I();
            dSalesDocProdTax_I dTaxes = new dSalesDocProdTax_I();
            dSalesDocProdEnc_I dEncabezado = new dSalesDocProdEnc_I();
            dSalesDocProdImp_I dImpuesto = new dSalesDocProdImp_I();
            dSopNextDoc_U dSopnumbe = new dSopNextDoc_U();
            dRollBackProd_D dRollBack = new dRollBackProd_D();
            dSalesDocProdUserDef_I duserDef = new dSalesDocProdUserDef_I();

            respuesta = ValidarDocumentos(ListDatos);
            if (respuesta.sError == 0)
            {
                foreach (taSopLineIvcInsert_ItemsTaSopLineIvcInsert itemlinea in ListDatos.taSopLineIvcInsert_Items)
                {
                    respuesta = dRenglon.InsertLineaDocVentas(itemlinea);
                    if (respuesta.sError != 0)
                    {
                        break;
                    }
                }
                //impuestos
                if (respuesta.sError == 0)
                {
                    foreach (taSopLineIvcTaxInsert_ItemsTaSopLineIvcTaxInsert itemTax in ListDatos.taSopLineIvcTaxInsert_Items)
                    {
                        respuesta = dTaxes.InsertTaxDocVentas(itemTax);
                        if (respuesta.sError != 0)
                        {
                            break;
                        }
                    }
                }
                //user defined
                if (respuesta.sError == 0)
                {
                        respuesta = duserDef.InsertUserDefDocVentas(ListDatos.taSopUserDefined);
                }
                if (respuesta.sError == 0)
                {
                    respuesta = dEncabezado.InsertEncDocVentas(ListDatos.taSopHdrIvcInsert);
                }
                if (respuesta.sError == 0)
                {
                    respuesta = dImpuesto.InsertImpDocVentas(ListDatos.DatosImpuesto);
                }
                //valida resultado y actualiza correlativo o elimina los registros si hubo algun detalle
                if (respuesta.sError == 0)
                {
                    respuesta = dSopnumbe.NextSopDocVentas(ListDatos.taSopHdrIvcInsert.SOPNUMBE
                                             ,ListDatos.taSopHdrIvcInsert.DOCID
                                             ,ListDatos.DatosImpuesto.IdDoc);
                }
                else {
                    respuestaF = dRollBack.RollBackProdDocVentas(ListDatos.taSopHdrIvcInsert.SOPNUMBE
                                             , ListDatos.taSopHdrIvcInsert.DOCID
                                             , ListDatos.DatosImpuesto.IdDoc);
                }
            }
            return respuesta;
        }

        public clsMsjRespuesta ValidarDocumentos(eFacturasParalela ListDatos)
        {
            clsMsjRespuesta respuesta = new clsMsjRespuesta();
            dSalesDocProd_V dValida = new dSalesDocProd_V();
            respuesta = dValida.ValidaDocVentas(ListDatos);
            return respuesta;
        }

        public decimal ValidarStock(string Articulo, string Almacen)
        {
            decimal respuesta = new decimal();
            dSalesDocProdStock_V dValida = new dSalesDocProdStock_V();
            respuesta = dValida.ValidaStockArticulos(Articulo, Almacen);
            return respuesta;
        }
    }
}
