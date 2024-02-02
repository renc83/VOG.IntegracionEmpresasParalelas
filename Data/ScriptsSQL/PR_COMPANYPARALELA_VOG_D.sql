/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Elimina la Conexion de la empresa .
Cliente: ALIBAL
Tablas: COMPANYPARALELA_VOG

Ejemplo:
EXEC PR_COMPANYPARALELA_VOG_D 
=======================================================================*/

IF exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PR_COMPANYPARALELA_VOG_D]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].PR_COMPANYPARALELA_VOG_D
GO

CREATE  PROCEDURE PR_COMPANYPARALELA_VOG_D
(@ROW_ID		int
)
AS
BEGIN
	DECLARE @RESPUESTA VARCHAR(20)='',@ERROR INT =0
	
	BEGIN TRY	
		DELETE FROM COMPANYPARALELA_VOG WHERE ROW_ID=@ROW_ID
		SET @RESPUESTA='Registro Eliminado'
	END TRY  
	BEGIN CATCH
			SET @RESPUESTA=ERROR_MESSAGE()
			SET @ERROR =ERROR_NUMBER()
	END CATCH

	SELECT @ERROR ERROR, @RESPUESTA AS RESPUESTA
END