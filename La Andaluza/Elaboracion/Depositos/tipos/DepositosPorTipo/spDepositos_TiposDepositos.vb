
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

    Public ReadOnly Property SelectDgvByDeposito As String
        Get
            Return "[dbo].[Depositos_TiposDepositosSelectDgvByDeposito]"
        End Get
    End Property
    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Depositos_TiposDepositos
        Dim dbo As New DBO_Depositos_TiposDepositos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Depositos_TiposDepositos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

End Class
