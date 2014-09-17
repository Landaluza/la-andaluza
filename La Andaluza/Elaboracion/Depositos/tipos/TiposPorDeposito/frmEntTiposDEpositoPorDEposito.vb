Public Class frmEntTiposDEpositoPorDEposito
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Depositos_TiposDepositos As DBO_Depositos_TiposDepositos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDepositos_TiposDepositos = Nothing, Optional ByRef v_dbo As DBO_Depositos_TiposDepositos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spDepositos_TiposDepositos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Depositos_TiposDepositos = If(v_dbo Is Nothing, New DBO_Depositos_TiposDepositos, v_dbo)
        dbo = m_DBO_Depositos_TiposDepositos
    End Sub

    Private Sub frmEntDepositos_TiposDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s1 As New spTiposDepositos
        s1.cargar_TiposDepositos(Me.cboTipoDeposito)
        If (Me.mododeapertura = VISION) Then

            Me.cboTipoDeposito.enabled = False
            Me.lblId_TipoDeposito.enabled = False

        End If
        If Config.userType <> 4 And Config.userType <> 9 Then
            butAddId_TipoDeposito.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_Depositos_TiposDepositos = CType(dbo, DBO_Depositos_TiposDepositos)

        cboTipoDeposito.SelectedValue = m_DBO_Depositos_TiposDepositos.Id_TipoDeposito
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.empty


        If cboTipoDeposito.selectedvalue = Nothing Then
            If errores = "" Then cboTipoDeposito.Focus()
            errores = errores & "No seleccionó un valor para Id_TipoDeposito." & Environment.NewLine()
        Else
            m_DBO_Depositos_TiposDepositos.Id_TipoDeposito = System.Convert.ToInt32(cboTipoDeposito.SelectedValue)
        End If
        If (errores = String.empty) Then
            Dbo = CType(m_DBO_Depositos_TiposDepositos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub


    Private Sub butAddId_TipoDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoDeposito.Click
        Dim DBO_TiposDepositos As New DBO_TiposDepositos
        Dim frmEnt As New frmEntTiposDepositos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposDepositos, DBO_TiposDepositos)
        frmEnt.ShowDialog()
        Dim s As New spTiposDepositos
        s.cargar_TiposDepositos(Me.cboTipoDeposito)
    End Sub

    Private Sub frmEntDepositos_TiposDepositos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
