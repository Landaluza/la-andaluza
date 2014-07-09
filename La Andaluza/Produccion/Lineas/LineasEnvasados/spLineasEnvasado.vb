Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spLineasEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[LineasEnvasadoSelect]",  _
                     "[dbo].[LineasEnvasadoInsert]",  _
                     "[dbo].[LineasEnvasadoUpdate]",  _
                     "[dbo].[LineasEnvasadoDelete]",  _
                     "[dbo].[LineasEnvasadoSelectDgv]",  _
                     "[dbo].[LineasEnvasadoSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal LineaEnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_LineasEnvasado
       Dim dbo As New DBO_LineasEnvasado
       dbo.searchKey = dbo.item("LineaEnvasadoID")
       dbo.searchKey.value = LineaEnvasadoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal LineaEnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_LineasEnvasado
       dbo.searchKey = dbo.item("LineaEnvasadoID")
       dbo.searchKey.value = LineaEnvasadoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_LineasEnvasado(ByRef cbo As ComboBox)
       cbo.mam_DataSource("LineasEnvasadoCbo", False)
   End Sub

    Public Function devolver_LineasEnvasado() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("LineasEnvasadoCbo", True)
    End Function
End Class
