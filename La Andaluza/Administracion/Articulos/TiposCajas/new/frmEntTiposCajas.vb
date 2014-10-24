Public Class frmEntTiposCajas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposCajas As DBO_TiposCajas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposCajas = Nothing, Optional ByRef v_dbo As DBO_TiposCajas = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spTiposCajas, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_TiposCajas = if(v_dbo Is Nothing, New DBO_TiposCajas, v_dbo)
        dbo = m_DBO_TiposCajas
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spTiposCajas, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_TiposCajas, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spTiposBotellas
        s0.cargar_TiposBotellas(Me.cboTipoBotella, dtb)
        Dim s1 As New spPaletsMovimientosTipos
        s1.cargar_PaletsMovimientosTipos(Me.cboid_MovimentoEncajado, dtb)
        Dim s2 As New sptiposEnvases
        s2.cargar_tiposEnvases(Me.cboid_tipoEnvase, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboTipoBotella.enabled = False
            Me.lblTipoBotellaID.enabled = False

            Me.cboid_MovimentoEncajado.enabled = False
            Me.lblid_MovimentoEncajado.enabled = False

            Me.cboid_tipoEnvase.enabled = False
            Me.lblid_tipoEnvase.enabled = False

        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddTipoBotellaID.enabled = False
            butVerTipoBotellaID.enabled = False
            butAddid_MovimentoEncajado.enabled = False
            butVerid_MovimentoEncajado.enabled = False
            butAddid_tipoEnvase.enabled = False
            butVerid_tipoEnvase.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_TiposCajas = New dbo_TiposCajas
        Else
            Me.m_DBO_TiposCajas = CType(dbo, DBO_TiposCajas)
        End If

        txtCodigoQS.Text = m_DBO_TiposCajas.CodigoQS
        txtDescripcion.Text = m_DBO_TiposCajas.Descripcion
        txtCapacidad.Text = m_DBO_TiposCajas.Capacidad
        cboTipoBotella.SelectedValue = m_DBO_TiposCajas.TipoBotellaID
        cboid_MovimentoEncajado.SelectedValue = m_DBO_TiposCajas.id_MovimentoEncajado
        chbFabricacionPropia.Checked = m_DBO_TiposCajas.FabricacionPropia
        cboid_tipoEnvase.SelectedValue = m_DBO_TiposCajas.id_tipoEnvase
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If Not isNumeric(txtCodigoQS.Text) Then
            If errores = "" Then txtCodigoQS.Focus()
            errores = errores & "El campo CodigoQS debe ser numérico." & Environment.NewLine()
        Else
            m_DBO_TiposCajas.CodigoQS = System.Convert.ToInt32(txtCodigoQS.Text)
        End If

        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_TiposCajas.Descripcion = txtDescripcion.Text
        End If

        If Not isNumeric(txtCapacidad.Text) Then
            If errores = "" Then txtCapacidad.Focus()
            errores = errores & "El campo Capacidad debe ser numérico." & Environment.NewLine()
        Else
            m_DBO_TiposCajas.Capacidad = System.Convert.ToInt32(txtCapacidad.Text)
        End If


        If cboTipoBotella.SelectedValue Is Nothing Then
            If errores = "" Then cboTipoBotella.Focus()
            errores = errores & "No seleccionó un valor para TipoBotellaID." & Environment.NewLine()
        Else
            m_DBO_TiposCajas.TipoBotellaID = System.Convert.ToInt32(cboTipoBotella.SelectedValue)
        End If

        If cboid_tipoEnvase.SelectedValue Is Nothing Then
            If errores = "" Then cboid_tipoEnvase.Focus()
            errores = errores & "No seleccionó un valor para Tipo envase." & Environment.NewLine()
        Else
            m_DBO_TiposCajas.id_tipoEnvase = System.Convert.ToInt32(cboid_tipoEnvase.SelectedValue)
        End If


        m_DBO_TiposCajas.id_MovimentoEncajado = cboid_MovimentoEncajado.SelectedValue


        m_DBO_TiposCajas.FabricacionPropia = chbFabricacionPropia.Checked

        If errores = String.empty Then
            dbo = CType(m_DBO_TiposCajas, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerTipoBotellaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoBotellaID.Click
        Dim frmEnt As New frmTiposBotellas()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddTipoBotellaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoBotellaID.Click
        Dim DBO_TiposBotellas As New DBO_TiposBotellas
        Dim frmEnt As New frmEntTiposBotellas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposBotellas, DBO_TiposBotellas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposBotellas
        s.cargar_TiposBotellas(Me.cboTipoBotella, dtb)
    End Sub

    Private Sub butVerid_MovimentoEncajado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_MovimentoEncajado.Click
        Dim frmEnt As New frmPaletsMovimientosTipos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddid_MovimentoEncajado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_MovimentoEncajado.Click
        Dim DBO_PaletsMovimientosTipos As New DBO_PaletsMovimientosTipos
        Dim frmEnt As New frmEntPaletsMovimientosTipos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spPaletsMovimientosTipos, DBO_PaletsMovimientosTipos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spPaletsMovimientosTipos
        s.cargar_PaletsMovimientosTipos(Me.cboid_MovimentoEncajado, dtb)
    End Sub

    Private Sub butVerid_tipoEnvase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_tipoEnvase.Click
        Dim frmEnt As New frmtiposEnvases()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddid_tipoEnvase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_tipoEnvase.Click
        Dim DBO_tiposEnvases As New DBO_tiposEnvases
        Dim frmEnt As New frmEnttiposEnvases(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New sptiposEnvases, DBO_tiposEnvases)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New sptiposEnvases
        s.cargar_tiposEnvases(Me.cboid_tipoEnvase, dtb)
    End Sub

    Private Sub frmEntTiposCajas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
