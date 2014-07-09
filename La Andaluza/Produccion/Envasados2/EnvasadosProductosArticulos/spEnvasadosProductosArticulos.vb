

Class spEnvasadosProductosArticulos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[EnvasadosProductosArticulosSelect]", "[dbo].[EnvasadosProductosArticulosInsert]", String.Empty, _
                   "[dbo].[EnvasadosProductosArticulosDelete]", String.Empty, "EnvasadosProductosArticulosSelectDgvByFormatoEnvasadoID")
    End Sub
    Public Function Select_Record(ByVal EnvasadoProductoArticuloID As Int32) As DBO_EnvasadosProductosArticulos
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_EnvasadosProductosArticulos As New DBO_EnvasadosProductosArticulos
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[EnvasadosProductosArticulosSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoProductoArticuloID", EnvasadoProductoArticuloID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_EnvasadosProductosArticulos.EnvasadoProductoArticuloID = If(reader("EnvasadoProductoArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoProductoArticuloID")))
                DBO_EnvasadosProductosArticulos.FormatoEnvasadoID = If(reader("FormatoEnvasadoID") Is Convert.DBNull, Nothing, Convert.ToInt32(reader("FormatoEnvasadoID")))
                DBO_EnvasadosProductosArticulos.LoteTerminadoID = If(reader("LoteTerminadoID") Is Convert.DBNull, Nothing, Convert.ToInt32(reader("LoteTerminadoID")))
                DBO_EnvasadosProductosArticulos.CantidadAsignada = If(reader("CantidadAsignada") Is Convert.DBNull, 0, Convert.ToInt32(reader("CantidadAsignada")))
                DBO_EnvasadosProductosArticulos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_EnvasadosProductosArticulos.CantidadAsignada = If(reader("Merma") Is Convert.DBNull, Nothing, Convert.ToInt32(reader("Merma")))
                DBO_EnvasadosProductosArticulos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosProductosArticulos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_EnvasadosProductosArticulos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_EnvasadosProductosArticulos
    End Function

    Public Function EnvasadosProductosArticulosInsert(ByVal dbo_EnvasadosProductosArticulos As DBO_EnvasadosProductosArticulos, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[EnvasadosProductosArticulosInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        If Not trans Is Nothing Then insertCommand.Transaction = trans

        insertCommand.Parameters.AddWithValue("@FormatoEnvasadoID", If(dbo_EnvasadosProductosArticulos.FormatoEnvasadoID.HasValue, dbo_EnvasadosProductosArticulos.FormatoEnvasadoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@LoteTerminadoID", If(dbo_EnvasadosProductosArticulos.LoteTerminadoID.HasValue, dbo_EnvasadosProductosArticulos.LoteTerminadoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@CantidadAsignada", If(dbo_EnvasadosProductosArticulos.CantidadAsignada.HasValue, dbo_EnvasadosProductosArticulos.CantidadAsignada, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_EnvasadosProductosArticulos.Observaciones)
        insertCommand.Parameters.AddWithValue("@Merma", dbo_EnvasadosProductosArticulos.Merma)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_EnvasadosProductosArticulos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_EnvasadosProductosArticulos.UsuarioModificacion)

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
            If trans Is Nothing Then connection.Close()
        End Try
    End Function

    Public Function EnvasadosProductosArticulosDelete(ByVal EnvasadoProductoArticuloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[EnvasadosProductosArticulosDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        If Not trans Is Nothing Then deleteCommand.Transaction = trans
        deleteCommand.Parameters.AddWithValue("@OldEnvasadoProductoArticuloID", EnvasadoProductoArticuloID)
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
            If trans Is Nothing Then connection.Close()
        End Try
    End Function

    Public Function GrabarEnvasadosProductosArticulos(ByVal dbo_EnvasadosProductosArticulos As DBO_EnvasadosProductosArticulos, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        dbo_EnvasadosProductosArticulos.FechaModificacion = System.DateTime.Now.date
        dbo_EnvasadosProductosArticulos.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        Return EnvasadosProductosArticulosInsert(dbo_EnvasadosProductosArticulos, trans)
    End Function

    Function ExistenTrasiegos(ByVal id As Integer) As Boolean
        Dim cuenta As Integer = 0

        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[LotesSelectMovimientos]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@loteID", id)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                cuenta = If(reader("cuenta") Is Convert.DBNull, 0, Convert.ToInt32(reader("cuenta")))
            End If

            reader.Close()
            Return If(cuenta > 0, True, False)
        Catch ex As Exception
            messagebox.show("Error al consultar los movimientos." & Environment.NewLine & _
                   "Se dehabilitara la generacion de trasiegos hasta poderse comprobar. Detalles:" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        Finally
            connection.Close()
        End Try
    End Function


End Class
