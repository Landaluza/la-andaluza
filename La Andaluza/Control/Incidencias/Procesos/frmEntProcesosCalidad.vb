Public Class frmEntProcesosCalidad
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ProcesosCalidad As DBO_ProcesosCalidad
    Private frmProcessosCalidad_Clasesenvasado As frmProcessosCalidad_Clasesenvasado

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProcesosCalidad = Nothing, Optional ByRef v_dbo As DBO_ProcesosCalidad = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spProcesosCalidad, v_sp)
        m_DBO_ProcesosCalidad = if(v_dbo Is Nothing, New DBO_ProcesosCalidad, v_dbo)
        dbo = m_DBO_ProcesosCalidad
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntProcesosCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboempleado, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboempleado.enabled = False
            Me.lblId_empleado.enabled = False

        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_ProcesosCalidad = New dbo_ProcesosCalidad
        Else
            Me.m_DBO_ProcesosCalidad = dbo

            Me.frmProcessosCalidad_Clasesenvasado = New frmProcessosCalidad_Clasesenvasado(Me.m_DBO_ProcesosCalidad.ID)
            Engine_LA.FormEnPestaña(Me.frmProcessosCalidad_Clasesenvasado, Me.tpClasesEnvasado)
        End If

        txtDescripcion.Text = m_DBO_ProcesosCalidad.Descripcion
        cboempleado.SelectedValue = m_DBO_ProcesosCalidad.Id_empleado
        txtDescripcionIngles.Text = m_DBO_ProcesosCalidad.DescripcionIngles
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_ProcesosCalidad.Descripcion = txtDescripcion.Text


        If cboempleado.SelectedValue is Nothing Then
            If errores = "" Then cboempleado.Focus()
            errores = errores & "No seleccionó un valor para Id_empleado." & Environment.NewLine
        Else
            m_DBO_ProcesosCalidad.Id_empleado = System.Convert.ToInt32(cboempleado.SelectedValue)
        End If
        m_DBO_ProcesosCalidad.DescripcionIngles = txtDescripcionIngles.Text


        If errores = String.empty Then
            Dbo = m_DBO_ProcesosCalidad
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_empleado.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboempleado, dtb)
    End Sub

   
End Class
