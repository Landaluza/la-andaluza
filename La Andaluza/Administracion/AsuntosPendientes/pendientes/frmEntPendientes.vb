Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPendientes
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Pendientes As DBO_Pendientes
    Private frmGestionesPendientes As frmVistaGestiones

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPendientes = Nothing, Optional ByRef v_dbo As DBO_Pendientes = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spPendientes, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Pendientes = If(v_dbo Is Nothing, New DBO_Pendientes, v_dbo)
        dbo = m_DBO_Pendientes

        dtpFecha.activarFoco()
        dtpFechaDocumento.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(New spPendientes, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_Pendientes, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        sp = CType(New spPendientes, BasesParaCompatibilidad.StoredProcedure)
        m_DBO_Pendientes = New DBO_Pendientes
        dbo = m_DBO_Pendientes
        dtpFecha.activarFoco()
        dtpFechaDocumento.activarFoco()
    End Sub

    Private Sub frmEntPendientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spTiposPendientes
        s0.cargar_TiposPendientes(Me.cboTipoPendiente)

        Dim s1 As New spProveedores
        s1.cargar_Proveedores(Me.cboProveedor)

        Dim s2 As New spEmpleados
        s2.cargar_Empleados(Me.cboResponsable)

        If Me.ModoDeApertura = VISION Then
            Me.cboTipoPendiente.Enabled = False
            Me.lblTipoPendiente.Enabled = False

            Me.cboProveedor.Enabled = False
            Me.lblProveedor.Enabled = False

            Me.cboResponsable.Enabled = False
            Me.lblResponsableID.Enabled = False
        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            'butAddTipoPendiente.enabled = False
            'butVerTipoPendiente.enabled = False
            butAddProveedor.Enabled = False
            butVerProveedor.Enabled = False
            butAddResponsableID.Enabled = False
            butVerResponsableID.Enabled = False
        End If

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_Pendientes = New DBO_Pendientes
        Else
            Me.m_DBO_Pendientes = CType(dbo, DBO_Pendientes)
        End If

        txtDescripcion.Text = m_DBO_Pendientes.Descripcion
        dtpFecha.Value = m_DBO_Pendientes.Fecha
        chbTerminada.Checked = m_DBO_Pendientes.Terminada
        cboTipoPendiente.SelectedValue = m_DBO_Pendientes.TipoPendiente
        cboProveedor.SelectedValue = m_DBO_Pendientes.Proveedor
        txtNumeroDocumento.Text = m_DBO_Pendientes.NumeroDocumento
        dtpFechaDocumento.Value = m_DBO_Pendientes.FechaDocumento
        txtRutaDocumento.Text = m_DBO_Pendientes.RutaDocumento
        cboResponsable.SelectedValue = m_DBO_Pendientes.ResponsableID

        If Me.ModoDeApertura <> INSERCION Then
            frmGestionesPendientes = New frmVistaGestiones(Me.m_DBO_Pendientes.ID)
            Engine_LA.FormEnPestaña(frmGestionesPendientes, Me.TabPage2)
        End If
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_Pendientes.Descripcion = txtDescripcion.Text

        m_DBO_Pendientes.TipoPendiente = cboTipoPendiente.SelectedValue
        m_DBO_Pendientes.ResponsableID = cboResponsable.SelectedValue
        m_DBO_Pendientes.Proveedor = cboProveedor.SelectedValue

        m_DBO_Pendientes.Fecha = dtpFecha.Value


        m_DBO_Pendientes.Terminada = chbTerminada.Checked

        m_DBO_Pendientes.NumeroDocumento = txtNumeroDocumento.Text


        m_DBO_Pendientes.FechaDocumento = dtpFechaDocumento.Value


        m_DBO_Pendientes.RutaDocumento = txtRutaDocumento.Text


        If errores = String.Empty Then
            dbo = CType(m_DBO_Pendientes, BasesParaCompatibilidad.DataBussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butRutaDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRutaDocumento.Click
        Dim arch As String
        'Cambiar "C:\" por la ruta adecuada

        arch = BasesParaCompatibilidad.File.Elegir_archivo("C:\")


        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRutaDocumento.Text = arch
        End If
    End Sub

    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRutaDocumento.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub butVerTipoPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoPendiente.Click
        Dim spt As New spTiposPendientes
        Dim frmEnt As New frmTiposPendientes()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        spt.cargar_TiposPendientes(Me.cboTipoPendiente)
    End Sub

    Private Sub butAddTipoPendiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoPendiente.Click
        Dim DBO_TiposPendientes As New DBO_TiposPendientes
        Dim s As New spTiposPendientes
        Dim frmEnt As New frmEntTiposPendientes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, s, DBO_TiposPendientes)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        s.cargar_TiposPendientes(Me.cboTipoPendiente)
    End Sub

    Private Sub butVerProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProveedor.Click
        Dim frmEnt As New frmProveedores()
        Dim s As New spProveedores
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        s.cargar_Proveedores(Me.cboProveedor)
    End Sub

    Private Sub butAddProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProveedor.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim s As New spProveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, s, DBO_Proveedores)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        s.cargar_Proveedores(Me.cboProveedor)
    End Sub

    Private Sub butVerResponsableID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerResponsableID.Click
        Dim s As New spEmpleados
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        s.cargar_Empleados(Me.cboResponsable)
    End Sub

    Private Sub butAddResponsableID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddResponsableID.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim s As New spEmpleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, s, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        s.cargar_Empleados(Me.cboResponsable)
    End Sub

    Private Sub frmEntPendientes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.tlpMiddle, Me)
    End Sub
End Class
