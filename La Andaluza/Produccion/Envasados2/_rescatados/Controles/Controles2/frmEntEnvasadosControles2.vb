Public Class frmEntEnvasadosControles2
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_DBO_EnvasadosControles2 As New DBO_EnvasadosControles2
    Private spEnvasadosControles2 As spEnvasadosControles2

    Public Sub New(ByVal modo As String, ByRef EnvasadosControles2 As DBO_EnvasadosControles2)
        MyBase.New(modo)
        InitializeComponent()
        spEnvasadosControles2 = New spEnvasadosControles2
        m_DBO_EnvasadosControles2 = EnvasadosControles2
    End Sub

   Private Sub frmEntEnvasadosControles2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bdnGeneral.Visible = False
        SetValores()
    End Sub

    Overrides Sub SetValores()
        If Not IsNothing(m_DBO_EnvasadosControles2) Then
            
            txtEnvasadoControl2ID.Text = m_DBO_EnvasadosControles2.EnvasadoControl2ID
            txtEnvasadoControlID.Text = If(m_DBO_EnvasadosControles2.EnvasadoControlID.HasValue, Convert.ToString(m_DBO_EnvasadosControles2.EnvasadoControlID), "")
            If Me.ModoDeApertura <> INSERCION Then
                chbBoquilla1.Checked = m_DBO_EnvasadosControles2.Boquilla1
                chbBoquilla2.Checked = m_DBO_EnvasadosControles2.Boquilla2
                chbBoquilla3.Checked = m_DBO_EnvasadosControles2.Boquilla3
                chbBoquilla4.Checked = m_DBO_EnvasadosControles2.Boquilla4
                chbBoquilla5.Checked = m_DBO_EnvasadosControles2.Boquilla5
                chbBoquilla6.Checked = m_DBO_EnvasadosControles2.Boquilla6
                chbEtiquetado.Checked = m_DBO_EnvasadosControles2.Etiquetado
                chbTaponado.Checked = m_DBO_EnvasadosControles2.Taponado
                chbBote.Checked = m_DBO_EnvasadosControles2.Bote
                chbEtiqueta.Checked = m_DBO_EnvasadosControles2.Etiqueta
                chbTapon.Checked = m_DBO_EnvasadosControles2.Tapon
                chbRetractil.Checked = m_DBO_EnvasadosControles2.Retractil
                chbCaja.Checked = m_DBO_EnvasadosControles2.Caja
            End If
            
        End If
    End Sub

   Private Sub GetValores()

        'm_DBO_EnvasadosControles2.EnvasadoControlID = System.Convert.ToInt32(if(txtEnvasadoControlID.Text = "", Nothing, txtEnvasadoControlID.Text))
       m_DBO_EnvasadosControles2.Boquilla1 = System.Convert.ToBoolean(chbBoquilla1.Checked)
       m_DBO_EnvasadosControles2.Boquilla2 = System.Convert.ToBoolean(chbBoquilla2.Checked)
       m_DBO_EnvasadosControles2.Boquilla3 = System.Convert.ToBoolean(chbBoquilla3.Checked)
       m_DBO_EnvasadosControles2.Boquilla4 = System.Convert.ToBoolean(chbBoquilla4.Checked)
       m_DBO_EnvasadosControles2.Boquilla5 = System.Convert.ToBoolean(chbBoquilla5.Checked)
       m_DBO_EnvasadosControles2.Boquilla6 = System.Convert.ToBoolean(chbBoquilla6.Checked)
       m_DBO_EnvasadosControles2.Etiquetado = System.Convert.ToBoolean(chbEtiquetado.Checked)
       m_DBO_EnvasadosControles2.Taponado = System.Convert.ToBoolean(chbTaponado.Checked)
       m_DBO_EnvasadosControles2.Bote = System.Convert.ToBoolean(chbBote.Checked)
       m_DBO_EnvasadosControles2.Etiqueta = System.Convert.ToBoolean(chbEtiqueta.Checked)
       m_DBO_EnvasadosControles2.Tapon = System.Convert.ToBoolean(chbTapon.Checked)
       m_DBO_EnvasadosControles2.Retractil = System.Convert.ToBoolean(chbRetractil.Checked)
       m_DBO_EnvasadosControles2.Caja = System.Convert.ToBoolean(chbCaja.Checked)

   End Sub

    Public Shadows Sub Guardar(ByRef m_DBO_EnvasadosControles2 As DBO_EnvasadosControles2)
        GetValores()
        spEnvasadosControles2.GrabarEnvasadosControles2(m_DBO_EnvasadosControles2)
        Me.Close()
    End Sub

End Class
