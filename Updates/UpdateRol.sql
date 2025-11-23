USE [farmacia]
GO

CREATE PROC rol_update
    (@rol INT, @nombre VARCHAR(100), @descripcion VARCHAR(500))
AS
BEGIN
    UPDATE [dbo].[rol]
    SET 
        [nombre] = @nombre,
        [descripcion] = @descripcion
    WHERE 
        [id_rol] = @rol
END
GO