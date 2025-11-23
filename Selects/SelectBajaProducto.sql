USE [farmacia]
GO

CREATE PROC bajaproducto_select (@producto INT)
AS
SELECT [producto]
       ,[fecha_baja] 
       ,[motivo]
       ,[usuario]
       ,[observaciones]
FROM [dbo].[baja_producto]
WHERE producto = @producto
GO