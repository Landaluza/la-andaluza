Public Class frmEntAlbaranesCargaProviDetalles
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Dim dtsAlb As New dtsAlbaranesCargaProviDetalles.AlbaranesCargaProviDetallesDataTable
    Dim ctlAlb As New ctlAlbaranesCargaProviDetalles

   
    Private Sub frmEntAlbaranesCargaProviDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlAlb.mostrarTodosAlbaranesCargaProviDetalles(dtsAlb)
            GeneralBindingSource.DataSource = dtsAlb
            GeneralBindingSource.Position = Posicion
        End If


        'Cortar y Pegar en el designer en la parte inferior de la funcion InitializeComponent()
        '**************************** Inicio codigo Generador ********************************* 
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.TabIndex = 1
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Obligatorio = False
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Numerico_EsNumerico = True
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.SCCCuadroDeTexto.TabIndex = 2
        Me.SCCCuadroDeTexto.Obligatorio = False
        Me.SCCCuadroDeTexto.Numerico_EsNumerico = True
        Me.SCCCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.CodigoQSCuadroDeTexto.TabIndex = 3
        Me.CodigoQSCuadroDeTexto.Obligatorio = False
        Me.CodigoQSCuadroDeTexto.Numerico_EsNumerico = True
        Me.CodigoQSCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.AticuloDescripcionCuadroDeTexto.TabIndex = 4
        Me.AticuloDescripcionCuadroDeTexto.Obligatorio = False
        Me.AticuloDescripcionCuadroDeTexto.MaxLength = 150
        Me.CajasCuadroDeTexto.TabIndex = 5
        Me.CajasCuadroDeTexto.Obligatorio = False
        Me.CajasCuadroDeTexto.Numerico_EsNumerico = True
        Me.CajasCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.UnidadMedidaIDCuadroDeTexto.TabIndex = 6
        Me.UnidadMedidaIDCuadroDeTexto.Obligatorio = False
        Me.UnidadMedidaIDCuadroDeTexto.Numerico_EsNumerico = True
        Me.UnidadMedidaIDCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.LoteCuadroDeTexto.TabIndex = 7
        Me.LoteCuadroDeTexto.Obligatorio = False
        Me.LoteCuadroDeTexto.MaxLength = 20
        Me.TipoPaletIDCuadroDeTexto.TabIndex = 8
        Me.TipoPaletIDCuadroDeTexto.Obligatorio = False
        Me.TipoPaletIDCuadroDeTexto.Numerico_EsNumerico = True
        Me.TipoPaletIDCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.ObservacionesCuadroDeTexto.TabIndex = 9
        Me.ObservacionesCuadroDeTexto.Obligatorio = False
        Me.ObservacionesCuadroDeTexto.MaxLength = 250
        Me.Reserva1CuadroDeTexto.TabIndex = 10
        Me.Reserva1CuadroDeTexto.Obligatorio = False
        Me.Reserva1CuadroDeTexto.MaxLength = 50
        Me.Reserva2CuadroDeTexto.TabIndex = 11
        Me.Reserva2CuadroDeTexto.Obligatorio = False
        Me.Reserva2CuadroDeTexto.MaxLength = 50
        Me.Reserva3CuadroDeTexto.TabIndex = 12
        Me.Reserva3CuadroDeTexto.Obligatorio = False
        Me.Reserva3CuadroDeTexto.MaxLength = 50
        '**************************** Final codigo Generador ********************************* 
    End Sub

    Public Sub CargarDatos(ByVal Pos As Integer, _
                           ByVal AlbaranCargaProviDetalleID As Integer, _
                           ByVal AlbaranCargaProviMaestroID As Integer, _
                           ByVal SCC As Integer, _
                           ByVal CodigoQS As Integer, _
                           ByVal AticuloDescripcion As String, _
                           ByVal Cajas As Integer, _
                           ByVal UnidadMedidaID As Integer, _
                           ByVal Lote As String, _
                           ByVal TipoPaletID As Integer, _
                           ByVal Observaciones As String, _
                           ByVal Reserva1 As String, _
                           ByVal Reserva2 As String, _
                           ByVal Reserva3 As String)
        Posicion = Pos
        ctlAlb.SetAlbaranCargaProviDetalleID(AlbaranCargaProviDetalleID)
        AlbaranCargaProviMaestroIDCuadroDeTexto.Text = AlbaranCargaProviMaestroID
        SCCCuadroDeTexto.Text = SCC
        CodigoQSCuadroDeTexto.Text = CodigoQS
        AticuloDescripcionCuadroDeTexto.Text = AticuloDescripcion
        CajasCuadroDeTexto.Text = Cajas
        UnidadMedidaIDCuadroDeTexto.Text = UnidadMedidaID
        LoteCuadroDeTexto.Text = Lote
        TipoPaletIDCuadroDeTexto.Text = TipoPaletID
        ObservacionesCuadroDeTexto.Text = Observaciones
        Reserva1CuadroDeTexto.Text = Reserva1
        Reserva2CuadroDeTexto.Text = Reserva2
        Reserva3CuadroDeTexto.Text = Reserva3
    End Sub

    Overrides Sub Guardar()
        Try
            If Me.Text.Substring(0, 8) = "Insertar" Then
                ctlAlb.GuardarAlbaranCargaProviDetalle(AlbaranCargaProviMaestroIDCuadroDeTexto.Text, _
                                                       SCCCuadroDeTexto.Text, _
                                                       CodigoQSCuadroDeTexto.Text, _
                                                       AticuloDescripcionCuadroDeTexto.Text, _
                                                       CajasCuadroDeTexto.Text, _
                                                       UnidadMedidaIDCuadroDeTexto.Text, _
                                                       LoteCuadroDeTexto.Text, _
                                                       TipoPaletIDCuadroDeTexto.Text, _
                                                       ObservacionesCuadroDeTexto.Text, _
                                                       Reserva1CuadroDeTexto.Text, _
                                                       Reserva2CuadroDeTexto.Text, _
                                                       Reserva3CuadroDeTexto.Text, "")
                Me.Close()

            ElseIf Me.Text.Substring(0, 9) = "Modificar" Then
                ctlAlb.GuardarAlbaranCargaProviDetalle(AlbaranCargaProviMaestroIDCuadroDeTexto.Text, _
                                                       SCCCuadroDeTexto.Text, _
                                                       CodigoQSCuadroDeTexto.Text, _
                                                       AticuloDescripcionCuadroDeTexto.Text, _
                                                       CajasCuadroDeTexto.Text, _
                                                       UnidadMedidaIDCuadroDeTexto.Text, _
                                                       LoteCuadroDeTexto.Text, _
                                                       TipoPaletIDCuadroDeTexto.Text, _
                                                       ObservacionesCuadroDeTexto.Text, _
                                                       Reserva1CuadroDeTexto.Text, _
                                                       Reserva2CuadroDeTexto.Text, _
                                                       Reserva3CuadroDeTexto.Text, "")
                Me.Close()
            End If
        Catch ex As Exception
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
