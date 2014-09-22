Public Class frmCambiarDesposito
    Private ctlDep As ctlDepositos
    Private OldLib As OldLib
    Private loteID As Integer
    Public Sub New(ByVal loteid As Integer, ByVal depositoid As String)
        InitializeComponent()

        Me.loteID = loteid
        ctlDep = New ctlDepositos
        OldLib = New OldLib
        Dim tabdep As DataTable = ctlDep.devolverDepositosporCodigo()
        cboDeposito.DataSource = OldLib.HacerTablasNoObligatorias(tabdep)
        cboDeposito.ValueMember = "ID"
        cboDeposito.DisplayMember = "Display"
        cboDeposito.SelectedText = depositoid
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If guardar Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function guardar() As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Dim dep As String
        If chbSinDeposito.Checked Then
            dep = "null"
        Else
            dep = cboDeposito.SelectedValue.ToString
        End If
        Return dtb.ConsultaAlteraciones("update lotes set depositoid =" & dep & " where loteid =" & Me.loteID)
    End Function
End Class