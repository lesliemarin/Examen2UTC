﻿CREATE PROCEDURE [dbo].[SolicitudInsertar]
	
@IdCliente INT,
@IdServicio INT,
@Cantidad INT ,
@Monto DECIMAL (18, 2),
@FechaEntrega DATETIME,
 @UsuarioEntrega VARCHAR (50),
 @Observaciones VARCHAR(250)

AS
 BEGIN
  SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

  BEGIN TRY

  INSERT INTO dbo.Solicitud
  (
		     
		   IdCliente 
		   ,IdServicio 
		   ,Cantidad 
		   ,Monto
		   ,FechaEntrega,
		   UsuarioEntrega,
		   Observaciones
  )
  VALUES
  (
		   @IdCliente 
		   ,@IdServicio 
		   ,@Cantidad 
		   ,@Monto
		   ,@FechaEntrega,
		   @UsuarioEntrega,
		   @Observaciones
  )

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodeError, '' AS MsgError

  END TRY

	  BEGIN CATCH
		SELECT 
			   ERROR_NUMBER() AS CodeError,
			   ERROR_MESSAGE() AS MsgError

	  ROLLBACK TRANSACTION TRASA
  
  END CATCH

  END 