Public Class frmEntPartesEnvasadosCausasIns
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_PartesEnvasados_CausasPartesEnvasado As DBO_PartesEnvasados_CausasPartesEnvasado

    Public ReadOnly Property DBO As DBO_PartesEnvasados_CausasPartesEnvasado
        Get
            Return Me.m_DBO_PartesEnvasados_CausasPartesEnvasado
        End Get
    End Property

    Public WriteOnly Property MaestroID As Integer
        Set(value As Integer)
            Me.m_DBO_PartesEnvasados_CausasPartesEnvasado.Id_ParteEnvasado = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()

        Me.m_DBO_PartesEnvasados_CausasPartesEnvasado = New DBO_PartesEnvasados_CausasPartesEnvasado

        If Config.UserType = 3 Then
            Me.butAddId_CausaParteEnvasado.Enabled = False
            Me.butVerId_CausaParteEnvasado.Enabled = False
        End If
    End Sub

    Public Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Dim s2 As New spCausasPartesEnvasado
        s2.cargar_CausasPartesEnvasado(Me.cboCausaParteEnvasado)
    End Sub

    Protected Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty

        If cboCausaParteEnvasado.SelectedValue is Nothing Then
            If errores = "" Then cboCausaParteEnvasado.Focus()
            errores = errores & "No seleccionó un valor para Id_CausaParteEnvasado." & Environment.NewLine
        Else
            m_DBO_PartesEnvasados_CausasPartesEnvasado.Id_CausaParteEnvasado = System.Convert.ToInt32(cboCausaParteEnvasado.SelectedValue)
        End If

        If errores = String.Empty Then            
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        If Me.GetValores Then
            RaiseEvent afterSave(Me, Nothing)
            Me.Close()
        End If
    End Sub

    Private Sub tsGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsGuardar.Click
        Me.Guardar()
    End Sub

    Private Sub tsSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsSalir.Click
        Me.m_DBO_PartesEnvasados_CausasPartesEnvasado = Nothing
        Me.Close()
    End Sub

    Private Sub frmEntPartesEnvasadosCausasIns_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SetValores()
    End Sub

    Private Sub butAddId_CausaParteEnvasado_Click(sender As System.Object, e As System.EventArgs) Handles butAddId_CausaParteEnvasado.Click
        Dim frm As New frmEntCausasPartesEnvasado(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spCausasPartesEnvasado, New DBO_CausasPartesEnvasado)
        frm.ShowDialog()
        SetValores()
    End Sub

    Private Sub butVerId_CausaParteEnvasado_Click(sender As System.Object, e As System.EventArgs) Handles butVerId_CausaParteEnvasado.Click
        Dim frm As New frmCausasPartesEnvasado
        frm.ShowDialog()
        SetValores()
    End Sub

    Private Sub frmEntPartesEnvasadosCausasIns_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.PanContenido, Me.SplitContainer1.Panel1)
    End Sub

 
End Class