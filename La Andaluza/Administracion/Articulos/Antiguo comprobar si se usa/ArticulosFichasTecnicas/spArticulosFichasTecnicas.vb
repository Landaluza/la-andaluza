

Class spArticulosFichasTecnicas
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosFichasTecnicasSelect]", "[dbo].[ArticulosFichasTecnicasInsert]", "[dbo].[ArticulosFichasTecnicasUpdate]", _
                   "[dbo].[ArticulosFichasTecnicasDelete]", "ArticulosFichasTecnicasSelectDgv", "ArticulosFichasTecnicasSelectDgvByArticuloID")
    End Sub

    Public Function Select_Record(ByVal ArticuloFichaTecnicaID As Int32) As DBO_ArticulosFichasTecnicas
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosFichasTecnicas As New DBO_ArticulosFichasTecnicas
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosFichasTecnicasSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloFichaTecnicaID", ArticuloFichaTecnicaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosFichasTecnicas.ArticuloFichaTecnicaID = If(reader("ArticuloFichaTecnicaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloFichaTecnicaID")))
                DBO_ArticulosFichasTecnicas.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosFichasTecnicas.ProveedorID = If(reader("ProveedorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorID")))
                DBO_ArticulosFichasTecnicas.AprobadorID = If(reader("AprobadorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("AprobadorID")))
                DBO_ArticulosFichasTecnicas.EstadoID = If(reader("EstadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EstadoID")))
                DBO_ArticulosFichasTecnicas.Version = If(reader("Version") Is Convert.DBNull, 0, Convert.ToInt32(reader("Version")))
                DBO_ArticulosFichasTecnicas.FechaAprobacion = If(reader("FechaAprobacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaAprobacion")))
                DBO_ArticulosFichasTecnicas.FechaObsoleta = If(reader("FechaObsoleta") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaObsoleta")))
                DBO_ArticulosFichasTecnicas.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_ArticulosFichasTecnicas.CambiosAnterior = If(reader("CambiosAnterior") Is Convert.DBNull, String.Empty, Convert.ToString(reader("CambiosAnterior")))
                DBO_ArticulosFichasTecnicas.PropuestasCambios = If(reader("PropuestasCambios") Is Convert.DBNull, String.Empty, Convert.ToString(reader("PropuestasCambios")))
                DBO_ArticulosFichasTecnicas.MotivoPasoObsoleta = If(reader("MotivoPasoObsoleta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("MotivoPasoObsoleta")))
                DBO_ArticulosFichasTecnicas.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosFichasTecnicas.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosFichasTecnicas.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosFichasTecnicas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosFichasTecnicas
    End Function

    Public Function ArticulosFichasTecnicasInsert(ByVal dbo_ArticulosFichasTecnicas As DBO_ArticulosFichasTecnicas) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ArticulosFichasTecnicasInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloID", dbo_ArticulosFichasTecnicas.ArticuloID)
        insertCommand.Parameters.AddWithValue("@ProveedorID", dbo_ArticulosFichasTecnicas.ProveedorID)
        insertCommand.Parameters.AddWithValue("@AprobadorID", dbo_ArticulosFichasTecnicas.AprobadorID)
        insertCommand.Parameters.AddWithValue("@EstadoID", dbo_ArticulosFichasTecnicas.EstadoID)
        insertCommand.Parameters.AddWithValue("@Version", dbo_ArticulosFichasTecnicas.Version)
        insertCommand.Parameters.AddWithValue("@FechaAprobacion", dbo_ArticulosFichasTecnicas.FechaAprobacion)
        insertCommand.Parameters.AddWithValue("@FechaObsoleta", If(dbo_ArticulosFichasTecnicas.FechaObsoleta.HasValue, dbo_ArticulosFichasTecnicas.FechaObsoleta, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_ArticulosFichasTecnicas.Ruta)
        insertCommand.Parameters.AddWithValue("@CambiosAnterior", dbo_ArticulosFichasTecnicas.CambiosAnterior)
        insertCommand.Parameters.AddWithValue("@PropuestasCambios", dbo_ArticulosFichasTecnicas.PropuestasCambios)
        insertCommand.Parameters.AddWithValue("@MotivoPasoObsoleta", dbo_ArticulosFichasTecnicas.MotivoPasoObsoleta)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosFichasTecnicas.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosFichasTecnicas.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosFichasTecnicas.UsuarioModificacion)
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

    Public Function ArticulosFichasTecnicasUpdate(ByVal newDBO_ArticulosFichasTecnicas As DBO_ArticulosFichasTecnicas) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ArticulosFichasTecnicasUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloID", newDBO_ArticulosFichasTecnicas.ArticuloID)
        updateCommand.Parameters.AddWithValue("@NewProveedorID", newDBO_ArticulosFichasTecnicas.ProveedorID)
        updateCommand.Parameters.AddWithValue("@NewAprobadorID", newDBO_ArticulosFichasTecnicas.AprobadorID)
        updateCommand.Parameters.AddWithValue("@NewEstadoID", newDBO_ArticulosFichasTecnicas.EstadoID)
        updateCommand.Parameters.AddWithValue("@NewVersion", newDBO_ArticulosFichasTecnicas.Version)
        updateCommand.Parameters.AddWithValue("@NewFechaAprobacion", newDBO_ArticulosFichasTecnicas.FechaAprobacion)
        updateCommand.Parameters.AddWithValue("@NewFechaObsoleta", If(newDBO_ArticulosFichasTecnicas.FechaObsoleta.HasValue, newDBO_ArticulosFichasTecnicas.FechaObsoleta, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_ArticulosFichasTecnicas.Ruta)
        updateCommand.Parameters.AddWithValue("@NewCambiosAnterior", newDBO_ArticulosFichasTecnicas.CambiosAnterior)
        updateCommand.Parameters.AddWithValue("@NewPropuestasCambios", newDBO_ArticulosFichasTecnicas.PropuestasCambios)
        updateCommand.Parameters.AddWithValue("@NewMotivoPasoObsoleta", newDBO_ArticulosFichasTecnicas.MotivoPasoObsoleta)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosFichasTecnicas.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosFichasTecnicas.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosFichasTecnicas.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloFichaTecnicaID", newDBO_ArticulosFichasTecnicas.ArticuloFichaTecnicaID)
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
            MessageBox.Show("Error en UpdateArticulosFichasTecnicas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosFichasTecnicasDelete(ByVal ArticuloFichaTecnicaID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ArticulosFichasTecnicasDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloFichaTecnicaID", ArticuloFichaTecnicaID)
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

    Public Sub GrabarArticulosFichasTecnicas(ByVal dbo_ArticulosFichasTecnicas As DBO_ArticulosFichasTecnicas)
        If dbo_ArticulosFichasTecnicas.ArticuloFichaTecnicaID = 0 Then
            ArticulosFichasTecnicasInsert(dbo_ArticulosFichasTecnicas)
        Else
            ArticulosFichasTecnicasUpdate(dbo_ArticulosFichasTecnicas)
        End If
    End Sub

    Public Sub Select_ArticulosFichasTecnicas_EstadoVigente(ByVal ArticuloID As Int32, ByVal ProveedorID As Int32)
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosFichasTecnicas_EstadoVigenteSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloID", ArticuloID)
        selectCommand.Parameters.AddWithValue("@ProveedorID", ProveedorID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                If If(reader("Number") Is Convert.DBNull, 0, Convert.ToInt32(reader("Number"))) > 0 Then
                    MessageBox.Show(String.Empty & If(reader("Number") Is Convert.DBNull, "0", Convert.ToString(reader("Number"))) & " record(s) already exists in [ArticuloFichaTecnica] with value 'Vigente'." & Environment.NewLine _
                           & "Please change the register state.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
    End Sub

End Class
