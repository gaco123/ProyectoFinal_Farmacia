USE [farmacia]
GO

CREATE PROC categoria_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[categoria]
GO