USE [farmacia]
GO

CREATE PROC proveedor_update
    (@proveedor INT, @nombre VARCHAR(100), @descripcion VARCHAR(500), @telefono VARCHAR(9), @direccion VARCHAR(100))
AS
BEGIN
    UPDATE [dbo].[proveedor]
    SET 
        [nombre] = @nombre,
        [descripcion] = @descripcion,
        [telefono] = @telefono,
        [direccion] = @direccion
    WHERE 
        [id_proveedor] = @proveedor
END
GO