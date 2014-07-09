Public Class frmEntTiposControlesLotesPlantilla
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposControlesLotesPlantilla As DBO_TiposControlesLotesPlantilla
    Private tsExtender As ToolStripButton

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposControlesLotesPlantilla = Nothing, Optional ByRef v_dbo As DBO_TiposControlesLotesPlantilla = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spTiposControlesLotesPlantilla, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_TiposControlesLotesPlantilla = if(v_dbo Is Nothing, New DBO_TiposControlesLotesPlantilla, v_dbo)
        dbo = m_DBO_TiposControlesLotesPlantilla
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spTiposControlesLotesPlantilla, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_TiposControlesLotesPlantilla, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposControlesLotesPlantilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spTiposControlesLotes
        s0.cargar_TiposControlesLotes(Me.cboTipoControl)
        Dim s1 As New spTiposLotes
        s1.cargar_TiposLotes(Me.cboTipoLote)
        Dim s2 As New spTiposProductos
        s2.cargar_ComboBox(Me.cboTipoProducto)
        Dim s3 As New spFrecuenciasTiposControlesLotes
        s3.cargar_FrecuenciasTiposControlesLotes(Me.cbofrecuencia)
        Dim s4 As New spProcedimientos
        s4.cargar_Procedimientos(Me.cboprocedimiento)
        If Me.mododeapertura = VISION Then
            Me.cboTipoControl.enabled = False
            Me.lblId_TipoControl.enabled = False

            Me.cboTipoLote.enabled = False
            Me.lblId_TipoLote.enabled = False

            Me.cboTipoProducto.enabled = False
            Me.lblId_TipoProducto.enabled = False

            Me.cbofrecuencia.enabled = False
            Me.lblId_frecuencia.enabled = False

            Me.cboprocedimiento.enabled = False
            Me.lblId_procedimiento.enabled = False
        Else
            If Me.ModoDeApertura = MODIFICACION Then
                tsExtender = Me.bdnGeneral.Items.Add("Extender")
                tsExtender.DisplayStyle = ToolStripItemDisplayStyle.Text
                tsExtender.TextDirection = ToolStripTextDirection.Horizontal
                tsExtender.TextAlign = ContentAlignment.MiddleRight
                AddHandler tsExtender.Click, AddressOf ExtenderPlantilla
            End If
        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddId_TipoControl.enabled = False
            butVerId_TipoControl.enabled = False
            butAddId_TipoLote.enabled = False
            butVerId_TipoLote.enabled = False
            butAddId_TipoProducto.enabled = False
            butVerId_TipoProducto.enabled = False
            butAddId_frecuencia.enabled = False
            butVerId_frecuencia.enabled = False
            butAddId_procedimiento.enabled = False
            butVerId_procedimiento.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_TiposControlesLotesPlantilla = New dbo_TiposControlesLotesPlantilla
        Else
            Me.m_DBO_TiposControlesLotesPlantilla = CType(dbo, DBO_TiposControlesLotesPlantilla)
        End If

        cboTipoControl.SelectedValue = m_DBO_TiposControlesLotesPlantilla.Id_TipoControl
        cboTipoLote.SelectedValue = m_DBO_TiposControlesLotesPlantilla.Id_TipoLote
        cboTipoProducto.SelectedValue = m_DBO_TiposControlesLotesPlantilla.Id_TipoProducto
        cbofrecuencia.SelectedValue = m_DBO_TiposControlesLotesPlantilla.Id_frecuencia
        chbCritico.Checked = m_DBO_TiposControlesLotesPlantilla.Critico
        cboprocedimiento.SelectedValue = m_DBO_TiposControlesLotesPlantilla.Id_procedimiento
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If cboTipoControl.SelectedValue is Nothing Then
            If errores = "" Then cboTipoControl.Focus()
            errores = errores & "No seleccionó un valor para Id_TipoControl." & Environment.NewLine()
        Else
            m_DBO_TiposControlesLotesPlantilla.Id_TipoControl = System.Convert.ToInt32(cboTipoControl.SelectedValue)
        End If

        If cboTipoLote.SelectedValue is Nothing Then
            If errores = "" Then cboTipoLote.Focus()
            errores = errores & "No seleccionó un valor para Id_TipoLote." & Environment.NewLine()
        Else
            m_DBO_TiposControlesLotesPlantilla.Id_TipoLote = System.Convert.ToInt32(cboTipoLote.SelectedValue)
        End If

        m_DBO_TiposControlesLotesPlantilla.Critico = chbCritico.Checked
        m_DBO_TiposControlesLotesPlantilla.Id_frecuencia = cbofrecuencia.SelectedValue
        m_DBO_TiposControlesLotesPlantilla.Id_procedimiento = cboprocedimiento.SelectedValue
        m_DBO_TiposControlesLotesPlantilla.Id_TipoProducto = cboTipoProducto.SelectedValue


        If errores = String.empty Then
            Dbo = CType(m_DBO_TiposControlesLotesPlantilla, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_TipoControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoControl.Click
        Dim frmEnt As New frmTiposControlesLotes()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_TipoControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoControl.Click
        Dim DBO_TiposControlesLotes As New DBO_TiposControlesLotes
        Dim frmEnt As New frmEntTiposControlesLotes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposControlesLotes, DBO_TiposControlesLotes)
        frmEnt.ShowDialog()
        Dim s As New spTiposControlesLotes
        s.cargar_TiposControlesLotes(Me.cboTipoControl)
    End Sub

    Private Sub butVerId_TipoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoLote.Click
        Dim frmEnt As New frmTiposLotes()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_TipoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoLote.Click
        Dim DBO_TiposLotes As New DBO_TiposLotes
        Dim frmEnt As New frmEntTiposLotes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposLotes, DBO_TiposLotes)
        frmEnt.ShowDialog()
        Dim s As New spTiposLotes
        s.cargar_TiposLotes(Me.cboTipoLote)
    End Sub

    Private Sub butVerId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoProducto.Click
        Dim frmEnt As New frmTiposProductos()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoProducto.Click
        Dim DBO_TiposProductos As New DBO_TiposProductos
        Dim frmEnt As New frmEntTiposProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposProductos, DBO_TiposProductos)
        frmEnt.ShowDialog()
        Dim s As New spTiposProductos
        s.cargar_ComboBox(Me.cboTipoProducto)
    End Sub

    Private Sub butVerId_frecuencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_frecuencia.Click
        Dim frmEnt As New frmFrecuenciasTiposControlesLotes()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_frecuencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_frecuencia.Click
        Dim DBO_FrecuenciasTiposControlesLotes As New DBO_FrecuenciasTiposControlesLotes
        Dim frmEnt As New frmEntFrecuenciasTiposControlesLotes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spFrecuenciasTiposControlesLotes, DBO_FrecuenciasTiposControlesLotes)
        frmEnt.ShowDialog()
        Dim s As New spFrecuenciasTiposControlesLotes
        s.cargar_FrecuenciasTiposControlesLotes(Me.cbofrecuencia)
    End Sub

    Private Sub butVerId_procedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_procedimiento.Click
        Dim frmEnt As New frmProcedimientos()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_procedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_procedimiento.Click
        Dim DBO_Procedimientos As New DBO_Procedimientos
        Dim frmEnt As New frmEntProcedimientos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProcedimientos, DBO_Procedimientos)
        frmEnt.ShowDialog()
        Dim s As New spProcedimientos
        s.cargar_Procedimientos(Me.cboprocedimiento)
    End Sub

    Private Sub frmEntTiposControlesLotesPlantilla_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.tlpMiddle, Me)
    End Sub

    Private Sub btnBorrarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrarProducto.Click
        cboTipoProducto.SelectedIndex = -1
    End Sub

    Private Sub btnBorrarPRocedimiento_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrarPRocedimiento.Click
        cboprocedimiento.SelectedIndex = -1
    End Sub

    Private Sub extenderPlantilla()
        Dim frm As New frmExtenderPlantillaControlLote(Me.m_DBO_TiposControlesLotesPlantilla.ID)
        AddHandler frm.afterSave, AddressOf guardado
        frm.ShowDialog()

    End Sub

    Private Sub guardado()
        RaiseEvent afterSave(Me, Nothing)
    End Sub
End Class
