Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsContenidos2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_PaletProducido As DBO_PaletsProducidos2
    Private m_Envasado As DBO_Envasados2
    Private m_PaletContenido As DBO_PaletsContenidos2
    Private formatoId As Integer

    Private butTodos As ToolStripButton
    Private butMil As ToolStripItem
    Private label1 As ToolStripItem

    Public padre As frmEntPaletsProducidos2
    Public Const ACCION_COMPLETAR As String = "Completar"
    Private spPaletsProducidos2 As spPaletsProducidos2
    Private spEnvasados2 As spEnvasados2
    Private calendar As BasesParaCompatibilidad.Calendar

    Public Sub New(ByVal formatoId As Integer, ByVal PaletProducidoID As Integer, Optional ver As Boolean = False)

        MyBase.New(New spPaletsContenidos2, formatoId)
        InitializeComponent()

        spPaletsProducidos2 = New spPaletsProducidos2
        spEnvasados2 = New spEnvasados2
        calendar = New BasesParaCompatibilidad.Calendar

        If PaletProducidoID = 0 Then
            spSelectDgv = "PaletsContenidos2ByPaletProducidoID " & "-1"
        Else
            spSelectDgv = "PaletsContenidos2ByPaletProducidoID " & PaletProducidoID.ToString
        End If

        Me.formatoId = formatoId
        m_PaletProducido = DBO_PaletsProducidos2.Instance
        m_Envasado = DBO_Envasados2.Instance
        m_PaletContenido = New DBO_PaletsContenidos2


        BindingNavigatorSinRegistros()
        butSalir.Visible = False

        If ver Then
            Me.butGuardar.Visible = False
            butModificar.Visible = False
            butEliminar.Visible = False
            butNuevo.Visible = False
        Else
            butModificar.Visible = True
            butEliminar.Visible = True
        End If
    End Sub

    'Public Sub New()

    '    InitializeComponent()

    '    spPaletsContenidos2 = New spPaletsContenidos2
    '    spPaletsProducidos2 = New spPaletsProducidos2
    '    spEnvasados2 = New spEnvasados2
    '    Me.Embebido = False

    '    spSelectDgv = "PaletsContenidosSelectDgv"

    '    label1 = Me.bdnGeneral.Items.Add("Se muestran solamente los ultimos 1.000 registros.")
    '    label1.Text = "Se muestran solamente los ultimos 1.000 registros."
    '    label1.DisplayStyle = ToolStripItemDisplayStyle.Text
    '    label1.Enabled = False
    '    Me.bdnGeneral.AddNewItem = label1

    '    butTodos = Me.bdnGeneral.Items.Add("Todos")
    '    butTodos.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    '    butTodos.Image = My.Resources.refresh
    '    AddHandler butTodos.Click, AddressOf butTodos2_Click

    '    butMil = Me.bdnGeneral.Items.Add("1.000")
    '    butMil.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
    '    butMil.Image = My.Resources.refresh
    '    AddHandler butMil.Click, AddressOf butMil2_Click
    '    butMil.Visible = False

    '    m_PaletProducido = DBO_PaletsProducidos2.Instance()
    '    m_Envasado = DBO_Envasados2.Instance()


    '    butNuevo.Visible = False
    '    Me.butSalir.Visible = True
    '    butModificar.Visible = False
    '    butEliminar.Visible = False
    'End Sub

    Public ReadOnly Property RowCount As Integer
        Get
            Return Me.dgvGeneral.RowCount
        End Get
    End Property

    Private Sub actualizarTrasAccion(Optional keepReg As Boolean = False)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        dgvFill()
        'GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)

        If Not padre Is Nothing Then
            padre.VerificarPaletsSinTerminar()
            padre.SetValores()
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then

            dataSource.Columns.Add("Lote")
            GeneralBindingSource.DataSource = dataSource 'DataTableFill(spSelectDgv)

            Try
                If Me.Embebido Then
                    With dgvGeneral
                        .DataSource = GeneralBindingSource
                        .Columns("PaletContenidoID").Visible = False
                        .Columns("PaletProducidoID").Visible = False
                        .Columns("EnAlmacen").Visible = False
                        .Columns("Completo").Visible = False
                        .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 75)
                        .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85)
                        .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 84)
                        .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 45)
                        .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                    End With
                Else
                    With dgvGeneral
                        .DataSource = GeneralBindingSource
                        .Columns("PaletContenidoID").Visible = False
                        .Columns("HoraFin").Visible = False
                        .Columns("PaletProducidoID").Visible = False
                        .Columns("EnAlmacen").Visible = False
                        .Columns("Terminado").Visible = False
                        .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 50, 0)
                        .FormatoColumna("HoraInicio", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 70, 1)
                        .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 250, 2)
                        .FormatoColumna("CantidadCajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 50, 3)
                        .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 380)
                    End With
                End If



                For Each row As DataGridViewRow In dgvGeneral.Rows
                    row.Cells("Lote").Value = calendar.DevuelveFechaJuliana(Convert.ToDateTime(row.Cells("gregoriano").Value)).ToString
                Next
                dgvGeneral.FormatoColumna("Lote", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 35)
                dgvGeneral.Columns("gregoriano").Visible = False
                dgvGeneral.MultiSelect = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Protected Overrides Sub dgvFill()
        dataSource = dtb.Consultar(spSelectDgv)

        If Not dataSource Is Nothing Then

            dataSource.Columns.Add("Lote")
            GeneralBindingSource.DataSource = dataSource 'DataTableFill(spSelectDgv)

            Try
                If Me.Embebido Then
                    With dgvGeneral
                        .DataSource = GeneralBindingSource
                        .Columns("PaletContenidoID").Visible = False
                        .Columns("PaletProducidoID").Visible = False
                        .Columns("EnAlmacen").Visible = False
                        .Columns("Completo").Visible = False
                        .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 75)
                        .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85)
                        .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 84)
                        .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 45)
                        .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                    End With
                Else
                    With dgvGeneral
                        .DataSource = GeneralBindingSource
                        .Columns("PaletContenidoID").Visible = False
                        .Columns("HoraFin").Visible = False
                        .Columns("PaletProducidoID").Visible = False
                        .Columns("EnAlmacen").Visible = False
                        .Columns("Terminado").Visible = False
                        .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 50, 0)
                        .FormatoColumna("HoraInicio", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 70, 1)
                        .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 250, 2)
                        .FormatoColumna("CantidadCajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 50, 3)
                        .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 380)
                    End With
                End If



                For Each row As DataGridViewRow In dgvGeneral.Rows
                    row.Cells("Lote").Value = calendar.DevuelveFechaJuliana(Convert.ToDateTime(row.Cells("gregoriano").Value)).ToString
                Next
                dgvGeneral.FormatoColumna("Lote", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 35)
                dgvGeneral.Columns("gregoriano").Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
