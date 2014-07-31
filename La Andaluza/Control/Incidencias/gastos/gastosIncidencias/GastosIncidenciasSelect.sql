IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Cantidad
     ,Id_concepto
     ,Id_costeConcepto
     ,Id_proveedor
     ,Id_empleado
     ,Id_cliente
FROM
     [dbo].[GastosIncidencias]
WHERE
    [Id] = @Id
End
