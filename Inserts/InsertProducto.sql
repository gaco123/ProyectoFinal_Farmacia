USE [farmacia]
GO

CREATE PROC producto_insert
    (@nombre VARCHAR(100), @descripcion VARCHAR(500), @principio_activo VARCHAR(100), @laboratorio INT, @categoria INT, @concentracion INT, @unidad_medida VARCHAR(20)
    , @presentacion VARCHAR(100), @stock_actual INT, @stock_minimo INT, @stock_maximo INT, @ubicacion INT, @precio_unitario NUMERIC(9,4), @costo_unitario NUMERIC(9,4))
AS
INSERT INTO [dbo].[producto]
           ([nombre]
           ,[descripcion]
           ,[principio_activo]
           ,[laboratorio]
           ,[categoria]
           ,[concentracion]
           ,[unidad_medida]
           ,[presentacion]
           ,[stock_actual]
           ,[stock_minimo]
           ,[stock_maximo]
           ,[ubicacion]
           ,[precio_unitario]
           ,[costo_unitario])
     VALUES
           (@nombre
           ,@descripcion
           ,@principio_activo
           ,@laboratorio
           ,@categoria
           ,@concentracion
           ,@unidad_medida
           ,@presentacion
           ,@stock_actual
           ,@stock_minimo
           ,@stock_maximo
           ,@ubicacion
           ,@precio_unitario
           ,@costo_unitario)
GO