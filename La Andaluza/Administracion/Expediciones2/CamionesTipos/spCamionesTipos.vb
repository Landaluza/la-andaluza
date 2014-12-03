Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spCamionesTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CamionesTiposSelect]",  _
                     "[dbo].[CamionesTiposInsert]",  _
                     "[dbo].[CamionesTiposUpdate]",  _
                     "[dbo].[CamionesTiposDelete]",  _
                     "[dbo].[CamionesTiposSelectDgv]",  _
                     "[dbo].[CamionesTiposSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal CamionTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CamionesTipos
        Dim dbo As New DBO_CamionesTipos
        dbo.searchKey = dbo.item("CamionTipoID")
        dbo.searchKey.value = CamionTipoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal CamionTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_CamionesTipos
        dbo.searchKey = dbo.item("CamionTipoID")
        dbo.searchKey.value = CamionTipoID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_CamionesTipos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("CamionesTiposCbo", False, dtb)
    End Sub

End Class
