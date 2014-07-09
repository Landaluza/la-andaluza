Public Class frmEntDetallesGestionesPendientes
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_DetallesGestionesPendientes As DBO_DetallesGestionesPendientes

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDetallesGestionesPendientes = Nothing, Optional ByRef v_dbo As DBO_DetallesGestionesPendientes = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spDetallesGestionesPendientes, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_DetallesGestionesPendientes = If(v_dbo Is Nothing, New DBO_DetallesGestionesPendientes, v_dbo)
        dbo = m_DBO_DetallesGestionesPendientes
    End Sub


    Overrides Sub SetValores() Implements BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_DetallesGestionesPendientes = CType(dbo, DBO_DetallesGestionesPendientes)

        txtDescripcion.Text = m_DBO_DetallesGestionesPendientes.Descripcion
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_DetallesGestionesPendientes.Descripcion = txtDescripcion.Text


        If errores = String.empty Then
            Dbo = CType(m_DBO_DetallesGestionesPendientes, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerGestionPendienteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmGestionesPendientes()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddGestionPendienteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_GestionesPendientes As New DBO_GestionesPendientes
        Dim frmEnt As New frmEntGestionesPendientes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spGestionesPendientes, DBO_GestionesPendientes)
        frmEnt.ShowDialog()
    End Sub

    Private Sub frmEntDetallesGestionesPendientes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.tlpMiddle, Me)
    End Sub
End Class
