Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntCostesAnuales_Empleados
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_CostesAnuales_Empleados As DBO_CostesAnuales_Empleados

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spCostesAnuales_Empleados = Nothing, Optional ByRef v_dbo As DBO_CostesAnuales_Empleados = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spCostesAnuales_Empleados, v_sp)
        m_DBO_CostesAnuales_Empleados = If(v_dbo Is Nothing, New DBO_CostesAnuales_Empleados, v_dbo)
        dbo = m_DBO_CostesAnuales_Empleados
        Me.dtpAno.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spCostesAnuales_Empleados, New DBO_CostesAnuales_Empleados)
        InitializeComponent()
        Me.dtpAno.activarFoco()
    End Sub



    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores

        Me.m_DBO_CostesAnuales_Empleados = dbo

        dtpAno.Value = If(m_DBO_CostesAnuales_Empleados.Fecha_Inicio = Nothing, Now.Date, m_DBO_CostesAnuales_Empleados.Fecha_Inicio) 'New Date(if(m_DBO_CostesAnuales_Empleados.Fecha_Inicio = String.Empty, Now.Year, m_DBO_CostesAnuales_Empleados.Fecha_Inicio), 1, 1)
        txtNormal.Text = m_DBO_CostesAnuales_Empleados.Normal
        txtExtra.Text = m_DBO_CostesAnuales_Empleados.Extra
        txtFestivo.Text = m_DBO_CostesAnuales_Empleados.Festivo
        txtTurno.Text = m_DBO_CostesAnuales_Empleados.Turno
        txtNocturnidad.Text = m_DBO_CostesAnuales_Empleados.Nocturnidad
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If dtpAno.Text = "" Then
            If errores = "" Then dtpAno.Focus()
            errores = errores & "El campo Ano no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_CostesAnuales_Empleados.Fecha_Inicio = dtpAno.Value
        End If

        m_DBO_CostesAnuales_Empleados.Normal = System.Convert.ToDouble(txtNormal.Text)


        m_DBO_CostesAnuales_Empleados.Extra = System.Convert.ToDouble(txtExtra.Text)


        m_DBO_CostesAnuales_Empleados.Festivo = System.Convert.ToDouble(txtFestivo.Text)


        m_DBO_CostesAnuales_Empleados.Turno = System.Convert.ToDouble(txtTurno.Text)


        m_DBO_CostesAnuales_Empleados.Nocturnidad = System.Convert.ToDouble(txtNocturnidad.Text)


        If errores = String.Empty Then
            dbo = m_DBO_CostesAnuales_Empleados
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub


End Class
