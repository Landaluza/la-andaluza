
Public Class frmEntDetallePorFamilia
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_FamliaProductos_TiposProductos As DBO_FamliaProductos_TiposProductos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spFamliaProductos_TiposProductos = Nothing, Optional ByRef v_dbo As DBO_FamliaProductos_TiposProductos = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spFamliaProductos_TiposProductos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_FamliaProductos_TiposProductos = If(v_dbo Is Nothing, New DBO_FamliaProductos_TiposProductos, v_dbo)
        dbo = m_DBO_FamliaProductos_TiposProductos
    End Sub

    Private Sub frmEntFamliaProductos_TiposProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spTiposProductos
        s0.cargar_ComboBox(Me.cboFamiliaProducto)
        If (Me.ModoDeApertura = VISION) Then
            Me.cboFamiliaProducto.Enabled = False
            Me.lblId_FamiliaProducto.Enabled = False

        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_FamliaProductos_TiposProductos = CType(dbo, DBO_FamliaProductos_TiposProductos)

        cboFamiliaProducto.SelectedValue = m_DBO_FamliaProductos_TiposProductos.Id_TipoProducto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If cboFamiliaProducto.SelectedValue = Nothing Then
            If errores = "" Then cboFamiliaProducto.Focus()
            errores = errores & "No seleccionó un valor para Id_FamiliaProducto." & Environment.NewLine()
        Else
            m_DBO_FamliaProductos_TiposProductos.Id_TipoProducto = System.Convert.ToInt32(cboFamiliaProducto.SelectedValue)
        End If
        If (errores = String.Empty) Then
            dbo = CType(m_DBO_FamliaProductos_TiposProductos, BasesParaCompatibilidad.DataBussines)
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
        Dim s As New spFamiliaProducto
        s.cargar_FamiliaProducto(Me.cboFamiliaProducto)
    End Sub

    Private Sub frmEntFamliaProductos_TiposProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class

