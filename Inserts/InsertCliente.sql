USE [famacia]
GO

CREATE PROC cliente_insert
    (@nombre VARCHAR(100), @ape_paterno VARCHAR(100), @ape_materno VARCHAR(100), @telefono VARCHAR(9), @direccion VARCHAR(100))
AS
INSERT INTO [dbo].[cliente]
           ([nombre]
           ,[ape_paterno]
           ,[ape_materno]
           ,[telefono]
           ,[direccion])
     VALUES
           (@nombre
           ,@ape_paterno
           ,@ape_materno
           ,@telefono
           ,@direccion)
GO