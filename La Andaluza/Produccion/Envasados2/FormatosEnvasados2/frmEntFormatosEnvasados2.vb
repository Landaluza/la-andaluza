Public Class frmEntFormatosEnvasados2
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Tabla As DataTable
    Public m_DBO_Envasado As DBO_Envasados2
    Public m_DBO_FormatoEnvasado As DBO_FormatosEnvasados
    Private m_linea As Integer
    Private m_CantidadEnvasada As Integer
    Private frHijo as BasesParaCompatibilidad.FrmAheredarOld
    Private spFormatosEnvasados As spFormatosEnvasados

    Private tsIncidencias As ToolStripItem
    Private tsIncidencias2 As ToolStripItem
    Private tsIncidencias3 As ToolStripItem
    Private tsIncidencias4 As ToolStripItem
    Private tsIncidencias5 As ToolStripItem
    Private tsIncidencias6 As ToolStripItem
    Private tsEspecificaciones As ToolStripItem

    Private frPalets As frmPaletsProducidos
    Private frmControlesCalidadEnvasados2 As frmEnvasadosControles
    Private frmIncidencias2 As frmIncidencias
    Private frmPropuestas2 As frmPropuestas2
    Private frmVelocidadEnvasados2 As frmVelocidadEnvasados2
    Private frmEnvasadosProductosArticulos As frmEnvasadosProductosArticulos_NO_USAR
    Private frmParadaOrdenadas2 As frmParadaOrdenadas2
    Private frmMaterialesEnvasados2 As frmMaterialesEnvasados2
    Private frmCambiosFormatosEnvasados2 As frmCambiosFormatosEnvasados2
    Private frmResumen As frmResumen
    Private frmempleados_formatosEnvasados As frmempleados_formatosEnvasados
    Private frmPartesEnvasados_CausasPartesEnvasado As frmPartesEnvasados_CausasPartesEnvasado
    Private frmPersonal As frmEntPersonalEnvasado
    Private frmPersonalOcupado As frmPersonalEnvasadoOcupado
    Private spFormatosEnvasados2 As spFormatosEnvasados2
    Private frmEntCambiosFormatosEnvasados2 As frmEntCambiosFormatosEnvasados2
    Private spTiposFormatosLineas As spTiposFormatosLineas
    Private spArticulosEnvasadosHistoricos As spArticulosEnvasadosHistoricos
    Public Sub New(ByVal modo As String, ByVal linea As Integer)
        MyBase.New(modo)
        InitializeComponent()
        m_DBO_Envasado = DBO_Envasados2.Instance
        m_DBO_FormatoEnvasado = Nothing
        Me.m_linea = linea
        spFormatosEnvasados = New spFormatosEnvasados
        spFormatosEnvasados2 = New spFormatosEnvasados2
        spTiposFormatosLineas = New spTiposFormatosLineas
        spArticulosEnvasadosHistoricos = New spArticulosEnvasadosHistoricos

        Dim s4 As New spTiposProductos
        s4.cargar_ComboBox_para_envasado_por_Linea(Me.cboTipoProducto, Me.m_DBO_Envasado.LineaID, dtb)

        tpgProduccion.Controls.Remove(tpgProduccion.TabPages("tpEspecificaciones"))
        tpgProduccion.Controls.Remove(tpgProduccion.TabPages("tpSeguimientos"))
    End Sub

    Public Sub New(ByVal modo As String, ByVal CantidadEnvasada As Integer, ByVal m_dbo As DBO_FormatosEnvasados, ByVal linea As Integer)
        Me.New(modo, linea)

        m_CantidadEnvasada = CantidadEnvasada
        m_DBO_FormatoEnvasado = m_dbo

        m_DBO_FormatoEnvasado = spFormatosEnvasados.Select_Record(m_DBO_FormatoEnvasado.ID, dtb)

        If Config.UserType = 4 Or Config.UserType = 9 Then
            Me.Panel2.Visible = True
            Me.cboTipoFormatoID.Enabled = True
            Me.cboTipoFormatoLinea.Enabled = True
            Me.cboTipoProducto.Enabled = True

        Else
            Me.Panel2.Visible = False
            Me.cboTipoFormatoID.Enabled = False
            Me.cboTipoFormatoLinea.Enabled = False
            Me.cboTipoProducto.Enabled = False

        End If

        Me.tpgProduccion.Visible = True
        Me.tpgProduccion.Enabled = True
        Me.cargar_formularios()
        Me.añadirMenu()
    End Sub



    Private Sub añadirMenu()
        If Config.UserType = 4 Then
            Return
        End If

        Me.tsIncidencias = Me.bdnGeneral.Items.Add("Incidencia Calidad")
        tsIncidencias.Text = "&Calidad (Alt+c)"
        tsIncidencias.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsIncidencias.Image = My.Resources.edit_add_2
        tsIncidencias.Tag = 7
        AddHandler tsIncidencias.Click, AddressOf frmIncidencias2.InsertarInc

        Me.tsIncidencias2 = Me.bdnGeneral.Items.Add("Incidencia Mecanica")
        tsIncidencias2.Text = "&Mecanica (Alt+m)"
        tsIncidencias2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsIncidencias2.Image = My.Resources.edit_add_2
        tsIncidencias2.Tag = 8
        AddHandler tsIncidencias2.Click, AddressOf frmIncidencias2.InsertarInc

        Me.tsIncidencias3 = Me.bdnGeneral.Items.Add("Incidencia Intrinseca")
        tsIncidencias3.Text = "&Intrinsecas (Alt+i)"
        tsIncidencias3.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsIncidencias3.Image = My.Resources.edit_add_2
        tsIncidencias3.Tag = 9
        AddHandler tsIncidencias3.Click, AddressOf frmIncidencias2.InsertarInc

        Me.tsIncidencias4 = Me.bdnGeneral.Items.Add("Incidencia Gestion")
        tsIncidencias4.Text = "&Gestion (Alt+g)"
        tsIncidencias4.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsIncidencias4.Image = My.Resources.edit_add_2
        tsIncidencias4.Tag = 10
        AddHandler tsIncidencias4.Click, AddressOf frmIncidencias2.InsertarInc

        Me.tsIncidencias5 = Me.bdnGeneral.Items.Add("Incidencia Planificada")
        tsIncidencias5.Text = "&Planificadas(Alt+p)"
        tsIncidencias5.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsIncidencias5.Image = My.Resources.edit_add_2
        tsIncidencias5.Tag = 11
        AddHandler tsIncidencias5.Click, AddressOf frmIncidencias2.InsertarInc

        Me.tsIncidencias6 = Me.bdnGeneral.Items.Add("Indencia Recuperables")
        tsIncidencias6.Text = "&Recuperables (Alt+r)"
        tsIncidencias6.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsIncidencias6.Image = My.Resources.edit_add_2
        tsIncidencias6.Tag = 12
        AddHandler tsIncidencias6.Click, AddressOf frmIncidencias2.InsertarInc

        Me.tsEspecificaciones = Me.bdnGeneral.Items.Add("Ver especificaciones")
        tsEspecificaciones.Text = "Ver &Especificaciones (Alt+e)"
        tsEspecificaciones.Tag = 0
        tsEspecificaciones.DisplayStyle = ToolStripItemDisplayStyle.Text
        AddHandler tsEspecificaciones.Click, AddressOf ButEspecificaciones_Click
    End Sub

    Private Sub frmEntFormatosEnvasados2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If m_DBO_Envasado.EnvasadoID = 0 Or m_DBO_Envasado.EnvasadoID = Nothing Then
            messagebox.show("Debe guardar antes el envasado.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Dispose()
            Return
        End If

        If Me.ModoDeApertura = MODIFICACION Then
            añadirFormularios()
        End If


        SetValores()


        If Me.ModoDeApertura = BasesParaCompatibilidad.FrmAHeredarEntOld.INSERCION Then
            'Me.deshabilitarAcciones()
            Me.tpgProduccion.Enabled = False
            Me.tpgProduccion.Visible = False
            SplitContainer1.Panel1Collapsed = True
            SplitContainer1.Panel2Collapsed = False

            frmPersonal = New frmEntPersonalEnvasado(Me.m_DBO_Envasado.LineaID, Me.m_DBO_Envasado.EnvasadoID, True)
            frmPersonal.Formato_Envasado = Me.m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID
            Engine_LA.FormEnPestaña(frmPersonal, Me.SplitContainer1.Panel2)
        End If

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub cargar_formularios()
        'frPalets = New frmPaletsProducidos2(Me.m_DBO_FormatoEnvasado.ID, True)
        frPalets = New frmPaletsProducidos(Me.m_linea, Me.m_DBO_FormatoEnvasado.ID, Me.m_DBO_FormatoEnvasado.EnvasadoID)

        frmControlesCalidadEnvasados2 = New frmEnvasadosControles(Me.m_DBO_FormatoEnvasado.ID, Me.m_DBO_Envasado.LineaID, True, Me)

        frmIncidencias2 = New frmIncidencias(Me.m_DBO_FormatoEnvasado.ID)  '(1, Me.m_DBO_FormatoEnvasado.FormatoEnvasadoID, Me.m_DBO_Envasado.EnvasadoID, m_linea, True, Me) '1 = Categoria Mecanica

        frmPropuestas2 = New frmPropuestas2(Me.m_DBO_FormatoEnvasado.ID, True, Me)

        frmVelocidadEnvasados2 = New frmVelocidadEnvasados2(Me.m_DBO_FormatoEnvasado.ID, True, Me)

        Dim m_Tabla As DataTable
        Dim m_TipoProductoID As Integer
        Dim m_Descripcion As String = ""
        Try
            dtb.PrepararConsulta("TiposFormatosSelectDgvByTipoFormatoEnvasadoID @id")
            dtb.AñadirParametroConsulta("@id", m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID)
            m_Tabla = dtb.Consultar()
            m_TipoProductoID = m_Tabla.Rows(0).Item("TipoProductoID")
            m_Descripcion = m_Tabla.Rows(0).Item("Descripcion")
        Catch ex As Exception
        End Try
        frmEnvasadosProductosArticulos = New frmEnvasadosProductosArticulos_NO_USAR(m_DBO_FormatoEnvasado.ID, m_TipoProductoID, m_Descripcion, m_CantidadEnvasada, True, Me)

        frmParadaOrdenadas2 = New frmParadaOrdenadas2(Me.m_DBO_FormatoEnvasado.ID, True, Me)

        frmMaterialesEnvasados2 = New frmMaterialesEnvasados2(Me.m_DBO_FormatoEnvasado.ID, True, Me)

        frmCambiosFormatosEnvasados2 = New frmCambiosFormatosEnvasados2(Me.m_DBO_FormatoEnvasado.ID, True, Me) 'Me.m_DBO_FormatoEnvasado.ID, Me.m_linea)

        ' frmResumen = New frmResumen(Me, True)

        frmempleados_formatosEnvasados = New frmempleados_formatosEnvasados(Me.m_DBO_FormatoEnvasado.ID)

        Me.frmPersonalOcupado = New frmPersonalEnvasadoOcupado(Me.m_DBO_FormatoEnvasado.EnvasadoID)
    End Sub

    Private Sub añadirFormularios()
        Engine_LA.FormEnPestaña(frPalets, tpPalets)

        Engine_LA.FormEnPestaña(frmControlesCalidadEnvasados2, tpControlesCalidad)

        Engine_LA.FormEnPestaña(frmIncidencias2, tpIncidencias)

        Engine_LA.FormEnPestaña(frmPropuestas2, tpPropuestas)

        Engine_LA.FormEnPestaña(frmVelocidadEnvasados2, tpVelocidad)

        Engine_LA.FormEnPestaña(frmEnvasadosProductosArticulos, tpProducto)

        Engine_LA.FormEnPestaña(frmParadaOrdenadas2, tpTiempoAsignado)

        Engine_LA.FormEnPestaña(frmMaterialesEnvasados2, tpTrazabilidadMatAux)

        Engine_LA.FormEnPestaña(frmCambiosFormatosEnvasados2, tpCambiosFormatos)

        'Engine_LA.FormEnPestaña(frmResumen, tpResumen)

        Engine_LA.FormEnPestaña(Me.frmempleados_formatosEnvasados, panEmpleados) 'tpFormatos_empleados)

        Engine_LA.FormEnPestaña(Me.frmPersonalOcupado, PanPersonalOcupados)
    End Sub

    Private Sub habilitarAcciones()
        Me.tpgProduccion.Enabled = True
        Me.añadirFormularios()
    End Sub

    Private Sub deshabilitarAcciones()
        Me.tpgProduccion.Enabled = False
    End Sub

    Overrides Sub Guardar()
        Dim cargar As Boolean = False
        Dim formato As Integer

            If Me.ModoDeApertura = MODIFICACION Then
                dtb.EmpezarTransaccion()
                Try

                    If Config.UserType = 4 Or Config.UserType = 9 Then
                        GetValores()
                        m_DBO_FormatoEnvasado.EnvasadoID = m_DBO_Envasado.EnvasadoID
                        If Not spFormatosEnvasados2.GrabarFormatosEnvasados2(m_DBO_FormatoEnvasado, dtb) Then
                            Throw New Exception("no se pudo grabar el formato")
                        End If
                    End If

                    dtb.TerminarTransaccion()
                    Me.Close()
                Catch ex As Exception
                dtb.CancelarTransaccion()
                MessageBox.Show("Asegurese de seleccionar antes el formato" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                End Try
                
        Else

            If Not Me.frmPersonal.getVAlores Then
                MessageBox.Show("Revise los datos del personal", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                If Convert.ToString(cboTipoFormatoLinea.SelectedValue) = "System.Data.DataRowView" Or cboTipoFormatoID.SelectedValue.ToString = "System.Data.DataRowView" Then
                    MessageBox.Show("Seleccione un formato", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
            Catch ex As Exception
                MessageBox.Show("Seleccione un formato", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End Try

            dtb.EmpezarTransaccion()

            Try

                GetValores()
                m_DBO_FormatoEnvasado.EnvasadoID = m_DBO_Envasado.EnvasadoID

                If Not spFormatosEnvasados2.GrabarFormatosEnvasados2(m_DBO_FormatoEnvasado, dtb) Then
                    Throw New Exception("No se pudo grabar el formato")
                End If

                If Not frmPersonal.guardar(m_DBO_FormatoEnvasado.ID, dtb) Then
                    Throw New Exception("No se pudo grabar el personal")
                End If

                formato = spFormatosEnvasados2.recuperarUltimoFormatoEnvasado(Me.m_DBO_Envasado, dtb)


                dtb.TerminarTransaccion()
                cargar = True

            Catch ex As Exception
                dtb.CancelarTransaccion()
                MessageBox.Show("Asegurese de seleccionar antes el formato" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        If cargar Then
            MyBase.Guardar()
            SetValores()
            Me.tpgProduccion.Visible = True
            cargar_formularios()
            Me.añadirFormularios()
            Me.habilitarAcciones()
            Me.añadirMenu()



            If formato <> Me.m_DBO_FormatoEnvasado.TipoFormatoLineaID Then
                Dim Respuesta As DialogResult
                Respuesta = MessageBox.Show(" El formato no coincide con el ultimo envasado" & Environment.NewLine & _
                                    "¿Desea crear un cambio de formato?", _
                                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Respuesta = DialogResult.Yes Then
                    Dim m_CambiosFormatosEnvasados2 As New DBO_CambiosFormatosEnvasados2
                    m_CambiosFormatosEnvasados2.CambioFormatoEnvasadoId = 0
                    m_CambiosFormatosEnvasados2.HoraInicio = DateTime.Now.TimeOfDay
                    m_CambiosFormatosEnvasados2.HoraFin = DateTime.Now.TimeOfDay
                    m_CambiosFormatosEnvasados2.FormatoEnvasadoAID = Me.m_DBO_FormatoEnvasado.ID

                    'Dim m_CambiosFormatosEnvasados2 As New DBO_CambiosFormatosEnvasados
                    'm_CambiosFormatosEnvasados2.ID = 0
                    'm_CambiosFormatosEnvasados2.HoraInicio = Me.m_DBO_Envasado.Fecha
                    'm_CambiosFormatosEnvasados2.HoraFin = Me.m_DBO_Envasado.Fecha
                    'm_CambiosFormatosEnvasados2.FormatoEnvasadoAID = Me.m_DBO_FormatoEnvasado.ID

                    frmEntCambiosFormatosEnvasados2 = New frmEntCambiosFormatosEnvasados2(BasesParaCompatibilidad.FrmAheredarOld.ACCION_INSERTAR, m_CambiosFormatosEnvasados2, 0, 0, Me.m_DBO_FormatoEnvasado.ID)
                    'frmEnt = New frmEntCambiosFormatosEnvasados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spCambiosFormatosEnvasados, m_CambiosFormatosEnvasados2)

                    frmEntCambiosFormatosEnvasados2.ShowDialog()
                End If
            End If
        End If
    End Sub

    Friend Sub GetValores()
        m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID = cboTipoFormatoID.SelectedValue
        m_DBO_FormatoEnvasado.TipoFormatoLineaID = cboTipoFormatoLinea.SelectedValue
    End Sub

    Overrides Sub SetValores()


        If Not m_DBO_FormatoEnvasado Is Nothing Then
            If Not (m_DBO_FormatoEnvasado.TipoFormatoLineaID = Nothing Or m_DBO_FormatoEnvasado.TipoFormatoLineaID = 0) Then

                Dim dboPFormato As DBO_ArticulosEnvasadoHistorico = spArticulosEnvasadosHistoricos.Select_Record(m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID, dtb)
                If Not dboPFormato Is Nothing Then
                    cboTipoProducto.SelectedValue = dboPFormato.TipoProductoID
                    cboTipoFormatoLinea.SelectedValue = m_DBO_FormatoEnvasado.TipoFormatoLineaID
                    cboTipoFormatoID.SelectedValue = m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID
                End If
            Else
                cboTipoFormatoLinea.SelectedIndex = 0
            End If
        Else
            m_DBO_FormatoEnvasado = New DBO_FormatosEnvasados
        End If


        If Me.ModoDeApertura = MODIFICACION Then
            If Config.UserType = 4 Or Config.UserType = 9 Then
                Me.Panel2.Visible = True
                Me.cboTipoFormatoID.Enabled = True
                Me.cboTipoFormatoLinea.Enabled = True
                Me.cboTipoProducto.Enabled = True

            Else
                Me.Panel2.Visible = False
                Me.cboTipoFormatoID.Enabled = False
                Me.cboTipoFormatoLinea.Enabled = False
                Me.cboTipoProducto.Enabled = False

            End If
            SplitContainer1.Panel1Collapsed = False
            SplitContainer1.Panel2Collapsed = True
        End If

        Me.Text = Me.Text & " | " & cboTipoFormatoID.Text
    End Sub

    Private Sub ButEspecificaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If tsEspecificaciones.Tag = 0 Then
            Try
                If cboTipoFormatoID.SelectedValue <> 0 Then
                    pnlEspecificaciones.Visible = True
                    'tpgProduccion.Visible = False
                    tsEspecificaciones.Text = "BasesParaCompatibilidad.BD.Cerrar &Especificaciones (Alt+e)"
                    tsEspecificaciones.Tag = 0
                End If
            Catch ex As Exception
                pnlEspecificaciones.Visible = False
                'tpgProduccion.Visible = True
            End Try
        Else
            pnlEspecificaciones.Visible = False
            tpgProduccion.Visible = True
            tsEspecificaciones.Text = "Ver &Especificaciones (Alt+e)"
            tsEspecificaciones.Tag = 1
        End If
    End Sub

    Private Sub cboTipoFormatoLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoFormatoLinea.SelectedIndexChanged
        Try
            If Convert.ToString(cboTipoFormatoLinea.SelectedValue) <> "System.Data.DataRowView" Then
                spArticulosEnvasadosHistoricos.cargar_comboByTipoFormatoLineaYtipoProducto(cboTipoFormatoID, cboTipoFormatoLinea.SelectedValue, cboTipoProducto.SelectedValue, dtb)
                Dim spFormatosEnvasados As New spFormatosEnvasados
                cboTipoFormatoID.SelectedValue = spFormatosEnvasados.FormatoHabitualPorEncajadoLinea(Me.m_DBO_Envasado.LineaID, Me.cboTipoFormatoLinea.SelectedValue, dtb)
            End If
        Catch ex As Exception
            cboTipoFormatoID.SelectedValue = 0
        End Try
    End Sub

    Private Sub frmEntFormatosEnvasados2_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ModificarBindingNavigator()
    End Sub

    Private Sub cboTipoFormatoID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoFormatoID.SelectedValueChanged
        Try
            frmFormatosEnvasados2.CadenaFormato = Me.cboTipoFormatoID.Text
        Catch ex As Exception
        End Try

        If Me.ModoDeApertura = INSERCION Then
            Try
                Me.frmPersonal.Formato_Envasado = cboTipoFormatoID.SelectedValue
            Catch ex As Exception

            End Try

            Try
                Me.frmPersonal.Formato_Linea = Me.cboTipoFormatoLinea.SelectedValue
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cboTipoProducto_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoProducto.SelectedValueChanged
        Try
            If Convert.ToString(cboTipoProducto.SelectedValue) <> "System.Data.DataRowView" Then                
                spTiposFormatosLineas.cargar_TiposFormatosLineas_por_linea_envasado_tipoProducto(cboTipoFormatoLinea, m_DBO_Envasado.LineaID.ToString, cboTipoProducto.SelectedValue, dtb)
            End If
        Catch ex As Exception
            cboTipoProducto.SelectedValue = 0
        End Try
    End Sub



End Class