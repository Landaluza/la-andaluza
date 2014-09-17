Public Class frmEntClasesProductosPorClase
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_TiposProductos_ClasesProductos As DBO_TiposProductos_ClasesProductos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposProductos_ClasesProductos = Nothing, Optional ByRef v_dbo As DBO_TiposProductos_ClasesProductos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spTiposProductos_ClasesProductos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_TiposProductos_ClasesProductos = If(v_dbo Is Nothing, New DBO_TiposProductos_ClasesProductos, v_dbo)
        dbo = m_DBO_TiposProductos_ClasesProductos
    End Sub

    Private Sub frmEntTiposProductos_ClasesProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spTiposProductos
        s0.cargar_TiposProductos(Me.cboTipoProducto)
        Dim s1 As New spClasesProductos
        s1.cargar_ClasesProductos(Me.cboClaseProducto)
        If (Me.mododeapertura = VISION) Then
            Me.cboTipoProducto.enabled = False
            Me.lblId_TipoProducto.enabled = False

            Me.cboClaseProducto.enabled = False
            Me.lblId_ClaseProducto.enabled = False

        End If
        If Config.userType <> 4 And Config.userType <> 9 Then
            butAddId_TipoProducto.enabled = False
            butVerId_TipoProducto.enabled = False
            butAddId_ClaseProducto.enabled = False
            butVerId_ClaseProducto.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_TiposProductos_ClasesProductos = CType(dbo, DBO_TiposProductos_ClasesProductos)

        cboTipoProducto.SelectedValue = m_DBO_TiposProductos_ClasesProductos.Id_TipoProducto
        cboClaseProducto.SelectedValue = m_DBO_TiposProductos_ClasesProductos.Id_ClaseProducto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.empty


        If cboTipoProducto.selectedvalue = Nothing Then
            If errores = "" Then cboTipoProducto.Focus()
            errores = errores & "No seleccion� un valor para Id_TipoProducto." & Environment.NewLine()
        Else
            m_DBO_TiposProductos_ClasesProductos.Id_TipoProducto = System.Convert.ToInt32(cboTipoProducto.SelectedValue)
        End If
        If cboClaseProducto.selectedvalue = Nothing Then
            If errores = "" Then cboClaseProducto.Focus()
            errores = errores & "No seleccion� un valor para Id_ClaseProducto." & Environment.NewLine()
        Else
            m_DBO_TiposProductos_ClasesProductos.Id_ClaseProducto = System.Convert.ToInt32(cboClaseProducto.SelectedValue)
        End If
        If (errores = String.empty) Then
            Dbo = CType(m_DBO_TiposProductos_ClasesProductos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoProducto.Click
        Dim frmEnt As New frmTiposProductos()
        guiMain.a�adirPesta�a(frmEnt)
    End Sub

    Private Sub butAddId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoProducto.Click
        Dim DBO_TiposProductos As New DBO_TiposProductos
        Dim frmEnt As New frmEntTiposProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposProductos, DBO_TiposProductos)
        frmEnt.ShowDialog()
        Dim s As New spTiposProductos
        s.cargar_TiposProductos(Me.cboTipoProducto)
    End Sub

    Private Sub butVerId_ClaseProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_ClaseProducto.Click
        Dim frmEnt As New frmClasesProductos()
        guiMain.a�adirPesta�a(frmEnt)
    End Sub

    Private Sub butAddId_ClaseProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_ClaseProducto.Click
        Dim DBO_ClasesProductos As New DBO_ClasesProductos
        Dim frmEnt As New frmEntClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spClasesProductos, DBO_ClasesProductos)
        frmEnt.ShowDialog()
        Dim s As New spClasesProductos
        s.cargar_ClasesProductos(Me.cboClaseProducto)
    End Sub

    Private Sub frmEntTiposProductos_ClasesProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
