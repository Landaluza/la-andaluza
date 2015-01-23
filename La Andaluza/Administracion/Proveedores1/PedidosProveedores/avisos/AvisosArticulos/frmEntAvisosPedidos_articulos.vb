Public Class frmEntAvisosPedidos_articulos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_AvisosPedidos_articulos As Proveedores.DBO_AvisosPedidos_articulos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAvisosPedidos_articulos = Nothing, Optional ByRef v_dbo As Proveedores.DBO_AvisosPedidos_articulos = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spAvisosPedidos_articulos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_AvisosPedidos_articulos = If(v_dbo Is Nothing, New Proveedores.DBO_AvisosPedidos_articulos, v_dbo)
        dbo = m_DBO_AvisosPedidos_articulos
    End Sub

   Private Sub frmEntAvisosPedidos_articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CType(Me.sp, spAvisosPedidos_articulos).cargar_proveedores(Me.cboproveedor, dtb)

        If (Me.ModoDeApertura = VISION) Then
            Me.cboproveedor.Enabled = False
            Me.lblId_proveedor.Enabled = False
        End If
   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If (Me.ModoDeApertura = INSERCION) Then
            Dim art As Integer = m_DBO_AvisosPedidos_articulos.Id_articulo
            Me.m_DBO_AvisosPedidos_articulos = New Proveedores.DBO_AvisosPedidos_articulos
            m_DBO_AvisosPedidos_articulos.Id_articulo = art
            m_DBO_AvisosPedidos_articulos.Leido = False
        Else
            Me.m_DBO_AvisosPedidos_articulos = CType(dbo, Proveedores.DBO_AvisosPedidos_articulos)
        End If

        cboproveedor.SelectedValue = m_DBO_AvisosPedidos_articulos.Id_proveedor
        If m_DBO_AvisosPedidos_articulos.Id_proveedor = 0 Then chbProveedor.Checked = False
        txtCabecera.Text = m_DBO_AvisosPedidos_articulos.Cabecera
        txtDetalle.Text = m_DBO_AvisosPedidos_articulos.Detalle
        Me.dtpFecha.Value = m_DBO_AvisosPedidos_articulos.Fecha
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty
        If Me.ModoDeApertura <> INSERCION Then
            Dim id As Integer = m_DBO_AvisosPedidos_articulos.ID
            Dim art As Integer = m_DBO_AvisosPedidos_articulos.Id_articulo
            m_DBO_AvisosPedidos_articulos = New Proveedores.DBO_AvisosPedidos_articulos
            m_DBO_AvisosPedidos_articulos.ID = id
            m_DBO_AvisosPedidos_articulos.Id_articulo = art
        End If

        If txtCabecera.Text = "" Then
            If errores = "" Then txtCabecera.Focus()
            errores = errores & "El campo Cabecera no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_AvisosPedidos_articulos.Cabecera = txtCabecera.Text
        End If

        If chbProveedor.Checked Then
            m_DBO_AvisosPedidos_articulos.Id_proveedor = cboproveedor.SelectedValue
        End If

        m_DBO_AvisosPedidos_articulos.Detalle = txtDetalle.Text
        m_DBO_AvisosPedidos_articulos.Fecha = Me.dtpFecha.Value.Date

        If (errores = String.Empty) Then
            dbo = CType(m_DBO_AvisosPedidos_articulos, BasesParaCompatibilidad.DataBussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
   End Function

   Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(dtb)
   End Sub

   Private Sub frmEntAvisosPedidos_articulos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
