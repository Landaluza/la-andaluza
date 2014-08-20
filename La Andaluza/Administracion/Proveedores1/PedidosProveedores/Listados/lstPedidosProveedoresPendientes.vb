

Public Class lstPedidosProveedoresPendientes
    ' Private bw As System.ComponentModel.BackgroundWorker
    Private orden As Integer
    Private fecha As String
    Private proveedor As Integer    
    'Private mSQL As String = Nothing




    Public Sub GenerarListado()
        Dim frm As New frmElegirOrdenListadoPedidos
        If frm.ShowDialog() = DialogResult.OK Then
            Me.orden = frm.Seleccion
            Me.fecha = frm.Fecha
            Me.proveedor = frm.Proveedor
            frm.Dispose()
            'bw.RunWorkerAsync()
            FastReport()
        End If
    End Sub

    'Private Sub cargar_datos()
    '    Select Case Me.orden
    '        Case 1
    '            mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 ORDER BY OrderBy"
    '        Case 2
    '            mSQL = "SELECT Proveedores.Nombre + CONVERT(varchar(10), PedidosProveedoresMaestros.Numero) AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 ORDER BY OrderBy"
    '            'mSQL = "SELECT Proveedores.Nombre + LEFT(CONVERT(VARCHAR, PedidosProveedoresMaestros.FechaServicio, 120), 10) + CONVERT(varchar(10), PedidosProveedoresMaestros.Numero) AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 ORDER BY OrderBy"
    '        Case 3
    '            mSQL = "SELECT LEFT(CONVERT(VARCHAR, PedidosProveedoresMaestros.FechaServicio, 120), 10) + CONVERT(varchar(10), PedidosProveedoresMaestros.Numero) AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 ORDER BY OrderBy"
    '        Case 4
    '            mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 AND convert(varchar(10),PedidosProveedoresMaestros.FechaServicio,112) = " & fecha & " ORDER BY OrderBy"
    '        Case 5
    '            mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 AND Proveedores.Proveedorid = " & Me.proveedor.ToString & " ORDER BY OrderBy"
    '        Case 6
    '            mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 AND PedidosProveedoresMaestros.FechaServicio < SYSDATETIME() ORDER BY OrderBy"
    '    End Select

    'End Sub

    Private Sub FastReport()
        Dim origen As String = String.Empty

        Select Case Me.orden
            Case 1
                origen = Config.PedidosPendientes
            Case 2
                origen = Config.PedidosPendientesPorProveedores
            Case 3
                origen = Config.PedidosPendientesPorFecha
            Case 4
                origen = Config.PedidosPendientesUnaFecha
            Case 5
                origen = Config.PedidosPendientesUnProveedor
            Case 6
                origen = Config.PedidosPendientesIncumplidos
        End Select


        Dim report As New ReportAdapter.Reporte(BasesParaCompatibilidad.Config.connectionString, origen)

        If orden = 4 Then
            report.añadirParametro("@fecha", fecha)
        ElseIf orden = 5 Then
            report.añadirParametro("@proveedor", proveedor)
        End If

        Try
            report.abrir()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
