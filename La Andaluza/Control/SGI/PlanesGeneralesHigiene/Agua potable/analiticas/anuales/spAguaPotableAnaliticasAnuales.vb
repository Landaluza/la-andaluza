

Public Class spAguaPotableAnaliticasAnuales
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AguaPotableAnaliticasAnualesSelect]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesInsert]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesUpdate]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesDelete]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesSelectDgv]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal AnaliticaAnualID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AguaPotableAnaliticasAnuales
        Dim dbo As New DBO_AguaPotableAnaliticasAnuales
        dbo.searchKey = dbo.item("AnaliticaAnualID")
        dbo.searchKey.value = AnaliticaAnualID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal AnaliticaAnualID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_AguaPotableAnaliticasAnuales
        dbo.searchKey = dbo.item("AnaliticaAnualID")
        dbo.searchKey.value = AnaliticaAnualID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
