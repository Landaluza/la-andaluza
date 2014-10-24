Public Class frmEntTareas
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_Tarea As DBO_Tareas
    Private m_VerID As Boolean = False
    Private spTareas As spTareas

    Public Sub New(ByRef Tarea As DBO_Tareas, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spTareas = New spTareas
        m_DBO_Tarea = Tarea
        m_Pos = Pos
        m_VerID = VerID
    End Sub

    Private Sub frmEntTareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetValores()
    End Sub

    Overrides Sub SetValores()
        
        txtTareaID.Text = m_DBO_Tarea.TareaID
        txtDescripcion.Text = m_DBO_Tarea.Descripcion
        txtObservaciones.Text = m_DBO_Tarea.Observaciones
        '
    End Sub

    Private Sub GetValores()
        
        m_DBO_Tarea.TareaID = System.Convert.ToInt32(txtTareaID.Text)
        m_DBO_Tarea.Descripcion = if(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_Tarea.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spTareas.GrabarTareas(m_DBO_Tarea, dtb)
        Me.Close()
    End Sub

End Class
