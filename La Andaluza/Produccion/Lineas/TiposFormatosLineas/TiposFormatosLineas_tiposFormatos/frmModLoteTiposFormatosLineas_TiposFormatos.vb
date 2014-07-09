Public Class frmModLoteTiposFormatosLineas_TiposFormatos
    Private resultado As DialogResult

    Public ReadOnly Property retorno As DialogResult
        Get
            Return Me.resultado
        End Get
    End Property

    Public ReadOnly Property velocidad_modificada As Boolean
        Get
            Return Me.chbVelocidad.Checked
        End Get
    End Property

    Public ReadOnly Property personal_modificado As Boolean
        Get
            Return Me.chbPersonal.Checked
        End Get
    End Property

    Public ReadOnly Property velocidad As Integer
        Get
            Return Me.txtVelocidad.Text
        End Get
    End Property

    Public ReadOnly Property personal As Integer
        Get
            Return Me.txtPersonal.Text
        End Get
    End Property

    Private Sub chbVelocidad_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbVelocidad.CheckedChanged
        Me.txtVelocidad.Enabled = Me.chbVelocidad.Checked
    End Sub

    Private Sub chbPersonal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbPersonal.CheckedChanged
        Me.txtPersonal.Enabled = Me.chbPersonal.Checked
    End Sub

    Private Function getValores() As Boolean
        Dim errores As String = String.Empty

        If Me.chbVelocidad.Checked Then
            If Not IsNumeric(txtVelocidad.Text) Then
                If errores = "" Then txtVelocidad.Focus()
                errores = errores & "El campo Velocidad debe ser numérico." & Environment.NewLine
            End If
        End If

        If Me.chbPersonal.Checked Then
            If Not IsNumeric(txtPersonal.Text) Then
                If errores = "" Then txtPersonal.Focus()
                errores = errores & "El campo 'personal recomendado' debe ser numérico." & Environment.NewLine
            Else
                If Not txtPersonal.Text > 0 Then
                    If errores = "" Then txtPersonal.Focus()
                    errores = errores & "El campo 'personal recomendado' debe ser mayor que cero." & Environment.NewLine
                End If
            End If
        End If

        If errores = String.Empty Then
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.getValores Then
            Me.resultado = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub frmModLoteTiposFormatosLineas_TiposFormatos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.resultado = Windows.Forms.DialogResult.Cancel
    End Sub
End Class