USE [farmacia]
GO

CREATE PROC registrostock_select (@regstock INT)
AS
SELECT [id_registro]
       ,[producto] 
       ,[orden_compra]
       ,[orden_venta]
       ,[fecha_registro]
       ,[fecha_vencimiento]
       ,[stock_es]
       ,[usuario]
       ,[observaciones]
       ,[precio_unitario]
       ,[costo_unitario]
FROM [dbo].[registro_stock]
WHERE id_registro = @regstock
GO