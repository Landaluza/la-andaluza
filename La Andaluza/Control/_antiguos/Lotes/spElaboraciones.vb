Public Class spElaboraciones
    Private web As BasesParaCompatibilidad.Web
    Public Sub New()

        Me.web = New BasesParaCompatibilidad.Web
    End Sub

    Public Function aprobar_lote_mezcla(ByVal loteid As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try
            Dim query As String = "update elaboraciones set estado = 2, completado=1 where id_lote=" & loteid
            If dtb.ConsultaAlteraciones(query) Then
                dtb.PrepararConsulta("select codigoLote from lotes where loteid = @id")
                dtb.AñadirParametroConsulta("@id", loteid)
                web.send_GET("Lote aprobado, " & dtb.Consultar().Rows(0).Item(0), web.recuperar_id_tablet(17, dtb))
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function deprobar_lote_mezcla(ByVal loteid As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try
            Dim query As String = "update elaboraciones set estado = 3 where id_lote=" & loteid

            If dtb.ConsultaAlteraciones(query) Then
                dtb.PrepararConsulta("select codigoLote from lotes where loteid = @id")
                dtb.AñadirParametroConsulta("@id", loteid)
                web.send_GET("Lote NO aprobado, " & dtb.Consultar().Rows(0).Item(0), web.recuperar_id_tablet(17, dtb))
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function repetir_muestra_mezcla(ByVal loteid As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try
            Dim query As String = "update elaboraciones set estado = 4 where id_lote=" & loteid
            If dtb.ConsultaAlteraciones(query) Then
                dtb.PrepararConsulta("select codigoLote from lotes where loteid = @id")
                dtb.AñadirParametroConsulta("@id", loteid)
                web.send_GET("Repetir muestra del lote " & dtb.Consultar().Rows(0).Item(0), web.recuperar_id_tablet(17, dtb))
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function procede_de_elaboracion(ByVal loteid As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try
            dtb.PrepararConsulta("select count(*) from elaboraciones where isnull(revisado,0)<>1 and (isnull(estado,0) = 1 or isnull(estado,0) = 4) and id_lote = @id")
            dtb.AñadirParametroConsulta("@id", loteid)
            Dim dt As DataTable = dtb.Consultar()
            If dt.Rows(0).Item(0) > 0 Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
