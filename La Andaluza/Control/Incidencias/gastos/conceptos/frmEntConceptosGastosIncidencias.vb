Public Class frmEntConceptosGastosIncidencias
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ConceptosGastosIncidencias As DBO_ConceptosGastosIncidencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spConceptosGastosIncidencias = Nothing, Optional ByRef v_dbo As DBO_ConceptosGastosIncidencias = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spConceptosGastosIncidencias, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_ConceptosGastosIncidencias = If(v_dbo Is Nothing, New DBO_ConceptosGastosIncidencias, v_dbo)
        dbo = m_DBO_ConceptosGastosIncidencias
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spConceptosGastosIncidencias, BasesParaCompatibilidad.storedprocedure), CType(New DBO_ConceptosGastosIncidencias, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntConceptosGastosIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spTiposConceptos
        s0.cargar_TiposConceptos(Me.cbotiposConceptos)
        Dim s1 As New spMedidasProductos
        s1.cargar_MedidasProductos(Me.cbomedidaProducto)
        If (Me.mododeapertura = VISION) Then
            Me.cbotiposConceptos.enabled = False
            Me.lblId_tiposConceptos.enabled = False

            Me.cbomedidaProducto.enabled = False
            Me.lblId_medidaProducto.enabled = False

        End If
        If Config.userType <> 4 And Config.userType <> 9 Then
            butAddId_tiposConceptos.enabled = False
            butVerId_tiposConceptos.enabled = False
            butAddId_medidaProducto.enabled = False
            butVerId_medidaProducto.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If (Me.modoDeApertura = INSERCION) Then
            Me.m_DBO_ConceptosGastosIncidencias = New dbo_ConceptosGastosIncidencias
        Else
            Me.m_DBO_ConceptosGastosIncidencias = CType(dbo, DBO_ConceptosGastosIncidencias)
        End If

        txtDescripcion.Text = m_DBO_ConceptosGastosIncidencias.Descripcion
        cbotiposConceptos.SelectedValue = m_DBO_ConceptosGastosIncidencias.Id_tiposConceptos
        cbomedidaProducto.SelectedValue = m_DBO_ConceptosGastosIncidencias.Id_medidaProducto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_ConceptosGastosIncidencias.Descripcion = txtDescripcion.Text
        End If



        If cbotiposConceptos.selectedvalue = Nothing Then
            If errores = "" Then cbotiposConceptos.Focus()
            errores = errores & "No seleccionó un valor para Id_tiposConceptos." & Environment.NewLine()
        Else
            m_DBO_ConceptosGastosIncidencias.Id_tiposConceptos = System.Convert.ToInt32(cbotiposConceptos.SelectedValue)
        End If
        If cbomedidaProducto.selectedvalue = Nothing Then
            If errores = "" Then cbomedidaProducto.Focus()
            errores = errores & "No seleccionó un valor para Id_medidaProducto." & Environment.NewLine()
        Else
            m_DBO_ConceptosGastosIncidencias.Id_medidaProducto = System.Convert.ToInt32(cbomedidaProducto.SelectedValue)
        End If
        If (errores = String.empty) Then
            Dbo = CType(m_DBO_ConceptosGastosIncidencias, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_tiposConceptos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_tiposConceptos.Click
        Dim frmEnt As New frmTiposConceptos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_tiposConceptos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_tiposConceptos.Click
        Dim DBO_TiposConceptos As New DBO_TiposConceptos
        Dim frmEnt As New frmEntTiposConceptos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposConceptos, DBO_TiposConceptos)
        frmEnt.ShowDialog()
        Dim s As New spTiposConceptos
        s.cargar_TiposConceptos(Me.cbotiposConceptos)
    End Sub

    Private Sub butVerId_medidaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_medidaProducto.Click
        Dim frmEnt As New frmMedidasProductos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_medidaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_medidaProducto.Click
        Dim DBO_MedidasProductos As New DBO_MedidasProductos
        Dim frmEnt As New frmEntMedidasProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spMedidasProductos, DBO_MedidasProductos)
        frmEnt.ShowDialog()
        Dim s As New spMedidasProductos
        s.cargar_MedidasProductos(Me.cbomedidaProducto)
    End Sub

    Private Sub frmEntConceptosGastosIncidencias_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
