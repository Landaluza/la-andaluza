Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spDDDAcciones
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[DDDAccionesSelect]",  _
                     "[dbo].[DDDAccionesInsert]",  _
                     "[dbo].[DDDAccionesUpdate]",  _
                     "[dbo].[DDDAccionesDelete]",  _
                     "[dbo].[DDDAccionesSelectDgv]",  _
                     "[dbo].[DDDAccionesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal DDDAccionID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_DDDAcciones
       Dim dbo As New DBO_DDDAcciones
       dbo.searchKey = dbo.item("DDDAccionID")
       dbo.searchKey.value = DDDAccionID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal DDDAccionID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_DDDAcciones
       dbo.searchKey = dbo.item("DDDAccionID")
       dbo.searchKey.value = DDDAccionID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Sub cargar_DDDAcciones(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("[DDDAccionesCbo]", False)
    End Sub

End Class
