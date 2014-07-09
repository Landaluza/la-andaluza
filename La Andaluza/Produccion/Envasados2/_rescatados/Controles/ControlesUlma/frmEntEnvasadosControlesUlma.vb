Public Class frmEntEnvasadosControlesUlma
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld
    Private m_DBO_EnvasadosControlesUlma As New DBO_EnvasadosControlesUlma

    Public Sub New(ByVal modo As String, ByRef EnvasadosControlesUlma As DBO_EnvasadosControlesUlma)
        MyBase.New(modo)
        InitializeComponent()
        m_DBO_EnvasadosControlesUlma = EnvasadosControlesUlma
    End Sub

    Private Sub frmEntEnvasadosControlesUlma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bdnGeneral.Visible = False
        SetValores()
    End Sub

    Overrides Sub SetValores()
        If Not IsNothing(m_DBO_EnvasadosControlesUlma) Then
            
            txtEnvasadoControlUlmaID.Text = m_DBO_EnvasadosControlesUlma.EnvasadoControlUlmaID.ToString

            If m_DBO_EnvasadosControlesUlma.EnvasadoControlID.HasValue Then
                txtEnvasadoControlID.Text = m_DBO_EnvasadosControlesUlma.EnvasadoControlID
            Else
                txtEnvasadoControlID.Text = Nothing
            End If


            If Me.ModoDeApertura <> INSERCION Then
                chbSoldaduraBolsa.Checked = m_DBO_EnvasadosControlesUlma.SoldaduraBolsa
                chbSuciedadBolsa.Checked = m_DBO_EnvasadosControlesUlma.SuciedadBolsa
                chbCentradoBolsa.Checked = m_DBO_EnvasadosControlesUlma.CentradoBolsa
                chbDiseñoBobina.Checked = m_DBO_EnvasadosControlesUlma.DiseñoBobina
            End If
            
        End If
    End Sub

    Private Sub GetValores()
        
        'm_DBO_EnvasadosControlesUlma.EnvasadoControlID = System.Convert.ToInt32(if(txtEnvasadoControlID.Text = "", Nothing, txtEnvasadoControlID.Text))
        m_DBO_EnvasadosControlesUlma.SoldaduraBolsa = System.Convert.ToBoolean(chbSoldaduraBolsa.Checked)
        m_DBO_EnvasadosControlesUlma.SuciedadBolsa = System.Convert.ToBoolean(chbSuciedadBolsa.Checked)
        m_DBO_EnvasadosControlesUlma.CentradoBolsa = System.Convert.ToBoolean(chbCentradoBolsa.Checked)
        m_DBO_EnvasadosControlesUlma.DiseñoBobina = System.Convert.ToBoolean(chbDiseñoBobina.Checked)
        
    End Sub

    Public Shadows Sub Guardar(ByRef m_DBO_EnvasadosControlesUlma As DBO_EnvasadosControlesUlma)
        Dim spEnvasadosControlesUlma As New spEnvasadosControlesUlma
        GetValores()
        spEnvasadosControlesUlma.GrabarEnvasadosControlesUlma(m_DBO_EnvasadosControlesUlma)
        Me.Close()
    End Sub

End Class
