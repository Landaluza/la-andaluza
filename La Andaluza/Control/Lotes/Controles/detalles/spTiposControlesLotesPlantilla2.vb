
Public Class spTiposControlesLotesPlantilla2
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposControlesLotesPlantilla2Select]",  _
                     "[dbo].[TiposControlesLotesPlantilla2Insert]",  _
                     "[dbo].[TiposControlesLotesPlantilla2Update]",  _
                     "[dbo].[TiposControlesLotesPlantilla2Delete]",  _
                     "[dbo].[TiposControlesLotesPlantilla2SelectDgv]",  _
                     "[dbo].[TiposControlesLotesPlantilla2SelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposControlesLotesPlantilla2
       Dim dbo As New DBO_TiposControlesLotesPlantilla2
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposControlesLotesPlantilla2
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