#Region "Sobrecargas BindingNavigator"

    Overrides Sub Insertar()
        If Me.butNuevo.Visible And Me.butNuevo.Enabled Then Action(ACCION_INSERTAR)
    End Sub

    Overrides Sub Modificar()
        Try
            If Me.butModificar.Visible And Me.butModificar.Enabled Then Action(ACCION_MODIFICAR)
        Catch ex As Exception
            MessageBox.Show("Asegurese de seleccionar una fila.")
        End Try
    End Sub

    Overrides Sub Ver()
        Try
            If Me.butVer.Visible And Me.butVer.Enabled Then Action(ACCION_VER)
        Catch ex As Exception
            MessageBox.Show("Asegurese de seleccionar una fila.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Overrides Sub Eliminar()
        If Me.butEliminar.Visible And Me.butEliminar.Enabled Then
            Try
                Dim response As DialogResult
                response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                                  "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = DialogResult.Yes Then
                    Dim m_Pos As Integer = GeneralBindingSource.Position
                    CType(sp, spPaletsContenidos2).EliminarPaletContenido(GeneralBindingSource(m_Pos).Item("PaletContenidoID"))
                    actualizarTrasAccion()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub completar()
        Me.Action(ACCION_COMPLETAR)
    End Sub

    Public Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim m_Pos As Integer = GeneralBindingSource.Position
        If Not Me.padre Is Nothing Then Me.padre.TimerSSCC.Stop()

        If Not Me.Embebido Then

            'm_PaletContenido = spPaletsContenidos2.Select_Record(Me.dgvGeneral.CurrentRow.Cells("PaletContenidoID").Value)

            m_PaletContenido = CType(sp, spPaletsContenidos2).Select_Record(Me.dgvGeneral.CurrentRow.Cells("PaletContenidoID").Value)
            m_PaletProducido = spPaletsProducidos2.Select_Record(Me.dgvGeneral.CurrentRow.Cells("PaletProducidoID").Value)
            spPaletsProducidos2.scc = m_PaletContenido.SCC

            Dim aux As DBO_FormatosEnvasados
            Dim spFormatosEnvasados As New spFormatosEnvasados
            aux = spFormatosEnvasados.Select_Record(m_PaletProducido.FormatoID)
            m_Envasado = spEnvasados2.Select_Record(aux.EnvasadoID)
            m_Envasado.LineaID = aux.TipoFormatoLineaID
        End If

        Dim frmEnt As New frmEntPaletsContenidos2(m_PaletContenido)

        Select Case TipoAction
            Case ACCION_INSERTAR
                spPaletsProducidos2.CompletarPaletContenido(m_PaletProducido)
                m_PaletContenido.PaletProducidoID = m_PaletProducido.PaletProducidoID
                m_PaletContenido.Terminado = True

                Dim HoraInicioAux As Object = dtb.Consultar("exec PaletsProducidos2GetUltimaHoraProduccionPorLinea2 " & m_Envasado.LineaID & ", " & m_Envasado.EnvasadoID).Rows(0).Item(0)
                m_PaletContenido.HoraInicio = If(HoraInicioAux Is Convert.DBNull, New TimeSpan(6, 55, 0), HoraInicioAux)
                m_PaletContenido.HoraFin = m_PaletContenido.HoraInicio.Add(New TimeSpan(0, 15, 0))
                m_PaletContenido.CantidadCajas = m_PaletProducido.CajasPalet
                m_PaletContenido.PartePaletContenidoID = 0
                m_PaletContenido.NroCajasCompletar = m_PaletProducido.NroCajasCompletar
                frmEnt.ModoDeApertura = frmEntPaletsContenidos2.INSERCION

            Case ACCION_MODIFICAR
                spPaletsProducidos2.CompletarPaletContenido(m_PaletProducido)
                m_PaletContenido.NroCajasCompletar = m_PaletProducido.NroCajasCompletar
                m_PaletContenido.PaletContenidoID = GeneralBindingSource(m_Pos).Item("PaletContenidoID")
                frmEnt.ModoDeApertura = frmEntPaletsContenidos2.MODIFICACION

            Case ACCION_VER
                spPaletsProducidos2.CompletarPaletContenido(m_PaletProducido)
                m_PaletContenido.NroCajasCompletar = m_PaletProducido.NroCajasCompletar
                m_PaletContenido.PaletContenidoID = GeneralBindingSource(m_Pos).Item("PaletContenidoID")
                frmEnt.ModoDeApertura = frmEntPaletsContenidos2.VISION

            Case ACCION_COMPLETAR
                If padre.dgvIncompletos.CurrentRow Is Nothing Then
                    MessageBox.Show("Pulse antes sobre una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
                padre.m_DBO_PaletProducido.PaletProducidoID = padre.dgvIncompletos.CurrentRow.Cells("PaletProducidoID").Value
                padre.m_DBO_PaletProducido = spPaletsProducidos2.Select_Record(padre.dgvIncompletos.CurrentRow.Cells("PaletProducidoID").Value)
                frmEnt.CambiarMensaje(padre.m_DBO_PaletProducido.SCC, padre.dgvIncompletos.CurrentRow.Cells("Cajas").Value)

                Dim HoraInicioAux As Object = dtb.Consultar("exec PaletsProducidos2GetUltimaHoraProduccionPorLinea2 " & padre.m_DBO_Envasado.LineaID & ", " & padre.m_DBO_Envasado.EnvasadoID).Rows(0).Item(0)
                Dim cajasAux As Integer = (padre.dgvIncompletos.CurrentRow.Cells("Cajas").Value)

                padre.SetValores()
                m_PaletContenido.HoraInicio = If(HoraInicioAux Is Nothing Or HoraInicioAux Is Convert.DBNull, _
                                                 New TimeSpan(6, 55, 0), HoraInicioAux)

                m_PaletContenido.HoraFin = m_PaletContenido.HoraInicio.Add(New TimeSpan(0, 15, 0))

                m_PaletContenido.CantidadCajas = padre.m_DBO_PaletProducido.CajasPalet - cajasAux
                m_PaletContenido.PaletProducidoID = padre.m_DBO_PaletProducido.PaletProducidoID
                m_PaletContenido.PartePaletContenidoID = padre.dgvIncompletos.CurrentRow.Cells("ConPaletID").Value
                m_PaletContenido.EnAlmacen = True
                m_PaletContenido.Terminado = True
                frmEnt.formatoid = Me.formatoId
                frmEnt.ModoDeApertura = frmEntPaletsContenidos2.COMPLETAR
        End Select

        frmEnt.padre = Me.padre
        frmEnt.contenidos = Me.dgvGeneral.Rows.Count
        Dim result As DialogResult = frmEnt.ShowDialog()

        If frmEnt.ModoDeApertura = frmEntPaletsContenidos2.COMPLETAR Then
            padre.SetValores()
        End If

        If result = Windows.Forms.DialogResult.OK Or result = Windows.Forms.DialogResult.Yes Then
            If Not padre Is Nothing Then
                If Not padre.ModoDeApertura = frmEntPaletsProducidos2.MODIFICACION And result = Windows.Forms.DialogResult.Yes Then
                    Me.padre.Close()
                Else
                    actualizarTrasAccion(If(TipoAction = ACCION_MODIFICAR, True, False))
                End If
            Else
                actualizarTrasAccion(If(TipoAction = ACCION_MODIFICAR, True, False))
            End If
        End If
        frmEnt.Dispose()
    End Sub
#End Region



    Private Sub butMil2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        spSelectDgv = "PaletsContenidosSelectDgv"
        label1.Text = "Se muestran solamente los ultimos 1.000 registros."
        butMil.Visible = False
        butTodos.Visible = True
        dgvGeneral.Visible = False
        dgvFill()
        dgvGeneral.Visible = True
    End Sub

    Private Sub butTodos2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        spSelectDgv = "PaletsContenidosSelectDgvAll"
        dgvGeneral.Visible = False
        label1.Text = "Se muestran todos los registros."
        butTodos.Visible = False
        butMil.Visible = True
        dgvFill()
        dgvGeneral.Visible = True
    End Sub

    Public Sub DatagridViewFill()
        If Not dgvGeneral Is Nothing Then Me.dgvFill()
    End Sub
End Class
