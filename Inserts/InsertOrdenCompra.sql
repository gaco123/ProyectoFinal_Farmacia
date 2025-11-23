USE [famacia]
GO

CREATE PROC ordencompra_insert
    (@fecha_orden DATE, @proveedor INT, @costo_total NUMERIC(9,4))
AS
INSERT INTO [dbo].[orden_compra]
           ([fecha_orden]
           ,[proveedor]
           ,[costo_total])
     VALUES
           (@fecha_orden
           ,@proveedor
           ,@costo_total)
GO