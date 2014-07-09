Public Class frmDoyPackInfoExtra
    Private formato As Integer
    Private spTiposFormatos As spArticulosEnvasadosHistoricos
    Public ReadOnly Property result As Integer
        Get
            Return Me.formato
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        spTiposFormatos = New spArticulosEnvasadosHistoricos
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.formato = 0
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Me.formato = cboFormato.SelectedValue
        Me.Close()
    End Sub

    Private Sub frmDoyPackInfoExtra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        spTiposFormatos.cargar_TiposFormatos_Todos(Me.cboFormato)
    End Sub

    Private Sub frmDoyPackInfoExtra_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.Panel1, Me)
    End Sub
End Class