

Class spVisitasNombres1
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[VisitasNombres1Select]", "[dbo].[VisitasNombres1Insert]", _
                   "[dbo].[VisitasNombres1Update]", "[dbo].[VisitasNombres1Delete]", _
                   "VisitasNombres1SelectDgv", "VisitasNombres1SelectDgvByID")
    End Sub


    Public Function Select_Record(ByVal VisitaNombreID As Int32) As DBO_VisitasNombres1
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_VisitasNombres1 As New DBO_VisitasNombres1
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[VisitasNombres1Select]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@VisitaNombreID", VisitaNombreID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                
                DBO_VisitasNombres1.VisitaNombreID = If(reader("VisitaNombreID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitaNombreID")))
                DBO_VisitasNombres1.EmpresaID = If(reader("EmpresaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EmpresaID")))
                DBO_VisitasNombres1.Nombre = If(reader("Nombre") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Nombre")))
                DBO_VisitasNombres1.DNI = If(reader("DNI") Is Convert.DBNull, String.Empty, Convert.ToString(reader("DNI")))
                DBO_VisitasNombres1.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_VisitasNombres1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_VisitasNombres1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_VisitasNombres1.VisitaTipoID = If(reader("VisitaTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitaTipoID")))
                
            Else
                DBO_VisitasNombres1 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show("Error en select_record. Detalles" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
        Return DBO_VisitasNombres1
    End Function

    Public Function VisitasNombres1Insert(ByVal dbo_VisitasNombres1 As DBO_VisitasNombres1) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[VisitasNombres1Insert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        
        insertCommand.Parameters.AddWithValue("@EmpresaID", If(dbo_VisitasNombres1.EmpresaID.HasValue, dbo_VisitasNombres1.EmpresaID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Nombre", dbo_VisitasNombres1.Nombre)
        insertCommand.Parameters.AddWithValue("@DNI", dbo_VisitasNombres1.DNI)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_VisitasNombres1.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_VisitasNombres1.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_VisitasNombres1.UsuarioModificacion)
        insertCommand.Parameters.AddWithValue("@VisitaTipoID", If(dbo_VisitasNombres1.VisitaTipoID.HasValue, dbo_VisitasNombres1.VisitaTipoID, Convert.DBNull))
        
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

    Public Function VisitasNombres1Update(ByVal newDBO_VisitasNombres1 As DBO_VisitasNombres1) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[VisitasNombres1Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewEmpresaID", If(newDBO_VisitasNombres1.EmpresaID.HasValue, newDBO_VisitasNombres1.EmpresaID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewNombre", newDBO_VisitasNombres1.Nombre)
        updateCommand.Parameters.AddWithValue("@NewDNI", newDBO_VisitasNombres1.DNI)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_VisitasNombres1.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_VisitasNombres1.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_VisitasNombres1.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@NewVisitaTipoID", If(newDBO_VisitasNombres1.VisitaTipoID.HasValue, newDBO_VisitasNombres1.VisitaTipoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@OldVisitaNombreID", newDBO_VisitasNombres1.VisitaNombreID)
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
            MessageBox.Show("Error en UpdateVisitasNombres1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function VisitasNombres1Delete(ByVal VisitaNombreID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[VisitasNombres1Delete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldVisitaNombreID", VisitaNombreID)
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
            connection.Close()
        End Try
    End Function

    Public Sub GrabarVisitasNombres1(ByVal dbo_VisitasNombres1 As DBO_VisitasNombres1)
        dbo_VisitasNombres1.FechaModificacion = System.DateTime.Now.date
        dbo_VisitasNombres1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_VisitasNombres1.VisitaNombreID = 0 Then
            VisitasNombres1Insert(dbo_VisitasNombres1)
        Else
            VisitasNombres1Update(dbo_VisitasNombres1)
        End If
    End Sub

End Class
