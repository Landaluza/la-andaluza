Public Class frmEntTiposBotellas
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposBotellas As DBO_TiposBotellas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposBotellas = Nothing, Optional ByRef v_dbo As DBO_TiposBotellas = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spTiposBotellas, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_TiposBotellas = If(v_dbo Is Nothing, New DBO_TiposBotellas, v_dbo)
        dbo = m_DBO_TiposBotellas
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spTiposBotellas, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_TiposBotellas, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposBotellas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New sptiposEnvases
        s0.cargar_tiposEnvases(Me.cboid_tipoEnvase, dtb)
        Dim s1 As New spMedidasProductos
        s1.cargar_MedidasProductos(Me.cboid_medidaProducto, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboid_tipoEnvase.enabled = False
            Me.lblid_tipoEnvase.enabled = False

            Me.cboid_medidaProducto.enabled = False
            Me.lblid_medidaProducto.enabled = False

        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddid_tipoEnvase.Enabled = False
            butVerid_tipoEnvase.Enabled = False
            butAddid_medidaProducto.Enabled = False
            butVerid_medidaProducto.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_TiposBotellas = New dbo_TiposBotellas
        Else
            Me.m_DBO_TiposBotellas = CType(dbo, DBO_TiposBotellas)
        End If

        txtCodigoQS.Text = m_DBO_TiposBotellas.CodigoQS
        txtDescripcion.Text = m_DBO_TiposBotellas.Descripcion
        txtCapacidad.Text = m_DBO_TiposBotellas.Capacidad
        cboid_tipoEnvase.SelectedValue = m_DBO_TiposBotellas.id_tipoEnvase
        cboid_medidaProducto.SelectedValue = m_DBO_TiposBotellas.id_medidaProducto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_TiposBotellas.CodigoQS = System.Convert.ToInt32(txtCodigoQS.Text)


        m_DBO_TiposBotellas.Descripcion = txtDescripcion.Text


        m_DBO_TiposBotellas.Capacidad = System.Convert.ToDouble(txtCapacidad.Text)

        If Me.cboid_medidaProducto Is Nothing Then
            errores = errores & Environment.NewLine & "No selecciono la medida"
        Else
            m_DBO_TiposBotellas.id_medidaProducto = cboid_medidaProducto.SelectedValue
        End If

        If Me.cboid_tipoEnvase Is Nothing Then
            errores = errores & Environment.NewLine & "No selecciono el envase"
        Else
            m_DBO_TiposBotellas.id_tipoEnvase = cboid_tipoEnvase.SelectedValue
        End If
        If errores = String.empty Then
            Dbo = CType(m_DBO_TiposBotellas, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerid_tipoEnvase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_tipoEnvase.Click
        Dim frmEnt As New frmtiposEnvases()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddid_tipoEnvase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_tipoEnvase.Click
        Dim DBO_tiposEnvases As New DBO_tiposEnvases
        Dim frmEnt As New frmEnttiposEnvases(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New sptiposEnvases, DBO_tiposEnvases)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New sptiposEnvases
        s.cargar_tiposEnvases(Me.cboid_tipoEnvase, dtb)
    End Sub

    Private Sub butVerid_medidaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_medidaProducto.Click
        Dim frmEnt As New frmMedidasProductos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddid_medidaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_medidaProducto.Click
        Dim DBO_MedidasProductos As New DBO_MedidasProductos
        Dim frmEnt As New frmEntMedidasProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spMedidasProductos, DBO_MedidasProductos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spMedidasProductos
        s.cargar_MedidasProductos(Me.cboid_medidaProducto, dtb)
    End Sub

    Private Sub frmEntTiposBotellas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
