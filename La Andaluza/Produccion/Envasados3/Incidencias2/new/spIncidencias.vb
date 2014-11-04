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

    Public Overloads Function Select_Record(ByVal IncidenciaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Incidencias
        Dim dbo As New DBO_Incidencias
        dbo.searchKey = dbo.item("IncidenciaID")
        dbo.searchKey.value = IncidenciaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal IncidenciaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Incidencias
        Dim terminar As Boolean
        dbo.searchKey = dbo.item("IncidenciaID")
        dbo.searchKey.value = IncidenciaID
        If dtb.Transaccion Is Nothing Then
            dtb.EmpezarTransaccion()
            terminar = True
        Else
            terminar = False
        End If

        Try
            If MyBase.DeleteProcedure(dbo, dtb) Then
                If terminar Then dtb.TerminarTransaccion()
                Return True
            Else
                If terminar Then dtb.CancelarTransaccion()
                Return False
            End If
        Catch ex As Exception
            If terminar Then dtb.CancelarTransaccion()
            Return False
        End Try

    End Function

    Public Sub cargar_Incidencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("IncidenciasCbo", False, dtb)
    End Sub

    Public Function selecccionar_ultima_incidencia(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("select max(incidenciaid) from incidencias")
        Return dtb.Consultar().Rows(0).Item(0)
    End Function
End Class
