Public Class frmCambiarDesposito
    Private ctlDep As ctlDepositos
    Private OldLib As OldLib
    Private loteID As Integer
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal loteid As Integer, ByVal depositoid As String)
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase()
        Me.loteID = loteid
        ctlDep = New ctlDepositos
        OldLib = New OldLib
        Dim tabdep As DataTable = ctlDep.devolverDepositosporCodigo(dtb)
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
        Dim dep As String
        If chbSinDeposito.Checked Then
            dep = "null"
        Else
            dep = cboDeposito.SelectedValue.ToString
        End If

        dtb.PrepararConsulta("update lotes set depositoid = @dep where loteid = @lot")
        dtb.AñadirParametroConsulta("@dep", dep)
        dtb.AñadirParametroConsulta("@lot", Me.loteID)
        Return dtb.Execute
    End Function
End Class