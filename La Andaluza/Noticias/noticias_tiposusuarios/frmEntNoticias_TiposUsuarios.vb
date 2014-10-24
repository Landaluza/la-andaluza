Public Class frmEntNoticias_TiposUsuarios
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Noticias_TiposUsuarios As DBO_Noticias_TiposUsuarios
    Private spTiposUsuarios As spTiposUsuarios

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spNoticias_TiposUsuarios = Nothing, Optional ByRef v_dbo As DBO_Noticias_TiposUsuarios = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spNoticias_TiposUsuarios, v_sp)
        m_DBO_Noticias_TiposUsuarios = If(v_dbo Is Nothing, New DBO_Noticias_TiposUsuarios, v_dbo)
        dbo = m_DBO_Noticias_TiposUsuarios
        spTiposUsuarios = New spTiposUsuarios
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spNoticias_TiposUsuarios, New DBO_Noticias_TiposUsuarios)
        InitializeComponent()
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_Noticias_TiposUsuarios = CType(dbo, DBO_Noticias_TiposUsuarios)
        cbotipoUsuario.SelectedValue = m_DBO_Noticias_TiposUsuarios.Id_tipoUsuario
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty

        If cbotipoUsuario.SelectedValue Is Nothing Then
            If errores = "" Then cbotipoUsuario.Focus()
            errores = errores & "No seleccionó un valor para Id_tipoUsuario." & Environment.NewLine()
        Else
            m_DBO_Noticias_TiposUsuarios.Id_tipoUsuario = System.Convert.ToInt32(cbotipoUsuario.SelectedValue)
        End If

        If errores = String.Empty Then
            dbo = m_DBO_Noticias_TiposUsuarios
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Error")
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub frmEntNoticias_TiposUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        spTiposUsuarios.cargar_TiposUsuarios(Me.cbotipoUsuario, dtb)
    End Sub

    Private Sub butVerId_tipoUsuario_Click(sender As System.Object, e As System.EventArgs) Handles butVerId_tipoUsuario.Click
        Dim frm As New frmTiposUsuarios
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        spTiposUsuarios.cargar_TiposUsuarios(Me.cbotipoUsuario, dtb)
    End Sub

    Private Sub butAddId_tipoUsuario_Click(sender As System.Object, e As System.EventArgs) Handles butAddId_tipoUsuario.Click
        Dim frm As New frmEntTiposUsuarios
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        spTiposUsuarios.cargar_TiposUsuarios(Me.cbotipoUsuario, dtb)
    End Sub
End Class
