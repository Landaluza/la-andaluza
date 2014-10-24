Public Class frmEntCausasPartesEnvasado
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_CausasPartesEnvasado As DBO_CausasPartesEnvasado

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spCausasPartesEnvasado = Nothing, Optional ByRef v_dbo As DBO_CausasPartesEnvasado = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spCausasPartesEnvasado, v_sp)
        m_DBO_CausasPartesEnvasado = if(v_dbo Is Nothing, New DBO_CausasPartesEnvasado, v_dbo)
        dbo = m_DBO_CausasPartesEnvasado
    End Sub

    Public Sub New()
        MyBase.new()
        InitializeComponent()
    End Sub

    Private Sub frmEntCausasPartesEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spCausasPartesEnvasadoTipos
        s.cargar_CausasPartesEnvasadoTipos(Me.cboid_CausaParteTipo, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboid_CausaParteTipo.enabled = False
            Me.lblid_CausaParteTipo.enabled = False
        End If

        If Config.UserType = 3 Then
            Me.butAddid_CausaParteTipo.Enabled = False
            Me.butVerid_CausaParteTipo.Enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_CausasPartesEnvasado = New dbo_CausasPartesEnvasado
        Else
            Me.m_DBO_CausasPartesEnvasado = dbo
        End If

        txtDescripcion.Text = m_DBO_CausasPartesEnvasado.Descripcion
        cboid_CausaParteTipo.SelectedValue = m_DBO_CausasPartesEnvasado.id_CausaParteTipo
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_CausasPartesEnvasado.Descripcion = txtDescripcion.Text
        End If

        If Me.cboid_CausaParteTipo.SelectedValue is Nothing Then
            If errores = "" Then cboid_CausaParteTipo.Focus()
            errores = errores & "No seleccionó un valor para 'tipo'." & Environment.NewLine
        Else
            m_DBO_CausasPartesEnvasado.id_CausaParteTipo = Me.cboid_CausaParteTipo.SelectedValue
        End If

        If errores = String.empty Then
            Dbo = m_DBO_CausasPartesEnvasado
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerid_CausaParteTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_CausaParteTipo.Click
        Dim frmEnt As New frmCausasPartesEnvasadoTipos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spCausasPartesEnvasadoTipos
        s.cargar_CausasPartesEnvasadoTipos(Me.cboid_CausaParteTipo, dtb)
    End Sub

    Private Sub butAddid_CausaParteTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_CausaParteTipo.Click
        Dim DBO_CausasPartesEnvasadoTipos As New DBO_CausasPartesEnvasadoTipos
        Dim frmEnt As New frmEntCausasPartesEnvasadoTipos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spCausasPartesEnvasadoTipos, DBO_CausasPartesEnvasadoTipos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spCausasPartesEnvasadoTipos
        s.cargar_CausasPartesEnvasadoTipos(Me.cboid_CausaParteTipo, dtb)
    End Sub

    
End Class
