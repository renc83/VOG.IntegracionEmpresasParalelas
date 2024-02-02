/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Lista el encabezado de la factura.
Cliente: ALIBAL
Tablas:  SOP10100

Ejemplo:
EXEC pr_SOP10100_VOG_S 
@DOCID	   ='C-FACTURA      '         
,@FILTRO   ='AND R.SOPNUMBE>=''20230110'''
=======================================================================*/
IF EXISTS(SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[pr_SOP10100_VOG_S]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
	DROP PROCEDURE [dbo].pr_SOP10100_VOG_S
go
CREATE PROCEDURE pr_SOP10100_VOG_S
(@DOCID		VARCHAR(15)
,@FILTRO	VARCHAR(max)=''
)
AS
BEGIN

SET NOCOUNT ON;
----------------DECLARACIONES---------------------------------------
DECLARE @SQLSTR    NVARCHAR(MAX)='',@Parametro nvarchar(500)

  SET @SQLSTR=CONCAT(' SELECT 
					 R.DOCID
					,R.SOPNUMBE 
					,R.DOCDATE
					,R.SOPTYPE
					,R.CUSTNMBR 
					,R.CUSTNAME 
					,R.BACHNUMB 
					,R.SLPRSNID 
					,R.CURNCYID 
					,R.LOCNCODE 
					,R.SHIPMTHD 
					,R.PYMTRMID 
					,R.CSTPONBR 
					,R.TXRGNNUM
					,ISNULL(C.COMMENT_1,'''') COMMENT_1
					,ISNULL(C.COMMENT_2,'''') COMMENT_2
					,ISNULL(C.COMMENT_3,'''') COMMENT_3
					,ISNULL(C.COMMENT_4,'''') COMMENT_4
					,IIF(R.CURNCYID=''USD'',R.ORTDISAM,TRDISAMT) TRDISAMT
			  FROM SOP10100 R
			 LEFT JOIN SOP10106 C ON R.SOPTYPE=C.SOPTYPE AND C.SOPNUMBE=R.SOPNUMBE
			 WHERE R.DOCID=@DOCID 
			   AND R.SOPTYPE IN (3,4)
			   AND R.VOIDSTTS=0 ',@FILTRO,' ORDER BY R.SOPNUMBE ')

PRINT @SQLSTR

  SET @Parametro = N'@DOCID	VARCHAR(15)';  
   EXECUTE sp_executesql @SQLSTR, @Parametro,  
						 @DOCID=@DOCID;

SET NOCOUNT OFF;
END