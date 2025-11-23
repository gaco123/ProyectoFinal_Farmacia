USE [farmacia]
GO

CREATE PROC bajaproducto_delete
    (@producto INT)
AS
BEGIN
    DELETE [dbo].[baja_producto]
    WHERE 
        [producto] = @producto
END
GO