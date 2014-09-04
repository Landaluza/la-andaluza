Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntEnvasados2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Tabla As DataTable
    Public m_DBO_Envasado As DBO_Envasados2
    Private m_LineaEnvasadoSeleccionada As Integer
    Private m_Control As Control
    Private frhijo As BasesParaCompatibilidad.FrmAheredarOld
    Private lbEnvasadoID As ToolStripItem
    Private frFormatos As frmFormatosEnvasados2
    Private frmEnvasadosProductos2 As frmEnvasadosProductos
    Private frmControlesPresionLlenadora2 As frmControlesPresionLlenadora2
    Private frmControlesContenidoEfectivo2 As frmControlesContenidoEfectivo2
    Private frmResumenpersonal As resumenPersonal
    Private spEnvasados2 As spEnvasados2
    Private btnEO As ToolStripButton
    Private calendar As BasesParaCompatibilidad.Calendar
    Private dtb As BasesParaCompatibilidad.DataBase

    Public ReadOnly Property Linea As Integer
        Get
            Return m_LineaEnvasadoSeleccionada
        End Get
    End Property
    Public Sub New(mode As String)
        MyBase.New(mode)
        InitializeComponent()
        spEnvasados2 = New spEnvasados2
        calendar = New BasesParaCompatibilidad.Calendar
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        m_DBO_Envasado = DBO_Envasados2.Instance
        dtpFecha.activarFoco()

        lbEnvasadoID = Me.bdnGeneral.Items.Add("EnvasadoID:")
        lbEnvasadoID.Text = "EnvasadoID:"
        lbEnvasadoID.DisplayStyle = ToolStripItemDisplayStyle.Text
        lbEnvasadoID.Enabled = False
        Me.bdnGeneral.Items.Add(New ToolStripControlHost(Me.txtEnvasadoID))
        lbEnvasadoID.Visible = False
        txtEnvasadoID.Visible = False
        butImprimir.ToolTipText = "Informe incidencias (F6)"
        OcultarBotonGrabar(False)
        butVer.Visible = False
        butImprimir.Visible = True

        btnEO = Me.bdnGeneral.Items.Add("Imprimir informe")
        btnEO.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        btnEO.Image = My.Resources.print_ico
        btnEO.TextDirection = ToolStripTextDirection.Horizontal
        btnEO.TextAlign = ContentAlignment.MiddleRight
        AddHandler btnEO.Click, AddressOf ImprimirEEO

        If m_DBO_Envasado.EnvasadoID = 0 Then
            dtpFecha.Visible = True
            Me.Label2.Visible = True
            Me.bdnGeneral.Visible = True
            Me.txtObservaciones.Text = ""
        Else
            txtObservaciones.Text = m_DBO_Envasado.Observaciones
        End If

        cboLineas.mam_DataSource("LineasEnvasadoSelectCbo", True, "Todas")
        SetValores()

        If Me.ModoDeApertura = INSERCION Then
            Me.tpgProduccion.Enabled = False
        Else
            Me.AñadirFormularios()
        End If
    End Sub

    'Private Sub frmEntEnvasados2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub AñadirFormularios()
        RellenaTabPrincipal()

        rellenarSeguimiento()

        frmEnvasadosProductos2 = New frmEnvasadosProductos(m_DBO_Envasado.EnvasadoID)
        Engine_LA.FormEnPestaña(frmEnvasadosProductos2, Me.tbpProductos)

        frmControlesPresionLlenadora2 = New frmControlesPresionLlenadora2(m_DBO_Envasado.EnvasadoID, True, Me)
        frmControlesPresionLlenadora2.Embebido = True
        Engine_LA.FormEnPestaña(frmControlesPresionLlenadora2, tbpPresion1)

        frmControlesContenidoEfectivo2 = New frmControlesContenidoEfectivo2(m_DBO_Envasado.EnvasadoID, True, Me)
        frmControlesContenidoEfectivo2.Embebido = True
        Engine_LA.FormEnPestaña(frmControlesContenidoEfectivo2, tbpContenido)

        If Config.UserType = 4 Or Config.UserType = 9 Then
            frmResumenpersonal = New resumenPersonal(Me.m_DBO_Envasado.EnvasadoID)
            Engine_LA.FormEnPestaña(frmResumenpersonal, tpResumenPersonal)
        Else
            Me.tpgProduccion.TabPages.Remove(tpResumenPersonal)
        End If
    End Sub

    Overrides Sub Guardar()
        Try
            If GetValores() Then
                spEnvasados2.GrabarEnvasados2(m_DBO_Envasado)

                If Me.ModoDeApertura = MODIFICACION Then
                    Me.Close()
                Else
                    SetValores()
                    MyBase.Guardar()
                    Me.AñadirFormularios()
                    Me.tpgProduccion.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error guardando envasado. Vuelva a intentarlo en unos segundos. Detalles: " & ex.Message, Convert.ToString(ex.GetType))
        End Try
    End Sub

    Public Overrides Sub SetValores()
        txtEnvasadoID.Text = m_DBO_Envasado.EnvasadoID
        dtpFecha.Value = m_DBO_Envasado.Fecha
    End Sub

    Public Function GetValores() As Boolean
        m_DBO_Envasado.Fecha = dtpFecha.Value.Date
        m_DBO_Envasado.Observaciones = Me.txtObservaciones.Text
        m_DBO_Envasado.FechaModificacion = System.DateTime.Now.Date
        m_DBO_Envasado.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If Me.ModoDeApertura = INSERCION Then
            If Me.cboLineas.SelectedValue Is Nothing Then
                MessageBox.Show("Selecciona un valor para la linea")
                Me.cboLineas.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub txtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If dtpFecha.Value > Now.Date Then
            dtpFecha.Value = Now.Date
        Else

            lblLote.Text = calendar.DevuelveFechaJuliana(dtpFecha.Value)
        End If
    End Sub

    'Private Sub AdministrarPestañas(ByVal nombre As String)
    '    Select Case nombre
    '        Case "tbpFormatos"
    '            RellenaTabPrincipal()

    '        Case "tbpSeguimiento"
    '            Dim dtSeg As DataTable
    '            If cboLineas.SelectedIndex = 0 Then
    '                dtSeg = DataTableFill("EnvasadosSeguimientoTodos " & Convert.ToString(m_DBO_Envasado.EnvasadoID))
    '            Else
    '                dtSeg = DataTableFill("EnvasadosSeguimientoPorLineaID " & Convert.ToString(m_DBO_Envasado.EnvasadoID) & ", " & Convert.ToString(m_DBO_Envasado.LineaID))
    '            End If
    '            If Not dtSeg Is Nothing Then
    '                If dtSeg.Rows.Count Then
    '                    dgvSeguimientoProduccion.DataSource = dtSeg
    '                    dgvSeguimientoProduccion.FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
    '                End If
    '            End If

    '        Case "tbpProductos"
    '            frmEnvasadosProductos2 = New frmEnvasadosProductos(m_DBO_Envasado.EnvasadoID)
    '            Engine_LA.FormEnPestaña(frmEnvasadosProductos2, Me.tbpProductos)

    '        Case "tbpPresion1"
    '                frmControlesPresionLlenadora2 = New frmControlesPresionLlenadora2(m_DBO_Envasado.EnvasadoID, True, Me)
    '                frhijo = frmControlesPresionLlenadora2
    '                frmControlesPresionLlenadora2.Embebido = True
    '                frhijo.Embebido = True
    '            Engine_LA.FormEnPestaña(frmControlesPresionLlenadora2, tbpPresion1)

    '        Case "tbpContenido"
    '                frmControlesContenidoEfectivo2 = New frmControlesContenidoEfectivo2(m_DBO_Envasado.EnvasadoID, True, Me)
    '                frhijo = frmControlesContenidoEfectivo2
    '                frmControlesContenidoEfectivo2.Embebido = True
    '                frhijo.Embebido = True
    '            Engine_LA.FormEnPestaña(frmControlesContenidoEfectivo2, tbpContenido)
    '    End Select
    'End Sub

    Private Sub cboLineas_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLineas.SelectionChangeCommitted
        SetValores()
        m_LineaEnvasadoSeleccionada = cboLineas.SelectedIndex
        RellenaTabPrincipal() 'Para que actualize los formatos de la linea
    End Sub

    Private Sub RellenaTabPrincipal()
        If cboLineas.SelectedIndex = 0 Then
            m_DBO_Envasado.LineaID = 0
        Else
            m_DBO_Envasado.LineaID = cboLineas.SelectedValue
        End If

        frFormatos = New frmFormatosEnvasados2(Me)
        Me.frhijo = frFormatos
        Me.frhijo.Embebido = True
        frFormatos.Embebido = True
        Engine_LA.FormEnPestaña(frFormatos, tbpFormatos)
    End Sub

    Private Sub rellenarSeguimiento()
        Dim dtSeg As DataTable
        If cboLineas.SelectedIndex = 0 Then
            dtb.PrepararConsulta("EnvasadosSeguimientoTodos @id")
            dtb.AñadirParametroConsulta("@id", m_DBO_Envasado.EnvasadoID)
        Else
            dtb.PrepararConsulta("EnvasadosSeguimientoPorLineaID @id, @linea")
            dtb.AñadirParametroConsulta("@id", m_DBO_Envasado.EnvasadoID)
            dtb.AñadirParametroConsulta("@linea", m_DBO_Envasado.LineaID)
        End If

        dtSeg = dtb.Consultar

        If Not dtSeg Is Nothing Then
            If dtSeg.Rows.Count Then
                dgvSeguimientoProduccion.DataSource = dtSeg
                dgvSeguimientoProduccion.FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End If
        End If
    End Sub
    Public Sub ImprimirEEO()
        Try
            Dim frm As New InformesCalidad.frmjuegos(BasesParaCompatibilidad.Config.connectionString, Me.m_DBO_Envasado.Fecha)
            GUImain.añadirPestaña(frm) 'frm.Show()            
        Catch ex As Exception
        End Try
    End Sub

    Private Sub timerSeguimiento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerSeguimiento.Tick
        rellenarSeguimiento()
    End Sub

    Private Sub tpgProduccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpgProduccion.SelectedIndexChanged
        If Me.tpgProduccion.SelectedTab.Name = "tbpSeguimiento" Then
            Me.timerSeguimiento.Enabled = True
            Me.timerSeguimiento.Start()
            Me.frhijo = Me.frFormatos
        Else
            Me.timerSeguimiento.Stop()
            Me.timerSeguimiento.Enabled = False
        End If
    End Sub

    Private Sub frmEntEnvasados2_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Me.timerSeguimiento.Stop()
            Me.timerSeguimiento.Enabled = False
        Catch ex As Exception

        End Try

        Dim spEmp As New spEmpleados
        Dim dt As DataTable

        If Me.cboLineas.SelectedValue = 0 Then
            dt = spEmp.devolver_Empleados_Envasados_ocupados(Me.m_DBO_Envasado.EnvasadoID)
        Else
            dt = spEmp.devolver_Empleados_Envasados_ocupados_por_linea(Me.cboLineas.SelectedValue, Me.m_DBO_Envasado.EnvasadoID)
        End If

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Dim listaNombres As String = ""

                For Each row As DataRow In dt.Rows
                    listaNombres = listaNombres & Environment.NewLine & row.Item("NombreCompleto") & " - Linea " & row.Item("LineaEnvasadoID")
                Next

                Dim res As DialogResult = MessageBox.Show("¿Seguro que desea salir? Quedan empleados con turnos por finalizar." & Environment.NewLine & "Detalles: " & listaNombres, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res = DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    'Private Sub frmEntEnvasados2_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
    '    Try
    '        Me.timerSeguimiento.Stop()
    '        Me.timerSeguimiento.Enabled = False
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub frmEntEnvasados2_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
    '    Try
    '        Me.timerSeguimiento.Enabled = True
    '        Me.timerSeguimiento.Start()
    '    Catch ex As Exception

    '    End Try
    'End Sub

End Class
