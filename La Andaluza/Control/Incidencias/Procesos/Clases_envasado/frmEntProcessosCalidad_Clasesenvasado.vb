Public Class frmEntProcessosCalidad_Clasesenvasado
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
        Dim s As New spClasesIncidencias
        s.cargar_ClasesIncidencias(Me.cboClase, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboClase.Enabled = False
            Me.lblId_clase.Enabled = False

        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_ClasesIncidencias = dbo

        Me.cboClase.SelectedValue = m_DBO_ClasesIncidencias.ID
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If cboClase.SelectedValue is Nothing Then
            errores = errores & "Debe seleccioanr la clase." & Environment.NewLine
        Else
            'm_DBO_ClasesIncidencias.ID = cboClase.SelectedValue
            Dim aux As Integer = m_DBO_ClasesIncidencias.id_procesoCalidad
            Dim spClase As New spClasesIncidencias
            m_DBO_ClasesIncidencias = spClase.Select_Record(cboClase.SelectedValue, dtb)
            m_DBO_ClasesIncidencias.id_procesoCalidad = aux
        End If

        

        If errores = String.empty Then
            Dbo = m_DBO_ClasesIncidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerid_procesoCalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmProcesosCalidad()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub
 

    Private Sub butAddId_clase_Click(sender As System.Object, e As System.EventArgs) Handles butAddId_clase.Click
        Dim frm As New frmEntClasesIncidencias
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub

    Private Sub butVerId_clase_Click(sender As System.Object, e As System.EventArgs) Handles butVerId_clase.Click
        Dim frm As New frmClasesIncidencias
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub
End Class