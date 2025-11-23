USE [famacia]
GO

CREATE PROC usuario_insert
    (@rol INT, @username VARCHAR(100), @contrasena VARCHAR(50), @nombre VARCHAR(100), @ape_paterno VARCHAR(100), @ape_materno VARCHAR(100), @telefono VARCHAR(9)
    , @email VARCHAR(100))
AS
INSERT INTO [dbo].[usuario]
           ([rol]
           ,[username]
           ,[contrasena]
           ,[nombre]
           ,[ape_paterno]
           ,[ape_materno]
           ,[telefono]
           ,[email])
     VALUES
           (@rol
           ,@username
           ,@contrasena
           ,@nombre
           ,@ape_paterno
           ,@ape_materno
           ,@telefono
           ,@email)
GO