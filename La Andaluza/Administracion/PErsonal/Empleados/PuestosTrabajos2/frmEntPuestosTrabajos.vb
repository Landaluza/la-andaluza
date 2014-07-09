Public Class frmEntPuestosTrabajos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_PuestosTrabajos As DBO_PuestosTrabajos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPuestosTrabajos = Nothing, Optional ByRef v_dbo As DBO_PuestosTrabajos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spPuestosTrabajos, v_sp)
        m_DBO_PuestosTrabajos = if(v_dbo Is Nothing, New DBO_PuestosTrabajos, v_dbo)
        dbo = m_DBO_PuestosTrabajos
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spPuestosTrabajos, New DBO_PuestosTrabajos)
        InitializeComponent()
    End Sub

    Private Sub frmEntPuestosTrabajos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spDepartamentos
        s.cargar_Departamentos(Me.cboDepartamento)
        If Me.mododeapertura = VISION Then
            Me.cboDepartamento.enabled = False
            Me.lblId_Departamento.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_PuestosTrabajos = New dbo_PuestosTrabajos
        Else
            Me.m_DBO_PuestosTrabajos = dbo
        End If

        txtDescripcion.Text = m_DBO_PuestosTrabajos.Descripcion
        cboDepartamento.SelectedValue = m_DBO_PuestosTrabajos.Id_Departamento
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_PuestosTrabajos.Descripcion = txtDescripcion.Text
        End If

        If Me.cboDepartamento.SelectedValue Is Nothing Then
            If errores = "" Then cboDepartamento.Focus()
            errores = errores & "No seleccionó un departamento." & Environment.NewLine
        Else
            Me.m_DBO_PuestosTrabajos.Id_Departamento = Me.cboDepartamento.SelectedValue
        End If

        If errores = String.empty Then
            Dbo = m_DBO_PuestosTrabajos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_Departamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_Departamento.Click
        Dim frmEnt As New frmDepartamentos()
        frmEnt.ShowDialog()
        Dim s As New spDepartamentos
        s.cargar_Departamentos(Me.cboDepartamento)
    End Sub

    Private Sub butAddId_Departamento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_Departamento.Click
        Dim DBO_Departamentos As New DBO_Departamentos
        Dim frmEnt As New frmEntDepartamentos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spDepartamentos, DBO_Departamentos)
        frmEnt.ShowDialog()
        Dim s As New spDepartamentos
        s.cargar_Departamentos(Me.cboDepartamento)
    End Sub

End Class
