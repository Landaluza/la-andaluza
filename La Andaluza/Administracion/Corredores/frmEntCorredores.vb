Public Class frmEntCorredores
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Corredores As DBO_Corredores

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spCorredores = Nothing, Optional ByRef v_dbo As DBO_Corredores = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spCorredores, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Corredores = If(v_dbo Is Nothing, New DBO_Corredores, v_dbo)
        dbo = m_DBO_Corredores
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spCorredores, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_Corredores, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Corredores = New dbo_Corredores
        Else
            Me.m_DBO_Corredores = CType(dbo, DBO_Corredores)
        End If

        txtNombre.Text = m_DBO_Corredores.Nombre
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtNombre.Text = "" Then
            If errores = "" Then txtNombre.Focus()
            errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Corredores.Nombre = txtNombre.Text
        End If



        If errores = String.empty Then
            Dbo = CType(m_DBO_Corredores, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub frmEntCorredores_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
