USE [farmacia]
GO

CREATE PROC usuario_delete
    (@usuario INT)
AS
BEGIN
    DELETE [dbo].[usuario]
    WHERE 
        [id_usuario] = @usuario
END
GO