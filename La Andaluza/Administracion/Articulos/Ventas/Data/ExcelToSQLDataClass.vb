

Public Class ExcelToSQLDataClass
    Public conexion As System.Data.SqlClient.SqlConnection
    Public transaction As System.Data.SqlClient.SqlTransaction

    Public Function GetConnection() As System.Data.SqlClient.SqlConnection
        Dim connectionString As String = BasesParaCompatibilidad.Config.connectionString

        closeConnection()

        If transaction Is Nothing Then
            conexion = New System.Data.SqlClient.SqlConnection(connectionString)
            conexion.Open()
        End If

        Return conexion
    End Function

    Public Sub beginTransaction()
        GetConnection()
        'ExcelToSQLDataClass.conexion.Open()
        Me.transaction = Me.conexion.BeginTransaction
    End Sub

    Public Sub endTransaction()
        Me.transaction.Commit()
        closeConnection()
        transaction = Nothing
    End Sub

    Public Sub cancelTransaction()
        Me.transaction.Rollback()
        closeConnection()
        Me.transaction = Nothing
    End Sub

    Public Sub closeConnection()
        If Me.transaction Is Nothing Then
            If Not conexion Is Nothing Then If Me.conexion.State Then Me.conexion.Close()
        End If
    End Sub

    Public Function SelectCodigoQS() As DataTable
        Dim selectProcedure As String = "[dbo].[CodigoQSSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, Me.GetConnection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then selectCommand.Transaction = transaction
        Dim dt As New DataTable
        Try
            ' If Not connection.State Then connection.Open()
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
        Return dt
    End Function

    Public Function SelectExcelToSQLByCodigoQS(ByVal CodigoQS As String) As DataTable
        Dim selectProcedure As String = "[dbo].[ExcelToSQLByCodigoQSSelect2]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, Me.GetConnection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then selectCommand.Transaction = transaction
        selectCommand.Parameters.AddWithValue("@CodigoQS", CodigoQS)
        Dim dt As New DataTable
        Try
            'If Not connection.State Then connection.Open()
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
        Return dt
    End Function

    Public Function VentasByCodigoQS(ByVal CodigoQS As String) As DataTable
        Dim selectProcedure As String = "[dbo].[VentasByCodigoQS]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, Me.GetConnection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then selectCommand.Transaction = transaction
        selectCommand.Parameters.AddWithValue("@CodigoQS", CodigoQS)
        Dim dt As New DataTable
        Try
            'If Not connection.State Then connection.Open()
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
        Return dt
    End Function

    'Public Function VentasByCodigoQSAño(ByVal CodigoQS As String, ByVal año As Integer) As DataTable
    '    Dim selectProcedure As String = "[dbo].[VentasByCodigoQSAño]"
    '    Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, ExcelToSQLDataClass.GetConnection)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    If Not transaction Is Nothing Then selectCommand.Transaction = transaction
    '    selectCommand.Parameters.AddWithValue("@CodigoQS", CodigoQS)
    '    selectCommand.Parameters.AddWithValue("@año", año)
    '    Dim dt As New DataTable
    '    Try
    '        'If Not connection.State Then connection.Open()
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
    '        If reader.HasRows Then
    '            dt.Load(reader)
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        closeConnection()
    '    End Try
    '    Return dt
    'End Function

    Public Function VentasByCodigoQSAñoMes(ByVal CodigoQS As String, ByVal año As Integer, ByVal mes As Integer) As DataTable
        Dim selectProcedure As String = "[dbo].[VentasByCodigoQSAñoMes]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, Me.GetConnection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then selectCommand.Transaction = transaction
        selectCommand.Parameters.AddWithValue("@CodigoQS", CodigoQS)
        selectCommand.Parameters.AddWithValue("@año", año)
        selectCommand.Parameters.AddWithValue("@mes", mes)
        Dim dt As New DataTable
        Try
            'If Not connection.State Then connection.Open()
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
        Return dt
    End Function

    Public Function VentasAcumuladasByCodigoQSAño(ByVal año As Integer, ByVal CodigoQS As String) As DataTable
        Dim selectProcedure As String = "[dbo].[VentasAcumuladosTotalesByCodigoQS]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, Me.GetConnection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then selectCommand.Transaction = transaction
        selectCommand.Parameters.AddWithValue("@CodigoQS", CodigoQS)
        selectCommand.Parameters.AddWithValue("@año", año)
        Dim dt As New DataTable
        Try
            'If Not connection.State Then connection.Open()
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
        Return dt
    End Function

    Public Function VentasAcumuladasMesByCodigoQSAño(ByVal año As Integer, ByVal CodigoQS As String) As DataTable
        Dim selectProcedure As String = "[dbo].[VentasAcumuladosMesByCodigoQSAño]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, Me.GetConnection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then selectCommand.Transaction = transaction
        selectCommand.Parameters.AddWithValue("@CodigoQS", CodigoQS)
        selectCommand.Parameters.AddWithValue("@año", año)
        Dim dt As New DataTable
        Try
            'If Not connection.State Then connection.Open()
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
        Return dt
    End Function

    Public Function VentasMesMaximo() As DataTable
        Dim selectProcedure As String = "[dbo].[VentasMesMaximo]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, Me.GetConnection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then selectCommand.Transaction = transaction
        Dim dt As New DataTable
        Try
            'If Not connection.State Then connection.Open()
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
        Return dt
    End Function

    Public Function SelectAll() As DataTable
        Dim selectProcedure As String = "[dbo].[ExcelToSQLSelectAll]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, Me.GetConnection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then selectCommand.Transaction = transaction
        Dim dt As New DataTable
        Try
            ' If Not connection.State Then connection.Open()
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
        Return dt
    End Function

    Public Function Add(ByVal clsExcelToSQL As ExcelToSQLClass) As Boolean
        Dim retorno As Boolean = True
        Dim insertProcedure As String = "[dbo].[ExcelToSQLInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, Me.GetConnection)
        insertCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then insertCommand.Transaction = transaction
        insertCommand.Parameters.AddWithValue("@CodigoQS", If(clsExcelToSQL.CodigoQS_IsDBNull = True, Convert.DBNull, clsExcelToSQL.CodigoQS))
        insertCommand.Parameters.AddWithValue("@Año", If(clsExcelToSQL.Año_IsDBNull = True, Convert.DBNull, clsExcelToSQL.Año))
        insertCommand.Parameters.AddWithValue("@Mes", If(clsExcelToSQL.Mes_IsDBNull = True, Convert.DBNull, clsExcelToSQL.Mes))
        insertCommand.Parameters.AddWithValue("@Cajas", If(clsExcelToSQL.Cajas_IsDBNull = True, Convert.DBNull, clsExcelToSQL.Cajas))
        insertCommand.Parameters.AddWithValue("@Observaciones", If(clsExcelToSQL.Observaciones_IsDBNull = True, Convert.DBNull, clsExcelToSQL.Observaciones))
        insertCommand.Parameters.AddWithValue("@Descripcion", clsExcelToSQL.Descripcion)
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            ' If Not connection.State Then connection.Open()
            Dim count As Integer = insertCommand.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            retorno = False
        Finally
            closeConnection()
        End Try

        Return retorno
    End Function

    Public Function Delete() As Boolean
        Dim deleteProcedure As String = "[dbo].[ExcelToSQLDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, Me.GetConnection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then deleteCommand.Transaction = transaction
        Try
            ' If Not connection.State Then connection.Open()
            deleteCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            closeConnection()
        End Try
    End Function

    Public Function Delete(ByVal month As Integer, ByVal year As Integer) As Boolean
        Dim deleteProcedure As String = "[dbo].[ExcelToSQLDeleteByMonthYear]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, Me.GetConnection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        If Not transaction Is Nothing Then deleteCommand.Transaction = transaction
        Try
            ' If Not connection.State Then connection.Open()
            deleteCommand.Parameters.AddWithValue("@Año", year)
            deleteCommand.Parameters.AddWithValue("@Mes", month)
            deleteCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Throw
        Finally
            closeConnection()
        End Try
    End Function

End Class
