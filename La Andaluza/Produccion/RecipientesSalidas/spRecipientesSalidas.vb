Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spRecipientesSalidas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[RecipientesSalidasSelect]",  _
                     "[dbo].[RecipientesSalidasInsert]",  _
                     "[dbo].[RecipientesSalidasUpdate]",  _
                     "[dbo].[RecipientesSalidasDelete]",  _
                     "[dbo].[RecipientesSalidasSelectDgv]",  _
                     "[dbo].[RecipientesSalidasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal RecipienteSalidaID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_RecipientesSalidas
        Dim dbo As New DBO_RecipientesSalidas
        dbo.searchKey = dbo.item("RecipienteSalidaID")
        dbo.searchKey.value = RecipienteSalidaID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal RecipienteSalidaID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_RecipientesSalidas
        dbo.searchKey = dbo.item("RecipienteSalidaID")
        dbo.searchKey.value = RecipienteSalidaID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

    Public Sub cargar_RecipientesSalidas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("RecipientesSalidasCbo", False, dtb)
    End Sub

End Class
