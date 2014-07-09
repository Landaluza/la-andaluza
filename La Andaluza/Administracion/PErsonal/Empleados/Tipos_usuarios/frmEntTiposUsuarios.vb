Public Class frmEntTiposUsuarios
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposUsuarios As DBO_TiposUsuarios

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposUsuarios = Nothing, Optional ByRef v_dbo As DBO_TiposUsuarios = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposUsuarios, v_sp)
        m_DBO_TiposUsuarios = if(v_dbo Is Nothing, New DBO_TiposUsuarios, v_dbo)
        dbo = m_DBO_TiposUsuarios
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposUsuarios = New DBO_TiposUsuarios
        Else
            Me.m_DBO_TiposUsuarios = dbo
        End If

        txtDescripcion.Text = m_DBO_TiposUsuarios.Descripcion
        txtpermisos.Text = m_DBO_TiposUsuarios.permisos
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposUsuarios.Descripcion = txtDescripcion.Text
        End If


        If IsNumeric(txtpermisos.Text) Then
            m_DBO_TiposUsuarios.permisos = System.Convert.ToInt32(txtpermisos.Text)
        Else
            If errores = "" Then txtpermisos.Focus()
            errores = errores & "El campo permisos debe ser numerico." & Environment.NewLine
        End If

        If errores = String.Empty Then
            dbo = m_DBO_TiposUsuarios
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
