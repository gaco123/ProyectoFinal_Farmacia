USE [farmacia]
GO

CREATE PROC producto_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[producto]
GO