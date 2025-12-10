USE [farmacia]
GO

CREATE PROC usuario_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[usuario]
GO