USE [farmacia]
GO

CREATE PROC categoria_update
    (@categoria INT, @nombre VARCHAR(100), @descripcion VARCHAR(500))
AS
BEGIN
    UPDATE [dbo].[categoria]
    SET 
        [nombre] = @nombre,
        [descripcion] = @descripcion
    WHERE 
        [id_categoria] = @categoria
END
GO