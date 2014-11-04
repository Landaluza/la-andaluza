Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spProgramasActividadesPreventivas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProgramasActividadesPreventivasSelect]",  _
                     "[dbo].[ProgramasActividadesPreventivasInsert]",  _
                     "[dbo].[ProgramasActividadesPreventivasUpdate]",  _
                     "[dbo].[ProgramasActividadesPreventivasDelete]",  _
                     "[dbo].[ProgramasActividadesPreventivasSelectDgv]",  _
                     "[dbo].[ProgramasActividadesPreventivasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal ProgramaActividadPreventivaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ProgramasActividadesPreventivas
        Dim dbo As New DBO_ProgramasActividadesPreventivas
        dbo.searchKey = dbo.item("ProgramaActividadPreventivaID")
        dbo.searchKey.value = ProgramaActividadPreventivaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ProgramaActividadPreventivaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ProgramasActividadesPreventivas
        dbo.searchKey = dbo.item("ProgramaActividadPreventivaID")
        dbo.searchKey.value = ProgramaActividadPreventivaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_ProgramasActividadesPreventivas(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("[ProgramasActividadesPreventivasSelectCbo]")
        comboBox.mam_DataSource(dtb.Consultar(), False)
    End Sub

End Class
