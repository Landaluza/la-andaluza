Imports BasesParaCompatibilidad.dtpExtension
Public Class frmSeleccionDosFechas
    Private fecha As DateTime
    Private fechaInicio As DateTime

    Public Sub New()

        InitializeComponent()

        Me.dtpFecha.activarFoco()
        Me.dtpFechaInicio.activarFoco()

        fecha = New Date
        fechaInicio = New Date
    End Sub
    Public ReadOnly Property FechaFinSeleccionada As Date
        Get
            Return Me.fecha
        End Get
    End Property

    Public ReadOnly Property FechaInicioSeleccionada As Date
        Get
            Return Me.fechaInicio
        End Get
    End Property

    Public ReadOnly Property FechaHoraInicioSeleccionada As DateTime
        Get
            Return Me.fechaInicio
        End Get
    End Property

    Public ReadOnly Property FechaHoraFinSeleccionada As DateTime
        Get
            Return Me.fecha
        End Get
    End Property

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.fecha = New Date(Me.dtpFecha.Value.Year, Me.dtpFecha.Value.Month, Me.dtpFecha.Value.Day)
        Me.fechaInicio = New Date(Me.dtpFechaInicio.Value.Year, Me.dtpFechaInicio.Value.Month, Me.dtpFechaInicio.Value.Day)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class