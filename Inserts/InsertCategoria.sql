USE [farmacia]
GO

CREATE PROC categoria_insert
    (@nombre VARCHAR(100), @descripcion VARCHAR(500))
AS
INSERT INTO [dbo].[categoria]
           ([nombre]
           ,[descripcion])
     VALUES
           (@nombre
           ,@descripcion)
GO