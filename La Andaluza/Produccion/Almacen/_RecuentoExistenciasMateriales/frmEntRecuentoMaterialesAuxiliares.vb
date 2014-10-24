Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntRecuentoMaterialesAuxiliares
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_RecuentoMaterialesAuxiliares As DBO_RecuentoMaterialesAuxiliares

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spRecuentoMaterialesAuxiliares = Nothing, Optional ByRef v_dbo As DBO_RecuentoMaterialesAuxiliares = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spRecuentoMaterialesAuxiliares, v_sp)
        m_DBO_RecuentoMaterialesAuxiliares = If(v_dbo Is Nothing, New DBO_RecuentoMaterialesAuxiliares, v_dbo)
        dbo = m_DBO_RecuentoMaterialesAuxiliares
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spRecuentoMaterialesAuxiliares, New DBO_RecuentoMaterialesAuxiliares)
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntRecuentoMaterialesAuxiliares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_RecuentoMaterialesAuxiliares = New DBO_RecuentoMaterialesAuxiliares
        Else
            Me.m_DBO_RecuentoMaterialesAuxiliares = dbo
        End If

        dtpFecha.Text = m_DBO_RecuentoMaterialesAuxiliares.Fecha.ToString
        txtObservaciones.Text = m_DBO_RecuentoMaterialesAuxiliares.Observaciones
        txtRuta.Text = m_DBO_RecuentoMaterialesAuxiliares.Ruta
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty
        m_DBO_RecuentoMaterialesAuxiliares.Fecha = dtpFecha.Value.Date
        m_DBO_RecuentoMaterialesAuxiliares.Observaciones = txtObservaciones.Text
        m_DBO_RecuentoMaterialesAuxiliares.Ruta = txtRuta.Text

        If errores = String.Empty Then
            dbo = m_DBO_RecuentoMaterialesAuxiliares
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    'Public Overrides Sub Guardar(ByRef dtb As BasesParaCompatibilidad.DataBase ) Implements  BasesParaCompatibilidad.savable.Guardar
    '    MyBase.Guardar(me.dtb)
    ' End Sub

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        arch = SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Almacen\Recuentos materiales auxiliares\")
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

    Public Function SeleccionarArchivo(ByVal OpcionForm As String, ByVal DoctoUbicacionfisicaCuadroDeTexto As String, ByVal archactual As String, Optional ByVal ruta As String = "") As String
        If (OpcionForm = "Ver") Then
            Dim hay_error As Short = AbrirArchivo(DoctoUbicacionfisicaCuadroDeTexto)
            Return DoctoUbicacionfisicaCuadroDeTexto
        Else
            Dim ofd As New OpenFileDialog
            Dim arch As String = ""
            ofd.CheckFileExists = True
            ofd.CheckPathExists = True
            ofd.Multiselect = False

            If ruta <> "" Then
                ofd.InitialDirectory = ruta
            End If

            If archactual <> "" Then
                ofd.FileName = archactual
            End If

            Dim ok As DialogResult = ofd.ShowDialog()
            If ok = Windows.Forms.DialogResult.OK Then
                arch = ofd.FileName
                Dim hay_error As Short = AbrirArchivo(arch)
                Return arch
            End If
            Return ""
        End If
    End Function

    Private Function AbrirArchivo(ByVal arch As String) As Short
        Dim hay_error As Short
        hay_error = ShellExecute(123456, "Open", arch, "", "", 3)
        Return hay_error
    End Function

    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer,
                                                                                  ByVal lpOperation As String,
                                                                                  ByVal lpFile As String,
                                                                                  ByVal lpParameters As String,
                                                                                  ByVal lpDirectory As String,
                                                                                  ByVal nShowCmd As Integer) As Integer

    ''http://social.msdn.microsoft.com/Forums/en-US/csharpgeneral/thread/ea8b0fd5-a660-46f9-9dcb-d525cc22dcbd/
    <Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function

End Class
