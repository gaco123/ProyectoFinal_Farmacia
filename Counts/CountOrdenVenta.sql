USE [farmacia]
GO

CREATE PROC ordenventa_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[orden_venta]
GO