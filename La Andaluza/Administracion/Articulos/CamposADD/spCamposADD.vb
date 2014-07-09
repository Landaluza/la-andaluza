

Class spCamposADD
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.new("[dbo].[CamposADDSelect]", "[dbo].[CamposADDInsert]", "[dbo].[CamposADDUpdate]", _
                   "[dbo].[CamposADDDelete]", "CamposADDSelectDgv", "CamposADDSelectDgvByArticuloTipoID")
    End Sub


    Public Function Select_Record(ByVal ID As Int32, ByRef dtb as BasesParaCompatibilidad.Database) As DBO_CamposADD
        dtb.Conectar()
        Dim DBO_CamposADD As New DBO_CamposADD
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[CamposADDSelect]")
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ID", ID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_CamposADD.ID = If(reader("ID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ID")))
                DBO_CamposADD.ArticuloTipoID = If(reader("ArticuloTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloTipoID")))
                DBO_CamposADD.SolicitanteID = If(reader("SolicitanteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("SolicitanteID")))
                DBO_CamposADD.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_CamposADD.Utilizacion = If(reader("Utilizacion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Utilizacion")))
                DBO_CamposADD.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_CamposADD.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_CamposADD.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_CamposADD = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
           dtb.Conectar()
        End Try
        Return DBO_CamposADD
    End Function

    Public Function CamposADDInsert(ByVal dbo_CamposADD As DBO_CamposADD, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()

        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[CamposADDInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloTipoID", If(dbo_CamposADD.ArticuloTipoID.HasValue, dbo_CamposADD.ArticuloTipoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@SolicitanteID", If(dbo_CamposADD.SolicitanteID.HasValue, dbo_CamposADD.SolicitanteID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_CamposADD.Descripcion)
        insertCommand.Parameters.AddWithValue("@Utilizacion", dbo_CamposADD.Utilizacion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_CamposADD.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_CamposADD.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_CamposADD.UsuarioModificacion)
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
           dtb.Conectar()
        End Try
    End Function

    Public Function CamposADDUpdate(ByVal newDBO_CamposADD As DBO_CamposADD, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[CamposADDUpdate]")
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloTipoID", If(newDBO_CamposADD.ArticuloTipoID.HasValue, newDBO_CamposADD.ArticuloTipoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewSolicitanteID", If(newDBO_CamposADD.SolicitanteID.HasValue, newDBO_CamposADD.SolicitanteID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_CamposADD.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewUtilizacion", newDBO_CamposADD.Utilizacion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_CamposADD.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_CamposADD.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_CamposADD.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldID", newDBO_CamposADD.ID)
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
            MessageBox.Show("Error en UpdateCamposADD" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
           dtb.Conectar()
        End Try
    End Function

    'Public Function CamposADDInsert(ByVal dbo_CamposADD As DBO_CamposADD) As Boolean
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim insertProcedure As String = "[dbo].[CamposADDInsert]"
    '    Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
    '    insertCommand.CommandType = CommandType.StoredProcedure
    '    insertCommand.Parameters.AddWithValue("@ArticuloTipoID", if(dbo_CamposADD.ArticuloTipoID.HasValue, dbo_CamposADD.ArticuloTipoID, Convert.DBNull ))
    '    insertCommand.Parameters.AddWithValue("@SolicitanteID", if(dbo_CamposADD.SolicitanteID.HasValue, dbo_CamposADD.SolicitanteID, Convert.DBNull ))
    '    insertCommand.Parameters.AddWithValue("@Descripcion", dbo_CamposADD.Descripcion)
    '    insertCommand.Parameters.AddWithValue("@Utilizacion", dbo_CamposADD.Utilizacion)
    '    insertCommand.Parameters.AddWithValue("@Observaciones", dbo_CamposADD.Observaciones)
    '    insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_CamposADD.FechaModificacion)
    '    insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_CamposADD.UsuarioModificacion)
    '    insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        insertCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '           Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '         Return False
    '    Finally
    '        connection.Close()
    '    End Try
    'End Function

    'Public Function CamposADDUpdate(ByVal newDBO_CamposADD As DBO_CamposADD) As Boolean
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim updateProcedure As String = "[dbo].[CamposADDUpdate]"
    '    Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
    '    updateCommand.CommandType = CommandType.StoredProcedure
    '    updateCommand.Parameters.AddWithValue("@NewArticuloTipoID", if(newDBO_CamposADD.ArticuloTipoID.HasValue, newDBO_CamposADD.ArticuloTipoID, Convert.DBNull ))
    '    updateCommand.Parameters.AddWithValue("@NewSolicitanteID", if(newDBO_CamposADD.SolicitanteID.HasValue, newDBO_CamposADD.SolicitanteID, Convert.DBNull ))
    '    updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_CamposADD.Descripcion)
    '    updateCommand.Parameters.AddWithValue("@NewUtilizacion", newDBO_CamposADD.Utilizacion)
    '    updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_CamposADD.Observaciones)
    '    updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_CamposADD.FechaModificacion)
    '    updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_CamposADD.UsuarioModificacion)
    '    updateCommand.Parameters.AddWithValue("@OldID", newDBO_CamposADD.ID)
    '    updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        updateCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '           Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '         MessageBox.Show("Error en UpdateCamposADD" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
    '         Return False
    '    Finally
    '        connection.Close()
    '    End Try
    'End Function

    Public Function CamposADDDelete(ByVal ID As Int32, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()

        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[CamposADDDelete]")
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldID", ID)
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

    Public Sub GrabarCamposADD(ByVal dbo_CamposADD As DBO_CamposADD, ByRef dtb as BasesParaCompatibilidad.Database)
        dbo_CamposADD.FechaModificacion = System.DateTime.Now.Date
        dbo_CamposADD.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_CamposADD.ID = 0 Then
            CamposADDInsert(dbo_CamposADD, dtb)
        Else
            CamposADDUpdate(dbo_CamposADD, dtb)
        End If
    End Sub

End Class
