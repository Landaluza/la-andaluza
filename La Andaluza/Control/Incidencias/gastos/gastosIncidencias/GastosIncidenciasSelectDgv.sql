IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[GastosIncidencias].[Id] Id
     ,[dbo].[GastosIncidencias].[Cantidad]
     ,[dbo].[ConceptosGastosIncidencias].[Descripcion]
     ,[dbo].[CostesPorConcepto].[Coste]
     ,[dbo].[Proveedores].[Nombre]
     ,[dbo].[Empleados].[Nombre]
     ,[dbo].[Clientes].[Nombre]
FROM
     [dbo].[GastosIncidencias]
     INNER JOIN [dbo].[ConceptosGastosIncidencias] ON [dbo].[GastosIncidencias].[Id_concepto] = [dbo].[ConceptosGastosIncidencias].[Id]
     INNER JOIN [dbo].[CostesPorConcepto] ON [dbo].[GastosIncidencias].[Id_costeConcepto] = [dbo].[CostesPorConcepto].[Id]
     INNER JOIN [dbo].[Proveedores] ON [dbo].[GastosIncidencias].[Id_proveedor] = [dbo].[Proveedores].[ProveedorID]
     INNER JOIN [dbo].[Empleados] ON [dbo].[GastosIncidencias].[Id_empleado] = [dbo].[Empleados].[Id]
     INNER JOIN [dbo].[Clientes] ON [dbo].[GastosIncidencias].[Id_cliente] = [dbo].[Clientes].[ClienteID]
End
