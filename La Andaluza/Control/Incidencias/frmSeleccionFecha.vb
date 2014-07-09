Imports BasesParaCompatibilidad.dtpExtension
Public Class frmSeleccionFecha
    Private fecha As DateTime

    Public Sub New()

        InitializeComponent()

        Me.dtpFecha.activarFoco()
    End Sub
    Public ReadOnly Property FechaSeleccionada As Date
        Get
            Return Me.fecha
        End Get
    End Property

    Public ReadOnly Property FechaHoraSeleccionada As DateTime
        Get
            Return Me.fecha
        End Get
    End Property

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.fecha = New Date(Me.dtpFecha.Value.Year, Me.dtpFecha.Value.Month, Me.dtpFecha.Value.Day)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class