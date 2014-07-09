Public Class frmEntPartesEnvasados_CausasPartesEnvasado
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_PartesEnvasados_CausasPartesEnvasado As DBO_PartesEnvasados_CausasPartesEnvasado
    Private ParteID As Integer

    Public WriteOnly Property ID_ParteEnvasado As Integer
        Set(value As Integer)
            Me.ParteID = value
        End Set
    End Property

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPartesEnvasados_CausasPartesEnvasado = Nothing, Optional ByRef v_dbo As DBO_PartesEnvasados_CausasPartesEnvasado = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spPartesEnvasados_CausasPartesEnvasado, v_sp)
        m_DBO_PartesEnvasados_CausasPartesEnvasado = if(v_dbo Is Nothing, New DBO_PartesEnvasados_CausasPartesEnvasado, v_dbo)
        dbo = m_DBO_PartesEnvasados_CausasPartesEnvasado
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntPartesEnvasados_CausasPartesEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s2 As New spCausasPartesEnvasado
        s2.cargar_CausasPartesEnvasado(Me.cboCausaParteEnvasado)
        If Me.ModoDeApertura = VISION Then
            Me.cboCausaParteEnvasado.Enabled = False
            Me.lblId_CausaParteEnvasado.Enabled = False
        End If

        If Config.UserType = 3 Then
            Me.butAddId_CausaParteEnvasado.Enabled = False
            Me.butVerId_CausaParteEnvasado.Enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores

        Me.m_DBO_PartesEnvasados_CausasPartesEnvasado = dbo

        If Me.ModoDeApertura = INSERCION Then
            If Me.ParteID <> Nothing Then
                m_DBO_PartesEnvasados_CausasPartesEnvasado.Id_ParteEnvasado = Me.ParteID
            End If
        End If

        cboCausaParteEnvasado.SelectedValue = m_DBO_PartesEnvasados_CausasPartesEnvasado.Id_CausaParteEnvasado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty

        If cboCausaParteEnvasado.SelectedValue is Nothing Then
            If errores = "" Then cboCausaParteEnvasado.Focus()
            errores = errores & "No seleccionó un valor para Id_CausaParteEnvasado." & Environment.NewLine
        Else
            m_DBO_PartesEnvasados_CausasPartesEnvasado.Id_CausaParteEnvasado = System.Convert.ToInt32(cboCausaParteEnvasado.SelectedValue)
        End If
        If errores = String.empty Then
            Dbo = m_DBO_PartesEnvasados_CausasPartesEnvasado
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar

        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_CausaParteEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_CausaParteEnvasado.Click
        Dim frmEnt As New frmCausasPartesEnvasado()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_CausaParteEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_CausaParteEnvasado.Click
        Dim DBO_CausasPartesEnvasado As New DBO_CausasPartesEnvasado
        Dim frmEnt As New frmEntCausasPartesEnvasado(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spCausasPartesEnvasado, DBO_CausasPartesEnvasado)
        frmEnt.ShowDialog()
        Dim s As New spCausasPartesEnvasado
        s.cargar_CausasPartesEnvasado(Me.cboCausaParteEnvasado)
    End Sub

End Class
