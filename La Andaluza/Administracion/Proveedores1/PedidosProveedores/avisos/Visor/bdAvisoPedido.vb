Namespace Proveedores
    Public Class bdAvisoPedido
        Inherits BasesParaCompatibilidad.DataBase

        Public Function seleccionar_avisos_por_articulo_y_proveedor(ByVal proveedor As Integer, ByVal articulo As Integer) As DataTable

            'PrepararConsulta("select id from avisospedidos where " & _
            '                 "(id_articulo= @art and id_proveedor is null) or (id_articulo is null and id_proveedor = @pro) or " & _
            '                 "(id_articulo= @art and id_proveedor = @pro) " & _
            '                 "and leido = 0")
            PrepararConsulta("select id from avisospedidos where " & _
                             "(id_articulo= @art and id_proveedor is null) or (id_articulo is null and id_proveedor is null) " & _
                             " or (id_articulo= @art and id_proveedor = @pro) " & _
                             "and leido = 0")

            AñadirParametroConsulta("@art", articulo)
            AñadirParametroConsulta("@pro", proveedor)

            Return Consultar()
        End Function

        Public Function seleccionar_avisos_por_proveedor(ByVal proveedor As Integer) As DataTable

            PrepararConsulta("select id from avisospedidos where " & _
                             "id_articulo is null and (id_proveedor = @pro or id_proveedor is null) " & _
                             "and leido = 0")

            AñadirParametroConsulta("@pro", proveedor)

            Return Consultar()
        End Function

        Public Function seleccionar_detalles_aviso(ByVal id As Integer) As DataTable

            PrepararConsulta("select fecha, cabecera, detalle from avisospedidos " & _
                             "where id = @id")

            AñadirParametroConsulta("@id", id)

            Return Consultar()
        End Function

        Public Function marcar_leido(ByVal id As Integer) As Boolean
            PrepararConsulta("update avisosPedidos set leido = 1 where id= @id")
            AñadirParametroConsulta("@id", id)
            Return Execute()
        End Function
    End Class

End Namespace