USE [farmacia]
GO

CREATE PROC rol_delete
    (@rol INT)
AS
BEGIN
    DELETE [dbo].[rol]
    WHERE 
        [id_rol] = @rol
END
GO