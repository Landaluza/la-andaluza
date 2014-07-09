Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spConductores
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ConductoresSelect]", _
                      "[dbo].[ConductoresInsert]", _
                      "[dbo].[ConductoresUpdate]", _
                      "[dbo].[ConductoresDelete]", _
                      "[dbo].[ConductoresSelectDgv]", _
                      "[dbo].[ConductoresSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal ConductorID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Conductores
       Dim dbo As New DBO_Conductores
       dbo.searchKey = dbo.item("ConductorID")
       dbo.searchKey.value = ConductorID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ConductorID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Conductores
       dbo.searchKey = dbo.item("ConductorID")
       dbo.searchKey.value = ConductorID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_Conductores(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ConductoresCbo", False)
   End Sub

End Class
