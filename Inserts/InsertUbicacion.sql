USE [famacia]
GO

CREATE PROC ubicacion_insert
    (@zona VARCHAR(50), @estante INT, @nivel INT)
AS
INSERT INTO [dbo].[ubicacion]
           ([zona]
           ,[estante]
           ,[nivel])
     VALUES
           (@zona
           ,@estante
           ,@nivel)
GO