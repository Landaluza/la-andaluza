

Class spPedidosProveedoresMaestros
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosProveedoresMaestrosSelect]", "[dbo].[PedidosProveedoresMaestrosInsert]", "[dbo].[PedidosProveedoresMaestrosUpdate]", _
                   "[dbo].[PedidosProveedoresMaestrosDelete]", "PedidosProveedoresMaestrosSelectDgv", String.Empty)
    End Sub

    Public Function Select_Record(ByVal PedidoProveedorMaestroID As Int32) As DBO_PedidosProveedoresMaestros
        BasesParaCompatibilidad.BD.Conectar()
        Dim Dbo_PedidosProveedoresMaestros As New DBO_PedidosProveedoresMaestros
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PedidosProveedoresMaestrosSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PedidoProveedorMaestroID", PedidoProveedorMaestroID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PedidosProveedoresMaestros.PedidoProveedorMaestroID = If(reader("PedidoProveedorMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorMaestroID")))
                Dbo_PedidosProveedoresMaestros.Numero = If(reader("Numero") Is Convert.DBNull, 0, Convert.ToInt32(reader("Numero")))
                Dbo_PedidosProveedoresMaestros.ProveedorID = If(reader("ProveedorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorID")))
                Dbo_PedidosProveedoresMaestros.FechaEmision = If(reader("FechaEmision") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaEmision")))
                Dbo_PedidosProveedoresMaestros.FechaServicio = If(reader("FechaServicio") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaServicio")))
                Dbo_PedidosProveedoresMaestros.EstadoID = If(reader("EstadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EstadoID")))
                Dbo_PedidosProveedoresMaestros.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                Dbo_PedidosProveedoresMaestros.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                Dbo_PedidosProveedoresMaestros.SolicitanteID = If(reader("SolicitanteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("SolicitanteID")))
                Dbo_PedidosProveedoresMaestros.PedidosProveedoresEstados_PedidoProveedorEstadoID = If(reader("PedidosProveedoresEstados_PedidoProveedorEstadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidosProveedoresEstados_PedidoProveedorEstadoID")))
            Else
                Dbo_PedidosProveedoresMaestros = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return Dbo_PedidosProveedoresMaestros
    End Function

    Public Function InsertPedidosProveedoresMaestros(ByVal dbo_PedidosProveedoresMaestros As DBO_PedidosProveedoresMaestros) As Boolean
        'Encontrar el numero mayor
        dbo_PedidosProveedoresMaestros.Numero = (BasesParaCompatibilidad.BD.ConsultaVer("max(Numero)", "PedidosProveedoresMaestros").Rows(0).Item(0)) + 1
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[PedidosProveedoresMaestrosInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Numero", dbo_PedidosProveedoresMaestros.Numero)
        insertCommand.Parameters.AddWithValue("@ProveedorID", dbo_PedidosProveedoresMaestros.ProveedorID)
        insertCommand.Parameters.AddWithValue("@FechaEmision", dbo_PedidosProveedoresMaestros.FechaEmision)
        insertCommand.Parameters.AddWithValue("@FechaServicio", dbo_PedidosProveedoresMaestros.FechaServicio)
        insertCommand.Parameters.AddWithValue("@EstadoID", dbo_PedidosProveedoresMaestros.EstadoID)
        insertCommand.Parameters.AddWithValue("@Observaciones", if(dbo_PedidosProveedoresMaestros.Observaciones_IsDBNull = True, Convert.DBNull, dbo_PedidosProveedoresMaestros.Observaciones))
        insertCommand.Parameters.AddWithValue("@SolicitanteID", dbo_PedidosProveedoresMaestros.SolicitanteID)
        insertCommand.Parameters.AddWithValue("@PedidosProveedoresEstados_PedidoProveedorEstadoID", dbo_PedidosProveedoresMaestros.PedidosProveedoresEstados_PedidoProveedorEstadoID)
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

    Public Function UpdatePedidosProveedoresMaestros(ByVal oldDbo_PedidosProveedoresMaestros As DBO_PedidosProveedoresMaestros, ByVal newDbo_PedidosProveedoresMaestros As DBO_PedidosProveedoresMaestros) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PedidosProveedoresMaestrosUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        'Comento la linea siguiente Para que el usuario no pueda cambiar el numero de pedido
        'updateCommand.Parameters.AddWithValue("@NewNumero", newDbo_PedidosProveedoresMaestros.Numero)
        updateCommand.Parameters.AddWithValue("@NewProveedorID", newDbo_PedidosProveedoresMaestros.ProveedorID)
        updateCommand.Parameters.AddWithValue("@NewFechaEmision", newDbo_PedidosProveedoresMaestros.FechaEmision)
        updateCommand.Parameters.AddWithValue("@NewFechaServicio", newDbo_PedidosProveedoresMaestros.FechaServicio)
        updateCommand.Parameters.AddWithValue("@NewEstadoID", newDbo_PedidosProveedoresMaestros.EstadoID)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", if(newDbo_PedidosProveedoresMaestros.Observaciones_IsDBNull = True, Convert.DBNull, newDbo_PedidosProveedoresMaestros.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewSolicitanteID", newDbo_PedidosProveedoresMaestros.SolicitanteID)
        updateCommand.Parameters.AddWithValue("@NewPedidosProveedoresEstados_PedidoProveedorEstadoID", newDbo_PedidosProveedoresMaestros.PedidosProveedoresEstados_PedidoProveedorEstadoID)
        updateCommand.Parameters.AddWithValue("@OldPedidoProveedorMaestroID", oldDbo_PedidosProveedoresMaestros.PedidoProveedorMaestroID)
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
            MessageBox.Show("Error en UpdatePedidosProveedoresMaestros" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function DeletePedidosProveedoresMaestros(ByVal PedidoProveedorMaestroID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[PedidosProveedoresMaestrosDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPedidoProveedorMaestroID", PedidoProveedorMaestroID)
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

    Public Function UpdatePedidosProveedoresMaestros_RutaPDF(ByVal PedidoProveedorMaestroID As Integer, ByVal RutaPDF As String) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PedidosProveedoresMaestros_RutaPDF_Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        'Para que el usuario no pueda cambiar el numero de pedido
        updateCommand.Parameters.AddWithValue("@NewRutaPDF", RutaPDF)
        updateCommand.Parameters.AddWithValue("@OldPedidoProveedorMaestroID", PedidoProveedorMaestroID)
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
            MessageBox.Show("Error en UpdatePedidosProveedoresMaestros_RutaPDF" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function CopyPedidosProveedores(ByVal PedidoProveedorMaestroID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim copyProcedure As String = "[dbo].[PedidosProveedoresCopy]"
        Dim copyCommand as new System.Data.SqlClient.SqlCommand(copyProcedure, connection)
        copyCommand.CommandType = CommandType.StoredProcedure
        copyCommand.Parameters.AddWithValue("@PedidoProveedorMaestroID", PedidoProveedorMaestroID)
        copyCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        copyCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

        Try
            copyCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(copyCommand.Parameters("@ReturnValue").Value)
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

    Public Function SelectProveedoresMailsPedidos(ByVal ProveedorID As Integer) As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ProveedoresMailsPedidosSelectDgvByProveedorID]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ProveedorID", ProveedorID)
        Dim dt As New DataTable

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
        Return dt
    End Function

    'Public Function SelectArticulosFichasTecnicasByProveedorID(ByVal ProveedorID As Integer) As DataTable
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim selectProcedure As String = "[dbo].[ArticulosFichasTecnicasByProveedorIDSelect]"
    '    Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    selectCommand.Parameters.AddWithValue("@ProveedorID", ProveedorID)
    '    Dim dt As New DataTable
    '    Try
    '        
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
    '        If reader.HasRows Then
    '            dt.Load(reader)
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        connection.Close()
    '    End Try
    '    Return dt
    'End Function

    'Public Function SelectArticulosFichasTecnicasByMaestroID(ByVal MaestroID As Integer) As DataTable
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim selectProcedure As String = "[dbo].[ArticulosFichasTecnicasByMaestroIDSelect]"
    '    Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    selectCommand.Parameters.AddWithValue("@MaestroID", MaestroID)
    '    Dim dt As New DataTable
    '    Try
    '        
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
    '        If reader.HasRows Then
    '            dt.Load(reader)
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        connection.Close()
    '    End Try
    '    Return dt
    'End Function

End Class
