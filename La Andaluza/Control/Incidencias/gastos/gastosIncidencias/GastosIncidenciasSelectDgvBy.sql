IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasSelectDgvBy]
AS 
BEGIN
SELECT
      [dbo].[GastosIncidencias].[Id]
     ,[dbo].[GastosIncidencias].[Cantidad]
     ,[dbo].[ConceptosGastosIncidencias].[Descripcion] AS Id_concepto
     ,[dbo].[CostesPorConcepto].[Coste] AS Id_costeConcepto
     ,[dbo].[Proveedores].[Nombre] AS Id_proveedor
     ,[dbo].[Empleados].[Nombre] AS Id_empleado
     ,[dbo].[Clientes].[Nombre] AS Id_cliente
FROM
     [dbo].[GastosIncidencias]
     INNER JOIN [dbo].[ConceptosGastosIncidencias] ON [dbo].[GastosIncidencias].[Id_concepto] = [dbo].[ConceptosGastosIncidencias].[Id]
     INNER JOIN [dbo].[CostesPorConcepto] ON [dbo].[GastosIncidencias].[Id_costeConcepto] = [dbo].[CostesPorConcepto].[Id]
     INNER JOIN [dbo].[Proveedores] ON [dbo].[GastosIncidencias].[Id_proveedor] = [dbo].[Proveedores].[ProveedorID]
     INNER JOIN [dbo].[Empleados] ON [dbo].[GastosIncidencias].[Id_empleado] = [dbo].[Empleados].[Id]
     INNER JOIN [dbo].[Clientes] ON [dbo].[GastosIncidencias].[Id_cliente] = [dbo].[Clientes].[ClienteID]
WHERE
     [dbo].[GastosIncidencias].[Id_controlIncidencia] = @Id_controlIncidencia

End
