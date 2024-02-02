/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Lista el detalle de los impuestos de la factura.
Cliente: ALIBAL
Tablas:  SOP10105

Ejemplo:
EXEC pr_SOP10106_VOG_S 
 @SOPNUMBE ='I-FAC-00109378'
,@CURNCYID = 'USD'
=======================================================================*/

IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pr_SOP10106_VOG_S]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pr_SOP10106_VOG_S
go
CREATE PROCEDURE pr_SOP10106_VOG_S
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
		--,USRDAT01
		--,USRDAT02
		--,USRTAB01
		--,USRTAB09
		--,USRTAB03
		,USERDEF1
		,USERDEF2
		,USRDEF03
		,USRDEF04
		,USRDEF05
		,COMMENT_1
		,COMMENT_2
		,COMMENT_3
		,COMMENT_4
		--,CMMTTEXT
  FROM SOP10106 R
 WHERE SOPTYPE IN (3,4)
   AND SOPNUMBE=@SOPNUMBE

SET NOCOUNT OFF;
END