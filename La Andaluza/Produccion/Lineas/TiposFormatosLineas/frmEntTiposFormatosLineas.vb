Public Class frmEntTiposFormatosLineas
   inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposFormatosLineas As DBO_TiposFormatosLineas
    Private frmTiposFormatosLineas_TiposFormatos As frmTiposFormatosLineas_TiposFormatos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposFormatosLineas = Nothing, Optional ByRef v_dbo As DBO_TiposFormatosLineas = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposFormatosLineas, v_sp)
        m_DBO_TiposFormatosLineas = if(v_dbo Is Nothing, New DBO_TiposFormatosLineas, v_dbo)
        dbo = m_DBO_TiposFormatosLineas
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposFormatosLineas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spLineasEnvasado
        s.cargar_LineasEnvasado(Me.cboLineaEnvasado)
        If Me.ModoDeApertura = VISION Then
            Me.cboLineaEnvasado.Enabled = False
            Me.lblLineaEnvasadoID.Enabled = False

        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposFormatosLineas = New DBO_TiposFormatosLineas
            Me.SplitContainer1.Panel2Collapsed = True
            Me.Height = 117
        Else
            Me.m_DBO_TiposFormatosLineas = dbo
            Me.SplitContainer1.Panel2Collapsed = False
            Me.Height = 752
            frmTiposFormatosLineas_TiposFormatos = New frmTiposFormatosLineas_TiposFormatos(Me.m_DBO_TiposFormatosLineas.ID)
            Engine_LA.FormEnPestaña(Me.frmTiposFormatosLineas_TiposFormatos, Me.tpFormatosEnvasados)
        End If

        txtDescripcion.Text = m_DBO_TiposFormatosLineas.Descripcion
        cboLineaEnvasado.SelectedValue = m_DBO_TiposFormatosLineas.LineaEnvasadoID
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        m_DBO_TiposFormatosLineas.Descripcion = txtDescripcion.Text
        If Me.cboLineaEnvasado.SelectedValue is Nothing Then
            errores &= "No seleccionó linea de envasado"
        Else
            m_DBO_TiposFormatosLineas.LineaEnvasadoID = Me.cboLineaEnvasado.SelectedValue
        End If

        If errores = String.Empty Then
            dbo = m_DBO_TiposFormatosLineas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerLineaEnvasadoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerLineaEnvasadoID.Click
        Dim frmEnt As New frmLineasEnvasado()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddLineaEnvasadoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddLineaEnvasadoID.Click
        Dim DBO_LineasEnvasado As New DBO_LineasEnvasado
        Dim frmEnt As New frmEntLineasEnvasado(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spLineasEnvasado, DBO_LineasEnvasado)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spLineasEnvasado
        s.cargar_LineasEnvasado(Me.cboLineaEnvasado)
    End Sub

    Private Sub frmEntTiposFormatosLineas_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me.SplitContainer1.Panel1)
    End Sub

End Class
