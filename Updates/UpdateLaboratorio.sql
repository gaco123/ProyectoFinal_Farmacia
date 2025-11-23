USE [farmacia]
GO

CREATE PROC laboratorio_update
    (@laboratorio INT, @nombre VARCHAR(100), @direccion VARCHAR(250), @telefono VARCHAR(9))
AS
BEGIN
    UPDATE [dbo].[laboratorio]
    SET 
        [nombre] = @nombre,
        [direccion] = @direccion,
        [telefono] = @telefono
    WHERE 
        [id_laboratorio] = @laboratorio
END
GO