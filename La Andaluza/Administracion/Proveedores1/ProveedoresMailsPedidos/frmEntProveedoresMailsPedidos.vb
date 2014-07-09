Public Class frmEntProveedoresMailsPedidos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ProveedoresMailsPedidos As DBO_ProveedoresMailsPedidos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProveedoresMailsPedidos = Nothing, Optional ByRef v_dbo As DBO_ProveedoresMailsPedidos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spProveedoresMailsPedidos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_ProveedoresMailsPedidos = if(v_dbo Is Nothing, New DBO_ProveedoresMailsPedidos, v_dbo)
        dbo = m_DBO_ProveedoresMailsPedidos
    End Sub


    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_ProveedoresMailsPedidos = CType(dbo, DBO_ProveedoresMailsPedidos)

        txtNombre.Text = m_DBO_ProveedoresMailsPedidos.Nombre
        txtMail.Text = m_DBO_ProveedoresMailsPedidos.Mail
        txtCargo.Text = m_DBO_ProveedoresMailsPedidos.Cargo
        txtObservaciones.Text = m_DBO_ProveedoresMailsPedidos.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_ProveedoresMailsPedidos.Nombre = txtNombre.Text


        If txtMail.Text = "" Then
            If errores = "" Then txtMail.Focus()
            errores = errores & "El campo Mail no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_ProveedoresMailsPedidos.Mail = txtMail.Text
        End If


        m_DBO_ProveedoresMailsPedidos.Cargo = txtCargo.Text
        m_DBO_ProveedoresMailsPedidos.Observaciones = txtObservaciones.Text


        If errores = String.empty Then
            Dbo = CType(m_DBO_ProveedoresMailsPedidos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub frmEntProveedoresMailsPedidos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
