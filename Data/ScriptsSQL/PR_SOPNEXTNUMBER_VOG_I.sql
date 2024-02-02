/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Actualiza los correlativos del Nativo GP .
Cliente: ALIBAL
Tablas: IMPS0003, SOP40200

Ejemplo:
EXEC PR_SOPNEXTNUMBER_VOG_I 

=======================================================================*/
IF exists (select * from dbo.sysobjects where id = object_id(N'dbo.PR_SOPNEXTNUMBER_VOG_I') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.PR_SOPNEXTNUMBER_VOG_I
GO

CREATE  PROCEDURE PR_SOPNEXTNUMBER_VOG_I
(@SOPNUMBE char(21)  
,@DOCID char(15)
,@IDDOC char(15) 
)				  
AS
BEGIN
	DECLARE @RESPUESTA   VARCHAR(50)='Registro Actualizado',@ERROR INT=0
	DECLARE @DATE_INSERT DATETIME =GETDATE()
	
	BEGIN TRY		 
				
		UPDATE IMPS0003 SET IMP_sop1codoc=@SOPNUMBE  WHERE rtrim(IMP_sop1iddoc)=@IDDOC
		UPDATE SOP40200 SET SOPNUMBE=@SOPNUMBE  WHERE rtrim(DOCID)=@DOCID
	END TRY  
	BEGIN CATCH
			SET @RESPUESTA=ERROR_MESSAGE()
			set @ERROR=ERROR_NUMBER()
	END CATCH

	SELECT  @ERROR ERROR,@RESPUESTA RESPUESTA
END