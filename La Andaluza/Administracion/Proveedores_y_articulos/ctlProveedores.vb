Public Class ctlProveedores


    Public Function devolverProveedoresAnaliticas() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Proveedores.ProveedorID, Proveedores.Nombre", "TipoProv_Proveedor INNER JOIN Proveedores ON TipoProv_Proveedor.ProveedorID = Proveedores.ProveedorID INNER JOIN TiposProveedores ON TipoProv_Proveedor.TipoProveedorID = TiposProveedores.TipoProveedorID", "TiposProveedores.Descripcion = 'Analiticas'")

    End Function

  

    Public Function devolverProveedores() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("*", "Proveedores")

    End Function

End Class
