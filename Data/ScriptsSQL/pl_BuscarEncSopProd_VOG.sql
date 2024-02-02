/*====================================================================
Author: Rafael Niño
Create date: 22/08/2023
Modulo: Integracion de Empresas Paralelas
Description SP:  Lee los tipos de documentos de ventas de la empresa destino.
Cliente: ALIBAL
Tablas: SOP30200  - 

Ejemplo:
EXEC pl_BuscarEncSopProd_VOG 
=======================================================================*/
IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pl_BuscarEncSopProd_VOG]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pl_BuscarEncSopProd_VOG
go
CREATE PROCEDURE pl_BuscarEncSopProd_VOG
AS
BEGIN

SET NOCOUNT ON;
----------------DECLARACIONES---------------------------------------
DECLARE @SQLSTR    NVARCHAR(MAX)='',@Parametro nvarchar(500)
Declare @TabVal Table (FLGVALIDADO int,FLGMENSAJE varchar(255));


-- SET @SQLSTR=CONCAT('','SELECT DOCID,SOPTYPE
--							 ,max(SOPNUMBE) SOPNUMBE
--							 ,max(DOCDATE) DOCDATE
--						FROM DBO.sop30200 
--					   WHERE SOPTYPE IN (4,3) 
--					   GROUP BY DOCID,SOPTYPE')
-- PRINT @SQLSTR
--
--   --INSERT INTO  @TabVal
--  EXECUTE sp_executesql @SQLSTR;

WITH CTE_FACT AS (
SELECT DOCID,SOPTYPE
		 ,max(SOPNUMBE) SOPNUMBE
		 ,max(DOCDATE) DOCDATE
	FROM DBO.sop30200 
   WHERE SOPTYPE IN (4,3) 
   GROUP BY DOCID,SOPTYPE
UNION ALL
SELECT DOCID,SOPTYPE
		 ,max(SOPNUMBE) SOPNUMBE
		 ,max(DOCDATE) DOCDATE
	FROM DBO.sop10100 
   WHERE SOPTYPE IN (4,3) 
   GROUP BY DOCID,SOPTYPE
)

SELECT DOCID,SOPTYPE
		 ,max(SOPNUMBE) SOPNUMBE
		 ,max(DOCDATE) DOCDATE
	FROM CTE_FACT 
   WHERE SOPTYPE IN (4,3) 
   GROUP BY DOCID,SOPTYPE


SET NOCOUNT OFF;
END