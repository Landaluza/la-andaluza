Public Class frmEntCamionesTipos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_CamionesTipos As DBO_CamionesTipos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spCamionesTipos = Nothing, Optional ByRef v_dbo As DBO_CamionesTipos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spCamionesTipos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_CamionesTipos = If(v_dbo Is Nothing, New DBO_CamionesTipos, v_dbo)
        dbo = m_DBO_CamionesTipos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spCamionesTipos, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_CamionesTipos, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_CamionesTipos = New dbo_CamionesTipos
        Else
            Me.m_DBO_CamionesTipos = CType(dbo, DBO_CamionesTipos)
        End If

        txtDescripcion.Text = m_DBO_CamionesTipos.Descripcion
        txtObservaciones.Text = m_DBO_CamionesTipos.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_CamionesTipos.Descripcion = txtDescripcion.Text


        m_DBO_CamionesTipos.Observaciones = txtObservaciones.Text


        If errores = String.empty Then
            Dbo = CType(m_DBO_CamionesTipos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

   Private Sub frmEntCamionesTipos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
