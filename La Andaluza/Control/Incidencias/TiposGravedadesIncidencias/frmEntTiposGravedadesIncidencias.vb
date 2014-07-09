Public Class frmEntTiposGravedadesIncidencias
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposGravedadesIncidencias As DBO_TiposGravedadesIncidencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposGravedadesIncidencias = Nothing, Optional ByRef v_dbo As DBO_TiposGravedadesIncidencias = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposGravedadesIncidencias, v_sp)
        m_DBO_TiposGravedadesIncidencias = if(v_dbo Is Nothing, New DBO_TiposGravedadesIncidencias, v_dbo)
        dbo = m_DBO_TiposGravedadesIncidencias
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposGravedadesIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposGravedadesIncidencias = New DBO_TiposGravedadesIncidencias
        Else
            Me.m_DBO_TiposGravedadesIncidencias = dbo
        End If

        txtdescripcion.Text = m_DBO_TiposGravedadesIncidencias.descripcion
        txtValores.Text = m_DBO_TiposGravedadesIncidencias.Valores
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtdescripcion.Text = "" Then
            If errores = "" Then txtdescripcion.Focus()
            errores = errores & "El campo descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposGravedadesIncidencias.descripcion = txtdescripcion.Text
        End If



        If txtValores.Text = "" Then
            If errores = "" Then txtValores.Focus()
            errores = errores & "El campo Valores no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposGravedadesIncidencias.Valores = System.Convert.ToDouble(txtValores.Text)
        End If


        If errores = String.Empty Then
            dbo = m_DBO_TiposGravedadesIncidencias
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
