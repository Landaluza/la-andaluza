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

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Medicos
       Dim dbo As New DBO_Medicos
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Medicos
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_Medicos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("MedicosCbo", False)
   End Sub

End Class
