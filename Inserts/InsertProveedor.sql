USE [famacia]
GO

CREATE PROC proveedor_insert
    (@nombre VARCHAR(100), @descripcion VARCHAR(500), @telefono VARCHAR(9), @direccion VARCHAR(100))
AS
INSERT INTO [dbo].[proveedor]
           ([nombre]
           ,[descripcion]
           ,[telefono]
           ,[direccion])
     VALUES
           (@nombre
           ,@descripcion
           ,@telefono
           ,@direccion)
GO