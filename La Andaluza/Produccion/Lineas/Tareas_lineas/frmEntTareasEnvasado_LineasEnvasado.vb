Public Class frmEntTareasEnvasado_LineasEnvasado
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TareasEnvasado_LineasEnvasado As DBO_TareasEnvasado_LineasEnvasado

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTareasEnvasado_LineasEnvasado = Nothing, Optional ByRef v_dbo As DBO_TareasEnvasado_LineasEnvasado = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTareasEnvasado_LineasEnvasado, v_sp)
        m_DBO_TareasEnvasado_LineasEnvasado = if(v_dbo Is Nothing, New DBO_TareasEnvasado_LineasEnvasado, v_dbo)
        dbo = m_DBO_TareasEnvasado_LineasEnvasado
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTareasEnvasado_LineasEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spTareasEnvasado
        s.cargar_TareasEnvasado(Me.cboTareaEnvasado)

        Dim s2 As New spLineasEnvasado
        s2.cargar_LineasEnvasado(Me.cboLineaEnvasado)
        If Me.ModoDeApertura = VISION Then
            Me.cboLineaEnvasado.Enabled = False
            Me.lblId_LineaEnvasado.Enabled = False
            Me.cboTareaEnvasado.Enabled = False
            Me.lblId_TareaEnvasado.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_TareasEnvasado_LineasEnvasado = dbo

        cboTareaEnvasado.SelectedValue = m_DBO_TareasEnvasado_LineasEnvasado.Id_TareaEnvasado
        cboLineaEnvasado.SelectedValue = m_DBO_TareasEnvasado_LineasEnvasado.Id_LineaEnvasado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If cboTareaEnvasado.SelectedValue is Nothing Then
            If errores = "" Then cboTareaEnvasado.Focus()
            errores = errores & "No seleccionó un valor para Id_TareaEnvasado." & Environment.NewLine
        Else
            m_DBO_TareasEnvasado_LineasEnvasado.Id_TareaEnvasado = System.Convert.ToInt32(cboTareaEnvasado.SelectedValue)
        End If
        If cboLineaEnvasado.SelectedValue is Nothing Then
            If errores = "" Then cboLineaEnvasado.Focus()
            errores = errores & "No seleccionó un valor para Id_LineaEnvasado." & Environment.NewLine
        Else
            m_DBO_TareasEnvasado_LineasEnvasado.Id_LineaEnvasado = System.Convert.ToInt32(cboLineaEnvasado.SelectedValue)
        End If
        If errores = String.Empty Then
            dbo = m_DBO_TareasEnvasado_LineasEnvasado
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_TareaEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TareaEnvasado.Click
        Dim frmEnt As New frmTareasEnvasado()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_TareaEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TareaEnvasado.Click
        Dim DBO_TareasEnvasado As New DBO_TareasEnvasado
        Dim frmEnt As New frmEntTareasEnvasado(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTareasEnvasado, DBO_TareasEnvasado)
        frmEnt.ShowDialog()
        Dim s As New spTareasEnvasado
        s.cargar_TareasEnvasado(Me.cboTareaEnvasado)
    End Sub

    Private Sub butVerId_LineaEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmLineasEnvasado()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_LineaEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_LineasEnvasado As New DBO_LineasEnvasado
        Dim frmEnt As New frmEntLineasEnvasado(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spLineasEnvasado, DBO_LineasEnvasado)
        frmEnt.ShowDialog()
        Dim s As New spLineasEnvasado
        s.cargar_LineasEnvasado(Me.cboLineaEnvasado)
    End Sub

End Class
