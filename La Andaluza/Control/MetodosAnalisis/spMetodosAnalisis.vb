Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMetodosAnalisis
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MetodosAnalisisSelect]",  _
                     "[dbo].[MetodosAnalisisInsert]",  _
                     "[dbo].[MetodosAnalisisUpdate]",  _
                     "[dbo].[MetodosAnalisisDelete]",  _
                     "[dbo].[MetodosAnalisisSelectDgv]",  _
                     "[dbo].[MetodosAnalisisSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal MetodoAnalisisID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_MetodosAnalisis
       Dim dbo As New DBO_MetodosAnalisis
       dbo.searchKey = dbo.item("MetodoAnalisisID")
       dbo.searchKey.value = MetodoAnalisisID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal MetodoAnalisisID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_MetodosAnalisis
       dbo.searchKey = dbo.item("MetodoAnalisisID")
       dbo.searchKey.value = MetodoAnalisisID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_MetodosAnalisis(ByRef cbo As ComboBox)
       cbo.mam_DataSource("MetodosAnalisisCbo", False)
   End Sub

    Public Function devolverMetodosAnalisis() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("MetodosAnalisisCbo", True)
    End Function

End Class
