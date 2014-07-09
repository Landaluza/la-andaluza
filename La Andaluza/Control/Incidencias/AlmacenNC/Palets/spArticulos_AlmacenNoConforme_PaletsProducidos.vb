

Public Class spArticulos_AlmacenNoConforme_PaletsProducidos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[Articulos_AlmacenNoConforme_PaletsProducidosSelect]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_PaletsProducidosInsert]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_PaletsProducidosUpdate]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_PaletsProducidosDelete]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_PaletsProducidosSelectDgv]",  _
                     "[dbo].[Articulos_AlmacenNoConforme_PaletsProducidosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Articulos_AlmacenNoConforme_PaletsProducidos
       Dim dbo As New DBO_Articulos_AlmacenNoConforme_PaletsProducidos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Articulos_AlmacenNoConforme_PaletsProducidos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
