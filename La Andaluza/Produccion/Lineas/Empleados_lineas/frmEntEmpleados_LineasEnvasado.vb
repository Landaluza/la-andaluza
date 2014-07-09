Public Class frmEntEmpleados_LineasEnvasado
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Empleados_LineasEnvasado As DBO_Empleados_LineasEnvasado

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spEmpleados_LineasEnvasado = Nothing, Optional ByRef v_dbo As DBO_Empleados_LineasEnvasado = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spEmpleados_LineasEnvasado, v_sp)
        m_DBO_Empleados_LineasEnvasado = if(v_dbo Is Nothing, New DBO_Empleados_LineasEnvasado, v_dbo)
        dbo = m_DBO_Empleados_LineasEnvasado
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntEmpleados_LineasEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_empleados_envasados(Me.cboEmpleado)
     
        Dim s2 As New spLineasEnvasado
        s2.cargar_LineasEnvasado(Me.cboLineaEnvasado)
        If Me.mododeapertura = VISION Then
            Me.cboLineaEnvasado.enabled = False
            Me.lblId_LineaEnvasado.enabled = False
            Me.cboEmpleado.Enabled = False
            Me.lblId_Empleado.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_Empleados_LineasEnvasado = dbo
        

        cboEmpleado.SelectedValue = m_DBO_Empleados_LineasEnvasado.Id_Empleado
        cboLineaEnvasado.SelectedValue = m_DBO_Empleados_LineasEnvasado.Id_LineaEnvasado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If cboEmpleado.SelectedValue is Nothing Then
            If errores = "" Then cboEmpleado.Focus()
            errores = errores & "No seleccionó un valor para Id_Empleado." & Environment.NewLine
        Else
            m_DBO_Empleados_LineasEnvasado.Id_Empleado = System.Convert.ToInt32(cboEmpleado.SelectedValue)
        End If
        If cboLineaEnvasado.SelectedValue is Nothing Then
            If errores = "" Then cboLineaEnvasado.Focus()
            errores = errores & "No seleccionó un valor para Id_LineaEnvasado." & Environment.NewLine
        Else
            m_DBO_Empleados_LineasEnvasado.Id_LineaEnvasado = System.Convert.ToInt32(cboLineaEnvasado.SelectedValue)
        End If
        If errores = String.empty Then
            Dbo = m_DBO_Empleados_LineasEnvasado
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_Empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmEmpleados()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_Empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        frmEnt.ShowDialog()
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboEmpleado)
    End Sub

    Private Sub butVerId_LineaEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmLineasEnvasado()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_LineaEnvasado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_LineasEnvasado As New DBO_LineasEnvasado
        Dim frmEnt As New frmEntLineasEnvasado(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spLineasEnvasado, DBO_LineasEnvasado)
        frmEnt.ShowDialog()
        Dim s As New spLineasEnvasado
        s.cargar_LineasEnvasado(Me.cboLineaEnvasado)
    End Sub

End Class
