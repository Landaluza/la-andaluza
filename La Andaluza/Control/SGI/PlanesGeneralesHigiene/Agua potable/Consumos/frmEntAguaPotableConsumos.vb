Public Class frmEntAguaPotableConsumos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_AguaPotableConsumos As DBO_AguaPotableConsumos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAguaPotableConsumos = Nothing, Optional ByRef v_dbo As DBO_AguaPotableConsumos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spAguaPotableConsumos, v_sp)
        m_DBO_AguaPotableConsumos = if(v_dbo Is Nothing, New DBO_AguaPotableConsumos, v_dbo)
        dbo = m_DBO_AguaPotableConsumos
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntAguaPotableConsumos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spFacturas
        s.cargar_Facturas(Me.cboid_factura)
        If Me.ModoDeApertura = VISION Then
            Me.cboid_factura.Enabled = False
            Me.lblid_factura.Enabled = False

        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_AguaPotableConsumos = New DBO_AguaPotableConsumos
        Else
            Me.m_DBO_AguaPotableConsumos = dbo
        End If

        txtPeriodo.Text = m_DBO_AguaPotableConsumos.Periodo
        txtLitros.Text = m_DBO_AguaPotableConsumos.Litros
        txtObservaciones.Text = m_DBO_AguaPotableConsumos.Observaciones
        cboid_factura.SelectedValue = m_DBO_AguaPotableConsumos.id_factura
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty

        If txtPeriodo.Text = "" Then
            errores &= Environment.NewLine & "El campo periodo no puede estar vacío"
        Else
            m_DBO_AguaPotableConsumos.Periodo = txtPeriodo.Text
        End If
        If txtLitros.Text = "" Then
            errores &= Environment.NewLine & "El campo litros no puede estar vacío"
        Else
            m_DBO_AguaPotableConsumos.Litros = System.Convert.ToInt32(txtLitros.Text)
        End If
        If Me.cboid_factura.SelectedValue is Nothing Then
            errores &= Environment.NewLine & "Debe seleccionar una factura"
        Else
            Me.m_DBO_AguaPotableConsumos.id_factura = Me.cboid_factura.SelectedValue
        End If

        m_DBO_AguaPotableConsumos.Observaciones = txtObservaciones.Text




        If errores = String.Empty Then
            dbo = m_DBO_AguaPotableConsumos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerid_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_factura.Click
        Dim frmEnt As New frmFacturas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_factura.Click
        Dim DBO_Facturas As New DBO_Facturas
        Dim frmEnt As New frmEntFacturas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spFacturas, DBO_Facturas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spFacturas
        s.cargar_Facturas(Me.cboid_factura)
    End Sub

End Class
