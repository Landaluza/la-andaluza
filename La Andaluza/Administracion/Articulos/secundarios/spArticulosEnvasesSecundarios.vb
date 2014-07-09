
Public Class spArticulosEnvasesSecundarios
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ArticulosEnvasesSecundariosSelect]", _
                      "[dbo].[ArticulosEnvasesSecundariosInsert]", _
                      "[dbo].[ArticulosEnvasesSecundariosUpdate]", _
                      "[dbo].[ArticulosEnvasesSecundariosDelete]", _
                      "[dbo].[ArticulosEnvasesSecundariosSelectDgv]", _
                      "[dbo].[ArticulosEnvasesSecundariosSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal EnvaseSecundarioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ArticulosEnvasesSecundarios
       Dim dbo As New DBO_ArticulosEnvasesSecundarios
       dbo.searchKey = dbo.item("EnvaseSecundarioID")
       dbo.searchKey.value = EnvaseSecundarioID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal EnvaseSecundarioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ArticulosEnvasesSecundarios
       dbo.searchKey = dbo.item("EnvaseSecundarioID")
       dbo.searchKey.value = EnvaseSecundarioID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

    Public Function Select_RecordByArticuloID(ByVal articuloid As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ArticulosEnvasesSecundarios
        Dim dbo As New DBO_ArticulosEnvasesSecundarios
        dbo.searchKey = dbo.item("ArticuloID")
        dbo.searchKey.value = articuloid
        MyBase.Select_proc(CType(dbo, BasesParaCompatibilidad.databussines), "ArticulosEnvasesSecundariosSelectByArticuloID", trans)
        Return dbo
    End Function

    Public Function actualizarReferenciaSecundario(secundario As Integer, terciario As Integer) As Boolean
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim migrateeProcedure As String = "[dbo].[ArticulosEnvasesSecundariosMigrarReferenciasTerciarios]"
        Dim migrateCommand As New System.Data.SqlClient.SqlCommand(migrateeProcedure, connection)
        Try
            migrateCommand.Transaction = BasesParaCompatibilidad.BD.transaction
            migrateCommand.CommandType = CommandType.StoredProcedure
            migrateCommand.Parameters.AddWithValue("@artSecundario", secundario)
            migrateCommand.Parameters.AddWithValue("@artTerciario", terciario)

            migrateCommand.ExecuteNonQuery()

            BasesParaCompatibilidad.BD.TerminarTransaccion()
            Return True
        Catch ex As Exception
            BasesParaCompatibilidad.BD.CancelarTransaccion()
            Return False
        End Try
    End Function
End Class
