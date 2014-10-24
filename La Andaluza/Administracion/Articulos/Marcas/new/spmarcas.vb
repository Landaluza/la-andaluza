Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spmarcas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[marcasSelect]", _
                      "[dbo].[marcasInsert]", _
                      "[dbo].[marcasUpdate]", _
                      "[dbo].[marcasDelete]", _
                      "[dbo].[marcasSelectDgv]", _
                      "[dbo].[marcasSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_marcas
        Dim dbo As New DBO_marcas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_marcas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.DataBussines), dtb)
    End Function

    Public Sub cargar_marcas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("marcasCbo", False, dtb)
    End Sub

End Class
