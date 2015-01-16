IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AvisosPedidosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AvisosPedidosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AvisosPedidosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_proveedor
     ,Id_articulo
     ,Leido
     ,Cabecera
     ,Detalle
     ,Fecha
FROM
     [dbo].[AvisosPedidos]
WHERE
    [Id] = @Id
End
