Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPoblaciones
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PoblacionesSelect]", "[dbo].[PoblacionesInsert]", "[dbo].[PoblacionesUpdate]", "[dbo].[PoblacionesDelete]", "[dbo].[PoblacionesSelectDgv]", "[dbo].[PoblacionesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Poblaciones
        Dim dbo As New DBO_Poblaciones
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Poblaciones
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByVal idProvincia As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PoblacionesCboByProvincia " & idProvincia, False, dtb)
    End Sub

End Class
