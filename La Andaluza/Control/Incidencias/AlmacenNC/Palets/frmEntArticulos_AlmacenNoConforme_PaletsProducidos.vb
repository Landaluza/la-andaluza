Public Class frmEntArticulos_AlmacenNoConforme_PaletsProducidos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Articulos_AlmacenNoConforme_PaletsProducidos As DBO_Articulos_AlmacenNoConforme_PaletsProducidos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spArticulos_AlmacenNoConforme_PaletsProducidos = Nothing, Optional ByRef v_dbo As DBO_Articulos_AlmacenNoConforme_PaletsProducidos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spArticulos_AlmacenNoConforme_PaletsProducidos, v_sp)
        m_DBO_Articulos_AlmacenNoConforme_PaletsProducidos = if(v_dbo Is Nothing, New DBO_Articulos_AlmacenNoConforme_PaletsProducidos, v_dbo)
        dbo = m_DBO_Articulos_AlmacenNoConforme_PaletsProducidos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spArticulos_AlmacenNoConforme_PaletsProducidos, New DBO_Articulos_AlmacenNoConforme_PaletsProducidos)
        InitializeComponent()
    End Sub

    Private Sub frmEntArticulos_AlmacenNoConforme_PaletsProducidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spPaletsProducidos
        s.cargar_PaletsProducidos(Me.cbopaletProduccido)
        If Me.mododeapertura = VISION Then
            Me.cbopaletProduccido.enabled = False
            Me.lblId_paletProduccido.enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores

        Me.m_DBO_Articulos_AlmacenNoConforme_PaletsProducidos = dbo

        cbopaletProduccido.SelectedValue = m_DBO_Articulos_AlmacenNoConforme_PaletsProducidos.Id_paletProduccido
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If cbopaletProduccido.SelectedValue is Nothing Then
            If errores = "" Then cbopaletProduccido.Focus()
            errores = errores & "No seleccionó un valor para Id_paletProduccido." & Environment.NewLine
        Else
            m_DBO_Articulos_AlmacenNoConforme_PaletsProducidos.Id_paletProduccido = System.Convert.ToInt32(cbopaletProduccido.SelectedValue)
        End If

        If errores = String.empty Then
            Dbo = m_DBO_Articulos_AlmacenNoConforme_PaletsProducidos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub



   

End Class
