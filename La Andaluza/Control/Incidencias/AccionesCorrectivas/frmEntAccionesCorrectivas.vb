Public Class frmEntAccionesCorrectivas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_AccionesCorrectivas As DBO_AccionesCorrectivas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAccionesCorrectivas = Nothing, Optional ByRef v_dbo As DBO_AccionesCorrectivas = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spAccionesCorrectivas, v_sp)
        m_DBO_AccionesCorrectivas = if(v_dbo Is Nothing, New DBO_AccionesCorrectivas, v_dbo)
        dbo = m_DBO_AccionesCorrectivas
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntAccionesCorrectivas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_AccionesCorrectivas = New dbo_AccionesCorrectivas
        Else
            Me.m_DBO_AccionesCorrectivas = dbo
        End If

        txtDescripcion.Text = m_DBO_AccionesCorrectivas.Descripcion
        txtObservaciones.Text = m_DBO_AccionesCorrectivas.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_AccionesCorrectivas.Descripcion = txtDescripcion.Text
        End If



        m_DBO_AccionesCorrectivas.Observaciones = txtObservaciones.Text


        If errores = String.empty Then
            Dbo = m_DBO_AccionesCorrectivas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

End Class
