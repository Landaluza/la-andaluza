

Public Class spControlIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlIncidenciasSelect]",  _
                     "[dbo].[ControlIncidenciasInsert]",  _
                     "[dbo].[ControlIncidenciasUpdate]",  _
                     "[dbo].[ControlIncidenciasDelete]",  _
                     "[dbo].[ControlIncidenciasSelectDgv]",  _
                     "[dbo].[ControlIncidenciasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ControlIncidencias
        Dim dbo As New DBO_ControlIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ControlIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Dim terminar As Boolean

        If dtb.Transaccion Is Nothing Then
            dtb.EmpezarTransaccion()
            terminar = True
        Else
            terminar = False
        End If

        If MyBase.DeleteProcedure(dbo, dtb) Then
            If terminar Then dtb.TerminarTransaccion()
            Return True
        Else
            If terminar Then dtb.CancelarTransaccion()
            Return False
        End If
    End Function


End Class
