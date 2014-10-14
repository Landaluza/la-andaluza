

Public Class spEnvasados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
        MyBase.New("[dbo].[EnvasadosSelect]", _
                     "[dbo].[EnvasadosInsert]", _
                     "[dbo].[EnvasadosUpdate]", _
                     "[dbo].[EnvasadosDelete]", _
                     "[dbo].[EnvasadosSelectDgv]", _
                     "[dbo].[EnvasadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal EnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Envasados
       Dim dbo As New DBO_Envasados
       dbo.searchKey = dbo.item("EnvasadoID")
       dbo.searchKey.value = EnvasadoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal EnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Envasados
       dbo.searchKey = dbo.item("EnvasadoID")
       dbo.searchKey.value = EnvasadoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Function recuperarEnvasadoDiario() As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("envasados_comprobar_envasado_diario", True).Rows(0).Item(0)
    End Function

End Class
