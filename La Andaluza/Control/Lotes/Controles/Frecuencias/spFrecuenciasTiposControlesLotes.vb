Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spFrecuenciasTiposControlesLotes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FrecuenciasTiposControlesLotesSelect]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesInsert]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesUpdate]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesDelete]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesSelectDgv]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_FrecuenciasTiposControlesLotes
        Dim dbo As New DBO_FrecuenciasTiposControlesLotes
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_FrecuenciasTiposControlesLotes
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_FrecuenciasTiposControlesLotes(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("FrecuenciasTiposControlesLotesCbo", False, dtb)
    End Sub

End Class
