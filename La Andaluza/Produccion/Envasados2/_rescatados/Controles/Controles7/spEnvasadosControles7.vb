

Class spEnvasadosControles7
    Inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[EnvasadosControles7SelectByEnvasadoControlID]", "[dbo].[EnvasadosControles7Insert]", "[dbo].[EnvasadosControles7Update]", _
                   "[dbo].[EnvasadosControles7Delete]", "EnvasadosControles7SelectDgv", "EnvasadosControles7SelectDgvByEnvasadoControlID")
    End Sub
    Public Function SelectByEnvasadoControlID(ByVal EnvasadoControlID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_EnvasadosControles7
        dtb.Conectar()
        Dim DBO_EnvasadosControles1 As New DBO_EnvasadosControles7

        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(Me.selectProcedureName)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoControlID", EnvasadoControlID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_EnvasadosControles1.EnvasadoControl1ID = If(reader("EnvasadoControl1ID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControl1ID")))
                DBO_EnvasadosControles1.EnvasadoControlID = If(reader("EnvasadoControlID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlID")))
                DBO_EnvasadosControles1.Roscador1 = If(reader("Roscador1") Is Convert.DBNull, False, Convert.ToBoolean(reader("Roscador1")))
                DBO_EnvasadosControles1.Roscador2 = If(reader("Roscador2") Is Convert.DBNull, False, Convert.ToBoolean(reader("Roscador2")))
                DBO_EnvasadosControles1.Roscador3 = If(reader("Roscador3") Is Convert.DBNull, False, Convert.ToBoolean(reader("Roscador3")))
                DBO_EnvasadosControles1.Roscador4 = If(reader("Roscador4") Is Convert.DBNull, False, Convert.ToBoolean(reader("Roscador4")))
                DBO_EnvasadosControles1.Roscador5 = If(reader("Roscador5") Is Convert.DBNull, False, Convert.ToBoolean(reader("Roscador5")))
                DBO_EnvasadosControles1.Roscador6 = If(reader("Roscador6") Is Convert.DBNull, False, Convert.ToBoolean(reader("Roscador6")))

                DBO_EnvasadosControles1.NivelDeLlenado = If(reader("NivelDeLlenado") Is Convert.DBNull, False, Convert.ToBoolean(reader("NivelDeLlenado")))
                DBO_EnvasadosControles1.Cara = If(reader("Cara") Is Convert.DBNull, False, Convert.ToBoolean(reader("Cara")))
                DBO_EnvasadosControles1.Contra = If(reader("Contra") Is Convert.DBNull, False, Convert.ToBoolean(reader("Contra")))
                DBO_EnvasadosControles1.Capsula = If(reader("Capsula") Is Convert.DBNull, False, Convert.ToBoolean(reader("Capsula")))
                DBO_EnvasadosControles1.Retrocapsula = If(reader("Retrocapsula") Is Convert.DBNull, False, Convert.ToBoolean(reader("Retrocapsula")))
                DBO_EnvasadosControles1.Caja = If(reader("Caja") Is Convert.DBNull, False, Convert.ToBoolean(reader("Caja")))
                DBO_EnvasadosControles1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosControles1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                'DBO_EnvasadosControles1 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_EnvasadosControles1
    End Function

    Public Function EnvasadosControles1Insert(ByVal dbo_EnvasadosControles1 As DBO_EnvasadosControles7, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(Me.insertProcedureName)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@EnvasadoControlID", If(dbo_EnvasadosControles1.EnvasadoControlID.HasValue, dbo_EnvasadosControles1.EnvasadoControlID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Roscador1", dbo_EnvasadosControles1.Roscador1)
        insertCommand.Parameters.AddWithValue("@Roscador2", dbo_EnvasadosControles1.Roscador2)
        insertCommand.Parameters.AddWithValue("@Roscador3", dbo_EnvasadosControles1.Roscador3)
        insertCommand.Parameters.AddWithValue("@Roscador4", dbo_EnvasadosControles1.Roscador4)
        insertCommand.Parameters.AddWithValue("@Roscador5", dbo_EnvasadosControles1.Roscador5)
        insertCommand.Parameters.AddWithValue("@Roscador6", dbo_EnvasadosControles1.Roscador6)
        insertCommand.Parameters.AddWithValue("@NivelDeLlenado", dbo_EnvasadosControles1.NivelDeLlenado)
        insertCommand.Parameters.AddWithValue("@Cara", dbo_EnvasadosControles1.Cara)
        insertCommand.Parameters.AddWithValue("@Contra", dbo_EnvasadosControles1.Contra)
        insertCommand.Parameters.AddWithValue("@Capsula", dbo_EnvasadosControles1.Capsula)
        insertCommand.Parameters.AddWithValue("@Retrocapsula", dbo_EnvasadosControles1.Retrocapsula)
        insertCommand.Parameters.AddWithValue("@Caja", dbo_EnvasadosControles1.Caja)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_EnvasadosControles1.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_EnvasadosControles1.UsuarioModificacion)

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
            Throw
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function EnvasadosControles1Update(ByVal newDBO_EnvasadosControles1 As DBO_EnvasadosControles7, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(Me.updateProcedureName)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewEnvasadoControlID", If(newDBO_EnvasadosControles1.EnvasadoControlID.HasValue, newDBO_EnvasadosControles1.EnvasadoControlID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewRoscador1", newDBO_EnvasadosControles1.Roscador1)
        updateCommand.Parameters.AddWithValue("@NewRoscador2", newDBO_EnvasadosControles1.Roscador2)
        updateCommand.Parameters.AddWithValue("@NewRoscador3", newDBO_EnvasadosControles1.Roscador3)
        updateCommand.Parameters.AddWithValue("@NewRoscador4", newDBO_EnvasadosControles1.Roscador4)
        updateCommand.Parameters.AddWithValue("@NewRoscador5", newDBO_EnvasadosControles1.Roscador5)
        updateCommand.Parameters.AddWithValue("@NewRoscador6", newDBO_EnvasadosControles1.Roscador6)
        updateCommand.Parameters.AddWithValue("@NewNivelDeLlenado", newDBO_EnvasadosControles1.NivelDeLlenado)
        updateCommand.Parameters.AddWithValue("@NewCara", newDBO_EnvasadosControles1.Cara)
        updateCommand.Parameters.AddWithValue("@NewContra", newDBO_EnvasadosControles1.Contra)
        updateCommand.Parameters.AddWithValue("@NewCapsula", newDBO_EnvasadosControles1.Capsula)
        updateCommand.Parameters.AddWithValue("@NewRetrocapsula", newDBO_EnvasadosControles1.Retrocapsula)
        updateCommand.Parameters.AddWithValue("@NewCaja", newDBO_EnvasadosControles1.Caja)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_EnvasadosControles1.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_EnvasadosControles1.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldEnvasadoControl1ID", newDBO_EnvasadosControles1.EnvasadoControl1ID)
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
            MessageBox.Show("Error en UpdateEnvasadosControles1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Sub GrabarEnvasadosControles1(ByVal dbo_EnvasadosControles1 As DBO_EnvasadosControles7, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_EnvasadosControles1.FechaModificacion = System.DateTime.Now.Date
        dbo_EnvasadosControles1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_EnvasadosControles1.EnvasadoControl1ID = 0 Then
            EnvasadosControles1Insert(dbo_EnvasadosControles1, dtb)
        Else
            EnvasadosControles1Update(dbo_EnvasadosControles1, dtb)
        End If
    End Sub

End Class
