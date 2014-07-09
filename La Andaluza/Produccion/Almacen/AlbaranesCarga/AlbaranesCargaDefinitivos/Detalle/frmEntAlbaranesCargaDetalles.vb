Public Class frmEntAlbaranesCargaDetalles

    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Dim dtsAlb As New dtsAlbaranesCargaDetalles.AlbaranesCargaDetallesDataTable
    Dim ctlAlb As New ctlAlbaranesCargaDetalles

    Overrides Sub Guardar()
        Try
            If Me.Text.Substring(0, 8) = "Insertar" Then
                ctlAlb.GuardarAlbaranCargaDetalle(AlbaranCargaMaestroIDCuadroDeTexto.Text, _
                                                  SccCuadroDeTexto.Text, _
                                                  CodigoQSCuadroDeTexto.Text, _
                                                  AticuloDescripcionCuadroDeTexto.Text, _
                                                  CajasCuadroDeTexto.Text, _
                                                  UnidadMedidaCuadroDeTexto.Text, _
                                                  LoteCuadroDeTexto.Text, _
                                                  TipoPaletCuadroDeTexto.Text, _
                                                  ObservacionesCuadroDeTexto.Text, _
                                                  Reserva1CuadroDeTexto.Text, _
                                                  Reserva2CuadroDeTexto.Text, _
                                                  Reserva3CuadroDeTexto.Text)
                Me.Close()
            End If
            If Me.Text.Substring(0, 9) = "Modificar" Then
                ctlAlb.GuardarAlbaranCargaDetalle( _
                           AlbaranCargaMaestroIDCuadroDeTexto.Text, _
                           SccCuadroDeTexto.Text, _
                           CodigoQSCuadroDeTexto.Text, _
                           AticuloDescripcionCuadroDeTexto.Text, _
                           CajasCuadroDeTexto.Text, _
                           UnidadMedidaCuadroDeTexto.Text, _
                           LoteCuadroDeTexto.Text, _
                           TipoPaletCuadroDeTexto.Text, _
                           ObservacionesCuadroDeTexto.Text, _
                           Reserva1CuadroDeTexto.Text, _
                           Reserva2CuadroDeTexto.Text, _
                           Reserva3CuadroDeTexto.Text)
                Me.Close()
            End If
        Catch ex As Exception
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEntAlbaranesCargaDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlAlb.mostrarTodosAlbaranesCargaDetalles(dtsAlb)
            GeneralBindingSource.DataSource = dtsAlb
            GeneralBindingSource.Position = Posicion
        End If

        'Cortar y Pegar en el designer en la parte inferior de la funcion InitializeComponent()
        '**************************** Inicio codigo Generador ********************************* 
        Me.AlbaranCargaMaestroIDCuadroDeTexto.TabIndex = 1
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Obligatorio = False
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Numerico_EsNumerico = True
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.SccCuadroDeTexto.TabIndex = 2
        Me.SccCuadroDeTexto.Obligatorio = False
        Me.SccCuadroDeTexto.Numerico_EsNumerico = True
        Me.SccCuadroDeTexto.Numerico_SeparadorMiles = True
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
        Me.UnidadMedidaCuadroDeTexto.TabIndex = 6
        Me.UnidadMedidaCuadroDeTexto.Obligatorio = False
        Me.UnidadMedidaCuadroDeTexto.MaxLength = 50
        Me.LoteCuadroDeTexto.TabIndex = 7
        Me.LoteCuadroDeTexto.Obligatorio = False
        Me.LoteCuadroDeTexto.MaxLength = 20
        Me.TipoPaletCuadroDeTexto.TabIndex = 8
        Me.TipoPaletCuadroDeTexto.Obligatorio = False
        Me.TipoPaletCuadroDeTexto.MaxLength = 50
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

    Public Sub CargarDatos(ByVal Pos As Integer, ByVal AlbaranCargaDetalleID As Integer, _
               ByVal AlbaranCargaMaestroID As Integer, _
               ByVal Scc As Integer, _
               ByVal CodigoQS As Integer, _
               ByVal AticuloDescripcion As String, _
               ByVal Cajas As Integer, _
               ByVal UnidadMedida As String, _
               ByVal Lote As String, _
               ByVal TipoPalet As String, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String)
        Posicion = Pos
        ctlAlb.SetAlbaranCargaDetalleID(AlbaranCargaDetalleID)
        AlbaranCargaMaestroIDCuadroDeTexto.Text = AlbaranCargaMaestroID
        SccCuadroDeTexto.Text = Scc
        CodigoQSCuadroDeTexto.Text = CodigoQS
        AticuloDescripcionCuadroDeTexto.Text = AticuloDescripcion
        CajasCuadroDeTexto.Text = Cajas
        UnidadMedidaCuadroDeTexto.Text = UnidadMedida
        LoteCuadroDeTexto.Text = Lote
        TipoPaletCuadroDeTexto.Text = TipoPalet
        ObservacionesCuadroDeTexto.Text = Observaciones
        Reserva1CuadroDeTexto.Text = Reserva1
        Reserva2CuadroDeTexto.Text = Reserva2
        Reserva3CuadroDeTexto.Text = Reserva3
    End Sub

End Class
