Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmWstepArticuloSecundario
    Implements BasesParaCompatibilidad.wizardable
    Private m_DBO_ArticulosEnvasesSecundario As DBO_ArticulosEnvasesSecundarios
    Private m_DBO_TiposFormatos1 As New DBO_ArticulosEnvasadosHistorico
    Private no_crear As Boolean
    Private modoDeApertura As Integer
    Public Event actualizarExtras()
    Private spArticulosEnvasesSecundarios As spArticulosEnvasesSecundarios
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()

        InitializeComponent()

        Me.m_DBO_ArticulosEnvasesSecundario = New DBO_ArticulosEnvasesSecundarios
        m_DBO_TiposFormatos1 = New DBO_ArticulosEnvasadosHistorico
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        no_crear = True
        spArticulosEnvasesSecundarios = New spArticulosEnvasesSecundarios
        modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION
    End Sub

    Public Sub New(ByVal articuloid As Integer)
        InitializeComponent()

        modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        no_crear = True
        spArticulosEnvasesSecundarios = New spArticulosEnvasesSecundarios
        Me.m_DBO_ArticulosEnvasesSecundario = spArticulosEnvasesSecundarios.Select_RecordByArticuloID(articuloid)
        establecerValores()
    End Sub

    Public WriteOnly Property TipoProducto As Integer
        Set(ByVal value As Integer)
            m_DBO_ArticulosEnvasesSecundario.ProductoID = value
        End Set
    End Property

    Public WriteOnly Property NoCrearSecundario As Boolean
        Set(ByVal value As Boolean)
            Me.no_crear = value
        End Set
    End Property

    'Public WriteOnly Property Descripcion As String
    '    Set(ByVal value As String)
    '        Me.m_DBO_ArticulosEnvasesSecundario.Descripcion = value
    '    End Set
    'End Property

    Public WriteOnly Property Articulo As Integer
        Set(ByVal value As Integer)
            Me.m_DBO_ArticulosEnvasesSecundario.ArticuloID = value
        End Set
    End Property

    Public WriteOnly Property QS As Integer
        Set(ByVal value As Integer)
            Me.m_DBO_TiposFormatos1.CodigoQS = value
        End Set
    End Property

    Public WriteOnly Property Formato As Integer
        Set(ByVal value As Integer)
            Me.m_DBO_TiposFormatos1.TipoFormatoID = value
        End Set
    End Property

    Private Sub frmWstepArticuloSecundario_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.panContenidos, Me)
    End Sub

    Public Sub establecerValores() Implements BasesParaCompatibilidad.wizardable.EstablecerValores
        Me.cboCajaID.mam_DataSource("ArticulosEnvasesSecundarios_TiposCajasCbo", False)
        Dim spArticulos1 As New spArticulos1

        Try
            Dim spProductos As New spTiposProductos
            spProductos.cargar_ComboBox(cboProducto)
        Catch ex As Exception
        End Try

        If Not Me.m_DBO_ArticulosEnvasesSecundario.ID = Nothing Then
            cboCajaID.SelectedValue = Me.m_DBO_ArticulosEnvasesSecundario.CajaID
            txtSeparadores.Text = Me.m_DBO_ArticulosEnvasesSecundario.Separadores
            txtCajasPalet.Text = Me.m_DBO_ArticulosEnvasesSecundario.CajasPalet
            txtPeso.Text = Me.m_DBO_ArticulosEnvasesSecundario.Peso
            txtGenericas.Text = m_DBO_ArticulosEnvasesSecundario.Genericas
            txtParticulares.Text = m_DBO_ArticulosEnvasesSecundario.Particulares
            txtObservaciones.Text = m_DBO_ArticulosEnvasesSecundario.Observaciones
            cboProducto.SelectedValue = m_DBO_ArticulosEnvasesSecundario.ProductoID

            Try
                If Me.modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION Then
                    Dim d As DBO_Articulos1
                    d = spArticulos1.Select_Record(m_DBO_ArticulosEnvasesSecundario.id_articuloPrimario)
                    txtDescripcionPrimario.Text = d.DescripcionLA
                End If
            Catch ex As Exception
            End Try
        Else
            Me.cboCajaID.Enabled = False
            Me.cboProducto.Enabled = False
        End If
    End Sub

    Public Function recuperarValor(ByVal nombre As String) As Object Implements BasesParaCompatibilidad.wizardable.recuperarValor
        Return Nothing
    End Function

    Public Function grabarDatos() As Boolean Implements BasesParaCompatibilidad.wizardable.grabarDatos



        If modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
            If Me.m_DBO_ArticulosEnvasesSecundario.ProductoID = Nothing Then
                Return False
            End If

            If Me.Enabled Then
                Dim m_DBO_TiposFormatos1 As New DBO_ArticulosEnvasadosHistorico
                If Me.m_DBO_ArticulosEnvasesSecundario.ID = Nothing Then Me.m_DBO_ArticulosEnvasesSecundario.ArticuloID = dtb.Consultar("select max(articuloID) from Articulos1", False).Rows(0).Item(0)
                If Me.m_DBO_TiposFormatos1.TipoFormatoID = Nothing Then
                    Dim spt As New spArticulosEnvasadosHistoricos
                    Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)
                    m_DBO_TiposFormatos1.TipoFormatoID = spt.seleccionar_ultimo_registro(dtb)
                End If


                ' m_DBO_TiposFormatos1.Descripcion = m_DBO_ArticulosEnvasesSecundario.Descripcion
                m_DBO_TiposFormatos1.Separadores = m_DBO_ArticulosEnvasesSecundario.Separadores
                m_DBO_TiposFormatos1.CajasPalet = m_DBO_ArticulosEnvasesSecundario.CajasPalet
                m_DBO_TiposFormatos1.Genericas = m_DBO_ArticulosEnvasesSecundario.Genericas
                m_DBO_TiposFormatos1.Particulares = m_DBO_ArticulosEnvasesSecundario.Particulares
                m_DBO_TiposFormatos1.TipoProductoID = m_DBO_ArticulosEnvasesSecundario.ProductoID
                m_DBO_TiposFormatos1.TipoCajaID = m_DBO_ArticulosEnvasesSecundario.CajaID
                m_DBO_TiposFormatos1.TipoProductoID = m_DBO_ArticulosEnvasesSecundario.ProductoID

                Dim spTiposFormatos1 As New spArticulosEnvasadosHistorico1
                If Not spTiposFormatos1.GrabarTiposFormatos1Sintransaccion(m_DBO_TiposFormatos1, BasesParaCompatibilidad.BD.transaction) Then Return False
            End If

        End If

        If Me.no_crear Then
            Dim spArticulosEnvasesSecundarios As New spArticulosEnvasesSecundarios
            If Not spArticulosEnvasesSecundarios.Grabar(m_DBO_ArticulosEnvasesSecundario, BasesParaCompatibilidad.BD.transaction) Then Return False
        End If

        Return True

    End Function

    Public Function comprobarCampos() As Boolean Implements BasesParaCompatibilidad.wizardable.comprobarCampos
        Dim errores As String = ""

        If Me.Enabled Then
            If cboCajaID.SelectedValue Is Nothing Then
                cboCajaID.Focus()
                errores = errores & "debe seleccionar un valor para caja" & Environment.NewLine
            Else
                m_DBO_ArticulosEnvasesSecundario.CajaID = System.Convert.ToInt32(cboCajaID.SelectedValue)
            End If

            If cboProducto.SelectedValue Is Nothing Then
                cboProducto.Focus()
                errores = errores & "debe seleccionar un valor para producto" & Environment.NewLine
            Else
                m_DBO_ArticulosEnvasesSecundario.ProductoID = System.Convert.ToInt32(cboProducto.SelectedValue)
            End If

            If txtSeparadores.Text = "" Or Not IsNumeric(txtSeparadores.Text) Then
                txtSeparadores.Focus()
                errores = errores & "El valor de separadores debe ser numerico" & Environment.NewLine
            Else
                m_DBO_ArticulosEnvasesSecundario.Separadores = System.Convert.ToInt32(If(txtSeparadores.Text = "", Nothing, txtSeparadores.Text))
            End If

            If txtCajasPalet.Text = "" Or Not IsNumeric(txtCajasPalet.Text) Then
                txtCajasPalet.Focus()
                errores = errores & "El valor de 'cajas palet' debe ser numerico" & Environment.NewLine
            Else
                m_DBO_ArticulosEnvasesSecundario.CajasPalet = System.Convert.ToInt32(If(txtCajasPalet.Text = "", Nothing, txtCajasPalet.Text))
            End If

            If txtPeso.Text = "" Or Not IsNumeric(txtPeso.Text) Then
                txtPeso.Focus()
                errores = errores & "El valor de 'Peso' debe ser numerico" & Environment.NewLine
            Else
                m_DBO_ArticulosEnvasesSecundario.Peso = System.Convert.ToDouble(If(txtPeso.Text = "", Nothing, txtPeso.Text))
            End If

            m_DBO_ArticulosEnvasesSecundario.Genericas = If(txtGenericas.Text = "", String.Empty, txtGenericas.Text)
            m_DBO_ArticulosEnvasesSecundario.Particulares = If(txtParticulares.Text = "", String.Empty, txtParticulares.Text)
            m_DBO_ArticulosEnvasesSecundario.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnPrimario_Click(sender As System.Object, e As System.EventArgs) Handles btnPrimario.Click
        Dim frm As New frmAsignarArticuloAarticulo(Me.m_DBO_ArticulosEnvasesSecundario.ArticuloID, True, If(Me.modoDeApertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION, True, False))
        frm.ShowDialog()

        If frm.id <> 0 Then
            Me.m_DBO_ArticulosEnvasesSecundario.id_articuloPrimario = frm.id
            Me.txtDescripcionPrimario.Text = frm.descripcion
            RaiseEvent actualizarExtras()
        End If
    End Sub

    Public Sub ActualizarDatos()
        Dim spArticulos1 As New spArticulos1
        Try
            Me.m_DBO_ArticulosEnvasesSecundario = spArticulosEnvasesSecundarios.Select_RecordByArticuloID(m_DBO_ArticulosEnvasesSecundario.ArticuloID)

            Dim m_art_aux As DBO_Articulos1 = spArticulos1.Select_Record(m_DBO_ArticulosEnvasesSecundario.id_articuloPrimario)
            Me.txtDescripcionPrimario.Text = m_art_aux.DescripcionLA
        Catch ex As Exception
            Me.txtDescripcionPrimario.Text = ""
            Me.m_DBO_ArticulosEnvasesSecundario.id_articuloPrimario = 0
        End Try
    End Sub
End Class