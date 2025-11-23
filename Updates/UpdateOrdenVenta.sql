USE [farmacia]
GO

CREATE PROC ordenventa_update
    (@orden INT, @fecha_orden DATE, @cliente INT, @costo_total NUMERIC(9,4))
AS
BEGIN
    UPDATE [dbo].[orden_venta]
    SET 
        [fecha_orden] = @fecha_orden,
        [cliente] = @cliente,
        [costo_total] = @costo_total
    WHERE 
        [id_orden] = @orden
END
GO