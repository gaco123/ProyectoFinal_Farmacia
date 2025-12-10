USE [farmacia]
GO

CREATE PROC registrostock_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[registro_stock]
GO