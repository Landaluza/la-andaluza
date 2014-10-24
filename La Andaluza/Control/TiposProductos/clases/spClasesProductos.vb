Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spClasesProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ClasesProductosSelect]",  _
                     "[dbo].[ClasesProductosInsert]",  _
                     "[dbo].[ClasesProductosUpdate]",  _
                     "[dbo].[ClasesProductosDelete]",  _
                     "[dbo].[ClasesProductosSelectDgv]",  _
                     "[dbo].[ClasesProductosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ClasesProductos
        Dim dbo As New DBO_ClasesProductos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ClasesProductos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

    Public Sub cargar_ClasesProductos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ClasesProductosCbo", False, dtb)
    End Sub

End Class
