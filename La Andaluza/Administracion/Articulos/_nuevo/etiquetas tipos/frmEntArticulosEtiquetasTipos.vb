Public Class frmEntArticulosEtiquetasTipos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ArticulosEtiquetasTipos As DBO_ArticulosEtiquetasTipos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spArticulosEtiquetasTipos = Nothing, Optional ByRef v_dbo As DBO_ArticulosEtiquetasTipos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spArticulosEtiquetasTipos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_ArticulosEtiquetasTipos = If(v_dbo Is Nothing, New DBO_ArticulosEtiquetasTipos, v_dbo)
        dbo = m_DBO_ArticulosEtiquetasTipos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spArticulosEtiquetasTipos, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_ArticulosEtiquetasTipos, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub


    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_ArticulosEtiquetasTipos = New DBO_ArticulosEtiquetasTipos
        Else
            Me.m_DBO_ArticulosEtiquetasTipos = CType(dbo, DBO_ArticulosEtiquetasTipos)
        End If

        txtDescripcion.Text = m_DBO_ArticulosEtiquetasTipos.Descripcion
        txtUtilizacion.Text = m_DBO_ArticulosEtiquetasTipos.Utilizacion
        txtObservaciones.Text = m_DBO_ArticulosEtiquetasTipos.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty

        m_DBO_ArticulosEtiquetasTipos.Descripcion = txtDescripcion.Text
        m_DBO_ArticulosEtiquetasTipos.Utilizacion = txtUtilizacion.Text
        m_DBO_ArticulosEtiquetasTipos.Observaciones = txtObservaciones.Text

        If errores = String.Empty Then
            dbo = CType(m_DBO_ArticulosEtiquetasTipos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub frmEntArticulosEtiquetasTipos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.tlpMiddle, Me)
    End Sub
End Class
