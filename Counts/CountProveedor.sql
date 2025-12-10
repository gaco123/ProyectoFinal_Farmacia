USE [farmacia]
GO

CREATE PROC proveedor_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[proveedor]
GO