

Public Class spAlbaranesCarga
    Public Function spDeleteAlbaranCargaSeguridadAllPedido(ByVal pedido As Integer) As Boolean
        Return spDeleteAlbaranCargaSeguridadAll(pedido, Nothing)
    End Function

    Public Function spDeleteAlbaranCargaSeguridadAllOrdenCarga(ByVal OrdenCarga As Integer) As Boolean
        Return spDeleteAlbaranCargaSeguridadAll(Nothing, OrdenCarga)
    End Function

    Public Sub spDeleteAlbaranCargaSeguridad(ByVal ValorSCC As Integer)
        BasesParaCompatibilidad.BD.Conectar()
        Try
            Dim cmd as new System.Data.SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = BasesParaCompatibilidad.BD.Cnx
            cmd.CommandText = "DeleteAlbaranCargaSeguridad"

            cmd.Parameters.AddWithValue("@SCC", ValorSCC)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            messagebox.show("Error en BD.spDeleteAlbaranCargaSeguridad" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        BasesParaCompatibilidad.BD.Cerrar()
    End Sub

    Public Function spDeleteAlbaranCargaDetalle(ByVal ValorSCC As Integer) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Try
            Dim cmd as new System.Data.SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = BasesParaCompatibilidad.BD.Cnx
            cmd.CommandText = "DeleteAlbaranCargaDetalle"

            cmd.Parameters.AddWithValue("@SCC", ValorSCC)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            messagebox.show("Error en BD.DeleteAlbaranCargaDetalle" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            BasesParaCompatibilidad.BD.Cerrar()
        End Try

    End Function

    Public Function devolverPalet(ByVal ValorSCC As Integer) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Try
            Dim cmd as new System.Data.SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = BasesParaCompatibilidad.BD.Cnx
            cmd.CommandText = "DeleteAlbaranCargaDevolverPalet"

            cmd.Parameters.AddWithValue("@SCC", ValorSCC)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            messagebox.show("Error en BD.DeleteAlbaranCargaDevolverPalet" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            BasesParaCompatibilidad.BD.Cerrar()
        End Try

    End Function

    Private Function spDeleteAlbaranCargaSeguridadAll(ByVal pedido As Integer, ByVal ordenCarga As Integer) As Boolean
        If ordenCarga = Nothing Then
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
            Try
                Dim cmd as new System.Data.SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = BasesParaCompatibilidad.BD.Cnx
                cmd.CommandText = "DeleteAlbaranCargaSeguridadAllPedido"
                If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then cmd.Transaction = BasesParaCompatibilidad.BD.transaction
                cmd.Parameters.AddWithValue("@pedido", pedido)

                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                messagebox.show("Error en BD.spDeleteAlbaranCargaSeguridadAllPedido" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Cerrar()
            End Try
        Else
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
            Try
                Dim cmd as new System.Data.SqlClient.SqlCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = BasesParaCompatibilidad.BD.Cnx
                cmd.CommandText = "DeleteAlbaranCargaSeguridadAllOC"
                If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then cmd.Transaction = BasesParaCompatibilidad.BD.transaction
                cmd.Parameters.AddWithValue("@orden", pedido)

                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                messagebox.show("Error en BD.spDeleteAlbaranCargaSeguridadAllOC" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Cerrar()
            End Try
        End If
    End Function

    Public Sub spInsertAlbaranCargaSeguridad(ByVal ValorSCC As Integer, _
                                           ByVal ValorCodigoQS As Integer, _
                                           ByVal ValorArticuloDescripcion As String, _
                                           ByVal ValorCajas As Integer, _
                                           ByVal ValorUnidadMedidaID As Integer, _
                                           ByVal ValorLote As String, _
                                           ByVal ValorTipoPaletID As Integer, _
                                           ByVal Peso As String, _
                                           ByVal ValorObservaciones As String, _
                                           ByVal ValorReserva1 As String, _
                                           ByVal ValorReserva2 As String, _
                                           ByVal ValorReserva3 As String, _
                                           ByVal ValorFechaModificacion As Date, _
                                           ByVal ValorUsuarioModificacion As Integer, _
                                           ByVal pedido As Integer, _
                                           ByVal ordenCarga As Integer, _
                                           ByVal loteAlternativo As String,
                                           ByVal sinpalet As Boolean)

        BasesParaCompatibilidad.BD.Conectar()
        Try
            Dim cmd as new System.Data.SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = BasesParaCompatibilidad.BD.Cnx
            cmd.CommandText = "InsertAlbaranCargaSeguridad4"
            cmd.Parameters.AddWithValue("@pedido", if(pedido = 0, Convert.DBNull, pedido))
            cmd.Parameters.AddWithValue("@ordenCarga", ordenCarga)
            cmd.Parameters.AddWithValue("@SCC", ValorSCC)
            cmd.Parameters.AddWithValue("@CodigoQS", ValorCodigoQS)
            cmd.Parameters.AddWithValue("@ArticuloDescripcion", ValorArticuloDescripcion)
            cmd.Parameters.AddWithValue("@Cajas", ValorCajas)
            cmd.Parameters.AddWithValue("@UnidadMedidaID", ValorUnidadMedidaID)
            cmd.Parameters.AddWithValue("@Lote", ValorLote)
            cmd.Parameters.AddWithValue("@TipoPaletID", ValorTipoPaletID)
            cmd.Parameters.AddWithValue("@Peso", Peso)
            cmd.Parameters.AddWithValue("@Observaciones", ValorObservaciones)
            cmd.Parameters.AddWithValue("@Reserva1", ValorReserva1)
            cmd.Parameters.AddWithValue("@Reserva2", ValorReserva2)
            cmd.Parameters.AddWithValue("@Reserva3", ValorReserva3)
            cmd.Parameters.AddWithValue("@LoteAlternativo", loteAlternativo)
            cmd.Parameters.AddWithValue("@FechaModificacion", ValorFechaModificacion)
            cmd.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
            cmd.Parameters.AddWithValue("@sinpalet", sinpalet)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            messagebox.show("Error en BD.spInsertAlbaranCargaSeguridad" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        BasesParaCompatibilidad.BD.Cerrar()
    End Sub

    Public Function spMaxAlbaranCargaProMaestro() As Integer
        Dim MaxID As Integer = 0
        Try
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
            Dim cmd as new System.Data.SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = BasesParaCompatibilidad.BD.Cnx
            cmd.CommandText = "MaxAlbaranCargaProMaestro"
            If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then cmd.Transaction = BasesParaCompatibilidad.BD.transaction

            MaxID = (cmd.ExecuteScalar())
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Cerrar()
            Return MaxID
        Catch ex As Exception
            messagebox.show("Error en BD.spMaxAlbaranCargaProMaestroID" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
End Class
