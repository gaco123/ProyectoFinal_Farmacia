USE [farmacia]
GO

CREATE PROC ubicacion_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[ubicacion]
GO