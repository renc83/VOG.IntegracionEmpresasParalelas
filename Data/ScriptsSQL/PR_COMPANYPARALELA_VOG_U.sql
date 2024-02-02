/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Actualiza la Conexion de la empresa .
Cliente: ALIBAL
Tablas: COMPANYPARALELA_VOG

Ejemplo:
EXEC PR_COMPANYPARALELA_VOG_U 
=======================================================================*/ 

IF exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PR_COMPANYPARALELA_VOG_U]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].PR_COMPANYPARALELA_VOG_U
GO

CREATE  PROCEDURE PR_COMPANYPARALELA_VOG_U
(@Descripcion		nvarchar(100) 
,@Conexion			nvarchar(max) 
,@Correo			nvarchar(100) 
,@BDDESTINO			NVARCHAR(20) 
,@USUARIO			NVARCHAR(50)
,@ROW_ID			INT
)
AS
BEGIN
	DECLARE @RESPUESTA VARCHAR(20)='',@ERROR INT =0
	DECLARE @DATE_INSERT DATETIME =GETDATE()

	BEGIN TRY	
		UPDATE COMPANYPARALELA_VOG SET 
				 Descripcion	=@Descripcion		
				,Conexion		=@Conexion		
				,Correo			=@Correo			
				,BDDESTINO		=@BDDESTINO			
				,DATE_INSERT	=@DATE_INSERT		
				,USUARIO		=@USUARIO		
		WHERE ROW_ID=@ROW_ID
		SET @RESPUESTA='Registro Actualizado'
	END TRY  
	BEGIN CATCH
			SET @RESPUESTA=ERROR_MESSAGE()
			SET @ERROR =ERROR_NUMBER()
	END CATCH

	SELECT @ERROR ERROR, @RESPUESTA AS RESPUESTA
END