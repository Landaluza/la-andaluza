Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spProcedimientos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProcedimientosSelect]",  _
                     "[dbo].[ProcedimientosInsert]",  _
                     "[dbo].[ProcedimientosUpdate]",  _
                     "[dbo].[ProcedimientosDelete]",  _
                     "[dbo].[ProcedimientosSelectDgv]",  _
                     "[dbo].[ProcedimientosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Procedimientos
       Dim dbo As New DBO_Procedimientos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Procedimientos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_Procedimientos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ProcedimientosCbo", False)
   End Sub

End Class
