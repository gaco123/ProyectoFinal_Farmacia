USE [farmacia]
GO

CREATE PROC categoria_delete
    (@categoria INT)
AS
BEGIN
    DELETE [dbo].[categoria]
    WHERE 
        [id_categoria] = @categoria
END
GO