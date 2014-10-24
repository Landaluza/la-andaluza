Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spIncidenciasCalidadGeneral
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[IncidenciasCalidadGeneralSelect]",  _
                     "[dbo].[IncidenciasCalidadGeneralInsert]",  _
                     "[dbo].[IncidenciasCalidadGeneralUpdate]",  _
                     "[dbo].[IncidenciasCalidadGeneralDelete]",  _
                     "[dbo].[IncidenciasCalidadGeneralSelectDgv]",  _
                     "[dbo].[IncidenciasCalidadGeneralSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_IncidenciasCalidadGeneral
        Dim dbo As New DBO_IncidenciasCalidadGeneral
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim terminar As Boolean
        If dtb.Transaccion Is Nothing Then
            dtb.EmpezarTransaccion()
            terminar = True
        Else
            terminar = False
        End If
        Dim dbo As New DBO_IncidenciasCalidadGeneral
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id

        If MyBase.DeleteProcedure(dbo, dtb) Then
            If terminar Then dtb.TerminarTransaccion()
            Return True
        Else
            If terminar Then dtb.CancelarTransaccion()
            Return False
        End If
    End Function

    Public Sub cargar_IncidenciasCalidadGeneral(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("IncidenciasCalidadGeneralCbo", False, dtb)
    End Sub

End Class
