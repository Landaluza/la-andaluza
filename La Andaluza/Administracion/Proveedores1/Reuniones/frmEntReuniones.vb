Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntReuniones
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave

    Private m_DBO_Reuniones As DBO_Reuniones




    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spReuniones = Nothing, Optional ByRef v_dbo As DBO_Reuniones = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spReuniones, v_sp)
        m_DBO_Reuniones = If(v_dbo Is Nothing, New DBO_Reuniones, v_dbo)
        dbo = m_DBO_Reuniones
        Me.dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntReuniones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboId_proveedor.mam_DataSource("Proveedores1Cbo", False)
        Me.cboId_TipoReunion.mam_DataSource("TiposReunionesCbo", False)


        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            'Me.m_DBO_Reuniones = New DBO_Reuniones            
            m_DBO_Reuniones = dbo
            If Me.m_DBO_Reuniones.Id_proveedor <> Nothing Then
                'Me.cboId_proveedor.SelectedValue = Me.m_DBO_Reuniones.Id_proveedor
                Me.cboId_proveedor.Enabled = False
            End If

        Else
            Me.m_DBO_Reuniones = dbo
        End If

        cboId_proveedor.SelectedValue = m_DBO_Reuniones.Id_proveedor
        cboId_TipoReunion.SelectedValue = m_DBO_Reuniones.Id_TipoReunion
        dtpFecha.Text = m_DBO_Reuniones.Fecha.ToString
        txtObservaciones.Text = m_DBO_Reuniones.Observaciones
        txtRutaDocumento.Text = m_DBO_Reuniones.RutaDocumento

    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If cboId_proveedor.SelectedValue Is Nothing Then
            If errores = "" Then cboId_proveedor.Focus()
            errores = errores & "No seleccionó un valor para Proveedor." & Environment.NewLine
        Else
            m_DBO_Reuniones.Id_proveedor = System.Convert.ToInt32(cboId_proveedor.SelectedValue)
        End If
        If cboId_TipoReunion.SelectedValue Is Nothing Then
            If errores = "" Then cboId_TipoReunion.Focus()
            errores = errores & "No seleccionó un valor para 'Tipo de reunión'." & Environment.NewLine
        Else
            m_DBO_Reuniones.Id_TipoReunion = System.Convert.ToInt32(cboId_TipoReunion.SelectedValue)
        End If
        m_DBO_Reuniones.Fecha = dtpFecha.Value.Date
        m_DBO_Reuniones.Observaciones = txtObservaciones.Text
        m_DBO_Reuniones.RutaDocumento = txtRutaDocumento.Text

        If errores = String.Empty Then
            dbo = m_DBO_Reuniones
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butRutaDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRutaDocumento.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRutaDocumento.Text, "", If(Me.m_DBO_Reuniones.RutaDefecto <> String.Empty, Me.m_DBO_Reuniones.RutaDefecto, "Z:\"))
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
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub butVerId_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmProveedores()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_proveedor.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Me.cboId_proveedor.mam_DataSource("Proveedores1Cbo", False)
    End Sub

    Private Sub butVerId_TipoReunion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmTiposReuniones()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_TipoReunion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoReunion.Click
        Dim DBO_TiposReuniones As New DBO_TiposReuniones
        Dim frmEnt As New frmEntTiposReuniones(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposReuniones, DBO_TiposReuniones)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Me.cboId_TipoReunion.mam_DataSource("TiposReunionesCbo", False)
    End Sub

End Class
