Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntAlbaranCargaProMaestro
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private dtsAlb As New dtsAlbaranCargaProMaestro.AlbaranCargaProMaestroDataTable
    Private ctlAlb As New ctlAlbaranCargaProMaestro

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        FechaDateTimePicker.activarFoco()
    End Sub

    Public Sub CargarDatos(ByVal Pos As Integer, _
                           ByVal AlbaranCargaProMaestroID As Integer, _
                           ByVal Numero As Integer, _
                           ByVal Fecha As DateTime, _
                           ByVal ResponsableCargaID As Integer, _
                           ByVal Observaciones As String, _
                           ByVal Reserva1 As String, _
                           ByVal Reserva2 As String, _
                           ByVal Reserva3 As String)

        Posicion = Pos
        ctlAlb.SetAlbaranCargaProMaestroID(AlbaranCargaProMaestroID)

        NumeroCuadroDeTexto.Text = Numero.ToString
        FechaDateTimePicker.Value = Fecha
        ResponsableCargaIDCuadroDeTexto.Text = ResponsableCargaID.ToString

        'ObservacionesCuadroDeTexto.Text = Observaciones
        'Reserva1CuadroDeTexto.Text = Reserva1
        'Reserva2CuadroDeTexto.Text = Reserva2
        'Reserva3CuadroDeTexto.Text = Reserva3
    End Sub

    Private Sub frmEntAlbaranCargaProMaestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlAlb.mostrarTodosAlbaranCargaProMaestro(dtsAlb)
            GeneralBindingSource.DataSource = dtsAlb
            GeneralBindingSource.Position = Posicion
        End If

        'Cortar y Pegar en el designer en la parte inferior de la funcion InitializeComponent()
        '**************************** Inicio codigo Generador ********************************* 
        Me.NumeroCuadroDeTexto.TabIndex = 1
        Me.NumeroCuadroDeTexto.Obligatorio = False
        Me.NumeroCuadroDeTexto.Numerico_EsNumerico = True
        Me.NumeroCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.FechaDateTimePicker.TabIndex = 2
        Me.FechaDateTimePicker.Format = DateTimePickerFormat.Short
        Me.FechaDateTimePicker.ShowUpDown = False
        Me.ResponsableCargaIDCuadroDeTexto.TabIndex = 3
        Me.ResponsableCargaIDCuadroDeTexto.Obligatorio = False
        Me.ResponsableCargaIDCuadroDeTexto.Numerico_EsNumerico = True
        Me.ResponsableCargaIDCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.ObservacionesCuadroDeTexto.TabIndex = 4
        Me.ObservacionesCuadroDeTexto.Obligatorio = False
        Me.ObservacionesCuadroDeTexto.MaxLength = 250
        Me.Reserva1CuadroDeTexto.TabIndex = 5
        Me.Reserva1CuadroDeTexto.Obligatorio = False
        Me.Reserva1CuadroDeTexto.MaxLength = 50
        Me.Reserva2CuadroDeTexto.TabIndex = 6
        Me.Reserva2CuadroDeTexto.Obligatorio = False
        Me.Reserva2CuadroDeTexto.MaxLength = 50
        Me.Reserva3CuadroDeTexto.TabIndex = 7
        Me.Reserva3CuadroDeTexto.Obligatorio = False
        Me.Reserva3CuadroDeTexto.MaxLength = 50
        '**************************** Final codigo Generador ********************************* 


    End Sub

    Overrides Sub Guardar()
        Try
            If Me.Text.Substring(0, 8) = "Insertar" Then
                ctlAlb.GuardarAlbaranCargaProMaestro((NumeroCuadroDeTexto.Text), _
                                                     FechaDateTimePicker.Value + " " + TimeOfDay, _
                                                     (ResponsableCargaIDCuadroDeTexto.Text), _
                                                     ObservacionesCuadroDeTexto.Text, _
                                                     Reserva1CuadroDeTexto.Text, _
                                                     Reserva2CuadroDeTexto.Text, _
                                                     Reserva3CuadroDeTexto.Text)
            End If

            If Me.Text.Substring(0, 9) = "Mod" Then
                ctlAlb.GuardarAlbaranCargaProMaestro((NumeroCuadroDeTexto.Text), _
                                                     FechaDateTimePicker.Value + " " + TimeOfDay, _
                                                     (ResponsableCargaIDCuadroDeTexto.Text), _
                                                     ObservacionesCuadroDeTexto.Text, _
                                                     Reserva1CuadroDeTexto.Text, _
                                                     Reserva2CuadroDeTexto.Text, _
                                                     Reserva3CuadroDeTexto.Text)

            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
