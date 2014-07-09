Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spPiernas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PiernasSelect]",  _
                     "[dbo].[PiernasInsert]",  _
                     "[dbo].[PiernasUpdate]",  _
                     "[dbo].[PiernasDelete]",  _
                     "[dbo].[PiernasSelectDgv]",  _
                     "[dbo].[PiernasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal PiernaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Piernas
       Dim dbo As New DBO_Piernas
       dbo.searchKey = dbo.item("PiernaID")
       dbo.searchKey.value = PiernaID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PiernaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Piernas
       dbo.searchKey = dbo.item("PiernaID")
       dbo.searchKey.value = PiernaID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_Piernas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PiernasCbo", False)
   End Sub

    Public Sub cargar_PiernasPorNave(ByRef cbo As ComboBox, ByVal nave As Integer)
        cbo.mam_DataSource("PiernasCboPorNave " & nave, False)
    End Sub
End Class
