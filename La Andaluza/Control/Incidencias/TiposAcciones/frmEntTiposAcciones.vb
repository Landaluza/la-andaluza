Public Class frmEntTiposAcciones
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposAcciones As DBO_TiposAcciones

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposAcciones = Nothing, Optional ByRef v_dbo As DBO_TiposAcciones = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposAcciones, v_sp)
        m_DBO_TiposAcciones = if(v_dbo Is Nothing, New DBO_TiposAcciones, v_dbo)
        dbo = m_DBO_TiposAcciones
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposAcciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposAcciones = New DBO_TiposAcciones
        Else
            Me.m_DBO_TiposAcciones = dbo
        End If

        txtDescripcion.Text = m_DBO_TiposAcciones.Descripcion
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposAcciones.Descripcion = txtDescripcion.Text
        End If



        If errores = String.Empty Then
            dbo = m_DBO_TiposAcciones
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
