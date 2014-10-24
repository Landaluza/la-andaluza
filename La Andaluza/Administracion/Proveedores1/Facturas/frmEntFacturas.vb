Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntFacturas
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Facturas As DBO_Facturas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spFacturas = Nothing, Optional ByRef v_dbo As DBO_Facturas = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spFacturas, v_sp)
        m_DBO_Facturas = If(v_dbo Is Nothing, New DBO_Facturas, v_dbo)
        dbo = m_DBO_Facturas
        Me.dtpfecha.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.dtpfecha.activarFoco()
    End Sub

    Private Sub frmEntFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spProveedores
        s.cargar_ComboBox(Me.cboid_proveedor, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboid_proveedor.Enabled = False
            Me.lblid_proveedor.Enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_Facturas = New DBO_Facturas
        Else
            Me.m_DBO_Facturas = dbo
        End If

        txtnumero.Text = m_DBO_Facturas.numero
        dtpfecha.Text = m_DBO_Facturas.fecha.ToString
        txtarchivo.Text = m_DBO_Facturas.archivo
        cboid_proveedor.SelectedValue = m_DBO_Facturas.id_proveedor
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If Not IsNumeric(txtnumero.Text) Then
            If errores = "" Then txtnumero.Focus()
            errores = errores & "El campo numero debe ser numérico." & Environment.NewLine
        Else
            m_DBO_Facturas.numero = System.Convert.ToInt32(txtnumero.Text)
        End If


        m_DBO_Facturas.fecha = dtpfecha.Value.Date


        If txtarchivo.Text = "" Then
            If errores = "" Then txtarchivo.Focus()
            errores = errores & "El campo archivo no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_Facturas.archivo = txtarchivo.Text
        End If



        If cboid_proveedor.SelectedValue Is Nothing Then
            If errores = "" Then cboid_proveedor.Focus()
            errores = errores & "No seleccionó un valor para id_proveedor." & Environment.NewLine
        Else
            m_DBO_Facturas.id_proveedor = System.Convert.ToInt32(cboid_proveedor.SelectedValue)
        End If
        If errores = String.Empty Then
            dbo = m_DBO_Facturas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerid_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_proveedor.Click
        Dim frmEnt As New frmProveedores()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_proveedor.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProveedores
        s.cargar_ComboBox(Me.cboid_proveedor, dtb)
    End Sub


    Private Sub btnaddFile_Click(sender As System.Object, e As System.EventArgs) Handles btnaddFile.Click

    End Sub
End Class
