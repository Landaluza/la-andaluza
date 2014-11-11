Public Class frmEntTiposMateriales
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposMateriales As DBO_TiposMateriales
    Private frmTiposMateriales_Provedores As frmTiposMateriales_Provedores

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposMateriales = Nothing, Optional ByRef v_dbo As DBO_TiposMateriales = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposMateriales, v_sp)
        m_DBO_TiposMateriales = if(v_dbo Is Nothing, New DBO_TiposMateriales, v_dbo)
        dbo = m_DBO_TiposMateriales
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores

        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposMateriales = New DBO_TiposMateriales
            Me.SplitContainer1.Panel2Collapsed = True
        Else
            Me.m_DBO_TiposMateriales = dbo
            Me.SplitContainer1.Panel2Collapsed = False
            frmTiposMateriales_Provedores = New frmTiposMateriales_Provedores(Me.m_DBO_TiposMateriales.ID)
            Engine_LA.FormEnPestaña(frmTiposMateriales_Provedores, tpProveedores)
        End If

        Me.CenterToParent()

        txtDescripcion.Text = m_DBO_TiposMateriales.Descripcion
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty

        m_DBO_TiposMateriales.Descripcion = txtDescripcion.Text

        If errores = String.Empty Then
            dbo = m_DBO_TiposMateriales
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    'Private Sub frmEntTiposMateriales_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
    '    BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.Panel1, Me.SplitContainer1.Panel1)
    'End Sub

End Class
