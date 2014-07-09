Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spArticulosFichasTecnicasEstados
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosFichasTecnicasEstadosSelect]", "[dbo].[ArticulosFichasTecnicasEstadosInsert]" _
                   , "[dbo].[ArticulosFichasTecnicasEstadosUpdate]", "[dbo].[ArticulosFichasTecnicasEstadosDelete]", _
                   "EnvasadosControles2SelectDgv", "EnvasadosControles2SelectDgvByEnvasadoControlID")
    End Sub
    Public Function Select_Record(ByVal ArticuloFichaTecnicaEstadoID As Int32) As DBO_ArticulosFichasTecnicasEstados
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosFichasTecnicasEstados As New DBO_ArticulosFichasTecnicasEstados
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = Me.selectProcedureName
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloFichaTecnicaEstadoID", ArticuloFichaTecnicaEstadoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosFichasTecnicasEstados.ArticuloFichaTecnicaEstadoID = If(reader("ArticuloFichaTecnicaEstadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloFichaTecnicaEstadoID")))
                DBO_ArticulosFichasTecnicasEstados.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosFichasTecnicasEstados.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosFichasTecnicasEstados.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosFichasTecnicasEstados.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosFichasTecnicasEstados = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosFichasTecnicasEstados
    End Function

    Public Function ArticulosFichasTecnicasEstadosInsert(ByVal dbo_ArticulosFichasTecnicasEstados As DBO_ArticulosFichasTecnicasEstados) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = insertProcedureName
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosFichasTecnicasEstados.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosFichasTecnicasEstados.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosFichasTecnicasEstados.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosFichasTecnicasEstados.UsuarioModificacion)
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try

            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            connection.Close()

        End Try
    End Function

    Public Function ArticulosFichasTecnicasEstadosUpdate(ByVal newDBO_ArticulosFichasTecnicasEstados As DBO_ArticulosFichasTecnicasEstados) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = updateProcedureName
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosFichasTecnicasEstados.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosFichasTecnicasEstados.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosFichasTecnicasEstados.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosFichasTecnicasEstados.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloFichaTecnicaEstadoID", newDBO_ArticulosFichasTecnicasEstados.ArticuloFichaTecnicaEstadoID)
        updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try

            updateCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateArticulosFichasTecnicasEstados" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosFichasTecnicasEstadosDelete(ByVal ArticuloFichaTecnicaEstadoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = deleteProcedureName
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloFichaTecnicaEstadoID", ArticuloFichaTecnicaEstadoID)
        deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try

            deleteCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub GrabarArticulosFichasTecnicasEstados(ByVal dbo_ArticulosFichasTecnicasEstados As DBO_ArticulosFichasTecnicasEstados)
        If dbo_ArticulosFichasTecnicasEstados.ArticuloFichaTecnicaEstadoID = 0 Then
            ArticulosFichasTecnicasEstadosInsert(dbo_ArticulosFichasTecnicasEstados)
        Else
            ArticulosFichasTecnicasEstadosUpdate(dbo_ArticulosFichasTecnicasEstados)
        End If
    End Sub

    Public Sub cargar_combo(ByRef cbo As ComboBox)
        cbo.mam_DataSource("ArticulosFichasTecnicas_ArticulosFichasTecnicasEstadosCbo", False)
    End Sub
End Class
