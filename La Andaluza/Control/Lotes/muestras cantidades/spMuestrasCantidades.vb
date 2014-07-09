Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMuestrasCantidades
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MuestrasCantidadesSelect]",  _
                     "[dbo].[MuestrasCantidadesInsert]",  _
                     "[dbo].[MuestrasCantidadesUpdate]",  _
                     "[dbo].[MuestrasCantidadesDelete]",  _
                     "[dbo].[MuestrasCantidadesSelectDgv]",  _
                     "[dbo].[MuestrasCantidadesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal CantidadID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_MuestrasCantidades
       Dim dbo As New DBO_MuestrasCantidades
       dbo.searchKey = dbo.item("CantidadID")
       dbo.searchKey.value = CantidadID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal CantidadID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_MuestrasCantidades
       dbo.searchKey = dbo.item("CantidadID")
       dbo.searchKey.value = CantidadID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_MuestrasCantidades(ByRef cbo As ComboBox)
       cbo.mam_DataSource("MuestrasCantidadesCbo", False)
   End Sub

End Class
