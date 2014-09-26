Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntMaterialesEnvasados
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave

    Private m_DBO_MaterialesEnvasados As DBO_MaterialesEnvasados

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spMaterialesEnvasados = Nothing, Optional ByRef v_dbo As DBO_MaterialesEnvasados = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spMaterialesEnvasados, v_sp)
        m_DBO_MaterialesEnvasados = If(v_dbo Is Nothing, New DBO_MaterialesEnvasados, v_dbo)
        dbo = m_DBO_MaterialesEnvasados
        dtpHoraFin.activarFoco()
        dtpHoraInicio.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spMaterialesEnvasados, New DBO_MaterialesEnvasados)
        InitializeComponent()
        dtpHoraFin.activarFoco()
        dtpHoraInicio.activarFoco()
    End Sub

    Private Sub frmEntMaterialesEnvasados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spTiposMateriales
        s.cargar_TiposMateriales(Me.cboTipoMaterial)
        If Me.ModoDeApertura = VISION Then
            Me.cboTipoMaterial.Enabled = False
            Me.lblTipoMaterialID.Enabled = False

        End If
        Dim s2 As New spProveedores
        s2.cargar_Proveedores(Me.cboProveedor)
        If Me.ModoDeApertura = VISION Then
            Me.cboProveedor.Enabled = False
            Me.lblProveedorID.Enabled = False

        End If


    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_MaterialesEnvasados = New DBO_MaterialesEnvasados
        Else
            Me.m_DBO_MaterialesEnvasados = dbo
        End If

        dtpHoraInicio.Text = m_DBO_MaterialesEnvasados.HoraInicio.ToString
        dtpHoraFin.Text = m_DBO_MaterialesEnvasados.HoraFin.ToString
        txtObservaciones.Text = m_DBO_MaterialesEnvasados.Observaciones
        txtLote.Text = m_DBO_MaterialesEnvasados.Lote
        txtCantidad.Text = m_DBO_MaterialesEnvasados.Cantidad
        cboTipoMaterial.SelectedValue = m_DBO_MaterialesEnvasados.TipoMaterialID
        cboProveedor.SelectedValue = m_DBO_MaterialesEnvasados.ProveedorID
        cboFormatoEnvasado.SelectedValue = m_DBO_MaterialesEnvasados.FormatoEnvasadoID
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_MaterialesEnvasados.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)

        m_DBO_MaterialesEnvasados.HoraFin = New TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0)


        m_DBO_MaterialesEnvasados.Observaciones = txtObservaciones.Text


        m_DBO_MaterialesEnvasados.Lote = txtLote.Text


        m_DBO_MaterialesEnvasados.Cantidad = System.Convert.ToInt32(txtCantidad.Text)


        If errores = String.Empty Then
            dbo = m_DBO_MaterialesEnvasados
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerTipoMaterialID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoMaterialID.Click
        Dim frmEnt As New frmTiposMateriales()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddTipoMaterialID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoMaterialID.Click
        Dim DBO_TiposMateriales As New DBO_TiposMateriales
        Dim frmEnt As New frmEntTiposMateriales(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposMateriales, DBO_TiposMateriales)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposMateriales
        s.cargar_TiposMateriales(Me.cboTipoMaterial)
    End Sub

    Private Sub butVerProveedorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProveedorID.Click
        Dim frmEnt As New frmProveedores()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddProveedorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProveedorID.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProveedores
        s.cargar_Proveedores(Me.cboProveedor)
    End Sub


End Class
