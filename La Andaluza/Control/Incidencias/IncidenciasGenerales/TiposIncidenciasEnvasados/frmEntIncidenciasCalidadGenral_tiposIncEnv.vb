Public Class frmEntIncidenciasCalidadGenral_tiposIncEnv
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable

    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposIncidencias As DBO_TiposIncidencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposIncidencias = Nothing, Optional ByRef v_dbo As DBO_TiposIncidencias = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposIncidencias, v_sp)
        m_DBO_TiposIncidencias = if(v_dbo Is Nothing, New DBO_TiposIncidencias, v_dbo)
        dbo = m_DBO_TiposIncidencias
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposIncidencias, New DBO_TiposIncidencias)
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        If Me.ModoDeApertura = VISION Then
            Me.cboTipo.Enabled = False
            Me.lblId_tipo.Enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_TiposIncidencias = dbo

        Me.cboTipo.SelectedValue = Me.m_DBO_TiposIncidencias.ID

        Dim s As New spTiposIncidencias
        s.cargar_TiposIncidenciasSinIncidenciaCalidad(Me.cboTipo, dtb, Me.m_DBO_TiposIncidencias.ID)

    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty

        If cboTipo.SelectedValue is Nothing Then
            errores = errores & "Debe seleccioanr la clase." & Environment.NewLine
        Else
            'm_DBO_ClasesIncidencias.ID = cboClase.SelectedValue
            Dim aux As Integer = m_DBO_TiposIncidencias.Id_IncidenciaCalidadGeneral
            Dim spTipo As New spTiposIncidencias
            m_DBO_TiposIncidencias = spTipo.Select_Record(cboTipo.SelectedValue, dtb)
            m_DBO_TiposIncidencias.Id_IncidenciaCalidadGeneral = aux
            If m_DBO_TiposIncidencias.Descripcion = "" Then m_DBO_TiposIncidencias.Descripcion = " "
        End If

        If errores = String.Empty Then
            dbo = m_DBO_TiposIncidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerMaquinaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmMaquinas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butVerId_tipo_Click(sender As System.Object, e As System.EventArgs) Handles butVerId_tipo.Click
        Dim frm As New frmTiposIncidencias
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub

    Private Sub butAddId_tipo_Click(sender As System.Object, e As System.EventArgs) Handles butAddId_tipo.Click
        Dim frm As New frmEntTiposIncidencias
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub
End Class