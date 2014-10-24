Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntArticulos_AlmacenNoConforme
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Articulos_AlmacenNoConforme As DBO_Articulos_AlmacenNoConforme

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spArticulos_AlmacenNoConforme = Nothing, Optional ByRef v_dbo As DBO_Articulos_AlmacenNoConforme = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spArticulos_AlmacenNoConforme, v_sp)
        m_DBO_Articulos_AlmacenNoConforme = If(v_dbo Is Nothing, New DBO_Articulos_AlmacenNoConforme, v_dbo)
        dbo = m_DBO_Articulos_AlmacenNoConforme
        dtpFechaEntrada.activarFoco()
        dtpFechaSalida.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spArticulos_AlmacenNoConforme, New DBO_Articulos_AlmacenNoConforme)
        InitializeComponent()
        dtpFechaEntrada.activarFoco()
        dtpFechaSalida.activarFoco()
    End Sub

    Private Sub frmEntArticulos_AlmacenNoConforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spTiposAcciones
        s.cargar_TiposAcciones(Me.cboTipoAccion, dtb)

        Dim s2 As New spMedidasProductos
        s2.cargar_MedidasProductos(Me.cboid_MedidaProducto, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboid_MedidaProducto.Enabled = False
            Me.lblid_MedidaProducto.Enabled = False
            Me.cboTipoAccion.Enabled = False
            Me.lblId_TipoAccion.Enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores

        Me.m_DBO_Articulos_AlmacenNoConforme = dbo

        txtObservaciones.Text = m_DBO_Articulos_AlmacenNoConforme.Observaciones
        dtpFechaEntrada.Text = m_DBO_Articulos_AlmacenNoConforme.FechaEntrada.ToString
        If m_DBO_Articulos_AlmacenNoConforme.FechaSalida = Nothing Then
            Me.chbSalida.Checked = False
        End If
        dtpFechaSalida.Text = m_DBO_Articulos_AlmacenNoConforme.FechaSalida.ToString
        cboTipoAccion.SelectedValue = m_DBO_Articulos_AlmacenNoConforme.Id_TipoAccion
        txtCantidad.Text = m_DBO_Articulos_AlmacenNoConforme.Cantidad
        cboid_MedidaProducto.SelectedValue = m_DBO_Articulos_AlmacenNoConforme.id_MedidaProducto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_Articulos_AlmacenNoConforme.Observaciones = txtObservaciones.Text


        m_DBO_Articulos_AlmacenNoConforme.FechaEntrada = dtpFechaEntrada.Value.Date

        If Me.chbSalida.Checked Then
            m_DBO_Articulos_AlmacenNoConforme.FechaSalida = dtpFechaSalida.Value.Date
        Else
            m_DBO_Articulos_AlmacenNoConforme.FechaSalida = Nothing
        End If

        If cboTipoAccion.SelectedValue Is Nothing Then
            If errores = "" Then cboTipoAccion.Focus()
            errores = errores & "No seleccionó un valor para Id_TipoAccion." & Environment.NewLine
        Else
            m_DBO_Articulos_AlmacenNoConforme.Id_TipoAccion = System.Convert.ToInt32(cboTipoAccion.SelectedValue)
        End If
        m_DBO_Articulos_AlmacenNoConforme.Cantidad = System.Convert.ToInt32(txtCantidad.Text)


        If cboid_MedidaProducto.SelectedValue Is Nothing Then
            If errores = "" Then cboid_MedidaProducto.Focus()
            errores = errores & "No seleccionó un valor para id_MedidaProducto." & Environment.NewLine
        Else
            m_DBO_Articulos_AlmacenNoConforme.id_MedidaProducto = System.Convert.ToInt32(cboid_MedidaProducto.SelectedValue)
        End If

        If errores = String.Empty Then
            dbo = m_DBO_Articulos_AlmacenNoConforme
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerId_TipoAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoAccion.Click
        Dim frmEnt As New frmTiposAcciones()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_TipoAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoAccion.Click
        Dim DBO_TiposAcciones As New DBO_TiposAcciones
        Dim frmEnt As New frmEntTiposAcciones(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposAcciones, DBO_TiposAcciones)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposAcciones
        s.cargar_TiposAcciones(Me.cboTipoAccion, dtb)
    End Sub

    Private Sub butVerid_MedidaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_MedidaProducto.Click
        Dim frmEnt As New frmMedidasProductos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_MedidaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_MedidaProducto.Click
        'Dim DBO_MedidasProductos As New DBO_MedidasProductos
        'Dim frmEnt As New frmEntMedidasProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spMedidasProductos,DBO_MedidasProductos)
        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        'dim s as new spMedidasProductos
        's.cargar_MedidasProductos(Me.cboid_MedidaProducto)
    End Sub



    Private Sub chbSalida_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbSalida.CheckedChanged
        Me.dtpFechaSalida.Enabled = Me.chbSalida.Checked
    End Sub
End Class
