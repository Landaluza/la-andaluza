Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmWstepIngredientes
    Implements wizardable

    Private m_IDI As Boolean
    Private m_DBO_ArticuloIngrediente As DBO_ArticulosIngredientes
    Private m_DBO_TiposProductos As DBO_TiposProductos
    Private spTiposProductos As spTiposProductos
    Private spArticulosIngredientes As spArticulosIngredientes
    Private spArticulosIngredientesIDI As spArticulosIngredientesIDI
    Private spArticulos_ArticulosCertificadosTipos As spArticulos_ArticulosCertificadosTipos
    Private frmEnt As frmEntArticulosIngredientesTipos
    Private dtb As BasesParaCompatibilidad.DataBase
    Public WriteOnly Property ArticuloID As Integer
        Set(value As Integer)
            Me.m_DBO_ArticuloIngrediente.ArticuloID = value
        End Set
    End Property

    Public Sub New(Optional ByVal IDI As Boolean = False)

        InitializeComponent()

        m_DBO_ArticuloIngrediente = New DBO_ArticulosIngredientes
        spArticulosIngredientes = New spArticulosIngredientes
        spArticulosIngredientesIDI = New spArticulosIngredientesIDI
        spArticulos_ArticulosCertificadosTipos = New spArticulos_ArticulosCertificadosTipos
        Me.m_IDI = IDI

        dtb = New BasesParaCompatibilidad.DataBase()
        m_DBO_TiposProductos = New DBO_TiposProductos
        spTiposProductos = New spTiposProductos

        Me.btnAddTProducto.Visible = False
    End Sub

    Public Sub New(ByVal IDI As Boolean, ByVal articuloid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        Me.m_IDI = IDI
        m_DBO_ArticuloIngrediente = New DBO_ArticulosIngredientes
        m_DBO_TiposProductos = New DBO_TiposProductos
        spTiposProductos = New spTiposProductos
        spArticulosIngredientes = New spArticulosIngredientes
        spArticulosIngredientesIDI = New spArticulosIngredientesIDI
        spArticulos_ArticulosCertificadosTipos = New spArticulos_ArticulosCertificadosTipos
        dtb = New BasesParaCompatibilidad.DataBase()

        If Me.m_IDI Then
            Me.m_DBO_ArticuloIngrediente = spArticulosIngredientesIDI.Select_RecordByArticuloID(dtb, articuloid)
        Else
            Me.m_DBO_ArticuloIngrediente = spArticulosIngredientes.Select_RecordByArticuloID(articuloid, dtb)
        End If

        Me.cbCreartipoProducto.Visible = False
        Me.panNuevoTipoProducto.Visible = False
        EstablecerValores()
    End Sub
    Public Function comprobarCampos() As Boolean Implements wizardable.comprobarCampos
        Dim errores As String = ""

        If cboIngredienteTipoID.SelectedValue Is Nothing Then
            cboIngredienteTipoID.Focus()
            errores = errores & "Debe seleccionar un valor para el tipo de ingrediente" & Environment.NewLine
        Else
            m_DBO_ArticuloIngrediente.IngredienteTipoID = System.Convert.ToInt32(cboIngredienteTipoID.SelectedValue)
        End If



        m_DBO_ArticuloIngrediente.Descripcion = If(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_ArticuloIngrediente.CertificadoOGM = 0
        'm_DBO_ArticuloIngrediente.CertificadoOGM = System.Convert.ToBoolean(chbCertificadoOGM.Checked)
        m_DBO_ArticuloIngrediente.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ArticuloIngrediente.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticuloIngrediente.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If Not Me.m_IDI Then
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
                Me.m_DBO_ArticuloIngrediente.TipoProductoID = Me.cboTipoProducto.SelectedValue

                If Me.txtDensidad.Text = "" Then
                    errores = "No introdució un valor para la densidad." & Environment.NewLine
                Else
                    m_DBO_ArticuloIngrediente.Densidad = Me.txtDensidad.Text
                End If

                If cboUnidad.SelectedIndex = -1 Then
                    errores = "No seleccionó una unidad de medida." & Environment.NewLine
                Else
                    m_DBO_ArticuloIngrediente.UnidadID = System.Convert.ToInt32(cboUnidad.SelectedIndex) + 1
                End If


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

        cargartipos()

        Dim spArticulos1 As New spArticulos1
        Dim cb As System.Windows.Forms.CheckBox
        Dim dt As DataTable = dtb.Consultar("ArticulosCertificadosTiposSelectDgv", True)

        If Not Me.m_IDI Then
            spTiposProductos.cargar_ComboBox(Me.cboTipoProducto, dtb)
            spTiposProductos.cargar_MedidasProductos(Me.cbMedidas, dtb)
        End If

        For Each row As System.Data.DataRow In dt.Rows
            cb = New System.Windows.Forms.CheckBox

            cb.Checked = False
            cb.Text = row.Item(1)
            cb.Tag = row.Item(0)
            cb.Dock = DockStyle.Top
            gbCertificados.Controls.Add(cb)
        Next

        If Not Me.m_DBO_ArticuloIngrediente.ArticuloID Is Nothing Then
            'Me.cboEstado.SelectedValue = Me.m_DBO_ArticuloIngrediente.estado
            Me.cboIngredienteTipoID.SelectedValue = Me.m_DBO_ArticuloIngrediente.IngredienteTipoID
            Me.txtDescripcion.Text = Me.m_DBO_ArticuloIngrediente.Descripcion
            Me.txtObservaciones.Text = Me.m_DBO_ArticuloIngrediente.Observaciones

            If Not Me.m_IDI Then
                Me.cboTipoProducto.SelectedValue = Me.m_DBO_ArticuloIngrediente.TipoProductoID
                Me.txtDensidad.Text = m_DBO_ArticuloIngrediente.Densidad
                Me.cboUnidad.SelectedIndex = m_DBO_ArticuloIngrediente.UnidadID - 1
            End If

            dt = spArticulos1.certificadosByArticuloId(Me.m_DBO_ArticuloIngrediente.ArticuloID, dtb)

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
        If Me.m_IDI Then
            Return GuardarIngredienteIDI()
        Else
            Return GuardarIngrediente()
        End If
    End Function

    Public Function recuperarValor(nombre As String) As Object Implements wizardable.recuperarValor
        Return Nothing
    End Function

    Private Sub cargartipos()
        If Me.m_IDI Then
            Me.cboIngredienteTipoID.mam_DataSource("ArticulosIngredientesIDI_ArticulosIngredientesIDITiposCbo", False, dtb)
        Else
            Me.cboIngredienteTipoID.mam_DataSource("ArticulosIngredientes_ArticulosIngredientesTiposCbo", False, dtb)
        End If
    End Sub

    Private Function GuardarIngrediente() As Boolean
        If Me.m_DBO_ArticuloIngrediente.ArticuloID Is Nothing Then Me.m_DBO_ArticuloIngrediente.ArticuloID = dtb.Consultar("select max(articuloID) from Articulos1", False).Rows(0).Item(0)

        If comprobarCampos() Then
            If Me.cbCreartipoProducto.Checked Then
                Me.m_DBO_TiposProductos.resetKey()

                If Not Me.spTiposProductos.Grabar(Me.m_DBO_TiposProductos, dtb) Then
                    Return False
                Else
                    Me.m_DBO_ArticuloIngrediente.TipoProductoID = dtb.Consultar("select max(tipoProductoid) from tiposProductos", False).Rows(0).Item(0)
                End If
            End If

            If Not spArticulosIngredientes.GrabarArticulosIngredientesSinTransaccion(m_DBO_ArticuloIngrediente, dtb) Then Return False

            If spArticulos_ArticulosCertificadosTipos.Articulos_ArticulosCertificadosTiposDeleteByArticuloIDSinTransaccion(Me.m_DBO_ArticuloIngrediente.ArticuloID, dtb) Then
                Dim cb As System.Windows.Forms.CheckBox
                Dim dbo_cert As DBO_Articulos_ArticulosCertificadosTipos

                For Each cb In gbCertificados.Controls
                    If cb.Checked Then
                        dbo_cert = New DBO_Articulos_ArticulosCertificadosTipos
                        dbo_cert.ArticuloCertificadoTipoID = cb.Tag
                        dbo_cert.ArticuloID = Me.m_DBO_ArticuloIngrediente.ArticuloID
                        dbo_cert.Observaciones = String.Empty
                        If Not spArticulos_ArticulosCertificadosTipos.Articulos_ArticulosCertificadosTiposInsertSinTransaccion(dbo_cert, dtb) Then
                            Return False
                        End If
                    End If
                Next

                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Function GuardarIngredienteIDI() As Boolean
        If Me.m_DBO_ArticuloIngrediente.ArticuloID Is Nothing Then Me.m_DBO_ArticuloIngrediente.ArticuloID = dtb.Consultar("select max(articuloID) from Articulos1", False).Rows(0).Item(0)

        If comprobarCampos() Then

            If Not spArticulosIngredientesIDI.GrabarArticulosIngredientesIDISinTransaccion(m_DBO_ArticuloIngrediente, dtb) Then Return False

            If spArticulos_ArticulosCertificadosTipos.Articulos_ArticulosCertificadosTiposDeleteByArticuloIDSinTransaccion(Me.m_DBO_ArticuloIngrediente.ArticuloID, dtb) Then
                Dim cb As System.Windows.Forms.CheckBox
                Dim dbo_cert As DBO_Articulos_ArticulosCertificadosTipos

                For Each cb In gbCertificados.Controls
                    If cb.Checked Then
                        dbo_cert = New DBO_Articulos_ArticulosCertificadosTipos
                        dbo_cert.ArticuloCertificadoTipoID = cb.Tag
                        dbo_cert.ArticuloID = Me.m_DBO_ArticuloIngrediente.ArticuloID
                        dbo_cert.Observaciones = String.Empty
                        If Not spArticulos_ArticulosCertificadosTipos.Articulos_ArticulosCertificadosTiposInsertSinTransaccion(dbo_cert, dtb) Then
                            Return False
                        End If
                    End If
                Next

                Return True

            Else : Return False
            End If

            Return True
        Else
            Return False
        End If
    End Function


    Private Sub btnAddTipo_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTipo.Click
        frmEnt = New frmEntArticulosIngredientesTipos(New DBO_ArticulosIngredientesTipos, 0, False, Me.m_IDI)
        frmEnt.Text = String.Format("{0} {1}", BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, If(Me.m_IDI, "ArticulosIngredientesIDITipo", "ArticulosIngredientesTipo"))
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        cargartipos()
    End Sub

    Private Sub frmWstepIngredientes_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.Panel1, Me)
    End Sub

    Private Sub cbCreartipoProducto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbCreartipoProducto.CheckedChanged
        Me.panNuevoTipoProducto.Enabled = Me.cbCreartipoProducto.Checked
        Me.pantipoProducto.Enabled = Not Me.cbCreartipoProducto.Checked
    End Sub

    Private Sub frmWstepIngredientes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If Me.m_IDI Then
            Me.pantipoProducto.Visible = False
            Me.panNuevoTipoProducto.Visible = False
            Me.btnAddTProducto.Visible = False
            Me.txtDensidad.Visible = False
            Me.cboUnidad.Visible = False
        End If
    End Sub

    Private Sub btnAddTProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnAddTProducto.Click
        Dim frm As New frmTiposProductos
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        spTiposProductos.cargar_ComboBox(Me.cboTipoProducto, dtb)
    End Sub
End Class