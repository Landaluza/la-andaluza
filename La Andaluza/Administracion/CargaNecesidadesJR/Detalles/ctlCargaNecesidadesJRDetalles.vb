Public Class ctlCargaNecesidadesJRDetalles
    Private clsCar As clsCargaNecesidadesJRDetalles
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()
        clsCar = New clsCargaNecesidadesJRDetalles
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
    End Sub

    Public Function GetCargaNecesidadesJRDetalleID() As Integer
        Return clsCar._CargaNecesidadesJRDetalleID
    End Function

    Public Sub SetCargaNecesidadesJRDetalleID(ByVal ID As Integer)
        clsCar._CargaNecesidadesJRDetalleID = ID
    End Sub


    Public Sub mostrarTodosCargaNecesidadesJRDetalles(ByRef dts As dtsCargaNecesidadesJRDetalles.CargaNecesidadesJRDetallesDataTable)
        Dim tabla As New DataTable
        tabla = clsCar.Devolver(dtb)
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsCargaNecesidadesJRDetalles.CargaNecesidadesJRDetallesRow
        While i < tabla.Rows.Count
            reg = dts.NewCargaNecesidadesJRDetallesRow
            reg.CargaNecesidadesJRDetalleID = tabla.Rows(i).Item(0)
            reg.CargaNecesidadesJRMaestroID = tabla.Rows(i).Item(1)
            reg.ArticuloID = tabla.Rows(i).Item(2)
            reg.Carga = tabla.Rows(i).Item(3)
            reg.Stock = tabla.Rows(i).Item(4)
            reg.Observaciones = tabla.Rows(i).Item(5)
            reg.Reserva1 = tabla.Rows(i).Item(6)
            reg.Reserva2 = tabla.Rows(i).Item(7)
            reg.Reserva3 = tabla.Rows(i).Item(8)
            dts.AddCargaNecesidadesJRDetallesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

 

    Public Sub EliminarCargaNecesidadesJRDetalle()
        clsCar.Eliminar()
    End Sub
End Class
