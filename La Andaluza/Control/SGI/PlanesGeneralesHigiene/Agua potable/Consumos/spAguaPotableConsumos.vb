

Public Class spAguaPotableConsumos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AguaPotableConsumosSelect]",  _
                     "[dbo].[AguaPotableConsumosInsert]",  _
                     "[dbo].[AguaPotableConsumosUpdate]",  _
                     "[dbo].[AguaPotableConsumosDelete]",  _
                     "[dbo].[AguaPotableConsumosSelectDgv]",  _
                     "[dbo].[AguaPotableConsumosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal ConsumoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AguaPotableConsumos
        Dim dbo As New DBO_AguaPotableConsumos
        dbo.searchKey = dbo.item("ConsumoID")
        dbo.searchKey.value = ConsumoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ConsumoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_AguaPotableConsumos
        dbo.searchKey = dbo.item("ConsumoID")
        dbo.searchKey.value = ConsumoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
