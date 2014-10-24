Public Class frmEntProveedores_Articulos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Proveedores_Articulos As DBO_Proveedores_Articulos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProveedores_Articulos = Nothing, Optional ByRef v_dbo As DBO_Proveedores_Articulos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spProveedores_Articulos(False), v_sp)
        m_DBO_Proveedores_Articulos = if(v_dbo Is Nothing, New DBO_Proveedores_Articulos, v_dbo)
        dbo = m_DBO_Proveedores_Articulos        
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntProveedores_Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spProveedores
        s.cargar_Proveedores(Me.cboProveedor, dtb)
        Dim s2 As New spArticulos1
        s2.cargar_Articulos(Me.cboArticulo, dtb)
        's.cargar_Articulos1(Me.cboArticulo)
        If Me.mododeapertura = VISION Then
            Me.cboArticulo.enabled = False
            Me.lblArticuloID.Enabled = False
            Me.cboProveedor.Enabled = False
            Me.lblProveedorID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_Proveedores_Articulos = dbo

        If m_DBO_Proveedores_Articulos.ProveedorID <> Nothing Then
            Me.cboProveedor.Enabled = False
        End If

        If m_DBO_Proveedores_Articulos.ArticuloID <> Nothing Then
            Me.cboArticulo.Enabled = False
        End If

        cboProveedor.SelectedValue = m_DBO_Proveedores_Articulos.ProveedorID
        cboArticulo.SelectedValue = m_DBO_Proveedores_Articulos.ArticuloID
        chbProveedorPrincipal.Checked = m_DBO_Proveedores_Articulos.ProveedorPrincipal
        chbProveedorUnico.Checked = m_DBO_Proveedores_Articulos.ProveedorUnico
        txtCantidadPedidoHabitual.Text = m_DBO_Proveedores_Articulos.CantidadPedidoHabitual
        txtCantidadPedidoMinima.Text = m_DBO_Proveedores_Articulos.CantidadPedidoMinima
        txtPlazoEntrega.Text = m_DBO_Proveedores_Articulos.PlazoEntrega
        txtPeriodosServicio.Text = m_DBO_Proveedores_Articulos.PeriodosServicio
        txtObservaciones.Text = m_DBO_Proveedores_Articulos.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_Proveedores_Articulos.ProveedorPrincipal = chbProveedorPrincipal.Checked

        m_DBO_Proveedores_Articulos.ProveedorUnico = chbProveedorUnico.Checked

        m_DBO_Proveedores_Articulos.CantidadPedidoHabitual = System.Convert.ToInt32(txtCantidadPedidoHabitual.Text)


        m_DBO_Proveedores_Articulos.CantidadPedidoMinima = System.Convert.ToInt32(txtCantidadPedidoMinima.Text)


        m_DBO_Proveedores_Articulos.PlazoEntrega = System.Convert.ToInt32(txtPlazoEntrega.Text)


        m_DBO_Proveedores_Articulos.PeriodosServicio = System.Convert.ToInt32(txtPeriodosServicio.Text)


        m_DBO_Proveedores_Articulos.Observaciones = txtObservaciones.Text

        If Me.cboArticulo.SelectedValue Is Nothing Then
            errores = errores & Environment.NewLine & "No selecciono el articulo"
        Else
            m_DBO_Proveedores_Articulos.ArticuloID = Me.cboArticulo.SelectedValue
        End If

        If Me.cboProveedor.SelectedValue Is Nothing Then
            errores = errores & Environment.NewLine & "No selecciono el articulo"
        Else
            m_DBO_Proveedores_Articulos.ProveedorID = Me.cboProveedor.SelectedValue
        End If

        If errores = String.Empty Then
            dbo = m_DBO_Proveedores_Articulos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar()
    End Sub

   

   

End Class
