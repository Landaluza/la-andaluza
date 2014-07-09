Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[IncidenciasSelect]",  _
                     "[dbo].[IncidenciasInsert]",  _
                     "[dbo].[IncidenciasUpdate]",  _
                     "[dbo].[IncidenciasDelete]",  _
                     "[dbo].[IncidenciasSelectDgv]",  _
                     "[dbo].[IncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal IncidenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Incidencias
       Dim dbo As New DBO_Incidencias
       dbo.searchKey = dbo.item("IncidenciaID")
       dbo.searchKey.value = IncidenciaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal IncidenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Incidencias
       dbo.searchKey = dbo.item("IncidenciaID")
        dbo.searchKey.value = IncidenciaID
        If trans Is Nothing Then BasesParaCompatibilidad.BD.EmpezarTransaccion()
        Try
            If MyBase.DeleteProcedure(dbo, if(trans Is Nothing, BasesParaCompatibilidad.BD.transaction, trans)) Then
                If trans Is Nothing Then BasesParaCompatibilidad.BD.TerminarTransaccion()
                Return True
            Else
                If trans Is Nothing Then BasesParaCompatibilidad.BD.CancelarTransaccion()
                Return False
            End If
        Catch ex As Exception
            If trans Is Nothing Then BasesParaCompatibilidad.BD.CancelarTransaccion()
            Return False
        End Try

   End Function

   Public Sub cargar_Incidencias(ByRef cbo As ComboBox)
       cbo.mam_DataSource("IncidenciasCbo", False)
   End Sub

    Public Function selecccionar_ultima_incidencia(Optional ByRef Cnx As SqlClient.SqlConnection = Nothing, Optional ByRef trans As SqlClient.SqlTransaction = Nothing) As Integer
        Dim dtb As BasesParaCompatibilidad.DataBase

        If Cnx Is Nothing Then
            dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Else
            dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server, Cnx, trans)
        End If

        Return dtb.Consultar("select max(incidenciaid) from incidencias", False).Rows(0).Item(0)
    End Function
End Class
