Public Class frmEntProcesos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As System.Object, e As System.EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Procesos As DBO_Procesos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProcesos = Nothing, Optional ByRef v_dbo As DBO_Procesos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spProcesos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Procesos = IIf(v_dbo Is Nothing, New DBO_Procesos, v_dbo)
        dbo = m_DBO_Procesos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spProcesos, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_Procesos, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spTiposLotes
        s0.cargar_TiposLotes(Me.cboTipoLote)
        If Me.mododeapertura = VISION Then
            Me.cboTipoLote.enabled = False
            Me.lblTipoLoteID.enabled = False

        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddTipoLoteID.enabled = False
            butVerTipoLoteID.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Procesos = New dbo_Procesos
        Else
            Me.m_DBO_Procesos = CType(dbo, DBO_Procesos)
        End If

        txtDescripcion.Text = m_DBO_Procesos.Descripcion
        txtTipoProductoParaLote.Text = m_DBO_Procesos.TipoProductoParaLote
        txtTipoMovimiento.Text = m_DBO_Procesos.TipoMovimiento
        cboTipoLote.SelectedValue = m_DBO_Procesos.TipoLoteID
        chbConMuestra.Checked = m_DBO_Procesos.ConMuestra
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Procesos.Descripcion = txtDescripcion.Text
        End If



        If txtTipoProductoParaLote.Text = "" Then
            If errores = "" Then txtTipoProductoParaLote.Focus()
            errores = errores & "El campo TipoProductoParaLote no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Procesos.TipoProductoParaLote = txtTipoProductoParaLote.Text
        End If



        If txtTipoMovimiento.Text = "" Then
            If errores = "" Then txtTipoMovimiento.Focus()
            errores = errores & "El campo TipoMovimiento no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Procesos.TipoMovimiento = txtTipoMovimiento.Text
        End If


        m_DBO_Procesos.TipoLoteID = Me.cboTipoLote.SelectedValue
        m_DBO_Procesos.ConMuestra = chbConMuestra.Checked

        If errores = String.empty Then
            Dbo = CType(m_DBO_Procesos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerTipoLoteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoLoteID.Click
        Dim frmEnt As New frmTiposLotes()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddTipoLoteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoLoteID.Click
        Dim DBO_TiposLotes As New DBO_TiposLotes
        Dim frmEnt As New frmEntTiposLotes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposLotes, DBO_TiposLotes)
        frmEnt.ShowDialog()
        Dim s As New spTiposLotes
        s.cargar_TiposLotes(Me.cboTipoLote)
    End Sub

    Private Sub frmEntProcesos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.tlpMiddle, Me)
    End Sub
End Class
