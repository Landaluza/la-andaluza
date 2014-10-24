Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntArticulosFichasCondiciones3
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ArticulosFichasCondiciones3 As DBO_ArticulosFichasCondiciones3
    Private m_VerID As Boolean = False
    Private spArticulosFichasCondiciones3 As spArticulosFichasCondiciones3
    Private frmEntProveedores As frmEntProveedores
    Private frmfrmEntPagosFormas As frmEntPagosFormas
    Private frmEntPagosPlazos As frmEntPagosPlazos
    Public Sub New(ByRef ArticulosFichasCondiciones3 As DBO_ArticulosFichasCondiciones3, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_ArticulosFichasCondiciones3 = ArticulosFichasCondiciones3
        m_Pos = Pos
        m_VerID = VerID
        spArticulosFichasCondiciones3 = New spArticulosFichasCondiciones3
        dtpFechaFinal.activarFoco()
        dtpFechaInicio.activarFoco()
    End Sub

    Private Sub frmEntArticulosFichasCondiciones3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboArticuloID.mam_DataSource("Articulos1Cbo", False, dtb)
        Me.cboProveedorID.mam_DataSource("ProveedoresSelectCbo", False, dtb)

        Me.cboFormaPagoID.mam_DataSource("PagosFormasCbo", False, dtb)
        Me.cboPlazoPagoID.mam_DataSource("PagosPlazosCbo", False, dtb)
        Me.cboUnidadID.mam_DataSource("MedidasProductosSelectCbo", False, dtb)

        butVer.Visible = True

        SetValores(m_DBO_ArticulosFichasCondiciones3.ArticuloFichaCondicionID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)

        If m_SelectRecord Then m_DBO_ArticulosFichasCondiciones3 = spArticulosFichasCondiciones3.Select_Record(m_ID, dtb)
        txtArticuloFichaCondicionID.Text = m_DBO_ArticulosFichasCondiciones3.ArticuloFichaCondicionID
        cboArticuloID.SelectedValue = If(m_DBO_ArticulosFichasCondiciones3.ArticuloID.HasValue, m_DBO_ArticulosFichasCondiciones3.ArticuloID, -1)

        cboProveedorID.SelectedValue = If(m_DBO_ArticulosFichasCondiciones3.ProveedorID.HasValue, m_DBO_ArticulosFichasCondiciones3.ProveedorID, -1)
        cboFormaPagoID.SelectedValue = If(m_DBO_ArticulosFichasCondiciones3.FormaPagoID.HasValue, m_DBO_ArticulosFichasCondiciones3.FormaPagoID, -1)
        cboPlazoPagoID.SelectedValue = If(m_DBO_ArticulosFichasCondiciones3.PlazoPagoID.HasValue, m_DBO_ArticulosFichasCondiciones3.PlazoPagoID, -1)
        cboUnidadID.SelectedValue = If(m_DBO_ArticulosFichasCondiciones3.UnidadID.HasValue, m_DBO_ArticulosFichasCondiciones3.UnidadID, -1)
        txtDescripcion.Text = m_DBO_ArticulosFichasCondiciones3.Descripcion
        txtEurosUnidad.Text = m_DBO_ArticulosFichasCondiciones3.EurosUnidad
        txtCantidadMinima.Text = If(m_DBO_ArticulosFichasCondiciones3.CantidadMinima.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.CantidadMinima), "")
        txtPrecioAnterior.Text = If(m_DBO_ArticulosFichasCondiciones3.PrecioAnterior.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.PrecioAnterior), "")
        txtIncremento.Text = If(m_DBO_ArticulosFichasCondiciones3.Incremento.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.Incremento), "")
        txtRuta.Text = m_DBO_ArticulosFichasCondiciones3.Ruta
        dtpFechaInicio.Text = If(m_DBO_ArticulosFichasCondiciones3.FechaInicio.HasValue, m_DBO_ArticulosFichasCondiciones3.FechaInicio, DateTime.Now)
        dtpFechaFinal.Text = If(m_DBO_ArticulosFichasCondiciones3.FechaFinal.HasValue, m_DBO_ArticulosFichasCondiciones3.FechaFinal, DateTime.Now)
        chbVigente.Checked = If(m_DBO_ArticulosFichasCondiciones3.Vigente = Nothing, True, Convert.ToBoolean(m_DBO_ArticulosFichasCondiciones3.Vigente))
        txtCosteTransporte.Text = If(m_DBO_ArticulosFichasCondiciones3.CosteTransporte.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.CosteTransporte), "")
        txtCosteEmbalaje.Text = If(m_DBO_ArticulosFichasCondiciones3.CosteEmbalaje.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.CosteEmbalaje), "")
        txtCosteDevolucionEmbalaje.Text = If(m_DBO_ArticulosFichasCondiciones3.CosteDevolucionEmbalaje.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.CosteDevolucionEmbalaje), "")
        txtAbonoDevolucionEmbalaje.Text = If(m_DBO_ArticulosFichasCondiciones3.AbonoDevolucionEmbalaje.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.AbonoDevolucionEmbalaje), "")
        txtCosteMolde.Text = If(m_DBO_ArticulosFichasCondiciones3.CosteMolde.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.CosteMolde), "")
        txtCosteAmortizacionMoldeUnidad.Text = If(m_DBO_ArticulosFichasCondiciones3.CosteAmortizacionMoldeUnidad.HasValue, Convert.ToString(m_DBO_ArticulosFichasCondiciones3.CosteAmortizacionMoldeUnidad), "")
        txtObservaciones.Text = m_DBO_ArticulosFichasCondiciones3.Observaciones
    End Sub

    Private Sub GetValores()
        m_DBO_ArticulosFichasCondiciones3.ArticuloID = System.Convert.ToInt32(cboArticuloID.SelectedValue)
        m_DBO_ArticulosFichasCondiciones3.ProveedorID = System.Convert.ToInt32(cboProveedorID.SelectedValue)
        m_DBO_ArticulosFichasCondiciones3.FormaPagoID = System.Convert.ToInt32(cboFormaPagoID.SelectedValue)
        m_DBO_ArticulosFichasCondiciones3.PlazoPagoID = System.Convert.ToInt32(cboPlazoPagoID.SelectedValue)
        m_DBO_ArticulosFichasCondiciones3.UnidadID = System.Convert.ToInt32(cboUnidadID.SelectedValue)
        m_DBO_ArticulosFichasCondiciones3.Descripcion = txtDescripcion.Text
        m_DBO_ArticulosFichasCondiciones3.EurosUnidad = System.Convert.ToDouble(txtEurosUnidad.Text)
        m_DBO_ArticulosFichasCondiciones3.CantidadMinima = System.Convert.ToDouble(If(txtCantidadMinima.Text = "", String.Empty, txtCantidadMinima.Text))
        m_DBO_ArticulosFichasCondiciones3.PrecioAnterior = System.Convert.ToDouble(If(txtPrecioAnterior.Text = "", String.Empty, txtPrecioAnterior.Text))
        m_DBO_ArticulosFichasCondiciones3.Incremento = System.Convert.ToDouble(If(txtIncremento.Text = "", String.Empty, txtIncremento.Text))
        m_DBO_ArticulosFichasCondiciones3.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
        m_DBO_ArticulosFichasCondiciones3.FechaInicio = If(dtpFechaInicio.Text = "", System.DateTime.Now.Date, dtpFechaInicio.Value.Date)
        m_DBO_ArticulosFichasCondiciones3.FechaFinal = If(dtpFechaFinal.Text = "", System.DateTime.Now.Date, dtpFechaFinal.Value.Date)
        m_DBO_ArticulosFichasCondiciones3.Vigente = System.Convert.ToBoolean(chbVigente.Checked)

        m_DBO_ArticulosFichasCondiciones3.CosteTransporte = System.Convert.ToDouble(If(txtCosteTransporte.Text = "", Nothing, txtCosteTransporte.Text))
        m_DBO_ArticulosFichasCondiciones3.CosteEmbalaje = If(txtCosteEmbalaje.Text = "", 0, System.Convert.ToDouble(txtCosteEmbalaje.Text))
        m_DBO_ArticulosFichasCondiciones3.CosteDevolucionEmbalaje = If(txtCosteDevolucionEmbalaje.Text = "", 0, System.Convert.ToDouble(txtCosteDevolucionEmbalaje.Text))
        m_DBO_ArticulosFichasCondiciones3.AbonoDevolucionEmbalaje = If(txtAbonoDevolucionEmbalaje.Text = "", 0, System.Convert.ToDouble(txtAbonoDevolucionEmbalaje.Text))
        m_DBO_ArticulosFichasCondiciones3.CosteMolde = If(txtCosteMolde.Text = "", 0, System.Convert.ToDouble(txtCosteMolde.Text))
        m_DBO_ArticulosFichasCondiciones3.CosteAmortizacionMoldeUnidad = If(txtCosteAmortizacionMoldeUnidad.Text = "", 0, System.Convert.ToDouble(txtCosteAmortizacionMoldeUnidad.Text))
        m_DBO_ArticulosFichasCondiciones3.Observaciones = txtObservaciones.Text

        m_DBO_ArticulosFichasCondiciones3.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosFichasCondiciones3.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spArticulosFichasCondiciones3.GrabarArticulosFichasCondiciones3(m_DBO_ArticulosFichasCondiciones3, dtb)
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Compras\Proveedores")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRuta.Text = arch
        End If
    End Sub

    Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRuta.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub butVerProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProveedor.Click
        'Proveedores no esta generado con la ultima version de Generador
        Dim DBO_Proveedor As New DBO_Proveedores
        Dim sp As New spProveedores
        DBO_Proveedor = sp.Select_Record(cboProveedorID.SelectedValue, dtb)

        frmEntProveedores = New frmEntProveedores(VISION, sp, DBO_Proveedor)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmEntProveedores)
    End Sub

    Private Sub butAddPagoForma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddPagoForma.Click
        Using frmEnt As New frmPagosFormas()
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
            Me.cboFormaPagoID.mam_DataSource("PagosFormasCbo", False, dtb)
        End Using
    End Sub

    Private Sub butVerPagoForma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerPagoForma.Click
        Dim DBO_PagosForma As New DBO_PagosFormas
        Dim spPagosFormas As New spPagosFormas
        DBO_PagosForma = spPagosFormas.Select_Record(cboFormaPagoID.SelectedValue, dtb)

        frmfrmEntPagosFormas = New frmEntPagosFormas(DBO_PagosForma, 1, False)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmfrmEntPagosFormas)
    End Sub

    Private Sub butVerPagoPlazo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerPagoPlazo.Click
        Dim DBO_PagosPlazo As New DBO_PagosPlazos
        Dim spPagosPlazos As New spPagosPlazos
        DBO_PagosPlazo = spPagosPlazos.Select_Record(cboPlazoPagoID.SelectedValue, dtb)

        frmEntPagosPlazos = New frmEntPagosPlazos(DBO_PagosPlazo, 1, False)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmEntPagosPlazos)
    End Sub

    Private Sub butAddPagoPlazo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddPagoPlazo.Click
        Using frmEnt As New frmPagosPlazos()
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
            Me.cboPlazoPagoID.mam_DataSource("PagosPlazosCbo", False, dtb)

        End Using
    End Sub

    Private Sub butVerUnidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerUnidad.Click
        'MedidasProductos no esta generado con la ultima version de Generador
    End Sub

    Private Sub butAddProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProveedor.Click
        Using frmEnt As New frmProveedores()
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        End Using
    End Sub

    Private Sub butAddUnidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddUnidad.Click
        Using frmEnt As New frmMedidasProductos()
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
            Me.cboUnidadID.mam_DataSource("MedidasProductosSelectCbo", False, dtb)
        End Using
    End Sub
End Class
