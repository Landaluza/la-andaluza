Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPaletsContenidos2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_DBO_Envasado As DBO_Envasados2
    Private m_DBO_FormatoEnvasado As DBO_FormatosEnvasados
    Private m_DBO_PaletProducido As DBO_PaletsProducidos2
    Private m_DBO_PaletsContenidos2 As DBO_PaletsContenidos2
    Public padre As frmEntPaletsProducidos2
    Public contenidos As Integer
    Public Const COMPLETAR As Integer = 5
    Private sccMov As Integer
    Private dbo_movimiento As Dbo_PaletsMovimiento
    Private spPMovimientos As spPaletsMovimiento
    Private monodosis As DispensadorMonodosis
    Private spPaletsContenidos2 As spPaletsContenidos2
    Private spPaletsProducidos2 As spPaletsProducidos2
    Public formatoid As Integer
    Private cajasOld As Integer

    Public Sub New(ByRef PaletContenido As DBO_PaletsContenidos2)
        init(PaletContenido)
    End Sub

    Private Sub init(ByVal PaletContenido As DBO_PaletsContenidos2)
        InitializeComponent()
        m_DBO_PaletsContenidos2 = PaletContenido
        m_DBO_Envasado = DBO_Envasados2.Instance
        m_DBO_PaletProducido = DBO_PaletsProducidos2.Instance
        Me.spPMovimientos = New spPaletsMovimiento
        Dim spFormato As New spFormatosEnvasados
        spPaletsContenidos2 = New spPaletsContenidos2
        spPaletsProducidos2 = New spPaletsProducidos2
        Me.monodosis = New DispensadorMonodosis
        Me.ToolTip1.SetToolTip(Me.btnMonodosis, "muestra una lista en detalle apra seleccionar las monodosis")

        If m_DBO_PaletsContenidos2.FormatoEnvasadoID <> m_DBO_PaletProducido.FormatoID And m_DBO_PaletsContenidos2.FormatoEnvasadoID <> 0 Then
            m_DBO_FormatoEnvasado = spFormato.Select_Record(m_DBO_PaletsContenidos2.FormatoEnvasadoID)
        Else
            m_DBO_FormatoEnvasado = spFormato.Select_Record(m_DBO_PaletProducido.FormatoID)
        End If
        dtpHoraInicio.activarFoco()
        dtpHoraFin.activarFoco()
    End Sub

    Public Sub CambiarMensaje(ByVal palet As String, ByVal cajas As String)
        Me.lblCompletando.Text = "Completando palet " + palet + " que tenía " + cajas + " cajas."
    End Sub

    Overrides Sub Guardar()
        Try
            GetValores()
            If Not spPaletsContenidos2.ValidarRangoHorario(m_DBO_PaletsContenidos2, Me.m_DBO_Envasado.EnvasadoID) Then
                MessageBox.Show("La hora de produccion se suporpone con la de otro palet.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Dim modoAntesDeCambios As Integer
            BasesParaCompatibilidad.BD.EmpezarTransaccion()

            If Not padre Is Nothing Then
                modoAntesDeCambios = padre.ModoDeApertura
                If padre.ModoDeApertura = frmEntPaletsProducidos2.INSERCION Or padre.ModoDeApertura = frmEntPaletsProducidos2.INSERTAR_PRIMER_PALET And Me.ModoDeApertura <> COMPLETAR Then
                    padre.guardado()
                End If
            End If

            Select Case Me.ModoDeApertura
                Case INSERCION
                    If Not padre Is Nothing Then m_DBO_PaletsContenidos2.PaletProducidoID = padre.getPaletId()
                    m_DBO_PaletsContenidos2.EnAlmacen = True
                    padre.chbEnAlmacen.Checked = True
                    m_DBO_PaletsContenidos2.PaletContenidoID = spPaletsContenidos2.InsertPaletsContenidos2(m_DBO_PaletsContenidos2)
                Case COMPLETAR
                    m_DBO_PaletsContenidos2.Terminado = True
                    padre.chbTerminado.Checked = True
                    m_DBO_PaletsContenidos2.EnAlmacen = True
                    padre.chbEnAlmacen.Checked = True
                    m_DBO_PaletsContenidos2.PaletContenidoID = spPaletsContenidos2.InsertPaletsContenidos2(m_DBO_PaletsContenidos2)
                    spPaletsContenidos2.DarPorTerminadoPaletContenido(m_DBO_PaletsContenidos2)
                Case MODIFICACION
                    spPaletsContenidos2.UpdatePaletsContenidos2(m_DBO_PaletsContenidos2)
            End Select

            'realzia los movimientso de las monodosis
            If Me.cboMonodosis.Visible And Me.m_DBO_PaletsContenidos2.CantidadCajas <> 0 Then
                monodosis.añadirMovimientoEncajado(Me.padre, Me.cboMonodosis, Me.txtCantidadCajas.Text, _
                                                   Me.m_DBO_PaletsContenidos2, Me.spPMovimientos, Me.dbo_movimiento, _
                                                   Me.m_DBO_FormatoEnvasado)

                Dim indice As Integer = Me.cboMonodosis.SelectedIndex
                Dim cont As Integer
                For cont = 0 To cboMonodosis.Items.Count - 1
                    Dim datarow As DataRowView = cboMonodosis.Items(cont)
                    If datarow.Item(4) = 3 Then indice = indice - 1
                Next

                ' If Me.cboMonodosis.SelectedIndex > 0 Then
                If indice > 0 Then
                    Dim resp As DialogResult = MessageBox.Show("El palet desde el que se envasa no es el mas antiguo, ¿se han quedado sin cantidad los anteriores?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If resp = DialogResult.Yes Then
                        monodosis.realizarDiferencia(Me.cboMonodosis)
                    End If
                End If
            Else
                If Not Me.SplitContainer1.Panel2Collapsed And Me.m_DBO_PaletsContenidos2.CantidadCajas <> 0 Then
                    For Each p As Object In Me.PanDoyPack.Controls
                        If TypeOf p Is Panel Then
                            For Each c As Object In p.Controls
                                If TypeOf c Is ComboBox Then
                                    monodosis.añadirMovimientoEncajado(Me.padre, c, Me.txtCantidadCajas.Text, _
                                                                       Me.m_DBO_PaletsContenidos2, Me.spPMovimientos, _
                                                                       Me.dbo_movimiento, Me.m_DBO_FormatoEnvasado, True)

                                    Dim indice As Integer = c.SelectedIndex
                                    Dim cont As Integer
                                    For cont = 0 To c.Items.Count - 1
                                        Dim datarow As DataRowView = c.Items(cont)
                                        If datarow.Item(4) = 3 Then indice = indice - 1
                                    Next

                                    If indice > 0 Then
                                        Dim panCbo As Panel = c.parent
                                        Dim nombre As String = "Alerta"

                                        For Each obj As Object In panCbo.Controls
                                            If TypeOf obj Is Label Then
                                                If obj.forecolor <> Color.Red Then
                                                    nombre = obj.text
                                                End If
                                            End If
                                        Next

                                        Dim resp As DialogResult = MessageBox.Show("El palet desde el que se envasa no es el mas antiguo, ¿se han quedado sin cantidad los anteriores?", nombre, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                        If resp = DialogResult.Yes Then
                                            monodosis.realizarDiferencia(c)
                                        End If
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            End If

            'da por terminado el PaletContenido (Palet) actual


            If m_DBO_PaletsContenidos2.Terminado Then
                spPaletsContenidos2.DarPorTerminadoPaletContenido(m_DBO_PaletsContenidos2)
                padre.chbTerminado.Checked = True
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                If Not padre Is Nothing Then Me.padre.ModoDeApertura = modoAntesDeCambios
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

            If (Me.cajasOld <> Me.m_DBO_PaletsContenidos2.CantidadCajas And Me.cajasOld <> 0 And modoAntesDeCambios = MODIFICACION) Or modoAntesDeCambios <> MODIFICACION Or Me.ModoDeApertura = COMPLETAR Then
                If Not padre Is Nothing Then padre.etiquetar()
            End If

            BasesParaCompatibilidad.BD.TerminarTransaccion()
            Me.Hide()
        Catch ex As Exception
            BasesParaCompatibilidad.BD.CancelarTransaccion()
            MessageBox.Show("Error al guardar, se BasesParaCompatibilidad.BD.Cerrará la ventana. Detalles:" & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Me.Close()
        End Try
    End Sub

    'Private Function checktxt() As Boolean
    '    If Not IsNumeric(txtCantidadCajas.Text) Then
    '        messagebox.show("Introduzca una cantidad de cajas numerica.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Return True

    '    ElseIf dtpHoraFin.Value > dtpHoraInicio.Value Then
    '        MessageBox.Show("La hora de final debe ser mayor que la inicial", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Return True

    '    elseIf Convert.ToInt32(txtCantidadCajas.Text) > m_DBO_PaletsContenidos2.NroCajasCompletar And Convert.ToInt32(txtCantidadCajas.Text) > 0 Then
    '        If messagebox.show("Las cajas por palet superan lo normal, ¿Es correcto?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) = DialogResult.Yes Then
    '            Me.padre.chbTerminado.Checked = True
    '        Else
    '            txtCantidadCajas.Text = m_DBO_PaletsContenidos2.NroCajasCompletar
    '            Me.padre.chbTerminado.Checked = False
    '            Return True
    '        End If
    '    End If

    '    Return False
    'End Function

    Overrides Sub SetValores()
        Dim CajasCompletarAux As Integer = m_DBO_PaletsContenidos2.NroCajasCompletar
        m_DBO_PaletsContenidos2.LineaID = m_DBO_PaletProducido.LineaID

        If ModoDeApertura = MODIFICACION Then
            Dim aux As Integer = m_DBO_PaletsContenidos2.NroCajasCompletar

            CajasCompletarAux = m_DBO_PaletsContenidos2.NroCajasCompletar
            m_DBO_PaletsContenidos2 = spPaletsContenidos2.Select_Record(m_DBO_PaletsContenidos2.PaletContenidoID)
            CajasCompletarAux = m_DBO_PaletsContenidos2.CantidadCajas
            m_DBO_PaletsContenidos2.NroCajasCompletar = aux

            If Not padre Is Nothing Then
                m_DBO_PaletsContenidos2.LineaID = padre.m_DBO_Envasado.LineaID
            Else
                If Me.Enabled Then Me.cbScc.SelectedValue = m_DBO_PaletsContenidos2.PaletProducidoID
            End If

            txtCantidadCajas.Text = m_DBO_PaletsContenidos2.CantidadCajas.ToString
        Else
            If ModoDeApertura = COMPLETAR Then
                CajasCompletarAux = m_DBO_PaletsContenidos2.CantidadCajas
                If CajasCompletarAux < 0 Then CajasCompletarAux = 0
            End If

            m_DBO_PaletsContenidos2.NroCajasCompletar = CajasCompletarAux
            txtCantidadCajas.Text = m_DBO_PaletsContenidos2.NroCajasCompletar.ToString
        End If

        txtPaletContenidoID.Text = m_DBO_PaletsContenidos2.PaletContenidoID.ToString
        dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_PaletsContenidos2.HoraInicio)
        dtpHoraFin.Value = DateTime.Now.Date.Add(m_DBO_PaletsContenidos2.HoraFin)

        If dtpHoraFin.Value.Day <> dtpHoraInicio.Value.Day Then
            dtpHoraFin.Value = dtpHoraInicio.Value.AddMinutes(1)
        End If

        Me.padre.chbTerminado.Checked = m_DBO_PaletsContenidos2.Terminado
        Me.padre.chbEnAlmacen.Checked = m_DBO_PaletsContenidos2.EnAlmacen
        txtObservaciones.Text = m_DBO_PaletsContenidos2.Observaciones
        txtPartePaletContenido.Text = m_DBO_PaletsContenidos2.PartePaletContenidoID.ToString
        Me.cajasOld = m_DBO_PaletsContenidos2.CantidadCajas
    End Sub

    Private Sub GetValores()
        Try
            m_DBO_PaletsContenidos2.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
            m_DBO_PaletsContenidos2.HoraFin = New TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0)
            m_DBO_PaletsContenidos2.CantidadCajas = System.Convert.ToInt32(txtCantidadCajas.Text)
            'm_DBO_PaletsContenidos2.PaletProducidoID = m_DBO_PaletsContenidos2.PaletProducidoID
            m_DBO_PaletsContenidos2.PartePaletContenidoID = (If(m_DBO_PaletsContenidos2.PartePaletContenidoID = 0, Nothing, m_DBO_PaletsContenidos2.PartePaletContenidoID))
            m_DBO_PaletsContenidos2.Terminado = Me.padre.chbTerminado.Checked
            m_DBO_PaletsContenidos2.EnAlmacen = Me.padre.chbEnAlmacen.Checked
            m_DBO_PaletsContenidos2.Observaciones = System.Convert.ToString(If(txtObservaciones.Text = "", Nothing, txtObservaciones.Text))
            If Me.ModoDeApertura = COMPLETAR Then
                m_DBO_PaletsContenidos2.FormatoEnvasadoID = Me.formatoid
            Else
                If ModoDeApertura <> MODIFICACION Then m_DBO_PaletsContenidos2.FormatoEnvasadoID = m_DBO_FormatoEnvasado.ID
            End If
            m_DBO_PaletsContenidos2.FechaModificacion = System.DateTime.Now.Date
            m_DBO_PaletsContenidos2.UsuarioModificacion = BasesParaCompatibilidad.Config.User

            'If Me.cboMonodosis.Visible Then Me.sccMov = Me.cboMonodosis.SelectedValue
        Catch ex As Exception
            MessageBox.Show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpHoraFin_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpHoraFin.Validating
        Dim ts1 As New DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day, _
                                dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        Dim ts2 As New DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day, _
                                dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0)

        If ts1 > ts2 Then
            MessageBox.Show("La hora de final debe ser mayor que la inicial", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub


    Private Sub ValidarPaletTerminado()
        Try
            If Convert.ToInt32(txtCantidadCajas.Text) >= (m_DBO_PaletsContenidos2.NroCajasCompletar) And Convert.ToInt32(txtCantidadCajas.Text) > 0 Then
                Me.padre.chbTerminado.Checked = True
            Else
                Me.padre.chbTerminado.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCantidadCajas_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCantidadCajas.TextChanged
        If Not IsNumeric(txtCantidadCajas.Text) Then
            MessageBox.Show("introduzca solo numeros", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCantidadCajas.SelectAll()
            Return
        Else
            Try
                If Convert.ToInt32(txtCantidadCajas.Text) >= (m_DBO_PaletsContenidos2.NroCajasCompletar) Then
                    Me.padre.chbTerminado.Checked = True
                Else
                    Me.padre.chbTerminado.Checked = False
                End If
            Catch ex As Exception
                MessageBox.Show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public Overrides Sub salir()
        If Not padre Is Nothing Then
            If (Me.padre.ModoDeApertura = frmEntPaletsProducidos2.INSERTAR_PRIMER_PALET Or Me.padre.ModoDeApertura = frmEntPaletsProducidos2.INSERCION) And (Me.contenidos = Nothing Or Me.contenidos = 0) Then
                padre.Close()
            End If
        End If
        Me.Dispose()
    End Sub

    Private Sub cbScc_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cbScc.SelectionChangeCommitted
        Try
            If Me.cbScc.Enabled Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                Me.Enabled = False

                m_DBO_PaletProducido = spPaletsProducidos2.Select_Record((Me.cbScc.SelectedValue))
                spPaletsProducidos2.scc = m_DBO_PaletProducido.SCC.ToString

                Dim aux As DBO_FormatosEnvasados
                Dim spFormatosEnvasados As New spFormatosEnvasados
                Dim spEnvasados2 As New spEnvasados2
                Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)

                aux = spFormatosEnvasados.Select_Record(m_DBO_PaletProducido.FormatoID)
                m_DBO_Envasado = spEnvasados2.Select_Record(aux.EnvasadoID)

                spPaletsProducidos2.CompletarPaletContenido(m_DBO_PaletProducido)
                m_DBO_PaletsContenidos2.NroCajasCompletar = m_DBO_PaletProducido.NroCajasCompletar

                Dim HoraInicioAux As Object = dtb.Consultar("execPaletsProducidos2GetUltimaHoraProduccionPorLinea2 " & aux.TipoFormatoLineaID & ", " & m_DBO_Envasado.EnvasadoID).Rows(0).Item(0)
                m_DBO_PaletsContenidos2.HoraInicio = If(HoraInicioAux Is Convert.DBNull, New TimeSpan(6, 55, 0), HoraInicioAux)
                m_DBO_PaletsContenidos2.HoraFin = m_DBO_PaletsContenidos2.HoraInicio.Add(New TimeSpan(0, 15, 0))

                SetValores()
            End If
        Catch ex As Exception
        Finally
            Me.Enabled = True
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub frmEntPaletsContenidos2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        If Me.padre Is Nothing Then
            Me.cbScc.mam_DataSource("paletsProducidosSelectCboScc", False)
            Me.cbScc.Visible = True
            Me.lblScc.Visible = True
        Else
            If Me.padre.ModoDeApertura = INSERCION And Me.ModoDeApertura <> COMPLETAR Then Me.padre.TimerSSCC.Start()
        End If

        SetValores()
        ModificarBindingNavigator()

        If Me.ModoDeApertura = VISION Then
            Me.butGuardar.Visible = False
        ElseIf ModoDeApertura = MODIFICACION Then
            Me.cbScc.Enabled = False
        End If

        If spPMovimientos.comprobarFormatoEncajado(Me.m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID) Then
            If Me.ModoDeApertura = INSERCION Or ModoDeApertura = COMPLETAR Then
                If Not Me.monodosis.EsDoyPack(Me.m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID) Then

                    Me.SplitContainer1.Panel2Collapsed = True
                    Me.cboMonodosis.Visible = True
                    Me.Label1.Visible = True
                    Me.btnMonodosis.Visible = True

                    spPaletsContenidos2.cargarComboDetallesMonodosis(Me.cboMonodosis, Me.m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID)

                    If Me.ModoDeApertura = INSERCION Or ModoDeApertura = COMPLETAR Then
                    Else

                        Me.dbo_movimiento = spPMovimientos.Select_RecordByContenidoPalet(Me.m_DBO_PaletsContenidos2.PaletContenidoID)
                        Me.dbo_movimiento = spPMovimientos.Select_RecordByContenidoPalet(Me.m_DBO_PaletsContenidos2.PaletContenidoID)
                        cboMonodosis.SelectedValue = dbo_movimiento.PaletID

                        If Me.ModoDeApertura = MODIFICACION Then
                        Else

                            Me.cboMonodosis.Enabled = False
                            Me.Label1.Enabled = False
                            Me.btnMonodosis.Enabled = False
                        End If
                    End If
                Else
                    Dim distance As Integer = Me.Width
                    Me.Width = Me.Width + 400
                    Me.SplitContainer1.Panel2Collapsed = False
                    Me.SplitContainer1.SplitterDistance = distance
                    Me.cboMonodosis.Visible = False
                    Me.Label1.Visible = False
                    Me.btnMonodosis.Visible = False

                    Me.monodosis.CargarMonodosis(Me.PanDoyPack, Me.m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID)
                    'cargar los combos de monodosis correspondientes
                End If
            Else
                Dim distance As Integer = Me.Width
                Me.SplitContainer1.Panel2Collapsed = True
                Me.cboMonodosis.Visible = False
                Me.Label1.Visible = False
                Me.btnMonodosis.Visible = False
                Me.txtCantidadCajas.Enabled = False
            End If
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub txtPartePaletContenido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPartePaletContenido.TextChanged
        Try
            If Me.ModoDeApertura = COMPLETAR Then
                lblCompletando.Visible = True
            Else
                lblCompletando.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnMonodosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonodosis.Click
        Dim mono As New frmContenidosDetallesMonodosis2(Me.m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID)
        mono.ShowDialog()
        Me.cboMonodosis.SelectedValue = mono.id
    End Sub

    Private Sub cboMonodosis_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboMonodosis.SelectedValueChanged
        If Me.cboMonodosis.SelectedItem(4) = 3 Then
            Me.lnoconforme.Visible = True
            cboMonodosis.BackColor = Color.Red
        Else
            Me.lnoconforme.Visible = False
            cboMonodosis.BackColor = Color.White
        End If
    End Sub


End Class
