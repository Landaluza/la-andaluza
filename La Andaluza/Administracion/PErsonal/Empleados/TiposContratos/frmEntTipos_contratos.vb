Public Class frmEntTipos_contratos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Tipos_contratos As DBO_Tipos_contratos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTipos_contratos = Nothing, Optional ByRef v_dbo As DBO_Tipos_contratos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTipos_contratos, v_sp)
        m_DBO_Tipos_contratos = if(v_dbo Is Nothing, New DBO_Tipos_contratos, v_dbo)
        dbo = m_DBO_Tipos_contratos
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTipos_contratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_Tipos_contratos = New DBO_Tipos_contratos
        Else
            Me.m_DBO_Tipos_contratos = dbo
        End If

        txtnombre.Text = m_DBO_Tipos_contratos.nombre
        txtobservaciones.Text = m_DBO_Tipos_contratos.observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtnombre.Text = "" Then
            If errores = "" Then txtnombre.Focus()
            errores = errores & "El campo nombre no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_Tipos_contratos.nombre = txtnombre.Text
        End If



        m_DBO_Tipos_contratos.observaciones = txtobservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_Tipos_contratos
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
