Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntArticulosFichasPaletizados1
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ArticulosFichasPaletizados1 As DBO_ArticulosFichasPaletizados1
    Private m_VerID As Boolean = False
    Private spArticulosFichasPaletizados1 As spArticulosFichasPaletizados1

    Public Sub New(ByRef ArticulosFichasPaletizados1 As DBO_ArticulosFichasPaletizados1, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_ArticulosFichasPaletizados1 = ArticulosFichasPaletizados1
        m_Pos = Pos
        m_VerID = VerID
        spArticulosFichasPaletizados1 = New spArticulosFichasPaletizados1
        dtpFechaObsoleta.activarFoco()
        dtpFechaVigente.activarFoco()
    End Sub

    Private Sub frmEntArticulosFichasPaletizados1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spArticulosEnvasadosHistoricos As New spArticulosEnvasadosHistoricos
        spArticulosEnvasadosHistoricos.cargar_TiposFormatos_Todos(cboArticuloID, dtb)
        'Me.cboArticuloID.mam_DataSource("ArticulosFichasPaletizados1_TiposFormatosCbo"), False)
        If Not m_VerID Then
            Me.cboArticuloID.Visible = False
            Me.lblArticuloID.Visible = False
        End If
        SetValores(m_DBO_ArticulosFichasPaletizados1.ArticuloFichaPaletizadoID, False)
        butVer.Visible = True
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)

        If m_SelectRecord Then m_DBO_ArticulosFichasPaletizados1 = spArticulosFichasPaletizados1.Select_Record(m_ID, dtb)
        If m_ID > 0 Then
            txtArticuloFichaPaletizadoID.Text = m_DBO_ArticulosFichasPaletizados1.ArticuloFichaPaletizadoID
            cboArticuloID.SelectedValue = If(m_DBO_ArticulosFichasPaletizados1.ArticuloID.HasValue, m_DBO_ArticulosFichasPaletizados1.ArticuloID, -1)
            txtDescripcion.Text = m_DBO_ArticulosFichasPaletizados1.Descripcion
            txtRuta.Text = m_DBO_ArticulosFichasPaletizados1.Ruta
            dtpFechaVigente.Text = If(m_DBO_ArticulosFichasPaletizados1.FechaVigente.HasValue, Convert.ToString(m_DBO_ArticulosFichasPaletizados1.FechaVigente), "")
            dtpFechaObsoleta.Text = If(m_DBO_ArticulosFichasPaletizados1.FechaObsoleta.HasValue, Convert.ToString(m_DBO_ArticulosFichasPaletizados1.FechaObsoleta), "")
            chbVigente.Checked = m_DBO_ArticulosFichasPaletizados1.Vigente
            txtObservaciones.Text = m_DBO_ArticulosFichasPaletizados1.Observaciones
        End If
    End Sub

    Private Sub GetValores()
        m_DBO_ArticulosFichasPaletizados1.ArticuloID = System.Convert.ToInt32(cboArticuloID.SelectedValue)
        m_DBO_ArticulosFichasPaletizados1.Descripcion = If(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_ArticulosFichasPaletizados1.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
        m_DBO_ArticulosFichasPaletizados1.FechaVigente = If(dtpFechaVigente.Text = "", System.DateTime.Now.Date, dtpFechaVigente.Value.Date)
        m_DBO_ArticulosFichasPaletizados1.FechaObsoleta = If(dtpFechaObsoleta.Text = "", System.DateTime.Now.Date, dtpFechaObsoleta.Value.Date)
        m_DBO_ArticulosFichasPaletizados1.Vigente = System.Convert.ToBoolean(chbVigente.Checked)
        m_DBO_ArticulosFichasPaletizados1.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ArticulosFichasPaletizados1.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosFichasPaletizados1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spArticulosFichasPaletizados1.GrabarArticulosFichasPaletizados1(m_DBO_ArticulosFichasPaletizados1, dtb)
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Sistema de Gestión Integrada\0.2. Calidad\Fichas tecnicas materiales auxiliares")
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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
