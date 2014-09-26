Public Class frmEntClasesIncidencias
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ClasesIncidencias As DBO_ClasesIncidencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spClasesIncidencias = Nothing, Optional ByRef v_dbo As DBO_ClasesIncidencias = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spClasesIncidencias, v_sp)
        m_DBO_ClasesIncidencias = if(v_dbo Is Nothing, New DBO_ClasesIncidencias, v_dbo)
        dbo = m_DBO_ClasesIncidencias
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spClasesIncidencias, New DBO_ClasesIncidencias)
        InitializeComponent()
    End Sub

    Private Sub frmEntClasesIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spProcesosCalidad
        s.cargar_ProcesosCalidad(Me.cboid_procesoCalidad)
        If Me.mododeapertura = VISION Then
            Me.cboid_procesoCalidad.enabled = False
            Me.lblid_procesoCalidad.enabled = False
        End If

        Dim s2 As New spCategoriaIncidencias
        s2.cargar_CategoriaIncidencias(Me.cboCategoria)
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_ClasesIncidencias = New dbo_ClasesIncidencias
        Else
            Me.m_DBO_ClasesIncidencias = dbo
        End If

        txtDescripcion.Text = m_DBO_ClasesIncidencias.Descripcion
        cboid_procesoCalidad.SelectedValue = m_DBO_ClasesIncidencias.id_procesoCalidad
        cboCategoria.SelectedValue = m_DBO_ClasesIncidencias.id_categoriaIncidencia
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_ClasesIncidencias.Descripcion = txtDescripcion.Text
        End If

        If cboCategoria.SelectedValue is Nothing Then
            If errores = "" Then cboCategoria.Focus()
            errores = errores & "No seleccionó una categoria." & Environment.NewLine
        Else
            m_DBO_ClasesIncidencias.id_categoriaIncidencia = Me.cboCategoria.SelectedValue
        End If

        m_DBO_ClasesIncidencias.id_procesoCalidad = Me.cboid_procesoCalidad.SelectedValue

        If errores = String.empty Then
            Dbo = m_DBO_ClasesIncidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerid_procesoCalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmProcesosCalidad()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_procesoCalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_ProcesosCalidad As New DBO_ProcesosCalidad
        Dim frmEnt As New frmEntProcesosCalidad(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProcesosCalidad, DBO_ProcesosCalidad)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProcesosCalidad
        s.cargar_ProcesosCalidad(Me.cboid_procesoCalidad)
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Me.cboid_procesoCalidad.SelectedValue = 0
        Me.cboid_procesoCalidad.Text = ""
    End Sub
End Class
