USE [farmacia]
GO

CREATE PROC producto_delete
    (@producto INT)
AS
BEGIN
    DELETE [dbo].[producto]
    WHERE 
        [id_producto] = @producto
END
GO