USE [farmacia]
GO

CREATE PROC ordencompra_select (@orden INT)
AS
SELECT [id_orden]
       ,[fecha_orden] 
       ,[proveedor]
       ,[costo_total]
FROM [dbo].[orden_compra]
WHERE id_orden = @orden
GO