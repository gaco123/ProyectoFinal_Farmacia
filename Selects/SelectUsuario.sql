USE [farmacia]
GO

CREATE PROC usuario_select (@usuario INT)
AS
SELECT [id_usuario]
       ,[rol] 
       ,[username]
       ,[contrasena]
       ,[nombre]
       ,[ape_paterno]
       ,[ape_materno]
       ,[telefono]
       ,[email]
FROM [dbo].[usuario]
WHERE id_usuario = @usuario
GO