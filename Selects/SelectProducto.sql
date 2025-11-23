USE [farmacia]
GO

CREATE PROC producto_select (@producto INT)
AS
SELECT [id_producto]
       ,[nombre] 
       ,[descripcion]
       ,[principio_activo]
       ,[laboratorio]
       ,[categoria]
       ,[concentracion]
       ,[unidad_medida]
       ,[presentacion]
       ,[stock_actual]
       ,[stock_maximo]
       ,[stock_minimo]
       ,[ubicacion]
       ,[precio_unitario]
       ,[costo_unitario]
       ,[estado]
FROM [dbo].[producto]
WHERE id_producto = @producto
GO