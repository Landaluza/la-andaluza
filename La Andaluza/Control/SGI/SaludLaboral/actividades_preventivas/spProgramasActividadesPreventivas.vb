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

   Public Overloads Function Select_Record(ByVal ProgramaActividadPreventivaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ProgramasActividadesPreventivas
       Dim dbo As New DBO_ProgramasActividadesPreventivas
       dbo.searchKey = dbo.item("ProgramaActividadPreventivaID")
       dbo.searchKey.value = ProgramaActividadPreventivaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ProgramaActividadPreventivaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ProgramasActividadesPreventivas
       dbo.searchKey = dbo.item("ProgramaActividadPreventivaID")
       dbo.searchKey.value = ProgramaActividadPreventivaID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Sub cargar_ProgramasActividadesPreventivas(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource(dtb.Consultar("[ProgramasActividadesPreventivasSelectCbo]"), False)
    End Sub

End Class
