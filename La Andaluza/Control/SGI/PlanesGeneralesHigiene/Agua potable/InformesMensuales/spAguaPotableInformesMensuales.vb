

Public Class spAguaPotableInformesMensuales
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AguaPotableInformesMensualesSelect]",  _
                     "[dbo].[AguaPotableInformesMensualesInsert]",  _
                     "[dbo].[AguaPotableInformesMensualesUpdate]",  _
                     "[dbo].[AguaPotableInformesMensualesDelete]",  _
                     "[dbo].[AguaPotableInformesMensualesSelectDgv]",  _
                     "[dbo].[AguaPotableInformesMensualesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal InformeMensualID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AguaPotableInformesMensuales
        Dim dbo As New DBO_AguaPotableInformesMensuales
        dbo.searchKey = dbo.item("InformeMensualID")
        dbo.searchKey.value = InformeMensualID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal InformeMensualID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_AguaPotableInformesMensuales
        dbo.searchKey = dbo.item("InformeMensualID")
        dbo.searchKey.value = InformeMensualID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
