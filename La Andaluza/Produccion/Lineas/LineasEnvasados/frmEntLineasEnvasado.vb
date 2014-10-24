Public Class frmEntLineasEnvasado
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_LineasEnvasado As DBO_LineasEnvasado
    Private frmTareasEnvasado_LineasEnvasado As frmTareasEnvasado_LineasEnvasado
    Private frmEmpleados_LineasEnvasado As frmEmpleados_LineasEnvasado
    Private frmMaquinas_Lineas As frmMaquinas_Lineas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spLineasEnvasado = Nothing, Optional ByRef v_dbo As DBO_LineasEnvasado = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spLineasEnvasado, v_sp)
        m_DBO_LineasEnvasado = if(v_dbo Is Nothing, New DBO_LineasEnvasado, v_dbo)
        dbo = m_DBO_LineasEnvasado
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntLineasEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_LineasEnvasado = New dbo_LineasEnvasado
        Else
            Me.m_DBO_LineasEnvasado = dbo
            Me.frmEmpleados_LineasEnvasado = New frmEmpleados_LineasEnvasado(Me.m_DBO_LineasEnvasado.ID)
            Me.frmTareasEnvasado_LineasEnvasado = New frmTareasEnvasado_LineasEnvasado(Me.m_DBO_LineasEnvasado.ID)
            Me.frmMaquinas_Lineas = New frmMaquinas_Lineas(Me.m_DBO_LineasEnvasado.ID)
            Engine_LA.FormEnPestaña(Me.frmEmpleados_LineasEnvasado, tpEmpleados)
            Engine_LA.FormEnPestaña(Me.frmTareasEnvasado_LineasEnvasado, tpTareas)
            Engine_LA.FormEnPestaña(Me.frmMaquinas_Lineas, tpMaquinas)
        End If

        txtDescripcion.Text = m_DBO_LineasEnvasado.Descripcion
        txtVelocidadMaxima.Text = m_DBO_LineasEnvasado.VelocidadMaxima
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_LineasEnvasado.Descripcion = txtDescripcion.Text


        m_DBO_LineasEnvasado.VelocidadMaxima = System.Convert.ToInt32(txtVelocidadMaxima.Text)


        If errores = String.empty Then
            Dbo = m_DBO_LineasEnvasado
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub frmEntLineasEnvasado_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.panTop, Me.SplitContainer1.Panel1)
    End Sub
End Class
