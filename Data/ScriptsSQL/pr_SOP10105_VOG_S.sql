/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Lista el detalle de los impuestos de la factura.
Cliente: ALIBAL
Tablas:  SOP10105

Ejemplo:
EXEC pr_SOP10105_VOG_S 
 @SOPNUMBE ='B-FAC-00045604'
,@CURNCYID = 'USD'
=======================================================================*/

IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pr_SOP10105_VOG_S]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pr_SOP10105_VOG_S
go
CREATE PROCEDURE pr_SOP10105_VOG_S
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
	   ,LNITMSEQ 
	   ,TAXDTLID 
	   ,IIF(@CURNCYID='USD',ORTOTSLS,TAXDTSLS) TAXDTSLS
	   ,IIF(@CURNCYID='USD',ORSLSTAX,STAXAMNT) STAXAMNT
	   ,TRXSORCE
	   ,TXDTLPCTAMT 
  FROM SOP10105 R
 WHERE SOPTYPE IN (3,4)
   AND SOPNUMBE=@SOPNUMBE
   AND LNITMSEQ>0


SET NOCOUNT OFF;
END