Public Class Notificador
    

    Function comprobarNotificaciones(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Dim dt As DataTable

        Try
            dtb.PrepararConsulta("Select texto, id from notificaciones where id_TipoUsuario = @id and leido = 0")
            dtb.AñadirParametroConsulta("@id", Config.UserType)
            dt = dtb.Consultar()

            'dtb.ConsultaAlteraciones("update notificaciones set leido = 1 where id_TipoUsuario = " & Config.UserType & " and leido = 0")

        Catch ex As Exception
            Return Nothing
        End Try

        Return dt
    End Function

    Public Function borrarNotificacion(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        Try
            dtb.PrepararConsulta("delete from notificaciones where id = @id")
            dtb.AñadirParametroConsulta("@id", id)
            Return dtb.Consultar(True)
        Catch ex As Exception
            Return False
        End Try
    End Function


    Function comprobarNumeroPedidos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer


        dtb.PrepararConsulta("PedidosClientesCountByDiaServicio2")
        Dim dt As DataTable = dtb.Consultar()

        If dt Is Nothing Then Return 0
        If dt.Rows(0) Is Nothing Then Return 0

        Return dt.Rows(0).Item(0)
    End Function

    Function comprobarNumeroOC(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer


        dtb.PrepararConsulta("OrdenesDeCargaCountByDiaServicio")
        Dim dt As DataTable = dtb.Consultar()

        If dt Is Nothing Then Return 0
        If dt.Rows(0) Is Nothing Then Return 0

        Return dt.Rows(0).Item(0)
    End Function
End Class
