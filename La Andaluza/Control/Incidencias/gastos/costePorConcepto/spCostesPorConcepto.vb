Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spCostesPorConcepto
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CostesPorConceptoSelect]",  _
                     "[dbo].[CostesPorConceptoInsert]",  _
                     "[dbo].[CostesPorConceptoUpdate]",  _
                     "[dbo].[CostesPorConceptoDelete]",  _
                     "[dbo].[CostesPorConceptoSelectDgv]",  _
                     "[dbo].[CostesPorConceptoSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_CostesPorConcepto
       Dim dbo As New DBO_CostesPorConcepto
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_CostesPorConcepto
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

    Public Sub cargar_CostesPorConcepto(ByRef cbo As ComboBox, id_concepto As Integer)
        Dim dt As DataTable = dtb.Consultar("select id, Coste from CostesPorConcepto where Id_ConceptosGastosIncidencias = " & id_concepto, False)
        cbo.mam_DataSource(dt, False)
    End Sub

    Public Function cargar_CostesPorConceptoActual(ByVal id_concepto As Integer) As DataRow
        Dim dt As DataTable = dtb.Consultar("select top 1 id, coste from costesporconcepto where id_ConceptosGastosIncidencias =" & id_concepto & " order by fecha desc", False)
        Return dt.Rows(0)
    End Function
End Class
