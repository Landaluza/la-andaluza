Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPaletsProducidos
Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PaletsProducidos5Select]", _
                        "[dbo].[PaletsProducidosInsert]", _
                        "[dbo].[PaletsProducidosUpdate]", _
                        "[dbo].[PaletsProducidos3Delete]", _
                        "[dbo].[PaletsProducidos6SelectDgv]", _
                        "[dbo].[PaletsProducidos6SelectByFormatoEnvasadoID]")
    End Sub

    Public Overloads Function Select_Record(ByVal PaletProducidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsProducidos
        Dim dbo As New DBO_PaletsProducidos
        dbo.searchKey = dbo.item("PaletProducidoID")
        dbo.searchKey.value = PaletProducidoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PaletProducidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        'borrar contenidos

        'Dim dbo As New DBO_PaletsProducidos
        'dbo.searchKey = dbo.item("PaletProducidoID")
        'dbo.searchKey.value = PaletProducidoID
        'Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines),dtb)


        dtb.Conectar()


        Try
            Dim deleteProcedure As String = "[dbo].[PaletsProducidos2eliminarContenidoPaletsPorPalets]"
            Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Parameters.AddWithValue("@PaletID", PaletProducidoID)
            deleteCommand.Parameters.AddWithValue("@borradoCompleto", 1)
            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MessageBox.Show("Error en PaletsProducidos2Delete" & Environment.NewLine() & Environment.NewLine() & ex.Message, ex.GetType.ToString)
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function Delete_sin_borrado_completo(ByVal PaletProducidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.Conectar()


        Try

            Dim deleteProcedure As String = "[dbo].[PaletsProducidos2eliminarContenidoPaletsPorPalets]"
            Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Parameters.AddWithValue("@PaletID", PaletProducidoID)
            deleteCommand.Parameters.AddWithValue("@borradoCompleto", 0)
            deleteCommand.ExecuteNonQuery()

            Dim PaletsProducidos2 As New DBO_PaletsProducidos

            Dim updateProcedure As String = "[dbo].[PaletsProducidos3Delete]"
            Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
            Dim mDBO_usuarios As New DBO_Usuarios
            Dim aux As New spUsuarios
            mDBO_usuarios = aux.Select_Record(BasesParaCompatibilidad.Config.User, dtb)

            updateCommand.CommandType = CommandType.StoredProcedure
            updateCommand.Parameters.AddWithValue("@OldPaletProducidoID", PaletProducidoID)
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", Now)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)
            updateCommand.Parameters.AddWithValue("@NewUsuarioNombre", mDBO_usuarios.Usuario)
            updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
            updateCommand.ExecuteNonQuery()

            Dim count As Integer = updateCommand.Parameters("@ReturnValue").Value

            Return True
        Catch ex As Exception
            MessageBox.Show("Error en PaletsProducidos2Delete" & Environment.NewLine() & Environment.NewLine() & ex.Message, ex.GetType.ToString)
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Sub cargar_PaletsProducidos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PaletsProducidosCbo", False, dtb)
    End Sub

 

    Public Sub cargar_PaletsProducidosNC_byArticulo(ByRef cbo As ComboBox, ByVal TipoFormatoID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PaletsProducidosNC_byArticuloCbo " & TipoFormatoID, False, dtb)
    End Sub

    Public Function Select_RecordBySSCC(ByVal scc As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsProducidos
        Dim dbo As New DBO_PaletsProducidos
        dbo.searchKey = dbo.item("SCC")
        dbo.searchKey.value = scc
        MyBase.Select_proc(dbo, "[dbo].[PaletsProducidos5SelectBySCC]", dtb)
        Return dbo
    End Function



End Class
