USE [farmacia]
GO

CREATE PROC ordencompra_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[orden_compra]
GO