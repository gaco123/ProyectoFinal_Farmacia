USE [farmacia]
GO

CREATE PROC laboratorio_delete
    (@laboratorio INT)
AS
BEGIN
    DELETE [dbo].[laboratorio]
    WHERE 
        [id_laboratorio] = @laboratorio
END
GO