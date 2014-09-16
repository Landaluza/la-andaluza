Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spTiposDepositos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposDepositosSelect]",  _
                     "[dbo].[TiposDepositosInsert]",  _
                     "[dbo].[TiposDepositosUpdate]",  _
                     "[dbo].[TiposDepositosDelete]",  _
                     "[dbo].[TiposDepositosSelectDgv]",  _
                     "[dbo].[TiposDepositosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposDepositos
       Dim dbo As New DBO_TiposDepositos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposDepositos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

   Public Sub cargar_TiposDepositos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposDepositosCbo", False)
   End Sub

End Class
