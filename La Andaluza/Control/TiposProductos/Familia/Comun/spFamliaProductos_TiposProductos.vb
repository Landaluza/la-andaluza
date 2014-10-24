
Public Class spFamliaProductos_TiposProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FamliaProductos_TiposProductosSelect]",  _
                     "[dbo].[FamliaProductos_TiposProductosInsert]",  _
                     "[dbo].[FamliaProductos_TiposProductosUpdate]",  _
                     "[dbo].[FamliaProductos_TiposProductosDelete]",  _
                     "[dbo].[FamliaProductos_TiposProductosSelectDgv]",  _
                     "[dbo].[FamliaProductos_TiposProductosSelectDgvBy]")
    End Sub

        Public ReadOnly Property SelectDgvByFamilia As String
        Get
            Return "FamliaProductos_TiposProductosSelectDgvByFamilia"
        End Get
    End Property

    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_FamliaProductos_TiposProductos
        Dim dbo As New DBO_FamliaProductos_TiposProductos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_FamliaProductos_TiposProductos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

End Class
