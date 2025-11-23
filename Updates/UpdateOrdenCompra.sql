USE [farmacia]
GO

CREATE PROC ordencompra_update
     (@orden INT, @fecha_orden DATE, @proveedor INT, @costo_total NUMERIC(9,4))
AS
BEGIN
    UPDATE [dbo].[orden_compra]
    SET 
        [fecha_orden] = @fecha_orden,
        [proveedor] = @proveedor,
        [costo_total] = @costo_total
    WHERE 
        [id_orden] = @orden
END
GO