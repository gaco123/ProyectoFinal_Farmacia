USE [farmacia]
GO

CREATE PROC laboratorio_select (@laboratorio INT)
AS
SELECT [id_laboratorio]
       ,[nombre] 
       ,[direccion]
       ,[telefono]
FROM [dbo].[laboratorio]
WHERE id_laboratorio = @laboratorio
GO