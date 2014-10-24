Public Class frmEntempleados_envasados
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_empleados_envasados As DBO_empleados_envasados

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spempleados_envasados = Nothing, Optional ByRef v_dbo As DBO_empleados_envasados = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spempleados_envasados, v_sp)
        m_DBO_empleados_envasados = if(v_dbo Is Nothing, New DBO_empleados_envasados, v_dbo)
        dbo = m_DBO_empleados_envasados
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spempleados_envasados, New DBO_empleados_envasados)
        InitializeComponent()
    End Sub

    Private Sub frmEntempleados_envasados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_empleados_envasados = New dbo_empleados_envasados
        Else
            Me.m_DBO_empleados_envasados = dbo
        End If

        cboenvasado.SelectedValue = m_DBO_empleados_envasados.Id_envasado
        cboempleado.SelectedValue = m_DBO_empleados_envasados.Id_empleado
        cbolinea.SelectedValue = m_DBO_empleados_envasados.Id_linea
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If cboenvasado.SelectedValue is Nothing Then
            If errores = "" Then cboenvasado.Focus()
            errores = errores & "No seleccionó un valor para Id_envasado." & Environment.NewLine
        Else
            m_DBO_empleados_envasados.Id_envasado = System.Convert.ToInt32(cboenvasado.SelectedValue)
        End If
        If cboempleado.SelectedValue is Nothing Then
            If errores = "" Then cboempleado.Focus()
            errores = errores & "No seleccionó un valor para Id_empleado." & Environment.NewLine
        Else
            m_DBO_empleados_envasados.Id_empleado = System.Convert.ToInt32(cboempleado.SelectedValue)
        End If
        If cbolinea.SelectedValue is Nothing Then
            If errores = "" Then cbolinea.Focus()
            errores = errores & "No seleccionó un valor para Id_linea." & Environment.NewLine
        Else
            m_DBO_empleados_envasados.Id_linea = System.Convert.ToInt32(cbolinea.SelectedValue)
        End If
        If errores = String.empty Then
            Dbo = m_DBO_empleados_envasados
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
