Public Class frmEntTiposSeguimientos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposSeguimientos As DBO_TiposSeguimientos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposSeguimientos = Nothing, Optional ByRef v_dbo As DBO_TiposSeguimientos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposSeguimientos, v_sp)
        m_DBO_TiposSeguimientos = if(v_dbo Is Nothing, New DBO_TiposSeguimientos, v_dbo)
        dbo = m_DBO_TiposSeguimientos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposSeguimientos, New DBO_TiposSeguimientos)
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposSeguimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposSeguimientos = New DBO_TiposSeguimientos
        Else
            Me.m_DBO_TiposSeguimientos = dbo
        End If

        txtDescripcion.Text = m_DBO_TiposSeguimientos.Descripcion
        txtObservaciones.Text = m_DBO_TiposSeguimientos.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposSeguimientos.Descripcion = txtDescripcion.Text
        End If



        m_DBO_TiposSeguimientos.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_TiposSeguimientos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

End Class
