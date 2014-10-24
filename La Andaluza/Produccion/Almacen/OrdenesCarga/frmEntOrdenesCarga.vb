
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntOrdenesCarga
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_OrdenesCarga As DBO_OrdenesCarga
    Private m_VerID As Boolean = False
    Private spOrdenesCarga As spOrdenesCarga

    Public Sub New(ByRef OrdenesCarga As DBO_OrdenesCarga, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spOrdenesCarga = New spOrdenesCarga
        m_DBO_OrdenesCarga = OrdenesCarga
        m_Pos = Pos
        m_VerID = VerID
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntOrdenesCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetValores(m_DBO_OrdenesCarga.OrdenCargaID, False)
        butVer.Visible = True
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)

        If m_SelectRecord Then m_DBO_OrdenesCarga = spOrdenesCarga.Select_Record(m_ID, dtb)
        If m_ID > 0 Then
            txtOrdenCargaID.Text = m_DBO_OrdenesCarga.OrdenCargaID
            dtpFecha.Text = m_DBO_OrdenesCarga.Fecha
            txtRuta.Text = m_DBO_OrdenesCarga.Ruta
            txtObservaciones.Text = m_DBO_OrdenesCarga.Observaciones
        End If
    End Sub

    Private Sub GetValores()
        m_DBO_OrdenesCarga.Fecha = dtpFecha.Value.Date
        m_DBO_OrdenesCarga.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
        m_DBO_OrdenesCarga.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spOrdenesCarga.GrabarOrdenesCarga(m_DBO_OrdenesCarga, dtb)
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Almacen\Ordenes de carga")
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
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        If txtRuta.Text <> "" Then
            Try
                Dim oApp As New Microsoft.Office.Interop.Excel.Application
                Dim oWBa As Microsoft.Office.Interop.Excel.Workbook = oApp.Workbooks.Open(txtRuta.Text)
                oApp.Visible = True
                oWBa.Activate()
            Catch ex As Exception
                MessageBox.Show("No se pudo abrir el archivo excel. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
