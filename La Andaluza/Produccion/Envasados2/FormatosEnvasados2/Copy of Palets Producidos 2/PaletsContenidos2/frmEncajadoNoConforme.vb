Public Class frmEncajadoNoConforme
    Private m_result As Integer
    Private m_cantidad As Integer

    Public ReadOnly Property Result As Integer
        Get
            Return Me.m_result
        End Get
    End Property

    Public Property Cantidad As Integer
        Get
            Return Me.m_cantidad
        End Get
        Set(value As Integer)
            Me.m_cantidad = value
        End Set
    End Property

    Private Sub frmEncajadoNoConforme_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.m_result = Nothing Then
            Me.m_result = -1
        End If
    End Sub

    Private Sub btnContinuar_Click(sender As System.Object, e As System.EventArgs) Handles btnContinuar.Click
        If Me.cbNoConforme.Checked Then
            If IsNumeric(Me.txtCantidad.Text) Then
                Me.m_result = 1
                Me.m_cantidad = Me.txtCantidad.Text
                Me.Close()
            End If
        Else
            Me.m_result = -1
            Me.Close()
        End If
    End Sub

    Private Sub cbNoConforme_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbNoConforme.CheckedChanged
        Me.txtCantidad.Enabled = Me.cbNoConforme.Checked
    End Sub

    Private Sub txtCantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))    
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function
End Class