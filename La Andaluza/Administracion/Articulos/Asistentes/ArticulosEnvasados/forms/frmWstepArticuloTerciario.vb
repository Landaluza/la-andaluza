Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmWstepArticuloTerciario
    Implements wizardable
    Private m_DBO_ArticulosEnvasesTerciarios1 As DBO_ArticulosEnvasesTerciarios
    Private spArticulosEnvasesTerciarios As spArticulosEnvasesTerciarios
    Private mododeApertura As Integer
    Public Event actualizarExtras()
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        spArticulosEnvasesTerciarios = New spArticulosEnvasesTerciarios
        Me.m_DBO_ArticulosEnvasesTerciarios1 = New DBO_ArticulosEnvasesTerciarios
        Me.mododeApertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION
        Me.panSecundario.Visible = False
    End Sub

    Public Sub New(ByVal articuloid As Integer)
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        spArticulosEnvasesTerciarios = New spArticulosEnvasesTerciarios
        Me.m_DBO_ArticulosEnvasesTerciarios1 = spArticulosEnvasesTerciarios.Select_RecordByArticuloID(articuloid, dtb)
        establecerValores()
        Me.mododeApertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION
        Me.panSecundario.Visible = True
    End Sub

    Public WriteOnly Property Marca As Integer
        Set(ByVal value As Integer)
            Me.m_DBO_ArticulosEnvasesTerciarios1.id_marca = value
        End Set
    End Property

    Public WriteOnly Property Formato As Integer
        Set(ByVal value As Integer)
            Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID = value
        End Set
    End Property

    Public WriteOnly Property TipoPalet As Integer
        Set(ByVal value As Integer)
            Me.m_DBO_ArticulosEnvasesTerciarios1.PaletTipoID = value
        End Set
    End Property

    Public WriteOnly Property Articulo As Integer
        Set(ByVal value As Integer)
            Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloID = value
        End Set
    End Property

    Private Sub frmWstepArticuloTerciario_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.panContenidos, Me)
    End Sub

    Public Sub establecerValores() Implements wizardable.EstablecerValores
        Dim spArticulos1 As New spArticulos1

        Try
            Dim spPalets As New spPaletsProducidos
            spPalets.cargar_PaletsProducidosNC_byArticulo(Me.cboSccNC, Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID, dtb)
        Catch ex As Exception
        End Try

        Try
            Dim spMarca As New spmarcas
            spMarca.cargar_marcas(Me.cboMarca, dtb)
        Catch ex As Exception
        End Try

        Try
            Dim spPalet As New spPaletsTipos
            spPalet.cargar_PaletsTipos(cboPalet, dtb)
            Me.cboPalet.mam_DataSource("PaletsTiposCbo", False, dtb)
        Catch ex As Exception
        End Try

        Try
            Dim spcabecera As New spcabecerasEtiquetas
            spcabecera.cargar_cabecerasEtiquetas(Me.cboCabeceraEtiqueta, dtb)
        Catch ex As Exception
        End Try

        If Not Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloID = Nothing Then
            cboPalet.SelectedValue = m_DBO_ArticulosEnvasesTerciarios1.PaletTipoID
            txtCajas.Text = m_DBO_ArticulosEnvasesTerciarios1.Cajas
            txtCajasPorCapa.Text = m_DBO_ArticulosEnvasesTerciarios1.CajasPorCapa
            txtCapas.Text = m_DBO_ArticulosEnvasesTerciarios1.Capas
            txtPesoIncluidoPalet.Text = m_DBO_ArticulosEnvasesTerciarios1.PesoIncluidoPalet
            txtObservaciones.Text = m_DBO_ArticulosEnvasesTerciarios1.Observaciones
            chbCargarDos.Checked = m_DBO_ArticulosEnvasesTerciarios1.CargarDos
            txtPermiteApilar.Text = m_DBO_ArticulosEnvasesTerciarios1.PermiteApilar
            txtLlevaSCC.Text = m_DBO_ArticulosEnvasesTerciarios1.LlevaSCC
            cboSccNC.SelectedValue = m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID

            cboSccNC.SelectedValue = m_DBO_ArticulosEnvasesTerciarios1.id_PaletProducidoNoConforme
            cboMarca.SelectedValue = m_DBO_ArticulosEnvasesTerciarios1.id_marca
            txtean.Text = m_DBO_ArticulosEnvasesTerciarios1.Ean13
            txtEan14.Text = m_DBO_ArticulosEnvasesTerciarios1.ean14
            cboCabeceraEtiqueta.SelectedValue = m_DBO_ArticulosEnvasesTerciarios1.id_cabeceraEtiqueta
            txtanosCaducidad.Text = m_DBO_ArticulosEnvasesTerciarios1.anosCaducidad

            Try
                Dim spArticulosEnvasesSecundarios As New spArticulosEnvasesSecundarios
                Dim m_sec_aux As DBO_ArticulosEnvasesSecundarios = spArticulosEnvasesSecundarios.Select_Record(m_DBO_ArticulosEnvasesTerciarios1.id_ArticuloEnvaseSecundario, dtb)
                Dim m_art_aux As DBO_Articulos1 = spArticulos1.Select_Record(m_sec_aux.ArticuloID, dtb)
                Me.txtSecundario.Text = m_art_aux.DescripcionLA
            Catch ex As Exception
                Me.txtSecundario.Text = ""
                Me.m_DBO_ArticulosEnvasesTerciarios1.id_ArticuloEnvaseSecundario = 0
            End Try

        Else
            Me.cboMarca.Enabled = False
            Me.cboPalet.Enabled = False
        End If
    End Sub

    Public Function recuperarValor(ByVal nombre As String) As Object Implements wizardable.recuperarValor
        Return New Object
    End Function

    Public Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean Implements wizardable.grabarDatos
        'If Me.m_DBO_ArticulosEnvasesTerciarios1.PaletTipoID Is Nothing Then
        '    Return False
        'Else
        '    If Me.mododeApertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
        '        If Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloID Is Nothing Then Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloID = RealizarConsulta("select max(articuloID) from Articulos1").Rows(0).Item(0)
        '        If Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID = 0 Or Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID Is Nothing Then
        '            Dim spt As New spArticulosEnvasadosHistoricos
        '            Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID = spt.seleccionar_ultimo_registro(dtb)
        '        End If
        '        If Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloEnvaseSecundarioID = Nothing Then Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloEnvaseSecundarioID = RealizarConsulta("select max(Envasesecundarioid) from articulosenvasesSecundarios").Rows(0).Item(0)
        '    End If

        '    Return GrabarArticulosEnvasesTerciarios1sintransaccion(m_DBO_ArticulosEnvasesTerciarios1,dtb)
        '    End If

        If Me.m_DBO_ArticulosEnvasesTerciarios1.PaletTipoID = Nothing Then
            Return False
        Else
            Dim spArticulosEnvasesTerciarios As New spArticulosEnvasesTerciarios

            If Me.mododeApertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
                Dim spf As New spArticulosEnvasadosHistoricos

                If Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloID = Nothing Then
                    dtb.PrepararConsulta("select max(articuloid) from articulos1")
                    Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloID = dtb.Consultar().Rows(0).Item(0)
                End If
                If Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID = 0 Or Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID = Nothing Then Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID = spf.seleccionar_ultimo_registro(dtb)
                If Me.m_DBO_ArticulosEnvasesTerciarios1.id_ArticuloEnvaseSecundario = Nothing Then
                    dtb.PrepararConsulta("select max(Envasesecundarioid) from articulosenvasesSecundarios")
                    Me.m_DBO_ArticulosEnvasesTerciarios1.id_ArticuloEnvaseSecundario = dtb.Consultar().Rows(0).Item(0)
                End If
            End If

            Return spArticulosEnvasesTerciarios.Grabar(m_DBO_ArticulosEnvasesTerciarios1, dtb)
        End If
    End Function

    Public Function comprobarCampos() As Boolean Implements wizardable.comprobarCampos
        Dim errores As String = ""
        m_DBO_ArticulosEnvasesTerciarios1.Cajas = If(txtCajas.Text = "", 0, System.Convert.ToInt32(txtCajas.Text))
        m_DBO_ArticulosEnvasesTerciarios1.CajasPorCapa = If(txtCajasPorCapa.Text = "", 0, System.Convert.ToInt32(txtCajasPorCapa.Text))
        m_DBO_ArticulosEnvasesTerciarios1.Capas = If(txtCapas.Text = "", 0, System.Convert.ToInt32(txtCapas.Text))
        m_DBO_ArticulosEnvasesTerciarios1.PesoIncluidoPalet = If(txtPesoIncluidoPalet.Text = "", 0, System.Convert.ToInt32(txtPesoIncluidoPalet.Text))
        m_DBO_ArticulosEnvasesTerciarios1.Observaciones = txtObservaciones.Text
        m_DBO_ArticulosEnvasesTerciarios1.CargarDos = chbCargarDos.Checked
        m_DBO_ArticulosEnvasesTerciarios1.PermiteApilar = If(txtPermiteApilar.Text = "", 0, System.Convert.ToInt32(txtPermiteApilar.Text))
        m_DBO_ArticulosEnvasesTerciarios1.LlevaSCC = If(txtLlevaSCC.Text = "", 0, System.Convert.ToInt32(txtLlevaSCC.Text))
        m_DBO_ArticulosEnvasesTerciarios1.Ean13 = txtean.Text
        m_DBO_ArticulosEnvasesTerciarios1.ean14 = txtEan14.Text
        m_DBO_ArticulosEnvasesTerciarios1.id_marca = cboMarca.SelectedValue
        m_DBO_ArticulosEnvasesTerciarios1.id_PaletProducidoNoConforme = cboSccNC.SelectedValue
        m_DBO_ArticulosEnvasesTerciarios1.PaletTipoID = cboPalet.SelectedValue
        m_DBO_ArticulosEnvasesTerciarios1.id_cabeceraEtiqueta = cboCabeceraEtiqueta.SelectedValue
        m_DBO_ArticulosEnvasesTerciarios1.anosCaducidad = If(txtanosCaducidad.Text = "", 0, System.Convert.ToInt32(txtanosCaducidad.Text))

        If Me.txtSecundario.Visible Then
            If Me.txtSecundario.Text = "" Then
                errores = errores & "No ha elegido el secundario que compone el articulo" & Environment.NewLine()
            End If
        End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine() & errores, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnSecundario_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim frm As New frmAsignarArticuloAarticulo(Me.m_DBO_ArticulosEnvasesTerciarios1.ArticuloID)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        If frm.id <> 0 Then
            Me.m_DBO_ArticulosEnvasesTerciarios1.id_ArticuloEnvaseSecundario = frm.id
            Me.txtSecundario.Text = frm.descripcion
            RaiseEvent actualizarExtras()
        End If
    End Sub

    Public Sub ActualizarDatos()
        Dim spArticulos1 As New spArticulos1

        If Me.panSecundario.Visible Then
            Try
                Me.m_DBO_ArticulosEnvasesTerciarios1 = spArticulosEnvasesTerciarios.Select_RecordByArticuloID(m_DBO_ArticulosEnvasesTerciarios1.ArticuloID, dtb)
                Dim spArticulosEnvasesSecundarios As New spArticulosEnvasesSecundarios
                Dim m_sec_aux As DBO_ArticulosEnvasesSecundarios = spArticulosEnvasesSecundarios.Select_Record(m_DBO_ArticulosEnvasesTerciarios1.id_ArticuloEnvaseSecundario, dtb)
                Dim m_art_aux As DBO_Articulos1 = spArticulos1.Select_Record(m_sec_aux.ArticuloID, dtb)
                Me.txtSecundario.Text = m_art_aux.DescripcionLA
                Dim spPalets As New spPaletsProducidos
                spPalets.cargar_PaletsProducidosNC_byArticulo(Me.cboSccNC, Me.m_DBO_ArticulosEnvasesTerciarios1.SccEtiquetaID, dtb)
            Catch ex As Exception
                Me.txtSecundario.Text = ""
                Me.m_DBO_ArticulosEnvasesTerciarios1.id_ArticuloEnvaseSecundario = 0
            End Try
        End If
    End Sub

    Private Sub btnverMarcas_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim frm As New frmmarcas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Dim sp As New spmarcas
        sp.cargar_marcas(Me.cboMarca, dtb)
    End Sub

    Private Sub btnaddMarcas_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmEntmarcas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Dim sp As New spmarcas
        sp.cargar_marcas(Me.cboMarca, dtb)
    End Sub

    Private Sub btnAdCabecera_Click(sender As System.Object, e As System.EventArgs) Handles butAdCabecera.Click
        Dim frm As New frmEntcabecerasEtiquetas
        If BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm) = Windows.Forms.DialogResult.OK Then
            Try
                Dim spcabecera As New spcabecerasEtiquetas
                spcabecera.cargar_cabecerasEtiquetas(Me.cboCabeceraEtiqueta, dtb)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub butverCAbecera_Click(sender As System.Object, e As System.EventArgs) Handles butverCAbecera.Click
        Dim frm As New frmcabecerasEtiquetas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub
End Class