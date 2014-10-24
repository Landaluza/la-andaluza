

Public Class spAlbaranesCarga
    Public Function spDeleteAlbaranCargaSeguridadAllPedido(ByVal pedido As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return spDeleteAlbaranCargaSeguridadAll(pedido, Nothing, dtb)
    End Function

    Public Function spDeleteAlbaranCargaSeguridadAllOrdenCarga(ByVal OrdenCarga As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return spDeleteAlbaranCargaSeguridadAll(Nothing, OrdenCarga, dtb)
    End Function

    Public Sub spDeleteAlbaranCargaSeguridad(ByVal ValorSCC As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.Conectar()
        Try
            Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("DeleteAlbaranCargaSeguridad")

            cmd.Parameters.AddWithValue("@SCC", ValorSCC)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error en BD.spDeleteAlbaranCargaSeguridad" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        dtb.Desconectar()
    End Sub

    Public Function spDeleteAlbaranCargaDetalle(ByVal ValorSCC As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()
        Try
            Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("DeleteAlbaranCargaDetalle")

            cmd.Parameters.AddWithValue("@SCC", ValorSCC)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error en BD.DeleteAlbaranCargaDetalle" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Desconectar()
        End Try

    End Function

    Public Function devolverPalet(ByVal ValorSCC As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()
        Try
            Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("DeleteAlbaranCargaDevolverPalet")

            cmd.Parameters.AddWithValue("@SCC", ValorSCC)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error en BD.DeleteAlbaranCargaDevolverPalet" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Desconectar()
        End Try

    End Function

    Private Function spDeleteAlbaranCargaSeguridadAll(ByVal pedido As Integer, ByVal ordenCarga As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If ordenCarga = Nothing Then
            dtb.Conectar()
            Try
                Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("DeleteAlbaranCargaSeguridadAllPedido")

                cmd.Parameters.AddWithValue("@pedido", pedido)

                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error en BD.spDeleteAlbaranCargaSeguridadAllPedido" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                dtb.Desconectar()
            End Try
        Else
            dtb.Conectar()
            Try
                Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("DeleteAlbaranCargaSeguridadAllOC")

                cmd.Parameters.AddWithValue("@orden", pedido)

                cmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error en BD.spDeleteAlbaranCargaSeguridadAllOC" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                dtb.Desconectar()
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
                                           ByVal sinpalet As Boolean, ByRef dtb As BasesParaCompatibilidad.DataBase)

        dtb.Conectar()
        Try
            Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("InsertAlbaranCargaSeguridad4")
            cmd.Parameters.AddWithValue("@pedido", If(pedido = 0, Convert.DBNull, pedido))
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
            MessageBox.Show("Error en BD.spInsertAlbaranCargaSeguridad" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dtb.Desconectar()
    End Sub

    'Public Function spMaxAlbaranCargaProMaestro() As Integer
    '    Dim MaxID As Integer = 0
    '    Try
    '        dtb.Conectar()
    '        Dim cmd As New System.Data.SqlClient.SqlCommand
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = BasesParaCompatibilidad.BD.Cnx
    '        cmd.CommandText = "MaxAlbaranCargaProMaestro"
    '        If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then cmd.Transaction = BasesParaCompatibilidad.BD.transaction

    '        MaxID = (cmd.ExecuteScalar())
    '        dtb.Desconectar()
    '        Return MaxID
    '    Catch ex As Exception
    '        messagebox.show("Error en BD.spMaxAlbaranCargaProMaestroID" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return Nothing
    '    End Try
    'End Function
End Class
