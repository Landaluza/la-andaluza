Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spDDDPlanes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[DDDPlanesSelect]",  _
                     "[dbo].[DDDPlanesInsert]",  _
                     "[dbo].[DDDPlanesUpdate]",  _
                     "[dbo].[DDDPlanesDelete]",  _
                     "[dbo].[DDDPlanesSelectDgv]",  _
                     "[dbo].[DDDPlanesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal DDDPlanID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_DDDPlanes
        Dim dbo As New DBO_DDDPlanes
        dbo.searchKey = dbo.item("DDDPlanID")
        dbo.searchKey.value = DDDPlanID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal DDDPlanID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_DDDPlanes
        dbo.searchKey = dbo.item("DDDPlanID")
        dbo.searchKey.value = DDDPlanID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_DDDPlanes(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("[DDDPlanesCbo]", False, dtb)
    End Sub

End Class
