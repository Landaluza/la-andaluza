IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[GastosIncidencias]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasInsert]
      @Cantidad decimal
     ,@Id_concepto int
     ,@Id_costeConcepto int
     ,@Id_proveedor int
     ,@Id_empleado int
     ,@Id_cliente int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[GastosIncidencias]
     (
      Cantidad
     ,Id_concepto
     ,Id_costeConcepto
     ,Id_proveedor
     ,Id_empleado
     ,Id_cliente
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Cantidad
     ,@Id_concepto
     ,@Id_costeConcepto
     ,@Id_proveedor
     ,@Id_empleado
     ,@Id_cliente
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
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

GO
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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasSelectDgvBy]  @Id_controlIncidencia int
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

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasUpdate] 
      @Cantidad decimal
     ,@Id_concepto int
     ,@Id_costeConcepto int
     ,@Id_proveedor int
     ,@Id_empleado int
     ,@Id_cliente int
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[GastosIncidencias]
SET
      [Cantidad] = @Cantidad
     ,[Id_concepto] = @Id_concepto
     ,[Id_costeConcepto] = @Id_costeConcepto
     ,[Id_proveedor] = @Id_proveedor
     ,[Id_empleado] = @Id_empleado
     ,[Id_cliente] = @Id_cliente
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
