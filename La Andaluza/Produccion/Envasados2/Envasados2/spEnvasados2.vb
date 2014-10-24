

Class spEnvasados2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[Envasados3Select]", "[dbo].[Envasados3Insert]", "[dbo].[Envasados3Update]", _
                  "[dbo].[Envasados2Delete]", "Envasados2SelectDgv", String.Empty)
    End Sub

    Public Function Select_Record(ByVal EnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Envasados2
        dtb.Conectar()
        Dim Dbo_Envasados2 As DBO_Envasados2 = Dbo_Envasados2.Instance

        Dim selectProcedure As String = "[dbo].[Envasados3Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@EnvasadoID", EnvasadoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_Envasados2.EnvasadoID = If(reader("EnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoID")))
                Dbo_Envasados2.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                Dbo_Envasados2.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                Dbo_Envasados2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                Dbo_Envasados2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                Dbo_Envasados2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtb.Desconectar()
        End Try
        Return Dbo_Envasados2
    End Function

    Public Function Select_Record(ByVal EnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal stub As Boolean) As DBO_Envasados3
        If dtb.Transaccion Is Nothing Then dtb.Conectar()
        Dim Dbo_Envasados2 As New DBO_Envasados3

        ' Dim selectProcedure As String = "[dbo].[Envasados3Select]"
        ' Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[Envasados3Select]")
        Dim selectCommand As New System.Data.SqlClient.SqlCommand("[dbo].[Envasados3Select]", dtb.Conexion)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@EnvasadoID", EnvasadoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_Envasados2.EnvasadoID = If(reader("EnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoID")))
                Dbo_Envasados2.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                Dbo_Envasados2.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                Dbo_Envasados2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                Dbo_Envasados2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                Dbo_Envasados2 = Nothing
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If dtb.Transaccion Is Nothing Then dtb.Desconectar()
        End Try
        Return Dbo_Envasados2
    End Function

    Public Function InsertEnvasados2(ByVal dbo_Envasados2 As DBO_Envasados2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[Envasados3Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_Envasados2.Fecha)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_Envasados2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_Envasados2.UsuarioModificacion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_Envasados2.Observaciones)
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return count
            Else
                Return 0
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function UpdateEnvasados2(ByVal Envasados2 As DBO_Envasados2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()


        Dim updateProcedure As String = "[dbo].[Envasados3Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewFecha", Envasados2.Fecha)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", Envasados2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", Envasados2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", Envasados2.Observaciones)
        updateCommand.Parameters.AddWithValue("@OldEnvasadoID", Envasados2.EnvasadoID)
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
            MessageBox.Show("Error en UpdateEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function DeleteEnvasados2(ByVal EnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[Envasados2Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldEnvasadoID", EnvasadoID)
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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GetEnvasadoIDPorFecha(ByVal EnvasadoFecha As DateTime, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.Conectar()

        Dim Procedure As String = "[dbo].[Envasados2ExisteEnFecha]"
        Dim Command As System.Data.SqlClient.SqlCommand = dtb.Comando(Procedure)
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.AddWithValue("@Fecha", EnvasadoFecha)
        Try
            Return (Command.ExecuteScalar)
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Sub GrabarEnvasados2(ByRef m_Envasados2 As DBO_Envasados2, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If Not m_Envasados2.EnvasadoID = Nothing Then
            UpdateEnvasados2(m_Envasados2, dtb)
        Else
            m_Envasados2.EnvasadoID = InsertEnvasados2(m_Envasados2, dtb)
        End If

        m_Envasados2 = Select_Record(m_Envasados2.EnvasadoID, dtb)

    End Sub

    Public Shared Function personalPendiente(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dt As DataTable = dtb.Consultar("select count(*) from empleados_formatosEnvasados, formatosEnvasados, envasados where id_formatoEnvasado = formatoEnvasadoid and formatosEnvasados.envasadoid = envasados.envasadoid and convert(varchar, envasados.fecha, 103) <> convert(varchar, CURRENT_TIMESTAMP, 103) and empleados_formatosEnvasados.fin is null", False)
        If dt Is Nothing Then Return False
        If dt.Rows(0) Is Nothing Then Return False

        If Convert.ToInt32(dt.Rows(0).Item(0)) > 0 Then
            Return True
        End If

        Return False
    End Function
End Class
