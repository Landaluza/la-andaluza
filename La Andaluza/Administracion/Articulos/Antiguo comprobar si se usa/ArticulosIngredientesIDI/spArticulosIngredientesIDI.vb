﻿

Class spArticulosIngredientesIDI
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosIngredientesIDISelect]", "[dbo].[ArticulosIngredientesIDIInsert2]", "[dbo].[ArticulosIngredientesIDIUpdate2]", _
                 "[dbo].[ArticulosIngredientesIDIDelete]", String.Empty, String.Empty)
    End Sub

    Public Function Select_Record(ByVal IngredienteID As Int32) As DBO_ArticulosIngredientes
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosIngredientes As New DBO_ArticulosIngredientes
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosIngredientesIDISelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@IngredienteID", IngredienteID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosIngredientes.IngredienteID = If(reader("IngredienteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("IngredienteID")))
                DBO_ArticulosIngredientes.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosIngredientes.IngredienteTipoID = If(reader("IngredienteTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("IngredienteTipoID")))
                DBO_ArticulosIngredientes.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosIngredientes.CertificadoOGM = If(reader("CertificadoOGM") Is Convert.DBNull, False, Convert.ToBoolean(reader("CertificadoOGM")))
                DBO_ArticulosIngredientes.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosIngredientes.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now, CDate(reader("FechaModificacion")))
                DBO_ArticulosIngredientes.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosIngredientes = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosIngredientes
    End Function

    Public Function Select_RecordByArticuloID(ByVal ArticuloID As Int32) As DBO_ArticulosIngredientes
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosIngredientes As New DBO_ArticulosIngredientes
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosIngredientesIDISelectByArticuloID]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloID", ArticuloID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosIngredientes.IngredienteID = If(reader("IngredienteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("IngredienteID")))
                DBO_ArticulosIngredientes.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosIngredientes.IngredienteTipoID = If(reader("IngredienteTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("IngredienteTipoID")))
                DBO_ArticulosIngredientes.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosIngredientes.CertificadoOGM = If(reader("CertificadoOGM") Is Convert.DBNull, False, Convert.ToBoolean(reader("CertificadoOGM")))
                DBO_ArticulosIngredientes.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosIngredientes.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now, CDate(reader("FechaModificacion")))
                DBO_ArticulosIngredientes.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosIngredientes = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosIngredientes
    End Function

    Public Function ArticulosIngredientesIDIInsert(ByVal dbo_ArticulosIngredientes As DBO_ArticulosIngredientes) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ArticulosIngredientesIDIInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_ArticulosIngredientes.ArticuloID.HasValue, dbo_ArticulosIngredientes.ArticuloID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@IngredienteTipoID", If(dbo_ArticulosIngredientes.IngredienteTipoID.HasValue, dbo_ArticulosIngredientes.IngredienteTipoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosIngredientes.Descripcion)
        insertCommand.Parameters.AddWithValue("@CertificadoOGM", dbo_ArticulosIngredientes.CertificadoOGM)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosIngredientes.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosIngredientes.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosIngredientes.UsuarioModificacion)
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

    Public Function ArticulosIngredientesIDIUpdate(ByVal newDBO_ArticulosIngredientes As DBO_ArticulosIngredientes) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ArticulosIngredientesIDIUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_ArticulosIngredientes.ArticuloID.HasValue, newDBO_ArticulosIngredientes.ArticuloID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewIngredienteTipoID", If(newDBO_ArticulosIngredientes.IngredienteTipoID.HasValue, newDBO_ArticulosIngredientes.IngredienteTipoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosIngredientes.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewCertificadoOGM", newDBO_ArticulosIngredientes.CertificadoOGM)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosIngredientes.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosIngredientes.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosIngredientes.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldIngredienteID", newDBO_ArticulosIngredientes.IngredienteID)
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
            MessageBox.Show("Error en UpdateArticulosIngredientesIDI " & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosIngredientesIDIInsertSinTransaccion(ByVal dbo_ArticulosIngredientes As DBO_ArticulosIngredientes, ByRef mytrans As SqlClient.SqlTransaction) As Boolean

        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Try
            Dim insertProcedure As String = "[dbo].[ArticulosIngredientesIDIInsert2]"
            Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
            insertCommand.CommandType = CommandType.StoredProcedure
            insertCommand.Transaction = mytrans
            insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_ArticulosIngredientes.ArticuloID.HasValue, dbo_ArticulosIngredientes.ArticuloID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@IngredienteTipoID", If(dbo_ArticulosIngredientes.IngredienteTipoID.HasValue, dbo_ArticulosIngredientes.IngredienteTipoID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosIngredientes.Descripcion)
            insertCommand.Parameters.AddWithValue("@CertificadoOGM", dbo_ArticulosIngredientes.CertificadoOGM)
            insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosIngredientes.Observaciones)
            insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosIngredientes.FechaModificacion)
            insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosIngredientes.UsuarioModificacion)
            insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        End Try
    End Function

    Public Function ArticulosIngredientesIDIUpdateSinTransaccion(ByVal newDBO_ArticulosIngredientes As DBO_ArticulosIngredientes, ByRef mytrans As SqlClient.SqlTransaction) As Boolean

        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Try
            Dim updateProcedure As String = "[dbo].[ArticulosIngredientesIDIUpdate2]"
            Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
            updateCommand.CommandType = CommandType.StoredProcedure
            updateCommand.Transaction = mytrans
            updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_ArticulosIngredientes.ArticuloID.HasValue, newDBO_ArticulosIngredientes.ArticuloID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewIngredienteTipoID", If(newDBO_ArticulosIngredientes.IngredienteTipoID.HasValue, newDBO_ArticulosIngredientes.IngredienteTipoID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosIngredientes.Descripcion)
            updateCommand.Parameters.AddWithValue("@NewCertificadoOGM", newDBO_ArticulosIngredientes.CertificadoOGM)
            updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosIngredientes.Observaciones)
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosIngredientes.FechaModificacion)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosIngredientes.UsuarioModificacion)
            updateCommand.Parameters.AddWithValue("@OldIngredienteID", newDBO_ArticulosIngredientes.IngredienteID)
            updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

            updateCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateArticulosIngredientesIDI " & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        End Try
    End Function

    Public Function ArticulosIngredientesIDIDelete(ByVal IngredienteID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ArticulosIngredientesIDIDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldIngredienteID", IngredienteID)
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

    Public Function GrabarArticulosIngredientesIDI(ByVal dbo_ArticulosIngredientes As DBO_ArticulosIngredientes) As Boolean
        If dbo_ArticulosIngredientes.IngredienteID = 0 Then
            Return ArticulosIngredientesIDIInsert(dbo_ArticulosIngredientes)
        Else
            Return ArticulosIngredientesIDIUpdate(dbo_ArticulosIngredientes)
        End If
    End Function

    Public Function GrabarArticulosIngredientesIDISinTransaccion(ByVal dbo_ArticulosIngredientes As DBO_ArticulosIngredientes, ByRef mytrans As SqlClient.SqlTransaction) As Boolean
        If dbo_ArticulosIngredientes.IngredienteID = 0 Then
            Return ArticulosIngredientesIDIInsertSinTransaccion(dbo_ArticulosIngredientes, mytrans)
        Else
            Return ArticulosIngredientesIDIUpdateSinTransaccion(dbo_ArticulosIngredientes, mytrans)
        End If
    End Function

End Class
