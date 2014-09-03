Public Class frmEntEnvasadosControles7
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_DBO_EnvasadosControles1 As New DBO_EnvasadosControles7
    Private spEnvasadosControles1 As spEnvasadosControles7

    Public Sub New(ByVal modo As String, ByRef EnvasadosControles1 As DBO_EnvasadosControles7)
        MyBase.New(modo)
        InitializeComponent()
        spEnvasadosControles1 = New spEnvasadosControles7
        m_DBO_EnvasadosControles1 = EnvasadosControles1
    End Sub

    Private Sub frmEntEnvasadosControles1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bdnGeneral.Visible = False
        SetValores()
    End Sub

    Overrides Sub SetValores()
        If Not IsNothing(m_DBO_EnvasadosControles1) Then

            txtEnvasadoControl1ID.Text = m_DBO_EnvasadosControles1.EnvasadoControl1ID
            txtEnvasadoControlID.Text = If(m_DBO_EnvasadosControles1.EnvasadoControlID.HasValue, Convert.ToString(m_DBO_EnvasadosControles1.EnvasadoControlID), "")
            If Me.ModoDeApertura <> INSERCION Then
                chbRoscador1.Checked = m_DBO_EnvasadosControles1.Roscador1
                chbRoscador2.Checked = m_DBO_EnvasadosControles1.Roscador2
                chbRoscador3.Checked = m_DBO_EnvasadosControles1.Roscador3
                chbRoscador4.Checked = m_DBO_EnvasadosControles1.Roscador4
                chbRoscador5.Checked = m_DBO_EnvasadosControles1.Roscador5
                chbRoscador6.Checked = m_DBO_EnvasadosControles1.Roscador6
                chbNivelDeLlenado.Checked = m_DBO_EnvasadosControles1.NivelDeLlenado
                chbCara.Checked = m_DBO_EnvasadosControles1.Cara
                chbContra.Checked = m_DBO_EnvasadosControles1.Contra
                chbCapsula.Checked = m_DBO_EnvasadosControles1.Capsula
                chbRetrocapsula.Checked = m_DBO_EnvasadosControles1.Retrocapsula
                chbCaja.Checked = m_DBO_EnvasadosControles1.Caja
            End If

        End If
    End Sub

    Private Sub GetValores()

        'm_DBO_EnvasadosControles1.EnvasadoControlID = System.Convert.ToInt32(if(txtEnvasadoControlID.Text = "", Nothing, txtEnvasadoControlID.Text))
        m_DBO_EnvasadosControles1.Roscador1 = System.Convert.ToBoolean(chbRoscador1.Checked)
        m_DBO_EnvasadosControles1.Roscador2 = System.Convert.ToBoolean(chbRoscador2.Checked)
        m_DBO_EnvasadosControles1.Roscador3 = System.Convert.ToBoolean(chbRoscador3.Checked)
        m_DBO_EnvasadosControles1.Roscador4 = System.Convert.ToBoolean(chbRoscador4.Checked)
        m_DBO_EnvasadosControles1.Roscador5 = System.Convert.ToBoolean(chbRoscador5.Checked)
        m_DBO_EnvasadosControles1.Roscador6 = System.Convert.ToBoolean(chbRoscador6.Checked)
        m_DBO_EnvasadosControles1.NivelDeLlenado = System.Convert.ToBoolean(chbNivelDeLlenado.Checked)
        m_DBO_EnvasadosControles1.Cara = System.Convert.ToBoolean(chbCara.Checked)
        m_DBO_EnvasadosControles1.Contra = System.Convert.ToBoolean(chbContra.Checked)
        m_DBO_EnvasadosControles1.Capsula = System.Convert.ToBoolean(chbCapsula.Checked)
        m_DBO_EnvasadosControles1.Retrocapsula = System.Convert.ToBoolean(chbRetrocapsula.Checked)
        m_DBO_EnvasadosControles1.Caja = System.Convert.ToBoolean(chbCaja.Checked)

    End Sub

    Public Shadows Sub Guardar(ByRef m_DBO_EnvasadosControles1 As DBO_EnvasadosControles7)
        GetValores()
        spEnvasadosControles1.GrabarEnvasadosControles1(m_DBO_EnvasadosControles1)
        Me.Close()
    End Sub


End Class
