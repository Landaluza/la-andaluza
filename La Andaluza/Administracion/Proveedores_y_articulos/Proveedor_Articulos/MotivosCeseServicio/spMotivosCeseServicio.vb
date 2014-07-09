Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMotivosCeseServicio
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[MotivosCeseServicioSelect]", _
                      "[dbo].[MotivosCeseServicioInsert]", _
                      "[dbo].[MotivosCeseServicioUpdate]", _
                      "[dbo].[MotivosCeseServicioDelete]", _
                      "[dbo].[MotivosCeseServicioSelectDgv]", _
                      "[dbo].[MotivosCeseServicioSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal MotivoCeseServicioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_MotivosCeseServicio
       Dim dbo As New DBO_MotivosCeseServicio
       dbo.searchKey = dbo.item("MotivoCeseServicioID")
       dbo.searchKey.value = MotivoCeseServicioID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal MotivoCeseServicioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_MotivosCeseServicio
       dbo.searchKey = dbo.item("MotivoCeseServicioID")
       dbo.searchKey.value = MotivoCeseServicioID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_MotivosCeseServicio(ByRef cbo As ComboBox)
       cbo.mam_DataSource("MotivosCeseServicioCbo", False)
   End Sub

End Class
