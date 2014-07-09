Public Class frmEntIncidenciasCalidad
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_IncidenciasCalidad As DBO_IncidenciasCalidad
    Private m_linea As Integer

    Public WriteOnly Property Incidencia As Integer
        Set(value As Integer)
            Me.m_DBO_IncidenciasCalidad.IncidenciaID = value
        End Set
    End Property

    Public WriteOnly Property Linea As Integer
        Set(value As Integer)
            Me.m_linea = value
        End Set
    End Property

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spIncidenciasCalidad = Nothing, Optional ByRef v_dbo As DBO_IncidenciasCalidad = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spIncidenciasCalidad, v_sp)
        m_DBO_IncidenciasCalidad = if(v_dbo Is Nothing, New DBO_IncidenciasCalidad, v_dbo)
        dbo = m_DBO_IncidenciasCalidad
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spIncidenciasCalidad, New DBO_IncidenciasCalidad)
        InitializeComponent()
    End Sub

    Private Sub frmEntIncidenciasCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim s As New spProveedores
        's.cargar_Proveedores(Me.cboProveedor)
        
        Dim s2 As New spTiposMateriales
        s2.cargar_TiposMateriales(Me.cboTipoMaterial)

        If Me.ModoDeApertura = VISION Then
            Me.cboTipoMaterial.Enabled = False
            Me.lblTipoMaterialID.Enabled = False

            Me.cboProveedor.Enabled = False
            Me.lblProveedorID.Enabled = False
        End If

        butVer.Visible = True
        Me.bdnGeneral.Visible = False

        If Config.UserType = 3 Then
            Me.butAddProveedorID.Enabled = False
            Me.butVerProveedorID.Enabled = False
            Me.butVerTipoMaterialID.Enabled = False
            Me.butAddTipoMaterialID.Enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_IncidenciasCalidad = dbo

        If Me.m_DBO_IncidenciasCalidad.IncidenciaID <> Nothing Then
            Try
                Dim scalidad As New spIncidenciasCalidad
                Me.m_DBO_IncidenciasCalidad = scalidad.Select_RecordByIncidenciaID(m_DBO_IncidenciasCalidad.IncidenciaID)
            Catch ex As Exception
                Me.m_DBO_IncidenciasCalidad = dbo
            End Try
        End If

        If m_DBO_IncidenciasCalidad Is Nothing Then
            Me.Enabled = False
        Else
            txtLote.Text = m_DBO_IncidenciasCalidad.Lote
            txtRutaDocumento.Text = m_DBO_IncidenciasCalidad.RutaDocumento
            cboTipoMaterial.SelectedValue = m_DBO_IncidenciasCalidad.TipoMaterialID
            cboProveedor.SelectedValue = m_DBO_IncidenciasCalidad.ProveedorID
        End If
    End Sub

    Public Function Comprobar() As Boolean
        Return Me.GetValores
    End Function

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty

        If txtLote.Text = "" Then
            If errores = "" Then txtLote.Focus()
            errores = errores & "El campo Lote no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_IncidenciasCalidad.Lote = txtLote.Text
        End If

        m_DBO_IncidenciasCalidad.RutaDocumento = txtRutaDocumento.Text

        If cboTipoMaterial.SelectedValue is Nothing Then
            If errores = "" Then cboTipoMaterial.Focus()
            errores = errores & "No seleccionó un valor para TipoMaterialID." & Environment.NewLine
        Else
            m_DBO_IncidenciasCalidad.TipoMaterialID = System.Convert.ToInt32(cboTipoMaterial.SelectedValue)
        End If

        m_DBO_IncidenciasCalidad.ProveedorID = Me.cboProveedor.SelectedValue

        If errores = String.empty Then
            Dbo = m_DBO_IncidenciasCalidad
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        If Me.GetValores Then

            If sp.Grabar(dbo, trans) Then
                evitarCerrarSinGuardar = False
                RaiseEvent afterSave(Me, Nothing)
                Me.Close()
            Else
                Throw New Exception("No se pudo guardar el detalle de la incidencia")
            End If

        End If
    End Sub

    Private Sub butRutaDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRutaDocumento.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRutaDocumento.Text, "", "Z:\")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRutaDocumento.Text = arch
        End If
    End Sub

    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRutaDocumento.Text
            Process.Start(psi)
        Catch ex As Exception
            messagebox.show(ex.Message)
        End Try
    End Sub

    Private Sub butVerProveedorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProveedorID.Click
        Dim frmEnt As New frmProveedores()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddProveedorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProveedorID.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        frmEnt.ShowDialog()
        Dim s As New spProveedores
        s.cargar_Proveedores(Me.cboProveedor)
    End Sub

    Private Sub butVerTipoMaterialID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoMaterialID.Click
        Dim frmEnt As New frmTiposMateriales()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddTipoMaterialID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoMaterialID.Click
        Dim DBO_TiposMateriales As New DBO_TiposMateriales
        Dim frmEnt As New frmEntTiposMateriales(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposMateriales, DBO_TiposMateriales)
        frmEnt.ShowDialog()
        Dim s As New spTiposMateriales
        s.cargar_TiposMateriales(Me.cboTipoMaterial)
    End Sub

    Private Sub frmEntIncidenciasCalidad_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        center()
    End Sub

    Public Sub center()
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.panContenido, Me)
    End Sub

    Private Sub cboTipoMaterial_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoMaterial.SelectedIndexChanged
        Try
            Dim s As New spProveedores
            s.cargar_Proveedores_Por_Tipo_Material(Me.cboProveedor, Me.cboTipoMaterial.SelectedValue)

            Dim spMaterialesEnvasados2 As New spMaterialesEnvasados2
            If Me.m_linea <> Nothing Then Me.cboProveedor.SelectedValue = spMaterialesEnvasados2.selectProveedorMasUsado(Me.cboTipoMaterial.SelectedValue, Me.m_linea)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmEntIncidenciasCalidad_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        SetValores()
    End Sub
End Class
