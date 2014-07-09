Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMuestrasMedidas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MuestrasMedidasSelect]",  _
                     "[dbo].[MuestrasMedidasInsert]",  _
                     "[dbo].[MuestrasMedidasUpdate]",  _
                     "[dbo].[MuestrasMedidasDelete]",  _
                     "[dbo].[MuestrasMedidasSelectDgv]",  _
                     "[dbo].[MuestrasMedidasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal MedidaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_MuestrasMedidas
       Dim dbo As New DBO_MuestrasMedidas
       dbo.searchKey = dbo.item("MedidaID")
       dbo.searchKey.value = MedidaID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal MedidaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_MuestrasMedidas
       dbo.searchKey = dbo.item("MedidaID")
       dbo.searchKey.value = MedidaID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_MuestrasMedidas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("MuestrasMedidasCbo", False)
   End Sub

End Class
