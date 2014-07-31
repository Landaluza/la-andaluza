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
