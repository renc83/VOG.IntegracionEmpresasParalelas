/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Lista el detalle de la factura.
Cliente: ALIBAL
Tablas:  SOP10200

Ejemplo:
EXEC pr_SOP10200_VOG_S 
 @SOPNUMBE ='A-FAC-00001021'
,@CURNCYID = 'USD'
=======================================================================*/

IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pr_SOP10200_VOG_S]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pr_SOP10200_VOG_S
go
CREATE PROCEDURE pr_SOP10200_VOG_S
(@SOPNUMBE	VARCHAR(15)
,@CURNCYID	VARCHAR(15)
)
AS
BEGIN

SET NOCOUNT ON;
----------------DECLARACIONES---------------------------------------
DECLARE @SQLSTR    NVARCHAR(MAX)='',@Parametro nvarchar(500)

SELECT SOPNUMBE 
	   ,SOPTYPE 
	   ,LOCNCODE 
	   ,ITEMNMBR 
	   ,ITEMDESC 
	   ,QUANTITY
	   ,IIF(@CURNCYID='USD',ORUNTPRC,UNITPRCE) UNITPRCE 
	   ,IIF(@CURNCYID='USD',OXTNDPRC,XTNDPRCE) XTNDPRCE 
	   ,IIF(@CURNCYID='USD',ORMRKDAM,MRKDNAMT) MRKDNAMT  
	   ,UOFM
	   ,IIF(@CURNCYID='USD',ORTDISAM,TRDISAMT) TRDISAMT
	   ,PRCLEVEL
	   ,LNITMSEQ
  FROM SOP10200 R
 WHERE SOPTYPE IN (3,4)
   AND SOPNUMBE=@SOPNUMBE


SET NOCOUNT OFF;
END