USE [farmacia]
GO

CREATE PROC bajaproducto_insert
    (@producto INT, @fecha_baja DATE, @motivo VARCHAR(500), @usuario INT, @observaciones VARCHAR(500))
AS
INSERT INTO [dbo].[baja_producto]
           ([producto]
           ,[fecha_baja]
           ,[motivo]
           ,[usuario]
           ,[observaciones])
     VALUES
           (@producto
           ,@fecha_baja
           ,@motivo
           ,@usuario
           ,@observaciones)
GO