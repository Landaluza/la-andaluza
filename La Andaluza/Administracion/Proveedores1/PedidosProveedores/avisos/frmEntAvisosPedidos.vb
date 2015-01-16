Namespace Proveedores
    Public Class frmEntAvisosPedidos
        Inherits BasesParaCompatibilidad.DetailedSimpleForm
        Implements BasesParaCompatibilidad.Savable
        Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
        Private m_DBO_AvisosPedidos As DBO_AvisosPedidos

        Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAvisosPedidos = Nothing, Optional ByRef v_dbo As DBO_AvisosPedidos = Nothing)
            MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
            InitializeComponent()
            If v_sp Is Nothing Then
                sp = CType(New spAvisosPedidos, BasesParaCompatibilidad.StoredProcedure)
            Else
                sp = v_sp
            End If
            m_DBO_AvisosPedidos = If(v_dbo Is Nothing, New DBO_AvisosPedidos, v_dbo)
            dbo = m_DBO_AvisosPedidos
        End Sub

        Public Sub New()
            MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(New spAvisosPedidos, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_AvisosPedidos, BasesParaCompatibilidad.DataBussines))
            InitializeComponent()
        End Sub

        Private Sub frmEntAvisosPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            CType(Me.sp, spAvisosPedidos).cargar_articulos(Me.cboarticulo, dtb)
            CType(Me.sp, spAvisosPedidos).cargar_proveedores(Me.cboproveedor, dtb)

            If (Me.ModoDeApertura = VISION) Then
                Me.cboproveedor.Enabled = False
                Me.lblId_proveedor.Enabled = False

                Me.cboarticulo.Enabled = False
                Me.lblId_articulo.Enabled = False
            End If
        End Sub

        Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
            If (Me.ModoDeApertura = INSERCION) Then
                Me.m_DBO_AvisosPedidos = New dbo_AvisosPedidos
            Else
                Me.m_DBO_AvisosPedidos = CType(dbo, DBO_AvisosPedidos)
            End If

            cboproveedor.SelectedValue = m_DBO_AvisosPedidos.Id_proveedor
            If m_DBO_AvisosPedidos.Id_proveedor = 0 Then chbProveedor.Checked = False
            cboarticulo.SelectedValue = m_DBO_AvisosPedidos.Id_articulo
            If m_DBO_AvisosPedidos.Id_articulo = 0 Then chbArticulo.Checked = False
            chbLeido.Checked = m_DBO_AvisosPedidos.Leido
            txtCabecera.Text = m_DBO_AvisosPedidos.Cabecera
            txtDetalle.Text = m_DBO_AvisosPedidos.Detalle
            Me.dtpFecha.Value = m_DBO_AvisosPedidos.Fecha
        End Sub

        Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
            Dim errores As String = String.Empty
            If Me.ModoDeApertura <> INSERCION Then
                Dim id As Integer = m_DBO_AvisosPedidos.ID
                m_DBO_AvisosPedidos = New DBO_AvisosPedidos
            End If

            m_DBO_AvisosPedidos.Leido = chbLeido.Checked

            If txtCabecera.Text = "" Then
                If errores = "" Then txtCabecera.Focus()
                errores = errores & "El campo Cabecera no puede estar vacío." & Environment.NewLine()
            Else
                m_DBO_AvisosPedidos.Cabecera = txtCabecera.Text
            End If

            If chbArticulo.Checked Then
                m_DBO_AvisosPedidos.Id_articulo = cboarticulo.SelectedValue
            End If

            If chbProveedor.Checked Then
                m_DBO_AvisosPedidos.Id_proveedor = cboproveedor.SelectedValue
            End If

            m_DBO_AvisosPedidos.Detalle = txtDetalle.Text
            m_DBO_AvisosPedidos.Fecha = Me.dtpFecha.Value.Date

            If (errores = String.Empty) Then
                dbo = CType(m_DBO_AvisosPedidos, BasesParaCompatibilidad.DataBussines)
                Return True
            Else
                MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End Function

        'Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
            'MyBase.Guardar(trans)
            MyBase.Guardar(dtb)
        End Sub



        Private Sub butVerId_articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim frmEnt As New frmArticulos1()
            GUImain.añadirPestaña(frmEnt)
        End Sub



        Private Sub frmEntAvisosPedidos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
        End Sub

        Private Sub chbProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles chbProveedor.CheckedChanged
            Me.cboproveedor.Enabled = chbProveedor.Checked
        End Sub

        Private Sub chbArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles chbArticulo.CheckedChanged
            Me.cboarticulo.Enabled = chbArticulo.Checked
        End Sub
    End Class
End Namespace