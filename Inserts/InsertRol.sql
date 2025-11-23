USE [famacia]
GO

CREATE PROC rol_insert
    (@nombre VARCHAR(100), @descripcion VARCHAR(500))
AS
INSERT INTO [dbo].[rol]
           ([nombre]
           ,[descripcion])
     VALUES
           (@nombre
           ,@descripcion)
GO