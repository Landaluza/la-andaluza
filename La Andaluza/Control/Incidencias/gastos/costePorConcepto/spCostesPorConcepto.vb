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

    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CostesPorConcepto
        Dim dbo As New DBO_CostesPorConcepto
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_CostesPorConcepto
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

    Public Sub cargar_CostesPorConcepto(ByRef cbo As ComboBox, id_concepto As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select id, Coste from CostesPorConcepto where Id_ConceptosGastosIncidencias = @id")
        dtb.AñadirParametroConsulta("@id", id_concepto)
        Dim dt As DataTable = dtb.Consultar()

        cbo.mam_DataSource(dt, False)
    End Sub

    Public Function cargar_CostesPorConceptoActual(ByVal id_concepto As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataRow
        dtb.PrepararConsulta("select top 1 id, coste from costesporconcepto where id_ConceptosGastosIncidencias = @id order by fecha desc")
        dtb.AñadirParametroConsulta("@id", id_concepto)
        Dim dt As DataTable = dtb.Consultar()

        Return dt.Rows(0)
    End Function
End Class
