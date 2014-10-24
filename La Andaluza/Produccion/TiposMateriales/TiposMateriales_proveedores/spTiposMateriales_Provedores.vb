

Public Class spTiposMateriales_Provedores
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposMateriales_ProvedoresSelect]",  _
                     "[dbo].[TiposMateriales_ProvedoresInsert]",  _
                     "[dbo].[TiposMateriales_ProvedoresUpdate]",  _
                     "[dbo].[TiposMateriales_ProvedoresDelete]",  _
                     "[dbo].[TiposMateriales_ProvedoresSelectDgv]",  _
                     "[dbo].[TiposMateriales_ProvedoresSelectDgvBy]")
    End Sub

    Public Sub New(stub As Boolean)
        MyBase.New("[dbo].[TiposMateriales_ProvedoresSelect]", _
                     "[dbo].[TiposMateriales_ProvedoresInsert]", _
                     "[dbo].[TiposMateriales_ProvedoresUpdate]", _
                     "[dbo].[TiposMateriales_ProvedoresDelete]", _
                     "[dbo].[TiposMateriales_ProvedoresSelectDgv]", _
                     "[dbo].[TiposMateriales_ProvedoresSelectDgvByProveedor]")
    End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposMateriales_Provedores
        Dim dbo As New DBO_TiposMateriales_Provedores
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposMateriales_Provedores
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
