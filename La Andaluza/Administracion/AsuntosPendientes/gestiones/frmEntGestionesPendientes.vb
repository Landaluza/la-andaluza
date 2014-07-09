Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntGestionesPendientes
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_GestionesPendientes As DBO_GestionesPendientes

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spGestionesPendientes = Nothing, Optional ByRef v_dbo As DBO_GestionesPendientes = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spGestionesPendientes, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_GestionesPendientes = If(v_dbo Is Nothing, New DBO_GestionesPendientes, v_dbo)
        dbo = m_DBO_GestionesPendientes
        dtpFecha.activarFoco()
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_GestionesPendientes = CType(dbo, DBO_GestionesPendientes)

        txtDescripcion.Text = m_DBO_GestionesPendientes.Descripcion
        dtpFecha.Value = m_DBO_GestionesPendientes.Fecha
        txtPersonaContactada.Text = m_DBO_GestionesPendientes.PersonaContactada
        txtMedioContacto.Text = m_DBO_GestionesPendientes.MedioContacto
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        m_DBO_GestionesPendientes.Descripcion = txtDescripcion.Text
        m_DBO_GestionesPendientes.Fecha = dtpFecha.Value
        m_DBO_GestionesPendientes.PersonaContactada = txtPersonaContactada.Text
        m_DBO_GestionesPendientes.MedioContacto = txtMedioContacto.Text

        If errores = String.Empty Then
            dbo = CType(m_DBO_GestionesPendientes, BasesParaCompatibilidad.DataBussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub frmEntGestionesPendientes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.tlpMiddle, Me)
    End Sub
End Class
