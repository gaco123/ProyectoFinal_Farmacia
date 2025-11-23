USE [famacia]
GO

CREATE PROC registrostock_insert
    (@producto INT, @orden_compra INT, @orden_venta INT, @fecha_registro DATE, @fecha_vencimiento DATE, @stock_es INT, @usuario INT, @observaciones VARCHAR(500)
    , @precio_unitario NUMERIC(9,4), @costo_unitario NUMERIC(9,4))
AS
INSERT INTO [dbo].[registro_stock]
           ([producto]
           ,[orden_compra]
           ,[orden_venta]
           ,[fecha_registro]
           ,[fecha_vencimiento]
           ,[stock_es]
           ,[usuario]
           ,[observaciones]
           ,[precio_unitario]
           ,[costo_unitario])
     VALUES
           (@producto
           ,@orden_compra
           ,@orden_venta
           ,@fecha_registro
           ,@fecha_vencimiento
           ,@stock_es
           ,@usuario
           ,@observaciones
           ,@precio_unitario
           ,@costo_unitario)
GO