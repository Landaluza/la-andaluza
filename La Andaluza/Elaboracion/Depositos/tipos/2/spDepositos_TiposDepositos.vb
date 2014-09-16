
Public Class spDepositos_TiposDepositos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[Depositos_TiposDepositosSelect]",  _
                     "[dbo].[Depositos_TiposDepositosInsert]",  _
                     "[dbo].[Depositos_TiposDepositosUpdate]",  _
                     "[dbo].[Depositos_TiposDepositosDelete]",  _
                     "[dbo].[Depositos_TiposDepositosSelectDgv]",  _
                     "[dbo].[Depositos_TiposDepositosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Depositos_TiposDepositos
       Dim dbo As New DBO_Depositos_TiposDepositos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Depositos_TiposDepositos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

End Class
