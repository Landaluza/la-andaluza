Public Class frmEntComunicaciones
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Comunicaciones As DBO_Comunicaciones

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spComunicaciones = Nothing, Optional ByRef v_dbo As DBO_Comunicaciones = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spComunicaciones, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Comunicaciones = IIf(v_dbo Is Nothing, New DBO_Comunicaciones, v_dbo)
        dbo = m_DBO_Comunicaciones
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spComunicaciones, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_Comunicaciones, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Comunicaciones = New dbo_Comunicaciones
        Else
            Me.m_DBO_Comunicaciones = CType(dbo, DBO_Comunicaciones)
        End If

        txtNombre.Text = m_DBO_Comunicaciones.Nombre
        txtPrimerApellido.Text = m_DBO_Comunicaciones.PrimerApellido
        txtSegundoApellido.Text = m_DBO_Comunicaciones.SegundoApellido
        txtMovilEmpresa.Text = m_DBO_Comunicaciones.MovilEmpresa
        txtEmailEmpresa.Text = m_DBO_Comunicaciones.EmailEmpresa
        txtExtension.Text = m_DBO_Comunicaciones.Extension
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtNombre.Text = "" Then
            If errores = "" Then txtNombre.Focus()
            errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Comunicaciones.Nombre = txtNombre.Text
        End If



        If txtPrimerApellido.Text = "" Then
            If errores = "" Then txtPrimerApellido.Focus()
            errores = errores & "El campo PrimerApellido no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Comunicaciones.PrimerApellido = txtPrimerApellido.Text
        End If



        If txtSegundoApellido.Text = "" Then
            If errores = "" Then txtSegundoApellido.Focus()
            errores = errores & "El campo SegundoApellido no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Comunicaciones.SegundoApellido = txtSegundoApellido.Text
        End If



        m_DBO_Comunicaciones.MovilEmpresa = txtMovilEmpresa.Text


        m_DBO_Comunicaciones.EmailEmpresa = txtEmailEmpresa.Text


        m_DBO_Comunicaciones.Extension = txtExtension.Text


        If errores = String.empty Then
            Dbo = CType(m_DBO_Comunicaciones, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub frmEntComunicaciones_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
