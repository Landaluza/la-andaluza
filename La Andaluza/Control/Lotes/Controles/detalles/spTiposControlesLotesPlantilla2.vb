
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

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposControlesLotesPlantilla2
        Dim dbo As New DBO_TiposControlesLotesPlantilla2
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposControlesLotesPlantilla2
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
