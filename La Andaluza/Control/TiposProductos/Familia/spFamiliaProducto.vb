Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spFamiliaProducto
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FamiliaProductoSelect]",  _
                     "[dbo].[FamiliaProductoInsert]",  _
                     "[dbo].[FamiliaProductoUpdate]",  _
                     "[dbo].[FamiliaProductoDelete]",  _
                     "[dbo].[FamiliaProductoSelectDgv]",  _
                     "[dbo].[FamiliaProductoSelectDgvBy]")
   End Sub

  
    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_FamiliaProducto
        Dim dbo As New DBO_FamiliaProducto
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_FamiliaProducto
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

    Public Sub cargar_FamiliaProducto(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("FamiliaProductoCbo", False, dtb)
    End Sub

End Class
