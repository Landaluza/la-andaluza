

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

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ControlIncidencias
       Dim dbo As New DBO_ControlIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ControlIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id

        If trans Is Nothing Then BasesParaCompatibilidad.BD.EmpezarTransaccion()

        If MyBase.DeleteProcedure(dbo, trans) Then
            If trans Is Nothing Then BasesParaCompatibilidad.BD.TerminarTransaccion()
            Return True
        Else
            If trans Is Nothing Then BasesParaCompatibilidad.BD.CancelarTransaccion()
            Return False
        End If
   End Function


End Class
