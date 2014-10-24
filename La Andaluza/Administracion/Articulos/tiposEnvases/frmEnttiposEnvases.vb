Public Class frmEnttiposEnvases
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_tiposEnvases As DBO_tiposEnvases

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As sptiposEnvases = Nothing, Optional ByRef v_dbo As DBO_tiposEnvases = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New sptiposEnvases, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_tiposEnvases = If(v_dbo Is Nothing, New DBO_tiposEnvases, v_dbo)
        dbo = m_DBO_tiposEnvases
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New sptiposEnvases, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_tiposEnvases, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_tiposEnvases = New dbo_tiposEnvases
        Else
            Me.m_DBO_tiposEnvases = CType(dbo, DBO_tiposEnvases)
        End If

        txtNombre.Text = m_DBO_tiposEnvases.Nombre
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtNombre.Text = "" Then
            If errores = "" Then txtNombre.Focus()
            errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_tiposEnvases.Nombre = txtNombre.Text
        End If



        If errores = String.empty Then
            Dbo = CType(m_DBO_tiposEnvases, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub frmEnttiposEnvases_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
