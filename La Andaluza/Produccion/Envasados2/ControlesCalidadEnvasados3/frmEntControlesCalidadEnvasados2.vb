Public Class frmEntControlesCalidadEnvasados2

    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ControlesCalidadEnvasados2 As DBO_ControlesCalidadEnvasados2
    Private m_VerID As Boolean = False
    Private spControlesCalidadEnvasados2 As spControlesCalidadEnvasados2

    Public Sub New(modo As String, ByRef ControlesCalidadEnvasados2 As DBO_ControlesCalidadEnvasados2, ByVal Pos As Integer, ByVal VerID As Boolean)
        MyBase.New(modo)
        InitializeComponent()
        m_DBO_ControlesCalidadEnvasados2 = ControlesCalidadEnvasados2
        m_Pos = Pos
        m_VerID = VerID
        spControlesCalidadEnvasados2 = New spControlesCalidadEnvasados2
    End Sub

    Private Sub frmEntControlesCalidadEnvasados2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetValores(m_DBO_ControlesCalidadEnvasados2.ControlCalidadEnvasados2ID, False)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        
        If m_SelectRecord Then m_DBO_ControlesCalidadEnvasados2 = spControlesCalidadEnvasados2.Select_Record(m_ID)
        If m_ID > 0 Then


           chbBotella.Checked = m_DBO_ControlesCalidadEnvasados2.Botella
           chbEtiqueta.Checked = m_DBO_ControlesCalidadEnvasados2.Etiqueta
           chbLoteadoEtiqueta.Checked = m_DBO_ControlesCalidadEnvasados2.LoteadoEtiqueta
           chbCaja.Checked = m_DBO_ControlesCalidadEnvasados2.Caja
           chbLoteadoCaja.Checked = m_DBO_ControlesCalidadEnvasados2.LoteadoCaja
           chbPalet.Checked = m_DBO_ControlesCalidadEnvasados2.Palet
           chbMuestra.Checked = m_DBO_ControlesCalidadEnvasados2.Muestra
           txtObservaciones.Text = m_DBO_ControlesCalidadEnvasados2.Observaciones
           txtNuevo.Text = m_DBO_ControlesCalidadEnvasados2.Nuevo
           txtOtroNuevo.Text = m_DBO_ControlesCalidadEnvasados2.OtroNuevo
           txtSegundoNuevo.Text = m_DBO_ControlesCalidadEnvasados2.SegundoNuevo

        End If
    End Sub

    Private Function GetValores() As Boolean
        
        m_DBO_ControlesCalidadEnvasados2.Botella = System.Convert.ToBoolean(chbBotella.Checked)
        m_DBO_ControlesCalidadEnvasados2.Etiqueta = System.Convert.ToBoolean(chbEtiqueta.Checked)
        m_DBO_ControlesCalidadEnvasados2.LoteadoEtiqueta = System.Convert.ToBoolean(chbLoteadoEtiqueta.Checked)
        m_DBO_ControlesCalidadEnvasados2.Caja = System.Convert.ToBoolean(chbCaja.Checked)
        m_DBO_ControlesCalidadEnvasados2.LoteadoCaja = System.Convert.ToBoolean(chbLoteadoCaja.Checked)
        m_DBO_ControlesCalidadEnvasados2.Palet = System.Convert.ToBoolean(chbPalet.Checked)
        m_DBO_ControlesCalidadEnvasados2.Muestra = System.Convert.ToBoolean(chbMuestra.Checked)
        m_DBO_ControlesCalidadEnvasados2.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ControlesCalidadEnvasados2.Nuevo = if(txtNuevo.Text = "", String.Empty, txtNuevo.Text)
        m_DBO_ControlesCalidadEnvasados2.OtroNuevo = if(txtOtroNuevo.Text = "", String.Empty, txtOtroNuevo.Text)
        m_DBO_ControlesCalidadEnvasados2.SegundoNuevo = if(txtSegundoNuevo.Text = "", String.Empty, txtSegundoNuevo.Text)
        
        Return True
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spControlesCalidadEnvasados2.GrabarControlesCalidadEnvasados2(m_DBO_ControlesCalidadEnvasados2) Then Me.Close()
        End If
    End Sub

End Class
