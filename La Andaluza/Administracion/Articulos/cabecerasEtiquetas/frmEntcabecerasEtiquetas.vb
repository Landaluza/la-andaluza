Public Class frmEntcabecerasEtiquetas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_cabecerasEtiquetas As DBO_cabecerasEtiquetas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spcabecerasEtiquetas = Nothing, Optional ByRef v_dbo As DBO_cabecerasEtiquetas = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spcabecerasEtiquetas, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_cabecerasEtiquetas = if(v_dbo Is Nothing, New DBO_cabecerasEtiquetas, v_dbo)
        dbo = m_DBO_cabecerasEtiquetas
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spcabecerasEtiquetas, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_cabecerasEtiquetas, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_cabecerasEtiquetas = New dbo_cabecerasEtiquetas
        Else
            Me.m_DBO_cabecerasEtiquetas = CType(dbo, DBO_cabecerasEtiquetas)
        End If

        txttexto.Text = m_DBO_cabecerasEtiquetas.texto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txttexto.Text = "" Then
            If errores = "" Then txttexto.Focus()
            errores = errores & "El campo texto no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_cabecerasEtiquetas.texto = txttexto.Text
        End If



        If errores = String.empty Then
            Dbo = CType(m_DBO_cabecerasEtiquetas, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub frmEntcabecerasEtiquetas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
