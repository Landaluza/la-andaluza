Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spTiposConceptos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposConceptosSelect]",  _
                     "[dbo].[TiposConceptosInsert]",  _
                     "[dbo].[TiposConceptosUpdate]",  _
                     "[dbo].[TiposConceptosDelete]",  _
                     "[dbo].[TiposConceptosSelectDgv]",  _
                     "[dbo].[TiposConceptosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposConceptos
        Dim dbo As New DBO_TiposConceptos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposConceptos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

    Public Sub cargar_TiposConceptos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposConceptosCbo", False, dtb)
    End Sub

End Class
