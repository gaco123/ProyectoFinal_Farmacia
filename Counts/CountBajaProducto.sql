USE [farmacia]
GO

CREATE PROC bajaproducto_count
AS
SELECT COUNT(*) AS 'NumFilas'
FROM [dbo].[baja_producto]
GO