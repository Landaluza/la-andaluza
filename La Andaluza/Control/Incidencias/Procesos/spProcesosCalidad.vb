Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spProcesosCalidad
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProcesosCalidadSelect]",  _
                     "[dbo].[ProcesosCalidadInsert]",  _
                     "[dbo].[ProcesosCalidadUpdate]",  _
                     "[dbo].[ProcesosCalidadDelete]",  _
                     "[dbo].[ProcesosCalidadSelectDgv]",  _
                     "[dbo].[ProcesosCalidadSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ProcesosCalidad
        Dim dbo As New DBO_ProcesosCalidad
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ProcesosCalidad
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ProcesosCalidad(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ProcesosCalidadCbo", False, dtb)
    End Sub

End Class
