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

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ProcesosCalidad
       Dim dbo As New DBO_ProcesosCalidad
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ProcesosCalidad
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_ProcesosCalidad(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ProcesosCalidadCbo", False)
   End Sub

End Class
