

Public Class spEnvasadosControlesUlma
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[EnvasadosControlesUlmaSelect]", "[dbo].[EnvasadosControlesUlmaInsert]", "[dbo].[EnvasadosControlesUlmaUpdate]", "[dbo].[EnvasadosControlesUlmaDelete]", "", "EnvasadosControlesUlmaSelectDgvByEnvasadoControlID ")
    End Sub

    Public Function SelectByEnvasadoControlID(ByVal EnvasadoControlID As Int32) As DBO_EnvasadosControlesUlma
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_EnvasadosControlesUlma As New DBO_EnvasadosControlesUlma
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[EnvasadosControlUlmaSelectByEnvasadoControlID]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoControlID", EnvasadoControlID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_EnvasadosControlesUlma.EnvasadoControlUlmaID = If(reader("EnvasadoControlUlmaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlUlmaID")))
                DBO_EnvasadosControlesUlma.EnvasadoControlID = If(reader("EnvasadoControlID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlID")))
                DBO_EnvasadosControlesUlma.SoldaduraBolsa = If(reader("SoldaduraBolsa") Is Convert.DBNull, False, Convert.ToBoolean(reader("SoldaduraBolsa")))
                DBO_EnvasadosControlesUlma.SuciedadBolsa = If(reader("SuciedadBolsa") Is Convert.DBNull, False, Convert.ToBoolean(reader("SuciedadBolsa")))
                DBO_EnvasadosControlesUlma.CentradoBolsa = If(reader("CentradoBolsa") Is Convert.DBNull, False, Convert.ToBoolean(reader("CentradoBolsa")))
                DBO_EnvasadosControlesUlma.DiseñoBobina = If(reader("DiseñoBobina") Is Convert.DBNull, False, Convert.ToBoolean(reader("DiseñoBobina")))
                DBO_EnvasadosControlesUlma.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosControlesUlma.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                'DBO_EnvasadosControlesUlma = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_EnvasadosControlesUlma
    End Function

    Public Function Select_Record(ByVal EnvasadoControlUlmaID As Int32) As DBO_EnvasadosControlesUlma
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_EnvasadosControlesUlma As New DBO_EnvasadosControlesUlma
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[EnvasadosControlesUlmaSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoControlUlmaID", EnvasadoControlUlmaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_EnvasadosControlesUlma.EnvasadoControlUlmaID = If(reader("EnvasadoControlUlmaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlUlmaID")))
                DBO_EnvasadosControlesUlma.EnvasadoControlID = If(reader("EnvasadoControlID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlID")))
                DBO_EnvasadosControlesUlma.SoldaduraBolsa = If(reader("SoldaduraBolsa") Is Convert.DBNull, False, Convert.ToBoolean(reader("SoldaduraBolsa")))
                DBO_EnvasadosControlesUlma.SuciedadBolsa = If(reader("SuciedadBolsa") Is Convert.DBNull, False, Convert.ToBoolean(reader("SuciedadBolsa")))
                DBO_EnvasadosControlesUlma.CentradoBolsa = If(reader("CentradoBolsa") Is Convert.DBNull, False, Convert.ToBoolean(reader("CentradoBolsa")))
                DBO_EnvasadosControlesUlma.DiseñoBobina = If(reader("DiseñoBobina") Is Convert.DBNull, False, Convert.ToBoolean(reader("DiseñoBobina")))
                DBO_EnvasadosControlesUlma.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosControlesUlma.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_EnvasadosControlesUlma = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_EnvasadosControlesUlma
    End Function

    Public Function EnvasadosControlesUlmaInsert(ByVal dbo_EnvasadosControlesUlma As DBO_EnvasadosControlesUlma) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[EnvasadosControlesUlmaInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        
        insertCommand.Parameters.AddWithValue("@EnvasadoControlID", If(dbo_EnvasadosControlesUlma.EnvasadoControlID.HasValue, dbo_EnvasadosControlesUlma.EnvasadoControlID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@SoldaduraBolsa", dbo_EnvasadosControlesUlma.SoldaduraBolsa)
        insertCommand.Parameters.AddWithValue("@SuciedadBolsa", dbo_EnvasadosControlesUlma.SuciedadBolsa)
        insertCommand.Parameters.AddWithValue("@CentradoBolsa", dbo_EnvasadosControlesUlma.CentradoBolsa)
        insertCommand.Parameters.AddWithValue("@DiseñoBobina", dbo_EnvasadosControlesUlma.DiseñoBobina)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_EnvasadosControlesUlma.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_EnvasadosControlesUlma.UsuarioModificacion)
        
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

    Public Function EnvasadosControlesUlmaUpdate(ByVal newDBO_EnvasadosControlesUlma As DBO_EnvasadosControlesUlma) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[EnvasadosControlesUlmaUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewEnvasadoControlID", If(newDBO_EnvasadosControlesUlma.EnvasadoControlID.HasValue, newDBO_EnvasadosControlesUlma.EnvasadoControlID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewSoldaduraBolsa", newDBO_EnvasadosControlesUlma.SoldaduraBolsa)
        updateCommand.Parameters.AddWithValue("@NewSuciedadBolsa", newDBO_EnvasadosControlesUlma.SuciedadBolsa)
        updateCommand.Parameters.AddWithValue("@NewCentradoBolsa", newDBO_EnvasadosControlesUlma.CentradoBolsa)
        updateCommand.Parameters.AddWithValue("@NewDiseñoBobina", newDBO_EnvasadosControlesUlma.DiseñoBobina)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_EnvasadosControlesUlma.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_EnvasadosControlesUlma.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldEnvasadoControlUlmaID", newDBO_EnvasadosControlesUlma.EnvasadoControlUlmaID)
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
            MessageBox.Show("Error en UpdateEnvasadosControlesUlma" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function EnvasadosControlesUlmaDelete(ByVal EnvasadoControlUlmaID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[EnvasadosControlesUlmaDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldEnvasadoControlUlmaID", EnvasadoControlUlmaID)
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
            Throw
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub GrabarEnvasadosControlesUlma(ByVal dbo_EnvasadosControlesUlma As DBO_EnvasadosControlesUlma)
        dbo_EnvasadosControlesUlma.FechaModificacion = System.DateTime.Now.date
        dbo_EnvasadosControlesUlma.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_EnvasadosControlesUlma.EnvasadoControlUlmaID = 0 Then
            EnvasadosControlesUlmaInsert(dbo_EnvasadosControlesUlma)
        Else
            EnvasadosControlesUlmaUpdate(dbo_EnvasadosControlesUlma)
        End If
    End Sub

End Class
