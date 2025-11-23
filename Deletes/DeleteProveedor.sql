USE [farmacia]
GO

CREATE PROC proveedor_delete
    (@proveedor INT)
AS
BEGIN
    DELETE [dbo].[proveedor]
    WHERE 
        [id_proveedor] = @proveedor
END
GO