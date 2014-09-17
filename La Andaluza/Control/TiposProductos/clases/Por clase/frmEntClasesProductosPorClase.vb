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
        s0.cargar_ComboBox(Me.cboTipoProducto)
        If (Me.mododeapertura = VISION) Then
            Me.cboTipoProducto.enabled = False
            Me.lblId_TipoProducto.enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_TiposProductos_ClasesProductos = CType(dbo, DBO_TiposProductos_ClasesProductos)

        cboTipoProducto.SelectedValue = m_DBO_TiposProductos_ClasesProductos.Id_TipoProducto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.empty

        If cboTipoProducto.selectedvalue = Nothing Then
            If errores = "" Then cboTipoProducto.Focus()
            errores = errores & "No seleccionó un valor para Id_TipoProducto." & Environment.NewLine()
        Else
            m_DBO_TiposProductos_ClasesProductos.Id_TipoProducto = System.Convert.ToInt32(cboTipoProducto.SelectedValue)
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

    Private Sub frmEntTiposProductos_ClasesProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
