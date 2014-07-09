Imports BasesParaCompatibilidad.dtpExtension
Public Class frmConversorJulianoGregoriano

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.dtpGregoriana.activarFoco()

    End Sub

    Private Sub frmConversorJulianoGregoriano_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.Panconversor, Me)
    End Sub

    Private Sub btnGregorianaToJuliana_Click(sender As System.Object, e As System.EventArgs) Handles btnGregorianaToJuliana.Click
        Dim calendar As New BasesParaCompatibilidad.Calendar
        txtJuliana.Text = calendar.DevuelveFechaJuliana(dtpGregoriana.Value)
    End Sub

    Private Sub btnJulianaToGregoriana_Click(sender As System.Object, e As System.EventArgs) Handles btnJulianaToGregoriana.Click
        Try
            Dim calendar As New BasesParaCompatibilidad.Calendar
            Dim m_fecha As String = Mid(txtJuliana.Text, 4, 2) & Mid(txtJuliana.Text, 1, 3)
            dtpGregoriana.Value = calendar.JulianToSerial(m_fecha)
        Catch ex As Exception
            MessageBox.Show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class