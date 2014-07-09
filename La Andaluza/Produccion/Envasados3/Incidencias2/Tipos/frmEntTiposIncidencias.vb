Public Class frmEntTiposIncidencias
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
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
        Dim s As New spMaquinas
        s.cargar_Maquinas(Me.cboMaquina)

        Dim s3 As New spCategoriaIncidencias
        If Me.ModoDeApertura = INSERCION Then
            s3.cargar_CategoriaIncidencias(Me.cboCategoriaIncidencia)
        Else
            s3.cargar_CategoriaIncidencias_con_retroCompatibilidad(Me.cboCategoriaIncidencia)
        End If


        Dim s4 As New spIncidenciasCalidadGeneral
        s4.cargar_IncidenciasCalidadGeneral(Me.cboIncidenciaCalidadGeneral)

        If Me.ModoDeApertura = VISION Then
            Me.cboIncidenciaCalidadGeneral.Enabled = False
            Me.lblId_IncidenciaCalidadGeneral.Enabled = False

            Me.cboCategoriaIncidencia.Enabled = False
            Me.lblCategoriaIncidenciaID.Enabled = False

            Me.cboClaseIncidencia.Enabled = False
            Me.lblClaseIncidenciaID.Enabled = False

            Me.cboMaquina.Enabled = False
            Me.lblMaquinaID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_TiposIncidencias = New DBO_TiposIncidencias
        Else
            Me.m_DBO_TiposIncidencias = dbo
        End If

        txtDescripcion.Text = m_DBO_TiposIncidencias.Descripcion
        cboMaquina.SelectedValue = m_DBO_TiposIncidencias.MaquinaID
        cboClaseIncidencia.SelectedValue = m_DBO_TiposIncidencias.ClaseIncidenciaID
        cboCategoriaIncidencia.SelectedValue = m_DBO_TiposIncidencias.CategoriaIncidenciaID
        txtDuracion.Text = m_DBO_TiposIncidencias.Duracion
        cboIncidenciaCalidadGeneral.SelectedValue = m_DBO_TiposIncidencias.Id_IncidenciaCalidadGeneral
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_TiposIncidencias.Descripcion = txtDescripcion.Text
        End If

        Me.m_DBO_TiposIncidencias.Id_IncidenciaCalidadGeneral = Me.cboIncidenciaCalidadGeneral.SelectedValue
        Me.m_DBO_TiposIncidencias.MaquinaID = Me.cboMaquina.SelectedValue

        If Me.cboClaseIncidencia.SelectedValue is Nothing Then
            errores = errores & "No seleccionó un valor para el tipo de incidencia." & Environment.NewLine
        Else
            Me.m_DBO_TiposIncidencias.ClaseIncidenciaID = Me.cboClaseIncidencia.SelectedValue
        End If

        If Me.cboCategoriaIncidencia.SelectedValue is Nothing Then
            errores = errores & "No seleccionó un valor para la categoría." & Environment.NewLine
        Else
            Me.m_DBO_TiposIncidencias.CategoriaIncidenciaID = Me.cboCategoriaIncidencia.SelectedValue
        End If

        m_DBO_TiposIncidencias.Duracion = System.Convert.ToInt32(txtDuracion.Text)


        If errores = String.Empty Then
            dbo = m_DBO_TiposIncidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerMaquinaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmMaquinas()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddMaquinaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_Maquinas As New DBO_Maquinas
        Dim frmEnt As New frmEntMaquinas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spMaquinas, DBO_Maquinas)
        frmEnt.ShowDialog()
        Dim s As New spMaquinas
        s.cargar_Maquinas(Me.cboMaquina)
    End Sub

    Private Sub butVerClaseIncidenciaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerClaseIncidenciaID.Click
        Dim frmEnt As New frmClasesIncidencias()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddClaseIncidenciaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddClaseIncidenciaID.Click
        Dim DBO_ClasesIncidencias As New DBO_ClasesIncidencias
        Dim frmEnt As New frmEntClasesIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spClasesIncidencias, DBO_ClasesIncidencias)
        frmEnt.ShowDialog()
        Dim s As New spClasesIncidencias
        s.cargar_ClasesIncidencias(Me.cboClaseIncidencia)
    End Sub

    Private Sub butVerCategoriaIncidenciaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerCategoriaIncidenciaID.Click
        Dim frmEnt As New frmCategoriaIncidencias()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddCategoriaIncidenciaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddCategoriaIncidenciaID.Click
        Dim DBO_CategoriaIncidencias As New DBO_CategoriaIncidencias
        Dim frmEnt As New frmEntCategoriaIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spCategoriaIncidencias, DBO_CategoriaIncidencias)
        frmEnt.ShowDialog()
        Dim s As New spCategoriaIncidencias
        s.cargar_CategoriaIncidencias(Me.cboCategoriaIncidencia)
    End Sub

    Private Sub butVerId_IncidenciaCalidadGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmIncidenciasCalidadGeneral()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_IncidenciaCalidadGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_IncidenciasCalidadGeneral As New DBO_IncidenciasCalidadGeneral
        Dim frmEnt As New frmEntIncidenciasCalidadGeneral(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spIncidenciasCalidadGeneral, DBO_IncidenciasCalidadGeneral)
        frmEnt.ShowDialog()
        Dim s As New spIncidenciasCalidadGeneral
        s.cargar_IncidenciasCalidadGeneral(Me.cboIncidenciaCalidadGeneral)
    End Sub

    Private Sub btnLimpiarMaquina_Click(sender As System.Object, e As System.EventArgs)
        Me.cboMaquina.Text = ""
        Me.cboMaquina.SelectedValue = 0
    End Sub

    Private Sub btnLimpiarIncidencia_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiarIncidencia.Click
        Me.cboIncidenciaCalidadGeneral.Text = ""
        Me.cboIncidenciaCalidadGeneral.SelectedValue = 0
    End Sub

    Private Sub cboCategoriaIncidencia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCategoriaIncidencia.SelectedIndexChanged
        Try
            If cboCategoriaIncidencia.SelectedValue = 1 Or cboCategoriaIncidencia.SelectedValue = 8 Then
                Me.cboMaquina.Enabled = True
                Me.btnLimpiarMaquina.Enabled = True
                Me.butAddMaquinaID.Enabled = True
                Me.butVerMaquinaID.Enabled = True
            Else
                Me.cboMaquina.Enabled = False
                Me.btnLimpiarMaquina.Enabled = False
                Me.butAddMaquinaID.Enabled = False
                Me.butVerMaquinaID.Enabled = False
            End If

            Dim s2 As New spClasesIncidencias
            s2.cargar_ClasesIncidencias_por_categoria(Me.cboClaseIncidencia, Me.cboCategoriaIncidencia.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub
End Class
