Public Class frmEntUsuarios
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Private m_DBO_Usuarios As DBO_Usuarios
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spUsuarios = Nothing, Optional ByRef v_dbo As DBO_Usuarios = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spUsuarios, v_sp)
        m_DBO_Usuarios = if(v_dbo Is Nothing, New DBO_Usuarios, v_dbo)
        dbo = m_DBO_Usuarios
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spUsuarios, New DBO_Usuarios)
        InitializeComponent()
    End Sub

    Private Sub frmEntUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spTiposUsuarios
        s.cargar_TiposUsuarios(Me.cboTipoUsuario)
        If Me.mododeapertura = VISION Then
            Me.cboTipoUsuario.enabled = False
            Me.lblTipoUsuarioID.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Usuarios = New dbo_Usuarios
        Else
            Me.m_DBO_Usuarios = dbo
        End If

        txtUsuario.Text = m_DBO_Usuarios.Usuario
        cboTipoUsuario.SelectedValue = m_DBO_Usuarios.TipoUsuarioID
        txtemail.Text = m_DBO_Usuarios.email
        txtpass.Text = m_DBO_Usuarios.pass
        txtservidorDeCorreo.Text = m_DBO_Usuarios.servidorDeCorreo
        txtcryptedPassword.Text = m_DBO_Usuarios.cryptedPassword
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtUsuario.Text = "" Then
            If errores = "" Then txtUsuario.Focus()
            errores = errores & "El campo Usuario no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_Usuarios.Usuario = txtUsuario.Text
        End If



        If cboTipoUsuario.SelectedValue Is Nothing Then
            If errores = "" Then cboTipoUsuario.Focus()
            errores = errores & "No seleccionó un valor para TipoUsuarioID." & Environment.NewLine
        Else
            m_DBO_Usuarios.TipoUsuarioID = System.Convert.ToInt32(cboTipoUsuario.SelectedValue)
        End If
        m_DBO_Usuarios.email = txtemail.Text


        m_DBO_Usuarios.pass = txtpass.Text


        m_DBO_Usuarios.servidorDeCorreo = txtservidorDeCorreo.Text


        m_DBO_Usuarios.cryptedPassword = txtcryptedPassword.Text


        If errores = String.empty Then
            Dbo = m_DBO_Usuarios
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerTipoUsuarioID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoUsuarioID.Click
        Dim frmEnt As New frmTiposUsuarios()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddTipoUsuarioID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoUsuarioID.Click
        Dim DBO_TiposUsuarios As New DBO_TiposUsuarios
        Dim frmEnt As New frmEntTiposUsuarios(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposUsuarios, DBO_TiposUsuarios)
        frmEnt.ShowDialog()
        Dim s As New spTiposUsuarios
        s.cargar_TiposUsuarios(Me.cboTipoUsuario)
    End Sub

End Class
