﻿

Public Class lstPedidosProveedoresPendientes
    ' Private bw As System.ComponentModel.BackgroundWorker
    Private orden As Integer
    Private fecha As String
    Private proveedor As Integer    
    Private mSQL As String = Nothing


    Public Sub New()
        'bw = New System.ComponentModel.BackgroundWorker
        'AddHandler bw.DoWork, AddressOf cargar_datos
        'AddHandler bw.RunWorkerCompleted, AddressOf FastReport
    End Sub

    Public Sub GenerarListado()
        Dim frm As New frmElegirOrdenListadoPedidos
        frm.ShowDialog()
        Me.orden = frm.Seleccion
        Me.fecha = frm.Fecha
        Me.proveedor = frm.Proveedor
        frm.Dispose()
        'bw.RunWorkerAsync()
        FastReport()
    End Sub

    Private Sub cargar_datos()
        Select Case Me.orden
            Case 1
                mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 ORDER BY OrderBy"
            Case 2
                mSQL = "SELECT Proveedores.Nombre + CONVERT(varchar(10), PedidosProveedoresMaestros.Numero) AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 ORDER BY OrderBy"
                'mSQL = "SELECT Proveedores.Nombre + LEFT(CONVERT(VARCHAR, PedidosProveedoresMaestros.FechaServicio, 120), 10) + CONVERT(varchar(10), PedidosProveedoresMaestros.Numero) AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 ORDER BY OrderBy"
            Case 3
                mSQL = "SELECT LEFT(CONVERT(VARCHAR, PedidosProveedoresMaestros.FechaServicio, 120), 10) + CONVERT(varchar(10), PedidosProveedoresMaestros.Numero) AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 ORDER BY OrderBy"
            Case 4
                mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 AND convert(varchar(10),PedidosProveedoresMaestros.FechaServicio,112) = " & fecha & " ORDER BY OrderBy"
            Case 5
                mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 AND Proveedores.Proveedorid = " & Me.proveedor.ToString & " ORDER BY OrderBy"
            Case 6
                mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 AND PedidosProveedoresMaestros.FechaServicio < SYSDATETIME() ORDER BY OrderBy"
        End Select

    End Sub

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
                mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 AND convert(varchar(10),PedidosProveedoresMaestros.FechaServicio,112) = " & fecha & " ORDER BY OrderBy"
            Case 5
                mSQL = "SELECT PedidosProveedoresMaestros.Numero AS OrderBy, PedidosProveedoresMaestros.PedidoProveedorMaestroID, PedidosProveedoresMaestros.Numero, Proveedores.Nombre, PedidosProveedoresMaestros.FechaEmision, PedidosProveedoresMaestros.FechaServicio, PedidosProveedoresMaestros.EstadoID, PedidosProveedoresMaestros.Observaciones as Observaciones1, PedidosProveedoresDetalles.PedidoProveedorDetalleID, PedidosProveedoresDetalles.Cantidad as Cantidad1, isnull(PedidosProveedoresDetalles.Observaciones, '') as Observaciones2, PedidosProveedoresDetalles.PedidoProveedorMaestroID, Articulos1.DescripcionLA, PedidosProveedoresEstados.Descripcion AS Estado, isnull(Articulos1.CodigoQS,'-') CodigoQS, convert(NVARCHAR, PedidosProveedoresEntregas.Fecha, 103) as Fecha, PedidosProveedoresEntregas.Cantidad as Cantidad2, PedidosProveedoresEntregas.Observaciones as Observaciones3 FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresDetalles ON PedidosProveedoresMaestros.PedidoProveedorMaestroID = PedidosProveedoresDetalles.PedidoProveedorMaestroID INNER JOIN Articulos1 ON PedidosProveedoresDetalles.ArticuloID = Articulos1.ArticuloID INNER JOIN PedidosProveedoresEstados ON PedidosProveedoresDetalles.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID LEFT JOIN PedidosProveedoresEntregas ON PedidosProveedoresDetalles.PedidoProveedorDetalleID = PedidosProveedoresEntregas.PedidoProveedorDetalleID WHERE PedidosProveedoresMaestros.EstadoID < 5 AND PedidosProveedoresDetalles.EstadoID <> 5 AND Proveedores.Proveedorid = " & Me.proveedor.ToString & " ORDER BY OrderBy"
            Case 6
                origen = Config.PedidosPendientesIncumplidos
        End Select


        Dim report As New ReportAdapter.Reporte(BasesParaCompatibilidad.Config.connectionString, origen)

        Try
            report.abrir()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Dim report As New Report
        'Dim table As TableDataSource

        'Try
        '    '.Load("\\192.168.1.200Administracion\Proveedores1\PedidosProveedores\Listados\report1.frx")
        '    'report.Load("\\192.168.1.200\datos\informatica\La Andaluza app\report1.frx")
        '    report.Load(Config.PedidosPendientes)
        'Catch ex As Exception
        '    MessageBox.Show("Problema cargando el informe, revise que el archivo se encuentre en el servidor", "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End Try        
        'report.SetParameterValue("MyParameter", BasesParaCompatibilidad.Config.connectionString)

        'Try
        '    table = TryCast(report.GetDataSource("tblReport1"), TableDataSource)
        'Catch ex As Exception
        '    MessageBox.Show("Problema recuperando los datos para el informe", "Error de consulta a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End Try

        'table.SelectCommand = mSQL
        'report.Show()
    End Sub

End Class
