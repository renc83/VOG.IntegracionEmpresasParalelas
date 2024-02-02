/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Reversa los registros ingresados en caso de un error .
Cliente: ALIBAL
Tablas: SOP10100,SOP10200,SOP10105,IMPS0213 y eConnectOutTemp

Ejemplo:
EXEC pr_SOP10200_VOG_S 
 @SOPNUMBE ='A-FAC-00001021'
,@CURNCYID = 'USD'
=======================================================================*/

IF exists (select * from dbo.sysobjects where id = object_id(N'dbo.PR_SOPROLLBACK_VOG_D') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.PR_SOPROLLBACK_VOG_D
GO

CREATE  PROCEDURE PR_SOPROLLBACK_VOG_D
(@SOPNUMBE char(21)  
,@DOCID char(15)
,@IDDOC char(15) 
)				  
AS
BEGIN
	DECLARE @RESPUESTA   VARCHAR(50)='Registro Actualizado',@ERROR INT=0
	DECLARE @DATE_INSERT DATETIME =GETDATE()
	
	BEGIN TRY		 
		delete from SOP10100 where  [SOPNUMBE]=@SOPNUMBE 
		delete from SOP10200 where  [SOPNUMBE]=@SOPNUMBE 
		delete from SOP10105 where  [SOPNUMBE]=@SOPNUMBE
		delete from IMPS0213 where  NroDocumento=@SOPNUMBE
		delete from  [eConnectOutTemp]	where [INDEX1]=@SOPNUMBE
	END TRY  
	BEGIN CATCH
			SET @RESPUESTA=ERROR_MESSAGE()
			set @ERROR=ERROR_NUMBER()
	END CATCH

	SELECT  @ERROR ERROR,@RESPUESTA RESPUESTA
END