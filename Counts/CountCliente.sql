USE [farmacia]
GO

CREATE PROC cliente_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[cliente]
GO