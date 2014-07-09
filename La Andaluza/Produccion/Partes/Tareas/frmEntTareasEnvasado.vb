Public Class frmEntTareasEnvasado
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TareasEnvasado As DBO_TareasEnvasado

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTareasEnvasado = Nothing, Optional ByRef v_dbo As DBO_TareasEnvasado = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTareasEnvasado, v_sp)
        m_DBO_TareasEnvasado = if(v_dbo Is Nothing, New DBO_TareasEnvasado, v_dbo)
        dbo = m_DBO_TareasEnvasado
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTareasEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TareasEnvasado = New DBO_TareasEnvasado
        Else
            Me.m_DBO_TareasEnvasado = dbo
        End If

        txtDescripcion.Text = m_DBO_TareasEnvasado.Descripcion
        txtObservaciones.Text = m_DBO_TareasEnvasado.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TareasEnvasado.Descripcion = txtDescripcion.Text
        End If



        m_DBO_TareasEnvasado.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_TareasEnvasado
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
