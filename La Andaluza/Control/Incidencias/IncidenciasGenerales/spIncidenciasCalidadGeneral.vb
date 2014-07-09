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

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_IncidenciasCalidadGeneral
       Dim dbo As New DBO_IncidenciasCalidadGeneral
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        If trans Is Nothing Then BasesParaCompatibilidad.BD.EmpezarTransaccion()
        Dim dbo As New DBO_IncidenciasCalidadGeneral
       dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id

        If MyBase.DeleteProcedure(dbo, trans) Then
            If trans Is Nothing Then BasesParaCompatibilidad.BD.TerminarTransaccion()
            Return True
        Else
            If trans Is Nothing Then BasesParaCompatibilidad.BD.CancelarTransaccion()
            Return False
        End If
   End Function

   Public Sub cargar_IncidenciasCalidadGeneral(ByRef cbo As ComboBox)
       cbo.mam_DataSource("IncidenciasCalidadGeneralCbo", False)
   End Sub

End Class
