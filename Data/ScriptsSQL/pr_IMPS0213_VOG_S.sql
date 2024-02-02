/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Lista la informacion del Modulo de Impuesto de la factura.
Cliente: ALIBAL
Tablas:  IMPS0213

Ejemplo:
EXEC pr_IMPS0213_VOG_S 
 @SOPNUMBE ='A-FAC-00127218'
--,@CURNCYID = 'USD'

=======================================================================*/

IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pr_IMPS0213_VOG_S]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pr_IMPS0213_VOG_S
go
CREATE PROCEDURE pr_IMPS0213_VOG_S
(@SOPNUMBE	VARCHAR(15)
--,@CURNCYID	VARCHAR(15)
)
AS
BEGIN

SET NOCOUNT ON;
----------------DECLARACIONES---------------------------------------
DECLARE @SQLSTR    NVARCHAR(MAX)='',@Parametro nvarchar(500)

SELECT  
		NroDocumento
		,Tipo
		,NroControl
		,IdDoc
		,IdCorrNroControl
		,IdTipoDoc
		,DocDescripcion
		,Planilla
		,Expediente
		,TipoTransaccion
		,Sucursal
		,IdCliente
		,NomCliente
		,TipoCliente
		,Rif
		,FechaDocumento
		,ISNULL(FechaContabilizacion,'19000101') FechaContabilizacion
		,Adicional1
		,Adicional2
		,Adicional3
		,TipoDoc
		,Direccion1
		,Direccion2
		,Direccion3
		,Ciudad
		,Estado
		,Pais
		,Telefono1
		,Telefono2
		,Telefono3
		,Fax
		,Procedencia
		,Generico
		,Cargado
		,ISNULL(Miscelaneos,0.00) Miscelaneos
		,ISNULL(Flete 	   ,0.00) Flete 
		,TipoContribuyente
		,Especial
from IMPS0213 where nrodocumento=@SOPNUMBE


SET NOCOUNT OFF;
END