Public Class frmEntTiposMateriales_Provedores
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposMateriales_Provedores As DBO_TiposMateriales_Provedores

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposMateriales_Provedores = Nothing, Optional ByRef v_dbo As DBO_TiposMateriales_Provedores = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposMateriales_Provedores, v_sp)
        m_DBO_TiposMateriales_Provedores = if(v_dbo Is Nothing, New DBO_TiposMateriales_Provedores, v_dbo)
        dbo = m_DBO_TiposMateriales_Provedores
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposMateriales_Provedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_TiposMateriales_Provedores = dbo

        Dim s As New spTiposMateriales
        s.cargar_TiposMateriales(Me.cboid_TiposMateriales)
        If Me.m_DBO_TiposMateriales_Provedores.id_TiposMateriales <> Nothing Then
            Me.PanTipoMaterial.Enabled = False
        End If

        Dim s2 As New spProveedores
        s2.cargar_Proveedores(Me.cboid_proveedor)
        If Me.m_DBO_TiposMateriales_Provedores.id_proveedor <> Nothing Then
            Me.PanProveedor.Enabled = False
        End If

        cboid_TiposMateriales.SelectedValue = m_DBO_TiposMateriales_Provedores.id_TiposMateriales
        cboid_proveedor.SelectedValue = m_DBO_TiposMateriales_Provedores.id_proveedor
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If cboid_TiposMateriales.SelectedValue is Nothing Then
            If errores = "" Then cboid_TiposMateriales.Focus()
            errores = errores & "No seleccionó un valor para id_TiposMateriales." & Environment.NewLine
        Else
            m_DBO_TiposMateriales_Provedores.id_TiposMateriales = System.Convert.ToInt32(cboid_TiposMateriales.SelectedValue)
        End If
        If cboid_proveedor.SelectedValue is Nothing Then
            If errores = "" Then cboid_proveedor.Focus()
            errores = errores & "No seleccionó un valor para id_proveedor." & Environment.NewLine
        Else
            m_DBO_TiposMateriales_Provedores.id_proveedor = System.Convert.ToInt32(cboid_proveedor.SelectedValue)
        End If
        If errores = String.Empty Then
            dbo = m_DBO_TiposMateriales_Provedores
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerid_TiposMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_TiposMateriales.Click
        Dim frmEnt As New frmTiposMateriales()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddid_TiposMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_TiposMateriales.Click
        Dim DBO_TiposMateriales As New DBO_TiposMateriales
        Dim frmEnt As New frmEntTiposMateriales(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposMateriales, DBO_TiposMateriales)
        frmEnt.ShowDialog()
        Dim s As New spTiposMateriales
        s.cargar_TiposMateriales(Me.cboid_TiposMateriales)
    End Sub

    Private Sub butVerid_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_proveedor.Click
        Dim frmEnt As New frmProveedores()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddid_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_proveedor.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        frmEnt.ShowDialog()
        Dim s As New spProveedores
        s.cargar_Proveedores(Me.cboid_proveedor)
    End Sub

End Class
