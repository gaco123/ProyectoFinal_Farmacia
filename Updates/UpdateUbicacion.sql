USE [farmacia]
GO

CREATE PROC ubicacion_update
    (@ubicacion INT, @zona VARCHAR(50), @estante INT, @nivel INT)
AS
BEGIN
    UPDATE [dbo].[ubicacion]
    SET 
        [zona] = @zona,
        [estante] = @estante,
        [nivel] = @nivel
    WHERE 
        [id_ubicacion] = @ubicacion
END
GO