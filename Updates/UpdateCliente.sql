USE [farmacia]
GO

CREATE PROC cliente_update
    (@cliente INT, @nombre VARCHAR(100), @ape_paterno VARCHAR(100), @ape_materno VARCHAR(100), @telefono VARCHAR(9), @direccion VARCHAR(100))
AS
BEGIN
    UPDATE [dbo].[cliente]
    SET 
        [nombre] = @nombre,
        [ape_paterno] = @ape_paterno,
        [ape_materno] = @ape_materno,
        [telefono] = @telefono,
        [direccion] = @direccion
    WHERE 
        [id_cliente] = @cliente
END
GO