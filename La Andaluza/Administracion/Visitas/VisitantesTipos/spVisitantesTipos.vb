

Class spVisitantesTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[VisitantesTiposSelect]", "[dbo].[VisitantesTiposInsert]", _
                   "[dbo].[VisitantesTiposUpdate]", "[dbo].[VisitantesTiposDelete]", _
                   "VisitantesTiposSelectDgv", String.Empty)
    End Sub

    Public Function Select_Record(ByVal VisitanteTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_VisitantesTipos
        dtb.Conectar()
        Dim DBO_VisitantesTipos As New DBO_VisitantesTipos

        Dim selectProcedure As String = "[dbo].[VisitantesTiposSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@VisitanteTipoID", VisitanteTipoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_VisitantesTipos.VisitanteTipoID = If(reader("VisitanteTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitanteTipoID")))
                DBO_VisitantesTipos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_VisitantesTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_VisitantesTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_VisitantesTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                'DBO_VisitantesTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_VisitantesTipos
    End Function

    Public Function VisitantesTiposInsert(ByVal dbo_VisitantesTipos As DBO_VisitantesTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[VisitantesTiposInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_VisitantesTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_VisitantesTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_VisitantesTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_VisitantesTipos.UsuarioModificacion)

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
            dtb.Desconectar()
        End Try
    End Function

    Public Function VisitantesTiposUpdate(ByVal newDBO_VisitantesTipos As DBO_VisitantesTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[VisitantesTiposUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_VisitantesTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_VisitantesTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_VisitantesTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_VisitantesTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldVisitanteTipoID", newDBO_VisitantesTipos.VisitanteTipoID)
        '<Tag=[Three][End]> -- please do not remove this line
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
            MessageBox.Show("Error en UpdateVisitantesTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function VisitantesTiposDelete(ByVal VisitanteTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[VisitantesTiposDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldVisitanteTipoID", VisitanteTipoID)
        '<Tag=[Four][End]> -- please do not remove this line
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
            dtb.Desconectar()
        End Try
    End Function

    Public Sub GrabarVisitantesTipos(ByVal dbo_VisitantesTipos As DBO_VisitantesTipos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_VisitantesTipos.FechaModificacion = System.DateTime.Now.Date
        dbo_VisitantesTipos.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_VisitantesTipos.VisitanteTipoID = 0 Then
            VisitantesTiposInsert(dbo_VisitantesTipos, dtb)
        Else
            VisitantesTiposUpdate(dbo_VisitantesTipos, dtb)
        End If
    End Sub

End Class
