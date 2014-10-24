Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spIncidenciasCalidad
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[IncidenciasCalidadSelect]",  _
                     "[dbo].[IncidenciasCalidadInsert]",  _
                     "[dbo].[IncidenciasCalidadUpdate]",  _
                     "[dbo].[IncidenciasCalidadDelete]",  _
                     "[dbo].[IncidenciasCalidadSelectDgv]",  _
                     "[dbo].[IncidenciasCalidadSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal IncidenciaCalidadID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_IncidenciasCalidad
        Dim dbo As New DBO_IncidenciasCalidad
        dbo.searchKey = dbo.item("IncidenciaCalidadID")
        dbo.searchKey.value = IncidenciaCalidadID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal IncidenciaCalidadID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_IncidenciasCalidad
        dbo.searchKey = dbo.item("IncidenciaCalidadID")
        dbo.searchKey.value = IncidenciaCalidadID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_IncidenciasCalidad(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("IncidenciasCalidadCbo", False, dtb)
    End Sub

    Function Select_RecordByIncidenciaID(ByVal incidenciaID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_IncidenciasCalidad
        Dim dbo As New DBO_IncidenciasCalidad
        dbo.searchKey = dbo.item("IncidenciaID")
        dbo.searchKey.value = incidenciaID
        MyBase.Select_proc(dbo, "IncidenciasCalidadSelectByIncidenciaId", dtb)
        Return dbo
    End Function

End Class
