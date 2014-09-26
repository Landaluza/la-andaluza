Public Class frmEntListaParametros
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ListaParametros As DBO_ListaParametros

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spListaParametros = Nothing, Optional ByRef v_dbo As DBO_ListaParametros = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spListaParametros, v_sp)
        m_DBO_ListaParametros = if(v_dbo Is Nothing, New DBO_ListaParametros, v_dbo)
        dbo = m_DBO_ListaParametros
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntListaParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spUnidadesMedidas
        s.cargar_UnidadesMedidas(Me.cboUnidadMedida)

        Dim s2 As New spParametrosTipos
        s2.cargar_ParametrosTipos(Me.cboid_parametroTipo)
        If Me.mododeapertura = VISION Then
            Me.cboid_parametroTipo.enabled = False
            Me.lblid_parametroTipo.enabled = False
            Me.cboUnidadMedida.Enabled = False
            Me.lblUnidadMedidaID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_ListaParametros = New dbo_ListaParametros
        Else
            Me.m_DBO_ListaParametros = dbo
        End If

        txtNombre.Text = m_DBO_ListaParametros.Nombre
        cboUnidadMedida.SelectedValue = m_DBO_ListaParametros.UnidadMedidaID
        cboid_parametroTipo.SelectedValue = m_DBO_ListaParametros.id_parametroTipo
        Me.cbEnvasado.Checked = m_DBO_ListaParametros.usoEnvasado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtNombre.Text = "" Then
            If errores = "" Then txtNombre.Focus()
            errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_ListaParametros.Nombre = txtNombre.Text
        End If

        If cboid_parametroTipo.SelectedValue is Nothing Then
            If errores = "" Then cboid_parametroTipo.Focus()
            errores = errores & "No seleccionó un valor para Tipo." & Environment.NewLine
        Else
            m_DBO_ListaParametros.id_parametroTipo = System.Convert.ToInt32(cboid_parametroTipo.SelectedValue)
        End If

        If cboUnidadMedida.SelectedValue is Nothing Then
            If errores = "" Then cboUnidadMedida.Focus()
            errores = errores & "No seleccionó un valor para UnidadMedidaID." & Environment.NewLine
        Else
            m_DBO_ListaParametros.UnidadMedidaID = System.Convert.ToInt32(cboUnidadMedida.SelectedValue)
        End If

        m_DBO_ListaParametros.usoEnvasado = Me.cbEnvasado.Checked

        If errores = String.empty Then
            Dbo = m_DBO_ListaParametros
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerUnidadMedidaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerUnidadMedidaID.Click
        Dim frmEnt As New frmUnidadesMedidas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spUnidadesMedidas
        s.cargar_UnidadesMedidas(Me.cboUnidadMedida)
    End Sub

    Private Sub butAddUnidadMedidaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddUnidadMedidaID.Click
        Dim DBO_UnidadesMedidas As New DBO_UnidadesMedidas
        Dim frmEnt As New frmEntUnidadesMedidas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spUnidadesMedidas, DBO_UnidadesMedidas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spUnidadesMedidas
        s.cargar_UnidadesMedidas(Me.cboUnidadMedida)
    End Sub

    Private Sub butVerid_parametroTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_parametroTipo.Click
        Dim frmEnt As New frmParametrosTipos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spParametrosTipos
        s.cargar_ParametrosTipos(Me.cboid_parametroTipo)
    End Sub

    Private Sub butAddid_parametroTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_parametroTipo.Click
        Dim DBO_ParametrosTipos As New DBO_ParametrosTipos
        Dim frmEnt As New frmEntParametrosTipos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spParametrosTipos, DBO_ParametrosTipos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spParametrosTipos
        s.cargar_ParametrosTipos(Me.cboid_parametroTipo)
    End Sub

End Class
