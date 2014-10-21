Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmWstepGraneles
    Implements wizardable

    Private m_DBO_ArticuloGranel As DBO_ArticulosGraneles
    Private m_DBO_TiposProductos As DBO_TiposProductos
    Private spTiposProductos As spTiposProductos
    Private spArticulosGraneles As spArticulosGraneles
    Private spArticulos_ArticulosCertificadosTipos As spArticulos_ArticulosCertificadosTipos
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Me.m_DBO_ArticuloGranel = New DBO_ArticulosGraneles
        m_DBO_TiposProductos = New DBO_TiposProductos
        spTiposProductos = New spTiposProductos
        spArticulosGraneles = New spArticulosGraneles
        spArticulos_ArticulosCertificadosTipos = New spArticulos_ArticulosCertificadosTipos
        Me.butaddTProducto.Visible = False
    End Sub

    Public Sub New(ByVal articuloid As Integer)

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        m_DBO_TiposProductos = New DBO_TiposProductos
        spTiposProductos = New spTiposProductos
        spArticulosGraneles = New spArticulosGraneles
        spArticulos_ArticulosCertificadosTipos = New spArticulos_ArticulosCertificadosTipos
        Me.m_DBO_ArticuloGranel = spArticulosGraneles.Select_RecordByArticuloID(articuloid)
        Me.cbCreartipoProducto.Visible = False
        Me.panNuevoTipoProducto.Visible = False
        EstablecerValores()
    End Sub
    Private Sub frmWstepGraneles_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(PanContenidos, Me)
    End Sub


    Public Function comprobarCampos() As Boolean Implements wizardable.comprobarCampos
        Dim errores As String = ""

        If cboGranelTipoID.SelectedValue Is Nothing Then
            cboGranelTipoID.Focus()
            errores = "Debe seleccionar un valor par el tipo de granel." & Environment.NewLine
        Else
            m_DBO_ArticuloGranel.GranelTipoID = System.Convert.ToInt32(cboGranelTipoID.SelectedValue)
        End If

        If Me.txtDensidad.Text = "" Then
            errores = "No introdució un valor para la densidad." & Environment.NewLine
        Else
            m_DBO_ArticuloGranel.Densidad = Me.txtDensidad.Text
        End If

        If Me.txtCantidaDefecto.Text = "" Then
            errores = "No introdució un valor para la densidad." & Environment.NewLine
        Else
            m_DBO_ArticuloGranel.Cantidad_elaborar_defecto = Me.txtCantidaDefecto.Text
        End If

        If cboUnidad.SelectedIndex = -1 Then
            errores = "No seleccionó una unidad de medida." & Environment.NewLine
        Else
            m_DBO_ArticuloGranel.UnidadID = System.Convert.ToInt32(cboUnidad.SelectedIndex) + 1
        End If


        m_DBO_ArticuloGranel.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticuloGranel.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If Me.cbCreartipoProducto.Checked Then
            If txtDescripcion.Text = "" Then
                If errores = "" Then txtDescripcion.Focus()
                errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
            Else
                m_DBO_TiposProductos.Descripcion = txtDescripcion.Text
            End If

            If txtAbreviatura.Text = "" Then
                If errores = "" Then txtAbreviatura.Focus()
                errores = errores & "El campo Abreviatura no puede estar vacío." & Environment.NewLine
            Else
                m_DBO_TiposProductos.Abreviatura = txtAbreviatura.Text
            End If

            m_DBO_TiposProductos.Enologico = chEnologico.Checked

            If cbMedidas.SelectedValue Is Nothing Then
                If errores = "" Then cbMedidas.Focus()
                errores = errores & "No seleccionó un valor para MedidaID." & Environment.NewLine
            Else
                m_DBO_TiposProductos.MedidaID = System.Convert.ToInt32(cbMedidas.SelectedValue)
            End If
        Else
            If cboTipoProducto.SelectedValue Is Nothing Then
                cboTipoProducto.Focus()
                errores = "Debe seleccionar un valor par el tipo de producto." & Environment.NewLine
            Else
                Me.m_DBO_ArticuloGranel.TipoProductoID = Me.cboTipoProducto.SelectedValue
            End If

        End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub EstablecerValores() Implements wizardable.EstablecerValores
        Me.cboGranelTipoID.mam_DataSource("ArticulosGraneles_ArticulosGranelesTiposCbo", False)
        spTiposProductos.cargar_ComboBox(Me.cboTipoProducto)
        spTiposProductos.cargar_MedidasProductos(Me.cbMedidas)

        Dim spArticulos1 As New spArticulos1
        Dim cb As System.Windows.Forms.CheckBox
        Dim dt As DataTable = dtb.Consultar("ArticulosCertificadosTiposSelectDgv", True)

        For Each row As System.Data.DataRow In dt.Rows
            cb = New System.Windows.Forms.CheckBox

            cb.Checked = False
            cb.Text = row.Item(1)
            cb.Tag = row.Item(0)
            cb.Dock = DockStyle.Top
            gbCertificados.Controls.Add(cb)
        Next

        If Not Me.m_DBO_ArticuloGranel.ArticuloID Is Nothing Then
            Me.cboTipoProducto.SelectedValue = Me.m_DBO_ArticuloGranel.TipoProductoID
            'Me.cargarDatosProducto(Me.m_DBO_ArticuloGranel.TipoProductoID)

            Me.cboGranelTipoID.SelectedValue = Me.m_DBO_ArticuloGranel.GranelTipoID

            dt = spArticulos1.certificadosByArticuloId(Me.m_DBO_ArticuloGranel.ArticuloID)

            Me.txtDensidad.Text = Me.m_DBO_ArticuloGranel.Densidad
            Me.cboUnidad.SelectedIndex = Me.m_DBO_ArticuloGranel.UnidadID - 1
            Me.txtCantidaDefecto.Text = Me.m_DBO_ArticuloGranel.Cantidad_elaborar_defecto

            For Each row As System.Data.DataRow In dt.Rows
                For Each cb In gbCertificados.Controls
                    If cb.Tag = row(0) Then
                        cb.Checked = True
                    End If
                Next
            Next
        End If
    End Sub

    Public Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean Implements wizardable.grabarDatos
        If Me.m_DBO_ArticuloGranel.ArticuloID Is Nothing Then Me.m_DBO_ArticuloGranel.ArticuloID = dtb.Consultar("select max(articuloID) from Articulos1", False).Rows(0).Item(0)

        If Me.cbCreartipoProducto.Checked Then
            Me.m_DBO_TiposProductos.resetKey()

            If Not Me.spTiposProductos.Grabar(Me.m_DBO_TiposProductos, BasesParaCompatibilidad.BD.transaction) Then
                Return False
            Else
                Me.m_DBO_ArticuloGranel.TipoProductoID = dtb.Consultar("select max(tipoProductoid) from tiposProductos", False).Rows(0).Item(0)
            End If
        Else
            Me.m_DBO_ArticuloGranel.TipoProductoID = Me.cboTipoProducto.SelectedValue
        End If

        If spArticulosGraneles.GrabarArticulosGranelesSinTransaccion(m_DBO_ArticuloGranel, BasesParaCompatibilidad.BD.transaction) Then
            If spArticulos_ArticulosCertificadosTipos.Articulos_ArticulosCertificadosTiposDeleteByArticuloIDSinTransaccion(Me.m_DBO_ArticuloGranel.ArticuloID, BasesParaCompatibilidad.BD.transaction) Then
                Dim cb As System.Windows.Forms.CheckBox
                Dim dbo_cert As DBO_Articulos_ArticulosCertificadosTipos

                For Each cb In gbCertificados.Controls
                    If cb.Checked Then
                        dbo_cert = New DBO_Articulos_ArticulosCertificadosTipos
                        dbo_cert.ArticuloCertificadoTipoID = cb.Tag
                        dbo_cert.ArticuloID = Me.m_DBO_ArticuloGranel.ArticuloID
                        dbo_cert.Observaciones = String.Empty
                        If Not spArticulos_ArticulosCertificadosTipos.Articulos_ArticulosCertificadosTiposInsertSinTransaccion(dbo_cert, BasesParaCompatibilidad.BD.transaction) Then
                            Return False
                        End If
                    End If
                Next

                Return True
            Else : Return False
            End If
        Else : Return False
        End If
    End Function

    Public Function recuperarValor(ByVal nombre As String) As Object Implements wizardable.recuperarValor
        Return Nothing
    End Function

    Private Sub cbCreartipoProducto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbCreartipoProducto.CheckedChanged
        Me.panNuevoTipoProducto.Enabled = Me.cbCreartipoProducto.Checked
        Me.pantipoProducto.Enabled = Not Me.cbCreartipoProducto.Checked

    End Sub

    'Private Sub cargarDatosProducto(ByVal id As Integer)
    '    Me.m_DBO_TiposProductos = spTiposProductos.Select_Record(Me.m_DBO_ArticuloGranel.TipoProductoID)

    '    txtDescripcion.Text = m_DBO_TiposProductos.Descripcion
    '    txtAbreviatura.Text = m_DBO_TiposProductos.Abreviatura
    '    chEnologico.Checked = m_DBO_TiposProductos.Enologico
    '    cbMedidas.SelectedValue = m_DBO_TiposProductos.MedidaID
    'End Sub

    Private Sub butaddTProducto_Click(sender As System.Object, e As System.EventArgs) Handles butaddTProducto.Click
        Dim frm As New frmTiposProductos
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        spTiposProductos.cargar_ComboBox(Me.cboTipoProducto)
    End Sub
End Class