USE [farmacia]
GO

CREATE PROC ordenventa_select (@orden INT)
AS
SELECT [id_orden]
       ,[fecha_orden] 
       ,[cliente]
       ,[costo_total]
FROM [dbo].[orden_venta]
WHERE id_orden = @orden
GO