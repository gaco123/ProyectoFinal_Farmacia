USE [farmacia]
GO

CREATE PROC rol_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[rol]
GO