USE [farmacia]
GO

CREATE PROC producto_update
    (@producto INT, @nombre VARCHAR(100), @descripcion VARCHAR(500), @principio_activo VARCHAR(100), @laboratorio INT, @categoria INT, @concentracion INT, @unidad_medida VARCHAR(20)
    , @presentacion VARCHAR(100), @stock_actual INT, @stock_minimo INT, @stock_maximo INT, @ubicacion INT, @precio_unitario NUMERIC(9,4), @costo_unitario NUMERIC(9,4))
AS
BEGIN
    UPDATE [dbo].[producto]
    SET 
        [nombre] = @nombre,
        [descripcion] = @descripcion,
        [principio_activo] = @principio_activo,
        [laboratorio] = @laboratorio,
        [categoria] = @categoria,
        [concentracion] = @concentracion,
        [unidad_medida] = @unidad_medida,
        [presentacion] = @presentacion,
        [stock_actual] = @stock_actual,
        [stock_minimo] = @stock_minimo,
        [stock_maximo] = @stock_maximo,
        [ubicacion] = @ubicacion,
        [precio_unitario] = @precio_unitario,
        [costo_unitario] = @costo_unitario

     WHERE 
        [id_producto] = @producto
END
GO