USE [famacia]
GO

CREATE PROC ordenventa_insert
    (@fecha_orden DATE, @cliente INT, @costo_total NUMERIC(9,4))
AS
INSERT INTO [dbo].[orden_venta]
           ([fecha_orden]
           ,[cliente]
           ,[costo_total])
     VALUES
           (@fecha_orden
           ,@cliente
           ,@costo_total)
GO