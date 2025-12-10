USE [farmacia]
GO

CREATE PROC laboratorio_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[laboratorio]
GO