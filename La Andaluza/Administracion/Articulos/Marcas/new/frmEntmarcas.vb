Public Class frmEntmarcas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_marcas As DBO_marcas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spmarcas = Nothing, Optional ByRef v_dbo As DBO_marcas = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spmarcas, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_marcas = If(v_dbo Is Nothing, New DBO_marcas, v_dbo)
        dbo = m_DBO_marcas
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spmarcas, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_marcas, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_marcas = New dbo_marcas
        Else
            Me.m_DBO_marcas = CType(dbo, DBO_marcas)
        End If

        txtNombre.Text = m_DBO_marcas.Nombre
        txtCodigoQS.Text = m_DBO_marcas.CodigoQS
        chbVigente.Checked = m_DBO_marcas.Vigente
        txtObservaciones.Text = m_DBO_marcas.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_marcas.Nombre = txtNombre.Text


        m_DBO_marcas.CodigoQS = txtCodigoQS.Text


        m_DBO_marcas.Vigente = chbVigente.Checked

        m_DBO_marcas.Observaciones = txtObservaciones.Text


        If errores = String.empty Then
            Dbo = CType(m_DBO_marcas, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub frmEntmarcas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
