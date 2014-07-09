Public Class frmEntEnvasadosControlesImar
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_DBO_EnvasadosControlesImar As New DBO_EnvasadosControlesImar    

    Public Sub New(ByVal modo As String, ByRef EnvasadosControlesImar As DBO_EnvasadosControlesImar)
        MyBase.New(modo)
        InitializeComponent()
        m_DBO_EnvasadosControlesImar = EnvasadosControlesImar
    End Sub

    Private Sub frmEntEnvasadosControlesImar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bdnGeneral.Visible = False
        SetValores()
    End Sub

    Overrides Sub SetValores()
        If Not IsNothing(m_DBO_EnvasadosControlesImar) Then
            
            txtEnvasadoControlImarID.Text = m_DBO_EnvasadosControlesImar.EnvasadoControlImarID
            txtEnvasadoControlID.Text = If(m_DBO_EnvasadosControlesImar.EnvasadoControlID.HasValue, Convert.ToString(m_DBO_EnvasadosControlesImar.EnvasadoControlID), "")
            If Me.ModoDeApertura <> INSERCION Then
                chbPeso1.Checked = m_DBO_EnvasadosControlesImar.Peso1
                chbPeso2.Checked = m_DBO_EnvasadosControlesImar.Peso2
                chbPeso3.Checked = m_DBO_EnvasadosControlesImar.Peso3
                chbPeso4.Checked = m_DBO_EnvasadosControlesImar.Peso4
                chbPeso5.Checked = m_DBO_EnvasadosControlesImar.Peso5
                chbPeso6.Checked = m_DBO_EnvasadosControlesImar.Peso6
                chbSuciedadExterior.Checked = m_DBO_EnvasadosControlesImar.SuciedadExterior
                chbMaterialExtraños.Checked = m_DBO_EnvasadosControlesImar.MaterialExtraños
                chbFormaDelSobre.Checked = m_DBO_EnvasadosControlesImar.FormaDelSobre
                chbBordesAbiertos.Checked = m_DBO_EnvasadosControlesImar.BordesAbiertos
                chbBordesManchados.Checked = m_DBO_EnvasadosControlesImar.BordesManchados
                chbSeparacionMonodosis.Checked = m_DBO_EnvasadosControlesImar.SeparacionMonodosis
                chbAbreFaciles.Checked = m_DBO_EnvasadosControlesImar.AbreFaciles
            End If
            
        End If
    End Sub

    Private Sub GetValores()
        
        'm_DBO_EnvasadosControlesImar.EnvasadoControlID = System.Convert.ToInt32(if(txtEnvasadoControlID.Text = "", Nothing, txtEnvasadoControlID.Text))
        m_DBO_EnvasadosControlesImar.Peso1 = System.Convert.ToBoolean(chbPeso1.Checked)
        m_DBO_EnvasadosControlesImar.Peso2 = System.Convert.ToBoolean(chbPeso2.Checked)
        m_DBO_EnvasadosControlesImar.Peso3 = System.Convert.ToBoolean(chbPeso3.Checked)
        m_DBO_EnvasadosControlesImar.Peso4 = System.Convert.ToBoolean(chbPeso4.Checked)
        m_DBO_EnvasadosControlesImar.Peso5 = System.Convert.ToBoolean(chbPeso5.Checked)
        m_DBO_EnvasadosControlesImar.Peso6 = System.Convert.ToBoolean(chbPeso6.Checked)
        m_DBO_EnvasadosControlesImar.SuciedadExterior = System.Convert.ToBoolean(chbSuciedadExterior.Checked)
        m_DBO_EnvasadosControlesImar.MaterialExtraños = System.Convert.ToBoolean(chbMaterialExtraños.Checked)
        m_DBO_EnvasadosControlesImar.FormaDelSobre = System.Convert.ToBoolean(chbFormaDelSobre.Checked)
        m_DBO_EnvasadosControlesImar.BordesAbiertos = System.Convert.ToBoolean(chbBordesAbiertos.Checked)
        m_DBO_EnvasadosControlesImar.BordesManchados = System.Convert.ToBoolean(chbBordesManchados.Checked)
        m_DBO_EnvasadosControlesImar.SeparacionMonodosis = System.Convert.ToBoolean(chbSeparacionMonodosis.Checked)
        m_DBO_EnvasadosControlesImar.AbreFaciles = System.Convert.ToBoolean(chbAbreFaciles.Checked)
        
    End Sub

    Public Shadows Sub Guardar(ByRef m_DBO_EnvasadosControlesImar As DBO_EnvasadosControlesImar)
        Dim spEnvasadosControlesImar As New spEnvasadosControlesImar
        GetValores()
        spEnvasadosControlesImar.GrabarEnvasadosControlesImar(m_DBO_EnvasadosControlesImar)
        Me.Close()
    End Sub

End Class
