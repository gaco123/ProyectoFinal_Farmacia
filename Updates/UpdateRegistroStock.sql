USE [farmacia]
GO

CREATE PROC registrostock_update
    (@registro INT, @producto INT, @orden_compra INT, @orden_venta INT, @fecha_registro DATE, @fecha_vencimiento DATE, @stock_es INT
    , @usuario INT, @observaciones VARCHAR(500), @precio_unitario NUMERIC(9,4), @costo_unitario NUMERIC(9,4))
AS
BEGIN
    UPDATE [dbo].[registro_stock]
    SET 
        [producto] = @producto,
        [orden_compra] = @orden_compra,
        [orden_venta] = @orden_venta,
        [fecha_registro] = @fecha_registro,
        [fecha_vencimiento] = @fecha_vencimiento,
        [stock_es] = @stock_es,
        [usuario] = @usuario,
        [observaciones] = @observaciones,
        [precio_unitario] = @precio_unitario,
        [costo_unitario] = @costo_unitario
    WHERE 
        [id_registro] = @registro
END
GO