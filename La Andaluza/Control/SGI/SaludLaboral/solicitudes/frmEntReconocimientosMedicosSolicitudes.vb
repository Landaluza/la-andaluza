Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntReconocimientosMedicosSolicitudes
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable

    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ReconocimientosMedicosSolicitudes As DBO_ReconocimientosMedicosSolicitudes

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spReconocimientosMedicosSolicitudes = Nothing, Optional ByRef v_dbo As DBO_ReconocimientosMedicosSolicitudes = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spReconocimientosMedicosSolicitudes, v_sp)
        m_DBO_ReconocimientosMedicosSolicitudes = If(v_dbo Is Nothing, New DBO_ReconocimientosMedicosSolicitudes, v_dbo)
        dbo = m_DBO_ReconocimientosMedicosSolicitudes
        dtpFechaSolicitud.activarFoco()
        dtpFechaDeseadaInicio.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFechaSolicitud.activarFoco()
        dtpFechaDeseadaInicio.activarFoco()
    End Sub

    Private Sub frmEntReconocimientosMedicosSolicitudes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spReconocimientosMedicosTipos
        s.cargar_ReconocimientosMedicosTipos(Me.cboReconocimientoMedicoTipo, dtb)

        Dim s2 As New spProveedores
        s2.cargar_ComboBox(Me.cboProveedor, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboProveedor.Enabled = False
            Me.lblProveedorID.Enabled = False
            Me.cboReconocimientoMedicoTipo.Enabled = False
            Me.lblReconocimientoMedicoTipoID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_ReconocimientosMedicosSolicitudes = New DBO_ReconocimientosMedicosSolicitudes
        Else
            Me.m_DBO_ReconocimientosMedicosSolicitudes = dbo
        End If

        dtpFechaSolicitud.Text = m_DBO_ReconocimientosMedicosSolicitudes.FechaSolicitud.ToString
        cboReconocimientoMedicoTipo.SelectedValue = m_DBO_ReconocimientosMedicosSolicitudes.ReconocimientoMedicoTipoID
        cboProveedor.SelectedValue = m_DBO_ReconocimientosMedicosSolicitudes.ProveedorID
        dtpFechaDeseadaInicio.Value = m_DBO_ReconocimientosMedicosSolicitudes.FechaDeseadaInicio

    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_ReconocimientosMedicosSolicitudes.FechaSolicitud = dtpFechaSolicitud.Value.Date


        m_DBO_ReconocimientosMedicosSolicitudes.FechaDeseadaInicio = dtpFechaDeseadaInicio.Value.Date

        If cboReconocimientoMedicoTipo.SelectedValue Is Nothing Then
            If errores = "" Then cboProveedor.Focus()
            errores = errores & "No seleccionó un valor para tipo de reconocimiento." & Environment.NewLine
        Else
            m_DBO_ReconocimientosMedicosSolicitudes.ReconocimientoMedicoTipoID = System.Convert.ToInt32(cboReconocimientoMedicoTipo.SelectedValue)
        End If

        If cboProveedor.SelectedValue Is Nothing Then
            If errores = "" Then cboProveedor.Focus()
            errores = errores & "No seleccionó un valor para ProveedorID." & Environment.NewLine
        Else
            m_DBO_ReconocimientosMedicosSolicitudes.ProveedorID = System.Convert.ToInt32(cboProveedor.SelectedValue)
        End If

        If errores = String.Empty Then
            dbo = m_DBO_ReconocimientosMedicosSolicitudes
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerReconocimientoMedicoTipoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerReconocimientoMedicoTipoID.Click
        Dim frmEnt As New frmReconocimientosMedicosTipos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spReconocimientosMedicosTipos
        s.cargar_ReconocimientosMedicosTipos(Me.cboReconocimientoMedicoTipo, dtb)
    End Sub

    Private Sub butAddReconocimientoMedicoTipoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddReconocimientoMedicoTipoID.Click
        Dim DBO_ReconocimientosMedicosTipos As New DBO_ReconocimientosMedicosTipos
        Dim frmEnt As New frmEntReconocimientosMedicosTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spReconocimientosMedicosTipos, DBO_ReconocimientosMedicosTipos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spReconocimientosMedicosTipos
        s.cargar_ReconocimientosMedicosTipos(Me.cboReconocimientoMedicoTipo, dtb)
    End Sub

    Private Sub butVerProveedorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProveedorID.Click
        Dim frmEnt As New frmProveedores()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s2 As New spProveedores
        s2.cargar_ComboBox(Me.cboProveedor, dtb)
    End Sub

    Private Sub butAddProveedorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProveedorID.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s2 As New spProveedores
        s2.cargar_ComboBox(Me.cboProveedor, dtb)
    End Sub

End Class
