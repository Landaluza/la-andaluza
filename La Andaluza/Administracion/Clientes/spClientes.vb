Imports BasesParaCompatibilidad.ComboBoxExtension


Class spClientes
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ClientesSelect]", "[dbo].[ClientesInsert]", "[dbo].[ClientesUpdate]", _
                    "[dbo].[ClientesDelete]", "ClientesSelectDgv", String.Empty)
    End Sub
    Public Function Select_Record(ByVal ClienteID As Int32) As Dbo_Clientes
        BasesParaCompatibilidad.BD.Conectar()
        Dim Dbo_Clientes As New DBO_Clientes
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ClientesSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ClienteID", ClienteID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_Clientes.ClienteID = If(reader("ClienteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ClienteID")))
                Dbo_Clientes.Nombre = If(reader("Nombre") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Nombre")))
                Dbo_Clientes.CodigoQS = If(reader("CodigoQS") Is Convert.DBNull, 0, Convert.ToInt32(reader("CodigoQS")))
            Else
                Dbo_Clientes = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return Dbo_Clientes
    End Function

    Public Function InsertClientes(ByVal dbo_Clientes As Dbo_Clientes) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ClientesInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Nombre", dbo_Clientes.Nombre)
        insertCommand.Parameters.AddWithValue("@CodigoQS", dbo_Clientes.CodigoQS)
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

    Public Function UpdateClientes(ByVal oldDbo_Clientes As Dbo_Clientes, ByVal newDbo_Clientes As Dbo_Clientes) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ClientesUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewNombre", newDbo_Clientes.Nombre)
        updateCommand.Parameters.AddWithValue("@NewCodigoQS", newDbo_Clientes.CodigoQS)
        updateCommand.Parameters.AddWithValue("@OldClienteID", oldDbo_Clientes.ClienteID)
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
            MessageBox.Show("Error en UpdateClientes" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function DeleteClientes(ByVal ClienteID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ClientesDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldClienteID", ClienteID)
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

    Public Function DeleteClientes(ByVal ClienteID As Int32, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ClientesDelete]")
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldClienteID", ClienteID)
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
           dtb.Conectar()
        End Try
    End Function

    Sub cargar_Clientes(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("ClientesCbo", False)
    End Sub

End Class
