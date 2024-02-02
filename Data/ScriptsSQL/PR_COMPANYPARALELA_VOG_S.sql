/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Lista la Conexion de la empresa .
Cliente: ALIBAL
Tablas: COMPANYPARALELA_VOG

Ejemplo:
EXEC PR_COMPANYPARALELA_VOG_S 
=======================================================================*/ 
IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[PR_COMPANYPARALELA_VOG_S]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].PR_COMPANYPARALELA_VOG_S
go
CREATE PROCEDURE PR_COMPANYPARALELA_VOG_S
(@ROW_ID		int=0)
AS
BEGIN

SET NOCOUNT ON;
----------------DECLARACIONES---------------------------------------

SELECT ROW_ID
		,Descripcion		
		,Conexion		
		,Correo			
		,BDDESTINO			
		,DATE_INSERT		
		,USUARIO
  FROM COMPANYPARALELA_VOG
  WHERE (ROW_ID=@ROW_ID OR @ROW_ID=0)
-- WHERE ACTIVO=1

SET NOCOUNT OFF;
END