Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spFacturas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FacturasSelect]",  _
                     "[dbo].[FacturasInsert]",  _
                     "[dbo].[FacturasUpdate]",  _
                     "[dbo].[FacturasDelete]",  _
                     "[dbo].[FacturasSelectDgv]",  _
                     "[dbo].[FacturasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Facturas
       Dim dbo As New DBO_Facturas
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Facturas
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_Facturas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("FacturasCbo", False)
   End Sub

End Class
