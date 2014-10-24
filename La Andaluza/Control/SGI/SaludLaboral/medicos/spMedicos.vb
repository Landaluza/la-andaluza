Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spMedicos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MedicosSelect]",  _
                     "[dbo].[MedicosInsert]",  _
                     "[dbo].[MedicosUpdate]",  _
                     "[dbo].[MedicosDelete]",  _
                     "[dbo].[MedicosSelectDgv]",  _
                     "[dbo].[MedicosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Medicos
        Dim dbo As New DBO_Medicos
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Medicos
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_Medicos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("MedicosCbo", False, dtb)
    End Sub

End Class
