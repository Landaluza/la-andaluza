Public Class frmEntDEtallePorFamilia
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_FamliaProductos_TiposProductos As DBO_FamliaProductos_TiposProductos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spFamliaProductos_TiposProductos = Nothing, Optional ByRef v_dbo As DBO_FamliaProductos_TiposProductos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spFamliaProductos_TiposProductos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_FamliaProductos_TiposProductos = If(v_dbo Is Nothing, New DBO_FamliaProductos_TiposProductos, v_dbo)
        dbo = m_DBO_FamliaProductos_TiposProductos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spFamliaProductos_TiposProductos, BasesParaCompatibilidad.storedprocedure), CType(New DBO_FamliaProductos_TiposProductos, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntFamliaProductos_TiposProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s1 As New spTiposProductos
        s1.cargar_ComboBox(Me.cboTipoProducto)
        If (Me.mododeapertura = VISION) Then
            Me.cboTipoProducto.Enabled = False
            Me.lblId_TipoProducto.enabled = False
        End If
        If Config.userType <> 4 And Config.userType <> 9 Then
            butAddId_TipoProducto.enabled = False
            butVerId_TipoProducto.enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If (Me.modoDeApertura = INSERCION) Then
            Me.m_DBO_FamliaProductos_TiposProductos = New dbo_FamliaProductos_TiposProductos
        Else
            Me.m_DBO_FamliaProductos_TiposProductos = CType(dbo, DBO_FamliaProductos_TiposProductos)
        End If

        cboTipoProducto.SelectedValue = m_DBO_FamliaProductos_TiposProductos.Id_TipoProducto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.empty


        If cboTipoProducto.selectedvalue = Nothing Then
            If errores = "" Then cboTipoProducto.Focus()
            errores = errores & "No seleccionó un valor para Id_TipoProducto." & Environment.NewLine()
        Else
            m_DBO_FamliaProductos_TiposProductos.Id_TipoProducto = System.Convert.ToInt32(cboTipoProducto.SelectedValue)
        End If
        If (errores = String.empty) Then
            Dbo = CType(m_DBO_FamliaProductos_TiposProductos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_FamiliaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmFamiliaProducto()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_FamiliaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_FamiliaProducto As New DBO_FamiliaProducto
        Dim frmEnt As New frmEntFamiliaProducto(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spFamiliaProducto, DBO_FamiliaProducto)
        frmEnt.ShowDialog()
    End Sub

    Private Sub butVerId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoProducto.Click
        Dim frmEnt As New frmTiposProductos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoProducto.Click
        Dim DBO_TiposProductos As New DBO_TiposProductos
        Dim frmEnt As New frmEntTiposProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposProductos, DBO_TiposProductos)
        frmEnt.ShowDialog()
        Dim s As New spTiposProductos
        s.cargar_ComboBox(Me.cboTipoProducto)
    End Sub

    Private Sub frmEntFamliaProductos_TiposProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
