USE [farmacia]
GO

CREATE PROC ordenventa_delete
    (@orden INT)
AS
BEGIN
    DELETE [dbo].[orden_venta]
    WHERE 
        [id_orden] = @orden
END
GO