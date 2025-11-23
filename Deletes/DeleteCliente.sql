USE [farmacia]
GO

CREATE PROC cliente_delete
    (@cliente INT)
AS
BEGIN
    DELETE [dbo].[cliente]
    WHERE 
        [id_cliente] = @cliente
END
GO