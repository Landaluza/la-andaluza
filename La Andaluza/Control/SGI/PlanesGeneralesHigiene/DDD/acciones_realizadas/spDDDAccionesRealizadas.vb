

Public Class spDDDAccionesRealizadas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[DDDAccionesRealizadasSelect]",  _
                     "[dbo].[DDDAccionesRealizadasInsert]",  _
                     "[dbo].[DDDAccionesRealizadasUpdate]",  _
                     "[dbo].[DDDAccionesRealizadasDelete]",  _
                     "[dbo].[DDDAccionesRealizadasSelectDgv]",  _
                     "[dbo].[DDDAccionesRealizadasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal DDDAccionRealizadaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_DDDAccionesRealizadas
        Dim dbo As New DBO_DDDAccionesRealizadas
        dbo.searchKey = dbo.item("DDDAccionRealizadaID")
        dbo.searchKey.value = DDDAccionRealizadaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal DDDAccionRealizadaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_DDDAccionesRealizadas
        dbo.searchKey = dbo.item("DDDAccionRealizadaID")
        dbo.searchKey.value = DDDAccionRealizadaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
