USE [farmacia]
GO

CREATE PROC ubicacion_select (@ubicacion INT)
AS
SELECT [id_ubicacion]
       ,[zona] 
       ,[estante]
       ,[nivel]
FROM [dbo].[ubicacion]
WHERE id_ubicacion = @ubicacion
GO