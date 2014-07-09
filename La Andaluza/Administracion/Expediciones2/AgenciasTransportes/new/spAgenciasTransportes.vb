Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spAgenciasTransportes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[AgenciasTransportesSelect]", _
                      "[dbo].[AgenciasTransportesInsert]", _
                      "[dbo].[AgenciasTransportesUpdate]", _
                      "[dbo].[AgenciasTransportesDelete]", _
                      "[dbo].[AgenciasTransportesSelectDgv]", _
                      "[dbo].[AgenciasTransportesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal AgenciaTransporteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_AgenciasTransportes
       Dim dbo As New DBO_AgenciasTransportes
       dbo.searchKey = dbo.item("AgenciaTransporteID")
       dbo.searchKey.value = AgenciaTransporteID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal AgenciaTransporteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_AgenciasTransportes
       dbo.searchKey = dbo.item("AgenciaTransporteID")
       dbo.searchKey.value = AgenciaTransporteID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_AgenciasTransportes(ByRef cbo As ComboBox)
       cbo.mam_DataSource("AgenciasTransportesCbo", False)
   End Sub

End Class
