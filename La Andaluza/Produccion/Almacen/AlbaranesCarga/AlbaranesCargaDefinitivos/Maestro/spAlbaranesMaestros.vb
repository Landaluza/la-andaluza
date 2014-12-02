Imports BasesParaCompatibilidad.ComboBoxExtension
Namespace AlbaranesCarga
    Public Class spAlbaranesMaestros

        Public Function seleccionar_agencia_por_conductor(ByVal camion As Integer, dtb As BasesParaCompatibilidad.DataBase) As String
            dtb.PrepararConsulta("select camiones.AgenciaTransporteID, Nombre from Camiones, AgenciasTransportes where camiones.AgenciaTransporteID = AgenciasTransportes.AgenciaTransporteID and camionID = @id  order by CamionID ")
            dtb.AñadirParametroConsulta("@id", camion)
            Return dtb.Consultar().Rows(0).Item(0)
        End Function

        Public Function seleccionar_remolque_por_conductor(ByVal camion As Integer, dtb As BasesParaCompatibilidad.DataBase) As String
            dtb.PrepararConsulta("select MatriculaRemolque, MatriculaRemolque from Camiones where camionID = @id  order by CamionID ")
            dtb.AñadirParametroConsulta("@id", camion)
            Return dtb.Consultar().Rows(0).Item(0)
        End Function

        Public Sub seleccionar_cabeza_por_conductor(ByVal conductor As Integer, ByRef cbo As ComboBox, dtb As BasesParaCompatibilidad.DataBase)
            dtb.PrepararConsulta("select camionID , MatriculaCabeza from Camiones where ConductorHabitualID = @id  order by CamionID ")
            dtb.AñadirParametroConsulta("@id", conductor)
            cbo.mam_DataSource(dtb.Consultar(), False)
        End Sub

        Public Sub cargar_agencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
            dtb.PrepararConsulta("select AgenciaTransporteID, Nombre from AgenciasTransportes")
            cbo.mam_DataSource(dtb.Consultar(), False)
        End Sub

        Sub cargar_pedidos(cbo As ComboBox, dtb As BasesParaCompatibilidad.DataBase, ByVal cargarTodos As Boolean)
            dtb.PrepararConsulta("select  PedidosClientesMaestros.PedidoClienteMaestroID, convert(varchar,PedidosClientesMaestros.numero) + ' ' + clientes.Nombre  + ' ' + LugaresEntregas.descripcion + ' | ' + PedidosClientesMaestros.observaciones  " & _
            " from PedidosClientesMaestros left join LugaresEntregas " & _
            " on PedidosClientesMaestros.PedidoClienteLugarEntregaID  =  LugaresEntregas.LugarEntregaID  " & _
            " left join clientes " & _
            " on PedidosClientesMaestros.ClienteID = clientes.ClienteID  " & _
            If(cargarTodos, "", " where Servido = 0 ") & _
            "order by FechaEmision desc")
            cbo.mam_DataSource(dtb.Consultar(), True, "")
        End Sub

        Public Function devolver_formas_pago(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
            dtb.prepararconsulta("PagosFormasCbo")
            Return dtb.consultar
        End Function

        Public Function devolverClientes(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
            dtb.prepararconsulta("ClientesSelectCbo")
            Return dtb.consultar
        End Function

        Public Function devolver_conductores(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
            dtb.prepararconsulta("ConductoresSelectCbo")
            Return dtb.consultar
        End Function

        Public Function devolver_provisionales(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
            dtb.PrepararConsulta("SelectAlbaranCargaProMaestroByReserva1")
            Return dtb.Consultar
        End Function
    End Class



End Namespace