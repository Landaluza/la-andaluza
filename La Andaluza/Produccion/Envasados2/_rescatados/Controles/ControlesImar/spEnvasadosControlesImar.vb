

Public Class spEnvasadosControlesImar
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[EnvasadosControlesImarSelect]", "[dbo].[EnvasadosControlesImarInsert]", "[dbo].[EnvasadosControlesImarUpdate]", "[dbo].[EnvasadosControlesImarDelete]", "", "EnvasadosControlesImarSelectDgvByEnvasadoControlID ")
    End Sub
    Public Function SelectByEnvasadoControlID(ByVal EnvasadoControlID As Int32) As DBO_EnvasadosControlesImar
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_EnvasadosControlesImar As New DBO_EnvasadosControlesImar
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[EnvasadosControlesImarSelectByEnvasadoControlID]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoControlID", EnvasadoControlID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_EnvasadosControlesImar.EnvasadoControlImarID = If(reader("EnvasadoControlImarID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlImarID")))
                DBO_EnvasadosControlesImar.EnvasadoControlID = If(reader("EnvasadoControlID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlID")))
                DBO_EnvasadosControlesImar.Peso1 = If(reader("Peso1") Is Convert.DBNull, False, Convert.ToBoolean(reader("Peso1")))
                DBO_EnvasadosControlesImar.Peso2 = If(reader("Peso2") Is Convert.DBNull, False, Convert.ToBoolean(reader("Peso2")))
                DBO_EnvasadosControlesImar.Peso3 = If(reader("Peso3") Is Convert.DBNull, False, Convert.ToBoolean(reader("Peso3")))
                DBO_EnvasadosControlesImar.Peso4 = If(reader("Peso4") Is Convert.DBNull, False, Convert.ToBoolean(reader("Peso4")))
                DBO_EnvasadosControlesImar.Peso5 = If(reader("Peso5") Is Convert.DBNull, False, Convert.ToBoolean(reader("Peso5")))
                DBO_EnvasadosControlesImar.Peso6 = If(reader("Peso6") Is Convert.DBNull, False, Convert.ToBoolean(reader("Peso6")))
                DBO_EnvasadosControlesImar.SuciedadExterior = If(reader("SuciedadExterior") Is Convert.DBNull, False, Convert.ToBoolean(reader("SuciedadExterior")))
                DBO_EnvasadosControlesImar.MaterialExtraños = If(reader("MaterialExtraños") Is Convert.DBNull, False, Convert.ToBoolean(reader("MaterialExtraños")))
                DBO_EnvasadosControlesImar.FormaDelSobre = If(reader("FormaDelSobre") Is Convert.DBNull, False, Convert.ToBoolean(reader("FormaDelSobre")))
                DBO_EnvasadosControlesImar.BordesAbiertos = If(reader("BordesAbiertos") Is Convert.DBNull, False, Convert.ToBoolean(reader("BordesAbiertos")))
                DBO_EnvasadosControlesImar.BordesManchados = If(reader("BordesManchados") Is Convert.DBNull, False, Convert.ToBoolean(reader("BordesManchados")))
                DBO_EnvasadosControlesImar.SeparacionMonodosis = If(reader("SeparacionMonodosis") Is Convert.DBNull, False, Convert.ToBoolean(reader("SeparacionMonodosis")))
                DBO_EnvasadosControlesImar.AbreFaciles = If(reader("AbreFaciles") Is Convert.DBNull, False, Convert.ToBoolean(reader("AbreFaciles")))
                DBO_EnvasadosControlesImar.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosControlesImar.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                'DBO_EnvasadosControlesImar = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_EnvasadosControlesImar
    End Function


  

    Public Function EnvasadosControlesImarInsert(ByVal dbo_EnvasadosControlesImar As DBO_EnvasadosControlesImar) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[EnvasadosControlesImarInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        
        insertCommand.Parameters.AddWithValue("@EnvasadoControlID", If(dbo_EnvasadosControlesImar.EnvasadoControlID.HasValue, dbo_EnvasadosControlesImar.EnvasadoControlID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Peso1", dbo_EnvasadosControlesImar.Peso1)
        insertCommand.Parameters.AddWithValue("@Peso2", dbo_EnvasadosControlesImar.Peso2)
        insertCommand.Parameters.AddWithValue("@Peso3", dbo_EnvasadosControlesImar.Peso3)
        insertCommand.Parameters.AddWithValue("@Peso4", dbo_EnvasadosControlesImar.Peso4)
        insertCommand.Parameters.AddWithValue("@Peso5", dbo_EnvasadosControlesImar.Peso5)
        insertCommand.Parameters.AddWithValue("@Peso6", dbo_EnvasadosControlesImar.Peso6)
        insertCommand.Parameters.AddWithValue("@SuciedadExterior", dbo_EnvasadosControlesImar.SuciedadExterior)
        insertCommand.Parameters.AddWithValue("@MaterialExtraños", dbo_EnvasadosControlesImar.MaterialExtraños)
        insertCommand.Parameters.AddWithValue("@FormaDelSobre", dbo_EnvasadosControlesImar.FormaDelSobre)
        insertCommand.Parameters.AddWithValue("@BordesAbiertos", dbo_EnvasadosControlesImar.BordesAbiertos)
        insertCommand.Parameters.AddWithValue("@BordesManchados", dbo_EnvasadosControlesImar.BordesManchados)
        insertCommand.Parameters.AddWithValue("@SeparacionMonodosis", dbo_EnvasadosControlesImar.SeparacionMonodosis)
        insertCommand.Parameters.AddWithValue("@AbreFaciles", dbo_EnvasadosControlesImar.AbreFaciles)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_EnvasadosControlesImar.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_EnvasadosControlesImar.UsuarioModificacion)
        
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
            connection.Close()
        End Try
    End Function

    Public Function EnvasadosControlesImarUpdate(ByVal newDBO_EnvasadosControlesImar As DBO_EnvasadosControlesImar) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[EnvasadosControlesImarUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewEnvasadoControlID", If(newDBO_EnvasadosControlesImar.EnvasadoControlID.HasValue, newDBO_EnvasadosControlesImar.EnvasadoControlID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewPeso1", newDBO_EnvasadosControlesImar.Peso1)
        updateCommand.Parameters.AddWithValue("@NewPeso2", newDBO_EnvasadosControlesImar.Peso2)
        updateCommand.Parameters.AddWithValue("@NewPeso3", newDBO_EnvasadosControlesImar.Peso3)
        updateCommand.Parameters.AddWithValue("@NewPeso4", newDBO_EnvasadosControlesImar.Peso4)
        updateCommand.Parameters.AddWithValue("@NewPeso5", newDBO_EnvasadosControlesImar.Peso5)
        updateCommand.Parameters.AddWithValue("@NewPeso6", newDBO_EnvasadosControlesImar.Peso6)
        updateCommand.Parameters.AddWithValue("@NewSuciedadExterior", newDBO_EnvasadosControlesImar.SuciedadExterior)
        updateCommand.Parameters.AddWithValue("@NewMaterialExtraños", newDBO_EnvasadosControlesImar.MaterialExtraños)
        updateCommand.Parameters.AddWithValue("@NewFormaDelSobre", newDBO_EnvasadosControlesImar.FormaDelSobre)
        updateCommand.Parameters.AddWithValue("@NewBordesAbiertos", newDBO_EnvasadosControlesImar.BordesAbiertos)
        updateCommand.Parameters.AddWithValue("@NewBordesManchados", newDBO_EnvasadosControlesImar.BordesManchados)
        updateCommand.Parameters.AddWithValue("@NewSeparacionMonodosis", newDBO_EnvasadosControlesImar.SeparacionMonodosis)
        updateCommand.Parameters.AddWithValue("@NewAbreFaciles", newDBO_EnvasadosControlesImar.AbreFaciles)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_EnvasadosControlesImar.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_EnvasadosControlesImar.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldEnvasadoControlImarID", newDBO_EnvasadosControlesImar.EnvasadoControlImarID)
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
            MessageBox.Show("Error en UpdateEnvasadosControlesImar" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub GrabarEnvasadosControlesImar(ByVal dbo_EnvasadosControlesImar As DBO_EnvasadosControlesImar)
        dbo_EnvasadosControlesImar.FechaModificacion = System.DateTime.Now.date
        dbo_EnvasadosControlesImar.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_EnvasadosControlesImar.EnvasadoControlImarID = 0 Then
            EnvasadosControlesImarInsert(dbo_EnvasadosControlesImar)
        Else
            EnvasadosControlesImarUpdate(dbo_EnvasadosControlesImar)
        End If
    End Sub

End Class
