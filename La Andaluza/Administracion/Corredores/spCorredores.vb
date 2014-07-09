Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spCorredores
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[CorredoresSelect]", _
                      "[dbo].[CorredoresInsert]", _
                      "[dbo].[CorredoresUpdate]", _
                      "[dbo].[CorredoresDelete]", _
                      "[dbo].[CorredoresSelectDgv]", _
                      "[dbo].[CorredoresSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal CorredorID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Corredores
       Dim dbo As New DBO_Corredores
       dbo.searchKey = dbo.item("CorredorID")
       dbo.searchKey.value = CorredorID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal CorredorID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Corredores
       dbo.searchKey = dbo.item("CorredorID")
       dbo.searchKey.value = CorredorID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_Corredores(ByRef cbo As ComboBox)
       cbo.mam_DataSource("CorredoresCbo", False)
   End Sub

End Class
