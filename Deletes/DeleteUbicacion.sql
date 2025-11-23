USE [farmacia]
GO

CREATE PROC ubicacion_delete
    (@ubicacion INT)
AS
BEGIN
    DELETE [dbo].[ubicacion]
    WHERE 
        [id_ubicacion] = @ubicacion
END
GO