Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spPaletsEstados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PaletsEstadosSelect]",  _
                     "[dbo].[PaletsEstadosInsert]",  _
                     "[dbo].[PaletsEstadosUpdate]",  _
                     "[dbo].[PaletsEstadosDelete]",  _
                     "[dbo].[PaletsEstadosSelectDgv]",  _
                     "[dbo].[PaletsEstadosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsEstados
        Dim dbo As New DBO_PaletsEstados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_PaletsEstados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_PaletsEstados(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PaletsEstadosCbo", False, dtb)
    End Sub

End Class
