Public Class frmEntDepositosPorTIpo
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Depositos_TiposDepositos As DBO_Depositos_TiposDepositos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDepositos_TiposDepositos = Nothing, Optional ByRef v_dbo As DBO_Depositos_TiposDepositos = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()
        If v_sp Is Nothing Then
            sp = CType(New spDepositos_TiposDepositos, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Depositos_TiposDepositos = If(v_dbo Is Nothing, New DBO_Depositos_TiposDepositos, v_dbo)
        dbo = m_DBO_Depositos_TiposDepositos
    End Sub

    Private Sub frmEntDepositos_TiposDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New ctlDepositos
        s0.devolverDepositosporCodigo(dtb, Me.cboDeposito)

        If (Me.mododeapertura = VISION) Then
            Me.cboDeposito.enabled = False
            Me.lblId_Deposito.enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_Depositos_TiposDepositos = CType(dbo, DBO_Depositos_TiposDepositos)

        cboDeposito.SelectedValue = m_DBO_Depositos_TiposDepositos.Id_Deposito
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.empty


        If cboDeposito.selectedvalue = Nothing Then
            If errores = "" Then cboDeposito.Focus()
            errores = errores & "No seleccionó un valor para Id_Deposito." & Environment.NewLine()
        Else
            m_DBO_Depositos_TiposDepositos.Id_Deposito = System.Convert.ToInt32(cboDeposito.SelectedValue)
        End If

        If (errores = String.empty) Then
            Dbo = CType(m_DBO_Depositos_TiposDepositos, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub frmEntDepositos_TiposDepositos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
