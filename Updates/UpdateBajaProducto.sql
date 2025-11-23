USE [farmacia]
GO

CREATE PROC bajaproducto_update
    (@producto INT, @fecha_baja DATE, @motivo VARCHAR(500), @usuario INT, @observaciones VARCHAR(500))
AS
BEGIN
    UPDATE [dbo].[baja_producto]
    SET 
        [fecha_baja] = @fecha_baja,
        [motivo] = @motivo,
        [usuario] = @usuario,
        [observaciones] = @observaciones
    WHERE 
        [producto] = @producto
END
GO