Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntProgramasActividadesPreventivas
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ProgramasActividadesPreventivas As DBO_ProgramasActividadesPreventivas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProgramasActividadesPreventivas = Nothing, Optional ByRef v_dbo As DBO_ProgramasActividadesPreventivas = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spProgramasActividadesPreventivas, v_sp)
        m_DBO_ProgramasActividadesPreventivas = If(v_dbo Is Nothing, New DBO_ProgramasActividadesPreventivas, v_dbo)
        dbo = m_DBO_ProgramasActividadesPreventivas
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFechaFinal.activarFoco()
        dtpFechaFinal.activarFoco()
    End Sub

    Private Sub frmEntProgramasActividadesPreventivas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_ProgramasActividadesPreventivas = New DBO_ProgramasActividadesPreventivas
        Else
            Me.m_DBO_ProgramasActividadesPreventivas = dbo
        End If

        txtDescripcion.Text = m_DBO_ProgramasActividadesPreventivas.Descripcion
        dtpFechaInicio.Text = m_DBO_ProgramasActividadesPreventivas.FechaInicio.ToString
        dtpFechaFinal.Text = m_DBO_ProgramasActividadesPreventivas.FechaFinal.ToString
        txtAutor.Text = m_DBO_ProgramasActividadesPreventivas.Autor
        txtObservaciones.Text = m_DBO_ProgramasActividadesPreventivas.Observaciones
        chbVigente.Checked = m_DBO_ProgramasActividadesPreventivas.Vigente
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_ProgramasActividadesPreventivas.Descripcion = txtDescripcion.Text
        End If



        m_DBO_ProgramasActividadesPreventivas.FechaInicio = dtpFechaInicio.Value.Date


        m_DBO_ProgramasActividadesPreventivas.FechaFinal = dtpFechaFinal.Value.Date


        m_DBO_ProgramasActividadesPreventivas.Autor = txtAutor.Text


        m_DBO_ProgramasActividadesPreventivas.Observaciones = txtObservaciones.Text


        m_DBO_ProgramasActividadesPreventivas.Vigente = chbVigente.Checked

        If errores = String.Empty Then
            dbo = m_DBO_ProgramasActividadesPreventivas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

End Class
