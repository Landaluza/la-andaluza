Public Class frmEntTiposLotes
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event afterSave1(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposLotes As DBO_TiposLotes

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposLotes = Nothing, Optional ByRef v_dbo As DBO_TiposLotes = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposLotes, v_sp)
        m_DBO_TiposLotes = if(v_dbo Is Nothing, New DBO_TiposLotes, v_dbo)
        dbo = m_DBO_TiposLotes
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposLotes, New DBO_TiposLotes)
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposLotes = New DBO_TiposLotes
        Else
            Me.m_DBO_TiposLotes = dbo
        End If

        txtDescripcion.Text = m_DBO_TiposLotes.Descripcion
        txtAbreviatura.Text = m_DBO_TiposLotes.Abreviatura
        txtOrden.Text = m_DBO_TiposLotes.Orden
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposLotes.Descripcion = txtDescripcion.Text
        End If



        If txtAbreviatura.Text = "" Then
            If errores = "" Then txtAbreviatura.Focus()
            errores = errores & "El campo Abreviatura no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposLotes.Abreviatura = txtAbreviatura.Text
        End If



        m_DBO_TiposLotes.Orden = System.Convert.ToInt32(txtOrden.Text)


        If errores = String.Empty Then
            dbo = m_DBO_TiposLotes
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub frmEntTiposLotes_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me)
    End Sub
End Class
