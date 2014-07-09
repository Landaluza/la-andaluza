Public Class frmEntTiposProveedoresCero
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposProveedoresCero As DBO_TiposProveedoresCero

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposProveedoresCero = Nothing, Optional ByRef v_dbo As DBO_TiposProveedoresCero = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposProveedoresCero, v_sp)
        m_DBO_TiposProveedoresCero = if(v_dbo Is Nothing, New DBO_TiposProveedoresCero, v_dbo)
        dbo = m_DBO_TiposProveedoresCero
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposProveedoresCero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposProveedoresCero = New DBO_TiposProveedoresCero
        Else
            Me.m_DBO_TiposProveedoresCero = dbo
        End If
        
        txtNombre.Text = m_DBO_TiposProveedoresCero.Nombre
        
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty
        
        m_DBO_TiposProveedoresCero.Nombre = txtNombre.Text
        
        If errores = String.Empty Then
            dbo = m_DBO_TiposProveedoresCero
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
