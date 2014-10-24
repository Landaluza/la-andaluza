Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPersonalCompetencias
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PersonalCompetenciasSelect]", _
                      "[dbo].[PersonalCompetenciasInsert]", _
                      "[dbo].[PersonalCompetenciasUpdate]", _
                      "[dbo].[PersonalCompetenciasDelete]", _
                      "[dbo].[PersonalCompetenciasSelectDgv]", _
                      "[dbo].[PersonalCompetenciasSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal PersonalCompetenciaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PersonalCompetencias
        Dim dbo As New DBO_PersonalCompetencias
        dbo.searchKey = dbo.item("PersonalCompetenciaID")
        dbo.searchKey.value = PersonalCompetenciaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PersonalCompetenciaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_PersonalCompetencias
        dbo.searchKey = dbo.item("PersonalCompetenciaID")
        dbo.searchKey.value = PersonalCompetenciaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_PersonalCompetencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PersonalCompetenciasCbo", False, dtb)
    End Sub

End Class
