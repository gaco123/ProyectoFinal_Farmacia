USE [farmacia]
GO

CREATE PROC ordencompra_delete
     (@orden INT)
AS
BEGIN
    DELETE [dbo].[orden_compra]
    WHERE 
        [id_orden] = @orden
END
GO