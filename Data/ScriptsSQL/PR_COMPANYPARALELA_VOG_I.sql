/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Ingresa la Conexion de la empresa .
Cliente: ALIBAL
Tablas: COMPANYPARALELA_VOG

Ejemplo:
EXEC PR_COMPANYPARALELA_VOG_D 
=======================================================================*/ 
IF exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PR_COMPANYPARALELA_VOG_I]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].PR_COMPANYPARALELA_VOG_I
GO

CREATE  PROCEDURE PR_COMPANYPARALELA_VOG_I
(@Descripcion		nvarchar(100) 
,@Conexion			nvarchar(max) 
,@Correo			nvarchar(100) 
,@BDDESTINO			nvarchar(20)  
,@USUARIO			NVARCHAR(50)
)				  
AS
BEGIN
	DECLARE @RESPUESTA   VARCHAR(50)='Registro Ingresado',@ACTIVO smallint=1,@ERROR INT=0
	DECLARE @DATE_INSERT DATETIME =GETDATE()
	
	BEGIN TRY
			INSERT INTO COMPANYPARALELA_VOG (Descripcion		
									   		,Conexion		
									   		,Correo			
									   		,BDDESTINO			
									   		,DATE_INSERT		
									   		,USUARIO)
							values	(@Descripcion		
									,@Conexion		
									,@Correo			
									,@BDDESTINO		
									,@DATE_INSERT		
									,@USUARIO)
	END TRY  
	BEGIN CATCH
			SET @RESPUESTA=ERROR_MESSAGE()
			set @ERROR=ERROR_NUMBER()
	END CATCH

	SELECT  @ERROR ERROR,@RESPUESTA RESPUESTA
END