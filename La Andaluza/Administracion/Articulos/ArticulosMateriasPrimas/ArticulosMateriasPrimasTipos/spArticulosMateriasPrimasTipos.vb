

Class spArticulosMateriasPrimasTipos
    inherits BasesParaCompatibilidad.sp
    Public Sub New()
        MyBase.New("[dbo].[ArticulosMateriasPrimasTiposSelect]", "[dbo].[ArticulosMateriasPrimasTiposInsert]", "[dbo].[ArticulosMateriasPrimasTiposUpdate]", _
                  "[dbo].[ArticulosMateriasPrimasTiposDelete]", "ArticulosMateriasPrimasTiposSelectDgv", "ArticulosMateriasPrimasTiposSelectDgvByMateriaPrimaTipoID")
    End Sub

    Public Function Select_Record(ByVal MateriaPrimaTipoID As Int32, ByRef dtb as BasesParaCompatibilidad.Database) As DBO_ArticulosMateriasPrimasTipos
        dtb.Conectar()
        Dim DBO_ArticulosMateriasPrimasTipos As New DBO_ArticulosMateriasPrimasTipos
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosMateriasPrimasTiposSelect]")
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@MateriaPrimaTipoID", MateriaPrimaTipoID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosMateriasPrimasTipos.MateriaPrimaTipoID = If(reader("MateriaPrimaTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MateriaPrimaTipoID")))
                DBO_ArticulosMateriasPrimasTipos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosMateriasPrimasTipos.Liquido = If(reader("Liquido") Is Convert.DBNull, False, Convert.ToBoolean(reader("Liquido")))
                DBO_ArticulosMateriasPrimasTipos.CertificadoOGM = If(reader("CertificadoOGM") Is Convert.DBNull, False, Convert.ToBoolean(reader("CertificadoOGM")))
                DBO_ArticulosMateriasPrimasTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosMateriasPrimasTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosMateriasPrimasTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosMateriasPrimasTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ArticulosMateriasPrimasTipos
    End Function

    Public Function ArticulosMateriasPrimasTiposInsert(ByVal dbo_ArticulosMateriasPrimasTipos As DBO_ArticulosMateriasPrimasTipos, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosMateriasPrimasTiposInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosMateriasPrimasTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Liquido", dbo_ArticulosMateriasPrimasTipos.Liquido)
        insertCommand.Parameters.AddWithValue("@CertificadoOGM", dbo_ArticulosMateriasPrimasTipos.CertificadoOGM)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosMateriasPrimasTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosMateriasPrimasTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosMateriasPrimasTipos.UsuarioModificacion)
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

    Public Function ArticulosMateriasPrimasTiposUpdate(ByVal newDBO_ArticulosMateriasPrimasTipos As DBO_ArticulosMateriasPrimasTipos, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()

        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosMateriasPrimasTiposUpdate]")
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosMateriasPrimasTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewLiquido", newDBO_ArticulosMateriasPrimasTipos.Liquido)
        updateCommand.Parameters.AddWithValue("@NewCertificadoOGM", newDBO_ArticulosMateriasPrimasTipos.CertificadoOGM)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosMateriasPrimasTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosMateriasPrimasTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosMateriasPrimasTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldMateriaPrimaTipoID", newDBO_ArticulosMateriasPrimasTipos.MateriaPrimaTipoID)
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
            MessageBox.Show("Error en UpdateArticulosMateriasPrimasTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function


    Public Function ArticulosMateriasPrimasTiposDelete(ByVal MateriaPrimaTipoID As Int32, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosMateriasPrimasTiposDelete]")
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldMateriaPrimaTipoID", MateriaPrimaTipoID)
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

    Public Sub GrabarArticulosMateriasPrimasTipos(ByVal dbo_ArticulosMateriasPrimasTipos As DBO_ArticulosMateriasPrimasTipos, ByRef dtb as BasesParaCompatibilidad.Database)
        If dbo_ArticulosMateriasPrimasTipos.MateriaPrimaTipoID = 0 Then
            ArticulosMateriasPrimasTiposInsert(dbo_ArticulosMateriasPrimasTipos, dtb)
        Else
            ArticulosMateriasPrimasTiposUpdate(dbo_ArticulosMateriasPrimasTipos, dtb)
        End If
    End Sub

End Class
