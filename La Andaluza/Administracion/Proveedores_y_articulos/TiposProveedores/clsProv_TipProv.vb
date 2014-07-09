Public Class clsProv_TipProv
#Region "Atributos"
    Private ProveedorID As Integer
    Private TipoProveedorID As Integer
#End Region

#Region "Propiedades"
    Public Property _ProveedorID() As Integer
        Get
            Return ProveedorID
        End Get

        Set(ByVal value As Integer)
            ProveedorID = value
        End Set
    End Property

    Public Property _TipoProveedorID() As Integer
        Get
            Return TipoProveedorID
        End Get

        Set(ByVal value As Integer)
            TipoProveedorID = value
        End Set
    End Property

#End Region

#Region "Propiedades"

    Public Function devolverSegunProveedorID() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("TiposProveedores.TipoProveedorID,TiposProveedores.Descripcion, t1.Descr", "TiposProveedores left join (SELECT TiposProveedores.Descripcion as Descr FROM Proveedores INNER JOIN TipoProv_Proveedor ON Proveedores.ProveedorID = TipoProv_Proveedor.ProveedorID INNER JOIN TiposProveedores ON TipoProv_Proveedor.TipoProveedorID = TiposProveedores.TipoProveedorID WHERE(Proveedores.ProveedorID = " & Convert.ToString(ProveedorID) & ")) as T1 on TiposProveedores.Descripcion = t1.Descr", "TiposProveedores.TipoProveedorID > 0")
    End Function

    Public Function existe() As Boolean
        Return BasesParaCompatibilidad.BD.ConsultaVer("Count(*)", "TipoProv_Proveedor", "ProveedorID = " & Convert.ToString(ProveedorID) & " and TipoProveedorID = " & Convert.ToString(TipoProveedorID)).Rows(0).Item(0) > 0
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar(Convert.ToString(ProveedorID) & "," & Convert.ToString(TipoProveedorID), "TipoProv_Proveedor")
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaEliminar("TipoProv_Proveedor", "ProveedorID = " & Convert.ToString(ProveedorID) & " and TipoProveedorID = " & Convert.ToString(TipoProveedorID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
