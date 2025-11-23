USE [famacia]
GO

CREATE PROC laboratorio_insert
    (@nombre VARCHAR(100), @direccion VARCHAR(250), @telefono VARCHAR(9))
AS
INSERT INTO [dbo].[laboratorio]
           ([nombre]
           ,[direccion]
           ,[telefono])
     VALUES
           (@nombre
           ,@direccion
           ,@telefono)
GO