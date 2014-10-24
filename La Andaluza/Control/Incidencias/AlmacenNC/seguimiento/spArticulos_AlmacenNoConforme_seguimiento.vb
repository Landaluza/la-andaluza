

Public Class spArticulos_AlmacenNoConforme_seguimiento
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[Articulos_AlmacenNoConforme_seguimientoSelect]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_seguimientoInsert]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_seguimientoUpdate]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_seguimientoDelete]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_seguimientoSelectDgv]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_seguimientoSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Articulos_AlmacenNoConforme_seguimiento
        Dim dbo As New DBO_Articulos_AlmacenNoConforme_seguimiento
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Articulos_AlmacenNoConforme_seguimiento
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
