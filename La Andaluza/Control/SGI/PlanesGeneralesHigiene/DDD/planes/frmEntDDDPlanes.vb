Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntDDDPlanes
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_DDDPlanes As DBO_DDDPlanes

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDDDPlanes = Nothing, Optional ByRef v_dbo As DBO_DDDPlanes = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spDDDPlanes, v_sp)
        m_DBO_DDDPlanes = If(v_dbo Is Nothing, New DBO_DDDPlanes, v_dbo)
        dbo = m_DBO_DDDPlanes
        dtpFechaInicio.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFechaInicio.activarFoco()
    End Sub

    Private Sub frmEntDDDPlanes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_DDDPlanes = New DBO_DDDPlanes
        Else
            Me.m_DBO_DDDPlanes = dbo
        End If

        dtpFechaInicio.Text = m_DBO_DDDPlanes.FechaInicio.ToString
        txtDescripcion.Text = m_DBO_DDDPlanes.Descripcion
        txtRuta.Text = m_DBO_DDDPlanes.Ruta
        txtObservaciones.Text = m_DBO_DDDPlanes.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_DDDPlanes.FechaInicio = dtpFechaInicio.Value.Date


        m_DBO_DDDPlanes.Descripcion = txtDescripcion.Text


        m_DBO_DDDPlanes.Ruta = txtRuta.Text


        m_DBO_DDDPlanes.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_DDDPlanes
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRuta.Text = arch
        End If
    End Sub

    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRuta.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
