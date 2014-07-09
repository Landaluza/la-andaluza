Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmPaletsMovimientoEntrePalets
    Private frmOrigen As frmPaletSCC
    Private frmDestino As frmPaletSCC
    Private Respuesta As DialogResult

    Private CajasOrigen As Integer = 0
    Private CajasDestino As Integer = 0
    Private CajasPaletOrigen As Integer = 0
    Private CajasPaletDestino As Integer = 0
    Private CajasFinales As Integer

    Private DBO_PaletsMovimientoTipo As New DBO_PaletsMovimientosTipos
    Private dbo_movimiento As Dbo_PaletsMovimiento
    Private dbo_MovimientoDB As New spPaletsMovimiento
    Private m_PaletProducidoOrigen As DBO_PaletsProducidos2
    Private m_PaletProducidoDestino As DBO_PaletsProducidos2
    Private spPaletsProducidos2 As spPaletsProducidos2
    Private dtb As BasesParaCompatibilidad.DataBase
    Private tsMovimiento As ToolStripItem

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        spPaletsProducidos2 = New spPaletsProducidos2
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        frmOrigen = New frmPaletSCC(True, "Origen")
        frmDestino = New frmPaletSCC(True, "Destino")
    End Sub
    Private Sub frmPaletsMovimientoEntrePalets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboMovimientoTipo.mam_DataSource("PaletsMovimientosTipos1Cbo", False)
        cboMovimientoTipo.MaxDropDownItems = cboMovimientoTipo.Items.Count

        Engine_LA.FormEnPestaña(frmOrigen, panOrigen)

        'frmOrigen.Panel2.Controls.Add(Me.butAñadirMovimiento)
        tsMovimiento = Me.frmOrigen.ToolStrip1.Items.Add("Generar movimiento")
        tsMovimiento.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsMovimiento.Image = My.Resources.note_go
        tsMovimiento.Alignment = ToolStripItemAlignment.Right
        tsMovimiento.TextDirection = ToolStripTextDirection.Horizontal
        tsMovimiento.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsMovimiento.Click, AddressOf butAñadirMovimiento_Click

        Engine_LA.FormEnPestaña(frmDestino, panDestino)

    End Sub

    Private Sub butAñadirMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Cursor = Cursors.WaitCursor
        Dim validado As Boolean

        Try
            validado = Me.validarCajas
        Catch ex As Exception
            MessageBox.Show("Error al validar las cajas. Detalles:" & Environment.NewLine & ex.Message)
            validado = False
        End Try
        If validado Then
            BasesParaCompatibilidad.BD.EmpezarTransaccion()
            Try



                dbo_movimiento = New Dbo_PaletsMovimiento

                ComprobarCantidades()
                'Movimiento del palets Origen
                m_PaletProducidoOrigen = spPaletsProducidos2.Select_RecordBySSCC(frmOrigen.txtSCC.Text, BasesParaCompatibilidad.BD.transaction)
                SetValores(dbo_movimiento, True)
                dbo_MovimientoDB.Add(dbo_movimiento)
                'Añadir Observaciones en PaletsProducidos

                m_PaletProducidoOrigen.observacionesPalets = txtObsPaletOrigen.Text
                spPaletsProducidos2.GrabarPaletProducido2(m_PaletProducidoOrigen)

                If DBO_PaletsMovimientoTipo.EntrePalets Then   'Movimiento del palets Destino
                    m_PaletProducidoDestino = spPaletsProducidos2.Select_RecordBySSCC(frmDestino.txtSCC.Text, BasesParaCompatibilidad.BD.transaction)
                    SetValores(dbo_movimiento, False)
                    dbo_MovimientoDB.Add(dbo_movimiento, True)
                    'Añadir Observaciones en PaletsProducidos
                End If

                txtCajas.Text = ""
                txtObsMovimiento.Text = ""
                txtObsPaletOrigen.Text = ""
                txtObsPaletDestino.Text = ""
                'butAñadirMovimiento.Visible = False
                lblObsPaletDestino.Visible = False
                txtObsPaletDestino.Visible = False
                gpbDestino.Visible = False

                BasesParaCompatibilidad.BD.TerminarTransaccion()
                'messagebox.show("Movimiento añadido correctamente")
                BasesParaCompatibilidad.MessageDialogue.DisplayMessage("Movimiento añadido correctamente", Me, AnchorStyles.Top, 2500)
                ' MessageBox.Show("Movimiento añadido correctamente", "Operacion terminada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                BasesParaCompatibilidad.BD.CancelarTransaccion()
                MessageBox.Show(ex.Message, Convert.ToString(ex.GetType))
            End Try
        End If
        Try
            frmOrigen.btnVer.PerformClick()
        Catch ex As Exception

        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetValores(ByVal dbo_movimiento As Dbo_PaletsMovimiento, ByVal Origen As Boolean)
        Try
            If Origen Then
                dbo_movimiento.PaletID = m_PaletProducidoOrigen.PaletProducidoID
                dbo_movimiento.Cajas = If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text))
                If DBO_PaletsMovimientoTipo.EntrePalets Then
                    dbo_movimiento.DocumentoID = System.Convert.ToInt32(frmDestino.txtSCC.Text)
                    dbo_movimiento.DocumentoID_IsDBNull = False
                Else
                    dbo_movimiento.DocumentoID = System.Convert.ToInt32(If(txtDocumento.Text = "", Nothing, txtDocumento.Text))
                    dbo_movimiento.DocumentoID_IsDBNull = If(txtDocumento.Text = "", True, False)
                End If
            Else
                dbo_movimiento.PaletID = m_PaletProducidoDestino.PaletProducidoID
                dbo_movimiento.Cajas = If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text)) * -1
                dbo_movimiento.DocumentoID = System.Convert.ToInt32(frmOrigen.txtSCC.Text)
                dbo_movimiento.DocumentoID_IsDBNull = False

                'If DBO_PaletsMovimientoTipo.PaletMovimientoTipoID = 21 Or DBO_PaletsMovimientoTipo.PaletMovimientoTipoID = 23 Or DBO_PaletsMovimientoTipo.PaletMovimientoTipoID = 26 Then
                If spPaletsMovimiento.esMovimientoEncajado(Me.cboMovimientoTipo.SelectedValue) Then
                    Dim capacidad As Integer = dtb.Consultar("PaletsProducidosCapacidadFormatoByPaletProducidoID " & m_PaletProducidoDestino.PaletProducidoID).Rows(0).Item(0)
                    dbo_movimiento.Cajas = dbo_movimiento.Cajas / capacidad
                End If
            End If

            dbo_movimiento.Tipo = Me.cboMovimientoTipo.SelectedValue
            dbo_movimiento.Tipo_IsDBNull = False
            dbo_movimiento.PaletID_IsDBNull = False
            dbo_movimiento.Fecha = dtpFecha.Value.Date
            dbo_movimiento.Fecha_IsDBNull = False
            dbo_movimiento.Cajas_IsDBNull = If(txtCajas.Text = "", True, False)

            dbo_movimiento.Comentarios = System.Convert.ToString(If(txtObsMovimiento.Text = "", String.Empty, txtObsMovimiento.Text))
            dbo_movimiento.Comentarios_IsDBNull = If(txtObsMovimiento.Text = "", True, False)
            dbo_movimiento.AutorizadoPor = Nothing
            dbo_movimiento.AutorizadoPor_IsDBNull = True
            dbo_movimiento.Receptor = Nothing
            dbo_movimiento.Receptor_IsDBNull = True
            dbo_movimiento.Motivo = "" ' Si pongo Nothing da error.
            dbo_movimiento.Motivo_IsDBNull = False
            dbo_movimiento.Solicitante = Nothing
            dbo_movimiento.Solicitante_IsDBNull = True
            dbo_movimiento.Cliente = Nothing
            dbo_movimiento.Cliente_IsDBNull = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub butAddMovimientoTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddMovimientoTipo.Click
        Using frmEnt As New frmPaletsMovimientosTipos()
            frmEnt.ShowDialog()
        End Using
        cboMovimientoTipo.mam_DataSource("PaletsMovimientosTipos1Cbo", False)
    End Sub

    'Private Sub txtCajas_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCajas.Validated
    '    validarCajas()
    'End Sub

    Private Function validarCajas() As Boolean
        Dim todoOk As Boolean = False

        If Me.txtCajas.Text <> "" Then
            If IsNumeric(txtCajas.Text) Then

                'Busco el PaletID del SSCC
                m_PaletProducidoOrigen = spPaletsProducidos2.Select_RecordBySSCC(frmOrigen.txtSCC.Text)
                'Sumo todas las cajas de los ContenidosPalet del PaletProducido de Origen y todos sus movimientos.
                Dim tbPaletsContenidosOrigen As DataTable = dtb.Consultar("SelectPaletsEnAlmacenByPaletID " & m_PaletProducidoOrigen.PaletProducidoID)

                'CajasPalet del Formato Origen
                Dim tbCajasPaletOrigen As DataTable = dtb.Consultar("PaletsContenidos2CapacidadCajaDePaletProducido " & m_PaletProducidoOrigen.PaletProducidoID)
                'messagebox.show("PaletsContenidos2CapacidadCajaDePaletProducido" & m_PaletProducidoOrigen.PaletProducidoID)
                If Convert.IsDBNull(tbCajasPaletOrigen.Rows(0).Item("CajasPalet")) Then Throw New Exception("El articulo no no tiene 'CajasPorMatricula'")
                CajasPaletOrigen = tbCajasPaletOrigen.Rows(0).Item("CajasPalet")

                CajasOrigen = tbPaletsContenidosOrigen.Rows(0).Item("Cajas")
                txtObsPaletOrigen.Text = m_PaletProducidoOrigen.observacionesPalets

                If DBO_PaletsMovimientoTipo.EntrePalets Then
                    If frmDestino.txtSCC.Text = "" Then
                        '''
                        If MessageBox.Show("No ha indicado palet de destino, ¿crear uno?", "Atencion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                            MessageBox.Show("Hay que indicar un palet de destino", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            frmDestino.txtSCC.Focus()
                            Return False
                        Else
                            Dim dEnvasado As DBO_Envasados
                            Dim dFormatoOrigen As DBO_FormatosEnvasados
                            Dim spEnvasado As New spEnvasados
                            Dim spFormato As New spFormatosEnvasados
                            Dim scc As Integer = 0
                            Dim paletgrabado As Integer

                            dFormatoOrigen = spFormato.Select_Record(m_PaletProducidoOrigen.FormatoID)

                            BasesParaCompatibilidad.BD.EmpezarTransaccion()
                            Try

                                dEnvasado = spEnvasado.Select_Record(spEnvasado.recuperarEnvasadoDiario, BasesParaCompatibilidad.BD.transaction)

                                Dim aux As Integer = spFormato.buscar_por_envasado_articulo_formato(dEnvasado.ID, dFormatoOrigen.TipoFormatoEnvasadoID, dFormatoOrigen.TipoFormatoLineaID, BasesParaCompatibilidad.BD.transaction, BasesParaCompatibilidad.BD.Cnx)

                                m_PaletProducidoDestino = New DBO_PaletsProducidos2
                                m_PaletProducidoDestino.FormatoID = aux
                                m_PaletProducidoDestino.HoraInicio = DateTime.Now.TimeOfDay
                                m_PaletProducidoDestino.HoraFin = DateTime.Now.TimeOfDay
                                m_PaletProducidoDestino.MultiLote = False
                                m_PaletProducidoDestino.Terminado = True
                                m_PaletProducidoDestino.EnAlmacen = True
                                m_PaletProducidoDestino.FechaModificacion = DateTime.Now
                                m_PaletProducidoDestino.UsuarioModificacion = 2
                                m_PaletProducidoDestino.observacionesPalets = ""
                                scc = spPaletsProducidos2.GetUltimoSCCmas1
                                m_PaletProducidoDestino.SCC = scc

                                paletgrabado = spPaletsProducidos2.InsertPaletsProducidos2(m_PaletProducidoDestino)


                                If paletgrabado = 0 Then
                                    BasesParaCompatibilidad.BD.CancelarTransaccion()
                                    Return False
                                Else


                                    BasesParaCompatibilidad.BD.TerminarTransaccion()
                                End If
                            Catch ex As Exception
                                BasesParaCompatibilidad.BD.CancelarTransaccion()
                                Return False
                            End Try

                            Try
                                m_PaletProducidoDestino = spPaletsProducidos2.Select_RecordSinMachacar(paletgrabado)
                            Catch ex As Exception
                                Return False
                            End Try
                            frmDestino.txtSCC.Text = m_PaletProducidoDestino.SCC
                            Me.frmDestino.btnVer.PerformClick()
                        End If
                    End If

                    'Busco el PaletID del SSCC destino
                    m_PaletProducidoDestino = spPaletsProducidos2.Select_RecordBySSCC(frmDestino.txtSCC.Text)

                    'Sumo todas las cajas de los ContenidosPalet del PaletProducido Destino y todos sus movimientos.
                    Dim tbPaletsContenidosDestino As DataTable = dtb.Consultar("SelectPaletsEnAlmacenByPaletID " & m_PaletProducidoDestino.PaletProducidoID)
                    If tbPaletsContenidosDestino Is Nothing Then
                        CajasDestino = 0
                    Else
                        If tbPaletsContenidosDestino.Rows.Count > 0 Then
                            CajasDestino = If(Convert.IsDBNull(tbPaletsContenidosDestino.Rows(0).Item("Cajas")), 0, Convert.ToInt32(tbPaletsContenidosDestino.Rows(0).Item("Cajas")))
                        Else
                            CajasDestino = 0
                        End If
                    End If

                    'CajasPalet del Formato Destino
                    Dim tbCajasPaletDestino As DataTable = dtb.Consultar("PaletsContenidos2CapacidadCajaDePaletProducido " & m_PaletProducidoDestino.PaletProducidoID)
                    CajasPaletDestino = tbCajasPaletDestino.Rows(0).Item("CajasPalet")

                    'If txtCajas.Text > CajasOrigen Then
                    If If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text)) > If(Me.frmOrigen.LblCajasExisten.Text = "", 0, Convert.ToInt32(Me.frmOrigen.LblCajasExisten.Text)) Then
                        MessageBox.Show("No puedes mover mas cajas de las que tiene el palet." & Environment.NewLine & _
                               "Cajas: " & CajasOrigen & Environment.NewLine)
                        txtCajas.Focus()
                    Else
                        If If(frmOrigen.txtSCC.Text = "", 0, Convert.ToInt32(frmOrigen.txtSCC.Text)) <> If(frmDestino.txtSCC.Text = "", 0, Convert.ToInt32(frmDestino.txtSCC.Text)) Then
                            'El palet Origen se queda con menos de las marcadas para su Formato.
                            If CajasOrigen + If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text)) > CajasPaletDestino Then
                                'Respuesta = messagebox.show("El palet origen se queda con " & (CajasOrigen - txtCajas.Text) & " cajas." & Environment.NewLine & _
                                Respuesta = MessageBox.Show("El palet origen se queda con " & Convert.ToString((Me.frmOrigen.LblCajasExisten.Text) - Convert.ToInt32(txtCajas.Text)) & " cajas." & Environment.NewLine & _
                                                       "Las cajas habituales son " & Convert.ToString(CajasPaletOrigen) & "." & Environment.NewLine & _
                                                       "¿Es correcto?", _
                                                       "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If Respuesta = DialogResult.Yes Then
                                    todoOk = True
                                Else
                                    txtCajas.Focus()
                                End If
                            Else
                                todoOk = True
                            End If

                            If DBO_PaletsMovimientoTipo.EntrePalets Then
                                Dim cajasañadir As Integer
                                If Me.cboMovimientoTipo.SelectedValue = 21 Or DBO_PaletsMovimientoTipo.ID = 23 Or DBO_PaletsMovimientoTipo.ID = 26 Then
                                    Dim capacidad As Integer = dtb.Consultar("PaletsProducidosCapacidadFormatoByPaletProducidoID " & m_PaletProducidoDestino.PaletProducidoID).Rows(0).Item(0)
                                    cajasañadir = If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text)) / capacidad
                                Else
                                    cajasañadir = If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text))
                                End If


                                'El palet Destino se queda con mas cajas de las marcadas para su Formato.
                                If CajasDestino + cajasañadir > CajasPaletDestino Then
                                    'Respuesta = messagebox.show("El palet destino se queda con " & (CajasDestino + txtCajas.Text) & " cajas." & Environment.NewLine & _
                                    Respuesta = MessageBox.Show("El palet destino se queda con " & CajasDestino + cajasañadir & " cajas." & Environment.NewLine & _
                                                           "Las cajas habituales son " & Convert.ToString(CajasPaletDestino) & "." & Environment.NewLine & _
                                                           "¿Es correcto?", _
                                                           "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                    If Respuesta = DialogResult.Yes Then
                                        todoOk = True
                                    Else
                                        txtCajas.Focus()
                                    End If
                                Else
                                    todoOk = True
                                End If
                            End If
                        Else
                            todoOk = True
                        End If
                    End If

                Else 'No es movimiento entre palets
                    'If txtCajas.Text > CajasOrigen Then
                    If If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text)) > If(Me.frmOrigen.LblCajasExisten.Text = "", 0, Convert.ToInt32(Me.frmOrigen.LblCajasExisten.Text)) Then
                        MessageBox.Show("No puedes mover mas cajas de las que tiene el palet." & Environment.NewLine & "Cajas:" & Me.frmOrigen.LblCajasExisten.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtCajas.Focus()
                        todoOk = False
                    Else
                        todoOk = True
                    End If
                End If

                'If todoOk Then
                '    butAñadirMovimiento.Visible = True
                '    butAñadirMovimiento.BringToFront()
                'End If
            Else
                MessageBox.Show("Las cajas deben ser numericas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCajas.Focus()
            End If
        Else
            MessageBox.Show("Debe rellenarse el campo cajas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCajas.Focus()
        End If

        Return todoOk
    End Function

    'Private Function validarCajas() As Boolean
    '    Dim todoOk As Boolean = False

    '    If Me.txtCajas.Text <> "" Then
    '        If IsNumeric(txtCajas.Text) Then

    '            'Busco el PaletID del SSCC
    '            m_PaletProducidoOrigen = spPaletsProducidos2.Select_RecordBySSCC(frmOrigen.txtSCC.Text)
    '            'Sumo todas las cajas de los ContenidosPalet del PaletProducido de Origen y todos sus movimientos.
    '            Dim tbPaletsContenidosOrigen As DataTable = DataTableFill("SelectPaletsEnAlmacenByPaletID", m_PaletProducidoOrigen.PaletProducidoID)

    '            'CajasPalet del Formato Origen
    '            Dim tbCajasPaletOrigen As DataTable = DataTableFill("PaletsContenidos2CapacidadCajaDePaletProducido", m_PaletProducidoOrigen.PaletProducidoID)
    '            'messagebox.show("PaletsContenidos2CapacidadCajaDePaletProducido" & m_PaletProducidoOrigen.PaletProducidoID)
    '            If Convert.IsDBNull(tbCajasPaletOrigen.Rows(0).Item("CajasPalet")) Then Throw New Exception("El articulo no no tiene 'CajasPorMatricula'")
    '            CajasPaletOrigen = tbCajasPaletOrigen.Rows(0).Item("CajasPalet")

    '            CajasOrigen = tbPaletsContenidosOrigen.Rows(0).Item("Cajas")
    '            txtObsPaletOrigen.Text = m_PaletProducidoOrigen.observacionesPalets

    '            If DBO_PaletsMovimientoTipo.EntrePalets Then
    '                If frmDestino.txtSCC.Text = "" Then
    '                    '''
    '                    If MessageBox.Show("No ha indicado palet de destino, ¿crear uno?", "Atencion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
    '                        messagebox.show("Hay que indicar un palet de destino", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                        frmDestino.txtSCC.Focus()
    '                        Return False
    '                    Else
    '                        m_PaletProducidoDestino = New DBO_PaletsProducidos2


    '                    End If
    '                End If

    '                'Busco el PaletID del SSCC destino
    '                m_PaletProducidoDestino = spPaletsProducidos2.Select_RecordBySSCC(frmDestino.txtSCC.Text)

    '                'Sumo todas las cajas de los ContenidosPalet del PaletProducido Destino y todos sus movimientos.
    '                Dim tbPaletsContenidosDestino As DataTable = DataTableFill("SelectPaletsEnAlmacenByPaletID", m_PaletProducidoDestino.PaletProducidoID)
    '                CajasDestino = tbPaletsContenidosDestino.Rows(0).Item("Cajas")

    '                'CajasPalet del Formato Destino
    '                Dim tbCajasPaletDestino As DataTable = DataTableFill("PaletsContenidos2CapacidadCajaDePaletProducido", m_PaletProducidoDestino.PaletProducidoID)
    '                CajasPaletDestino = tbCajasPaletDestino.Rows(0).Item("CajasPalet")

    '                'If txtCajas.Text > CajasOrigen Then
    '                If Convert.ToInt32(if(txtCajas.Text = "", 0, txtCajas.Text)) > Convert.ToInt32(if(Me.frmOrigen.LblCajasExisten.Text = "", 0, Me.frmOrigen.LblCajasExisten.Text)) Then
    '                    messagebox.show("No puedes mover mas cajas de las que tiene el palet." & Environment.NewLine & _
    '                           "Cajas: " & CajasOrigen & Environment.NewLine)
    '                    txtCajas.Focus()
    '                Else
    '                    If Convert.ToInt32(if(frmOrigen.txtSCC.Text = "", 0, frmOrigen.txtSCC.Text)) <> Convert.ToInt32(if(frmDestino.txtSCC.Text = "", 0, frmDestino.txtSCC.Text)) Then
    '                        'El palet Origen se queda con menos de las marcadas para su Formato.
    '                        If CajasOrigen + Convert.ToInt32(if(txtCajas.Text = "", 0, txtCajas.Text)) > CajasPaletDestino Then
    '                            'Respuesta = messagebox.show("El palet origen se queda con " & (CajasOrigen - txtCajas.Text) & " cajas." & Environment.NewLine & _
    '                            Respuesta = messagebox.show("El palet origen se queda con " & ((Me.frmOrigen.LblCajasExisten.Text) - Convert.ToInt32(txtCajas.Text)) & " cajas." & Environment.NewLine & _
    '                                                   "Las cajas habituales son " & CajasPaletOrigen & "." & Environment.NewLine & _
    '                                                   "¿Es correcto?", _
    '                                                   "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '                                                   " Palet completo ")
    '                            If Respuesta = DialogResult.Yes Then
    '                                todoOk = True
    '                            Else
    '                                txtCajas.Focus()
    '                            End If
    '                        Else
    '                            todoOk = True
    '                        End If

    '                        If DBO_PaletsMovimientoTipo.EntrePalets Then
    '                            Dim cajasañadir As Integer
    '                            If Me.cboMovimientoTipo.SelectedValue = 21 Or DBO_PaletsMovimientoTipo.ID = 23 Or DBO_PaletsMovimientoTipo.ID = 26 Then
    '                                Dim capacidad As Integer = DataTableFill("PaletsProducidosCapacidadFormatoByPaletProducidoID " & m_PaletProducidoDestino.PaletProducidoID).Rows(0).Item(0)
    '                                cajasañadir = Convert.ToInt32(if(txtCajas.Text = "", 0, txtCajas.Text)) / capacidad
    '                            Else
    '                                cajasañadir = Convert.ToInt32(if(txtCajas.Text = "", 0, txtCajas.Text))
    '                            End If


    '                            'El palet Destino se queda con mas cajas de las marcadas para su Formato.
    '                            If CajasDestino + cajasañadir > CajasPaletDestino Then
    '                                'Respuesta = messagebox.show("El palet destino se queda con " & (CajasDestino + txtCajas.Text) & " cajas." & Environment.NewLine & _
    '                                Respuesta = messagebox.show("El palet destino se queda con " & CajasDestino + cajasañadir & " cajas." & Environment.NewLine & _
    '                                                       "Las cajas habituales son " & CajasPaletDestino & "." & Environment.NewLine & _
    '                                                       "¿Es correcto?", _
    '                                                       "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '                                                       " Palet completo ")
    '                                If Respuesta = DialogResult.Yes Then
    '                                    todoOk = True
    '                                Else
    '                                    txtCajas.Focus()
    '                                End If
    '                            Else
    '                                todoOk = True
    '                            End If
    '                        End If
    '                    Else
    '                        todoOk = True
    '                    End If
    '                End If

    '            Else 'No es movimiento entre palets
    '                'If txtCajas.Text > CajasOrigen Then
    '                If Convert.ToInt32(if(txtCajas.Text = "", 0, txtCajas.Text)) > Convert.ToInt32(if(Me.frmOrigen.LblCajasExisten.Text = "", 0, Me.frmOrigen.LblCajasExisten.Text)) Then
    '                    messagebox.show("No puedes mover mas cajas de las que tiene el palet." & Environment.NewLine & "Cajas:" & Me.frmOrigen.LblCajasExisten.Text, "", MessageBoxButtons.OK , MessageBoxIcon.Exclamation )
    '                    txtCajas.Focus()
    '                    todoOk = False
    '                Else
    '                    todoOk = True
    '                End If
    '            End If

    '            'If todoOk Then
    '            '    butAñadirMovimiento.Visible = True
    '            '    butAñadirMovimiento.BringToFront()
    '            'End If
    '        Else
    '            messagebox.show("Las cajas deben ser numericas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            txtCajas.Focus()
    '        End If
    '    Else
    '        messagebox.show("Debe rellenarse el campo cajas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        txtCajas.Focus()
    '    End If

    '    Return todoOk
    'End Function

    Private Sub ComprobarCantidades()
        CajasOrigen = Convert.ToInt32(Me.frmOrigen.LblCajasExisten.Text)
        'El palet Origen se queda a 0, ya no esta EnAlmacen
        'If CajasOrigen - txtCajas.Text = 0 Then
        If Me.frmOrigen.LblCajasExisten.Text - txtCajas.Text = 0 Then
            dbo_MovimientoDB.UpdatePaletsContenidosEnAlmacen(m_PaletProducidoOrigen.PaletProducidoID, False)
        End If

        If frmOrigen.txtSCC.Text <> frmDestino.txtSCC.Text Then
            'El palet Origen se queda incompleto
            'If CajasOrigen - txtCajas.Text < CajasPaletOrigen Then
            If Me.frmOrigen.LblCajasExisten.Text - txtCajas.Text < CajasPaletOrigen Then
                'Respuesta = messagebox.show("El palet origen se queda con " & (CajasOrigen - txtCajas.Text) & " cajas." & Environment.NewLine & _
                Respuesta = MessageBox.Show("El palet origen se queda con " & Convert.ToString((Me.frmOrigen.LblCajasExisten.Text) - (txtCajas.Text)) & " cajas." & Environment.NewLine & _
                    "Para estar completo deberia tener " & Convert.ToString(CajasPaletOrigen) & "." & Environment.NewLine & _
                    "¿Dejamos el palets como incompleto?", _
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Respuesta = DialogResult.Yes Then
                    dbo_MovimientoDB.UpdatePaletsContenidosTerminado(m_PaletProducidoOrigen.PaletProducidoID, False)
                Else
                    dbo_MovimientoDB.UpdatePaletsContenidosTerminado(m_PaletProducidoOrigen.PaletProducidoID, True)
                End If
            End If

            Dim cajasañadir As Integer
            ' If Me.cboMovimientoTipo.SelectedValue = 21 Or DBO_PaletsMovimientoTipo.PaletMovimientoTipoID = 23 Or DBO_PaletsMovimientoTipo.PaletMovimientoTipoID = 26 Then
            If spPaletsMovimiento.esMovimientoEncajado(Me.cboMovimientoTipo.SelectedValue) Then
                Dim capacidad As Integer = dtb.Consultar("PaletsProducidosCapacidadFormatoByPaletProducidoID " & m_PaletProducidoDestino.PaletProducidoID).Rows(0).Item(0)
                cajasañadir = If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text)) / capacidad
            Else
                cajasañadir = If(txtCajas.Text = "", 0, Convert.ToInt32(txtCajas.Text))
            End If

            'El palet Destino se queda incompleto
            If CajasDestino + cajasañadir < CajasPaletDestino And txtCajas.Text > -1 Then
                Respuesta = MessageBox.Show("El palet destino se queda con " & CajasDestino + cajasañadir & " cajas." & Environment.NewLine & _
                                   "Para estar completo deberia tener " & Convert.ToString(CajasPaletDestino) & "." & Environment.NewLine & _
                                   "¿Dejamos el palets como incompleto?", _
                                   "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Respuesta = DialogResult.Yes Then
                    dbo_MovimientoDB.UpdatePaletsContenidosTerminado(m_PaletProducidoDestino.PaletProducidoID, False)
                Else
                    dbo_MovimientoDB.UpdatePaletsContenidosTerminado(m_PaletProducidoDestino.PaletProducidoID, True)
                End If
            End If
        End If
    End Sub

    Private Sub cboMovimientoTipo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMovimientoTipo.SelectedValueChanged
        Try
            If cboMovimientoTipo.SelectedIndex = 0 Then
            Else
                Me.cboMovimientoSubTipo.mam_DataSource(dtb.Consultar("PaletsMovimientoSubTipoByTipo " & cboMovimientoTipo.SelectedValue), False)
                cboMovimientoSubTipo.Refresh()
                Dim sp As New spPaletsMovimientosTipos
                DBO_PaletsMovimientoTipo = sp.Select_Record(Me.cboMovimientoTipo.SelectedValue)
            End If

            If DBO_PaletsMovimientoTipo.EntrePalets Then
                gpbDestino.Visible = True
                lblObsPaletDestino.Visible = True
                txtObsPaletDestino.Visible = True
            Else
                gpbDestino.Visible = False
                txtObsPaletDestino.Visible = False
            End If

            lblAutorizadoPor.Visible = False
            lblReceptor.Visible = False
            lblMotivo.Visible = False
            lblCliente.Visible = False
            lblSolicitante.Visible = False

            txtAutorizadoPor.Visible = False
            txtReceptor.Visible = False
            txtMotivo.Visible = False
            txtCliente.Visible = False
            txtSolicitante.Visible = False

            If cboMovimientoTipo.Text = "Envasar" Then

            ElseIf cboMovimientoTipo.Text = "Comprar" Then

            ElseIf cboMovimientoTipo.Text = "Regalar" Then
                lblAutorizadoPor.Visible = True
                lblReceptor.Visible = True
                lblMotivo.Visible = True
                txtAutorizadoPor.Visible = True
                txtReceptor.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Rotura" Then
                lblAutorizadoPor.Visible = True
                lblMotivo.Visible = True
                txtAutorizadoPor.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Diferencia" Then
                lblMotivo.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Muestra" Then
                lblSolicitante.Visible = True
                txtSolicitante.Visible = True

            ElseIf cboMovimientoTipo.Text = "Devolucion" Then
                lblMotivo.Visible = True
                lblCliente.Visible = True
                txtMotivo.Visible = True
                txtCliente.Visible = True

            ElseIf cboMovimientoTipo.Text = "Reetiquetar" Then
                lblMotivo.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Destruir" Then
                lblAutorizadoPor.Visible = True
                lblMotivo.Visible = True
                txtAutorizadoPor.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "ManipularExt" Then
                lblReceptor.Visible = True
                lblMotivo.Visible = True
                txtReceptor.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Mover" Then

            ElseIf cboMovimientoTipo.Text = "Expedir" Then

            ElseIf cboMovimientoTipo.Text = "Bloquear" Then

            ElseIf cboMovimientoTipo.Text = "Deposito" Then

            ElseIf cboMovimientoTipo.Text = "Tipos" Then

            ElseIf cboMovimientoTipo.Text = "Anular" Then

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboMovimientoTipo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMovimientoTipo.SelectionChangeCommitted
        'Me.cboMovimientoSubTipo.mam_DataSource("PaletsMovimientoSubTipoByTipo " & cboMovimientoTipo.SelectedValue), False)
        Dim sp As String = "PaletsMovimientoSubTipoByTipo " & cboMovimientoTipo.SelectedValue
        Me.cboMovimientoSubTipo.mam_DataSource(sp, False)
        cboMovimientoSubTipo.Refresh()
    End Sub

End Class