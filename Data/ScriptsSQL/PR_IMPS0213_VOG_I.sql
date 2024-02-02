/*====================================================================
Author: Rafael Niño
Create date: 22/01/2024
Modulo: Integracion de Facturas empresas paralelas
Description SP:  Inserta informacion del Modulo de Impuesto de la factura.
Cliente: ALIBAL
Tablas:  IMPS0213

SP : Para ingresar chequeras
EXEC PR_IMPS0213_VOG_I 
 @USUARIO		='sa'
,@BDORIGEN		='ALIB5'
,@CHEQORIGEN	='CARIBES'
,@BDDESTINO		='IDTE3'
,@CHEQDESTINO	='BANESCO'
,@CTADESTINO	='111-000-01'

SELECT * FROM IMPS0213 where  NroDocumento='A-FAC-00127218'
delete FROM IMPS0213 where  NroDocumento='A-FAC-00127218'
*/  
IF exists (select * from dbo.sysobjects where id = object_id(N'dbo.PR_IMPS0213_VOG_I') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure dbo.PR_IMPS0213_VOG_I
GO

CREATE  PROCEDURE PR_IMPS0213_VOG_I
(@NumeroDocumento char(21)  
,@Tipo smallint  
,@IdDoc char(15)
,@NroControl char(81)  
,@IdCorrNroControl char(15)  
,@IdTipoDoc char(15)  
,@DocDescripcion char(31)  
,@Planilla char(31)  
,@Expediente char(31)  
,@TipoTransaccion smallint  
,@Sucursal char(31)  
,@IdCliente char(15)  
,@NomCliente char(100)  
,@TipoCliente smallint  
,@Rif char(11)    
,@FechaDocumentoC datetime   
--,@FechaContabilizacion datetime  
,@Adicional1 char(61)  
,@Adicional2 char(61)  
,@Adicional3 char(61)  
,@TipoDoc smallint  
,@Direccion1 char(61)  
,@Direccion2 char(61)  
,@Direccion3 char(61)  
,@Ciudad char(35)  
,@Estado char(29)  
,@Pais char(61)  
,@Telefono1 char(21)  
,@Telefono2 char(21)  
,@Telefono3 char(21)  
,@Fax char(21)  
,@Procedencia char(3)  
,@Generico bit  
,@Cargado bit  
,@TipoContribuyente char(10)   
,@Especial bit
,@Miscelaneos numeric(19,5)
,@Flete		  numeric(19,5)
)				  
AS
BEGIN
	DECLARE @RESPUESTA   VARCHAR(50)='Registro Ingresado',@ACTIVO smallint=1,@ERROR INT=0
	DECLARE @DATE_INSERT DATETIME =GETDATE()
	
	BEGIN TRY
			 INSERT INTO dbo.IMPS0213  
			   (NroDocumento  
			   ,Tipo 
			   ,NroControl
			   ,IdDoc  
			   ,IdCorrNroControl  
			   ,IdTipoDoc  
			   ,DocDescripcion  
			   ,Planilla  
			   ,Expediente  
			   ,TipoTransaccion  
			   ,Sucursal  
			   ,IdCliente  
			   ,NomCliente  
			   ,TipoCliente  
			   ,Rif  
			   ,FechaDocumento  
			   ,Adicional1  
			   ,Adicional2  
			   ,Adicional3  
			   ,TipoDoc  
			   ,Direccion1  
			   ,Direccion2  
			   ,Direccion3  
			   ,Ciudad  
			   ,Estado  
			   ,Pais  
			   ,Telefono1  
			   ,Telefono2  
			   ,Telefono3  
			   ,Fax  
			   ,Procedencia  
			   ,Generico  
			   ,Cargado  
			   ,TipoContribuyente  
			   ,Especial
			   ,Miscelaneos
			   ,Flete)   
			VALUES  
				(@NumeroDocumento  
				 ,@Tipo 
				 ,@NroControl
				 ,@IdDoc  
				 ,@IdCorrNroControl  
				 ,@IdTipoDoc  
				 ,@DocDescripcion  
				 ,@Planilla  
				 ,@Expediente  
				 ,@TipoTransaccion  
				 ,@Sucursal  
				 ,@IdCliente  
				 ,@NomCliente  
				 ,@TipoCliente  
				 ,@Rif  
				 ,@FechaDocumentoC   
				 ,@Adicional1  
				 ,@Adicional2  
				 ,@Adicional3  
				 ,@TipoDoc  
				 ,@Direccion1  
				 ,@Direccion2  
				 ,@Direccion3  
				 ,@Ciudad  
				 ,@Estado  
				 ,@Pais  
				 ,@Telefono1  
				 ,@Telefono2  
				 ,@Telefono3  
				 ,@Fax  
				 ,@Procedencia  
				 ,@Generico  
				,@Cargado  
				,@TipoContribuyente    
				,@Especial
				,@Miscelaneos
				,@Flete) 
				
		UPDATE IMPS0005 SET IMP_sop1codoc1=@IdCorrNroControl WHERE IMP_sop1iddoc1=@IdCorrNroControl
	END TRY  
	BEGIN CATCH
			SET @RESPUESTA=ERROR_MESSAGE()
			set @ERROR=ERROR_NUMBER()
	END CATCH

	SELECT  @ERROR ERROR,@RESPUESTA RESPUESTA
END