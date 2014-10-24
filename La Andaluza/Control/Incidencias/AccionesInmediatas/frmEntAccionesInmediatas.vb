Public Class frmEntAccionesInmediatas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_AccionesInmediatas As DBO_AccionesInmediatas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAccionesInmediatas = Nothing, Optional ByRef v_dbo As DBO_AccionesInmediatas = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spAccionesInmediatas, v_sp)
        m_DBO_AccionesInmediatas = if(v_dbo Is Nothing, New DBO_AccionesInmediatas, v_dbo)
        dbo = m_DBO_AccionesInmediatas
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntAccionesInmediatas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_AccionesInmediatas = New dbo_AccionesInmediatas
        Else
            Me.m_DBO_AccionesInmediatas = dbo
        End If

        txtDescripcion.Text = m_DBO_AccionesInmediatas.Descripcion
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_AccionesInmediatas.Descripcion = txtDescripcion.Text


        If errores = String.empty Then
            Dbo = m_DBO_AccionesInmediatas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

End Class
