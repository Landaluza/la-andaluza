Imports BasesParaCompatibilidad.WordExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntplantillasBoletines
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable

    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private BoletinCodigoLote As String
    Private BoletinTipoLote As String
    Private BoletinTipoProducto As String
    Private BoletinAcidez As String
    Private BoletinAlcoholResidual As String
    Private BoletinExtracto As String
    Private BoletinExtractoGrado As String
    Private BoletinAzucarTotal As String
    Private BoletinSulfuroso As String
    Private BoletinDensidad As String


    Private padre As frmGeneradorBoletines
    Private spBoletin As spplantillasBoletines

    Public Const TIPO_BOLETIN_ENVASADO As String = "Envasado"
    Public Const TIPO_BOLETIN_GRANELL As String = "Granell"

    Private m_BoletinTipo As String
    Private m_CodigoLote As String
    'Private m_plantilla As Integer
    Private m_Descripcion As String
    Private m_boletin As DBO_plantillasBoletines    
    Private v_Parametros As Collection
    Private dtb as BasesParaCompatibilidad.Database

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spplantillasBoletines = Nothing, Optional ByRef v_dbo As DBO_plantillasBoletines = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spplantillasBoletines, v_sp)
        spBoletin = New spplantillasBoletines
        m_boletin = if(v_dbo Is Nothing, New DBO_plantillasBoletines, v_dbo)
        dbo = m_boletin        
        'Me.m_plantilla = m_boletin.id
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Me.dtpFecha.activarFoco()
    End Sub

    Public Sub New(Optional ByVal id_plantilla As Integer = Nothing)
        InitializeComponent()
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Me.dtpFecha.activarFoco()
    End Sub

    Public Sub New(ByVal CodigoLote As String, ByVal stub As Boolean)
        InitializeComponent()
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Me.dtpFecha.activarFoco()

        m_CodigoLote = CodigoLote
        Me.m_BoletinTipo = TIPO_BOLETIN_ENVASADO
        sp = New spplantillasBoletines
        m_boletin = New DBO_plantillasBoletines
        dbo = m_boletin

        Me.butGuardar.Visible = False        
    End Sub

    Public Sub New(ByRef padre As frmGeneradorBoletines)
        InitializeComponent()
        m_BoletinTipo = TIPO_BOLETIN_ENVASADO
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        'RellenarComboBox(cboAnalistas, ctlPer.devolverAnalistas(), False)        
        spBoletin = New spplantillasBoletines
        sp = spBoletin
        m_boletin = New DBO_plantillasBoletines
        dbo = m_boletin
        Me.v_Parametros = New Collection
        Me.padre = padre
        MyBase.bdnGeneral.Visible = False
    End Sub

    Public Sub New(ByVal CodigoLote As String, ByVal plantilla As Integer, Optional ByRef padre As frmGeneradorBoletines = Nothing)
        InitializeComponent()
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        spBoletin = New spplantillasBoletines
        sp = spBoletin
        m_boletin = New DBO_plantillasBoletines
        Me.v_Parametros = New Collection
        m_boletin.id = plantilla
        dbo = m_boletin
        m_CodigoLote = CodigoLote
        Me.padre = padre
        '''cargarParametros()
        habilitarControles()
        setValores()
        MyBase.bdnGeneral.Visible = False
        m_BoletinTipo = TIPO_BOLETIN_ENVASADO
        'RellenarComboBox(cboAnalistas, ctlPer.devolverAnalistas(), False)
        'Me.v_Parametros = New Collection
        'Me.padre = padre
    End Sub

    Public Sub nuevo()
        Me.m_CodigoLote = ""
        'cargarParametros()
        habilitarControles()
        Me.m_boletin.id = 0
        dbo = m_boletin
    End Sub

    Private Sub frmEntplantillasBoletines_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.v_Parametros = New Collection
        spBoletin = New spplantillasBoletines
        spBoletin.cargaComboAnalistas(cboAnalistas)
        Me.ToolTip1.SetToolTip(butCancelar, "Pulsa para cancelar la edicion y volver al formulario")
        Me.ToolTip1.SetToolTip(Button1, "Pulsa para guardar la plantilla y volver al formulario")
        Me.ToolTip1.SetToolTip(btnImprimir, "Crea un archivo Word a partir de los datos de la plantilla")

        
        cargarParametros()
        habilitarControles()
        'If Not Me.ModoDeApertura = MODIFICACION Then
        '    Me.m_boletin = New DBO_plantillasBoletines
        'End If
    End Sub

    Public Sub habilitarControles()
        If Me.m_CodigoLote = "" Then
            If Me.ModoDeApertura = Nothing Then
                Me.Button1.Visible = True
                Me.butCancelar.Visible = True
            Else
                Me.Button1.Visible = False
                Me.butCancelar.Visible = False
            End If

            Me.txtNombre.Visible = True
            Me.lNombre.Visible = True
            Me.btnImprimir.Visible = False
        Else
            Me.Button1.Visible = False
            Me.butCancelar.Visible = False
            Me.txtNombre.Visible = False
            Me.lNombre.Visible = False
            Me.btnImprimir.Visible = True
        End If
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_boletin = New DBO_plantillasBoletines
        Else
            Me.m_boletin = dbo
        End If

        'If Me.m_plantilla <> Nothing Then
        If Me.m_boletin.id <> Nothing Then
            Dim m_dbo As New DBO_plantillasBoletines
            'm_dbo = spBoletines.selectRecord(m_plantilla)
            m_dbo = spBoletin.Select_Record(Me.m_boletin.id)

            If m_dbo.id_empresa = 1 Then
                Me.rdbLA.Checked = True
            ElseIf m_dbo.id_empresa = 2 Then
                Me.rdbJR.Checked = True
            Else
                Me.rdbSinLogo.Checked = True
            End If

            Me.txtNombre.Text = m_dbo.Nombre

            txtComentario1.Text = m_dbo.pie1
            txtComentario2.Text = m_dbo.Pie2

            cbComentario1.Checked = if(m_dbo.pie1 <> "", True, False)
            cbComentario2.Checked = if(m_dbo.Pie2 <> "", True, False)

            Me.txtCabecera.Text = m_dbo.Cabecera
        End If
    End Sub

    Private Sub cargarParametros()
        Dim tablaParametros, tablaCategorias As System.Data.DataTable
        Dim contCategorias, contParametros, margenHorizontal As Integer
        Dim grupo As GroupBox
        Dim combo As New System.Windows.Forms.CheckBox
        Dim separador As Panel
        Dim margen As Integer = 0

        contCategorias = 0
        contParametros = 0
        margenHorizontal = 8

        'TO DO crear en la bd el select para la modificacion
        If Me.m_CodigoLote <> "" Then
            dtb.PrepararConsulta("LotesSelectCategoriasParametrosByCodigoLote @cod")
            dtb.AñadirParametroConsulta("@cod", m_CodigoLote)
            tablaCategorias = dtb.Consultar()
        Else
            tablaCategorias = dtb.Consultar("LotesSelectAllCategoriasParametros")
        End If

        While contCategorias < tablaCategorias.Rows.Count
            contParametros = 0

            If Me.m_boletin.id = Nothing Then
                If Me.m_CodigoLote <> "" Then
                    dtb.PrepararConsulta("LotesSelectByCodigoLoteYCatagoriaParametro @cod, @id")
                    dtb.AñadirParametroConsulta("@cod", m_CodigoLote)
                    dtb.AñadirParametroConsulta("@id", tablaCategorias.Rows(contCategorias).Item("ID"))
                    tablaParametros = dtb.Consultar()
                Else
                    dtb.PrepararConsulta("LotesSelectByCatagoriaParametro @id")
                    dtb.AñadirParametroConsulta("@id", tablaCategorias.Rows(contCategorias).Item("ID"))
                    tablaParametros = dtb.Consultar()
                End If
            Else
                If Me.ModoDeApertura = MODIFICACION Then
                    dtb.PrepararConsulta("PlantillasBoletinesSelectByCatagoriaParametro_Plantilla @bol, @cat")
                    dtb.AñadirParametroConsulta("@bol", m_boletin.id)
                    dtb.AñadirParametroConsulta("@cat", tablaCategorias.Rows(contCategorias).Item("ID"))
                    tablaParametros = dtb.Consultar()
                Else
                    dtb.PrepararConsulta("LotesSelectByCodigoLote_CatagoriaParametro_Plantilla @cod, @cat, @bol")
                    dtb.AñadirParametroConsulta("@cod", m_CodigoLote)
                    dtb.AñadirParametroConsulta("@cat", tablaCategorias.Rows(contCategorias).Item("ID"))
                    dtb.AñadirParametroConsulta("@bol", m_boletin.id)
                    tablaParametros = dtb.Consultar()
                End If
            End If
            grupo = New GroupBox
            Me.PanParametros.Controls.Add(grupo)

            grupo.Height = 18
            grupo.Dock = DockStyle.Left
            grupo.Text = tablaCategorias.Rows(contCategorias).Item("Nombre")
            grupo.Name = tablaCategorias.Rows(contCategorias).Item("Nombre")

            While contParametros < tablaParametros.Rows.Count
                combo = New System.Windows.Forms.CheckBox
                If Me.ModoDeApertura = MODIFICACION Then
                    combo.Checked = Convert .ToBoolean(tablaParametros.Rows(contParametros).Item("Selected"))
                Else
                    combo.Checked = True
                End If
                grupo.Height += combo.Height + (combo.Margin.Top * 2)
                grupo.Controls.Add(combo)
                Me.v_Parametros.Add(combo)
                combo.Dock = DockStyle.Top
                combo.Padding = New Padding(17, 0, 0, 0)

                combo.Text = tablaParametros.Rows(contParametros).Item("Nombre")
                combo.Name = tablaParametros.Rows(contParametros).Item("Nombre")
                combo.Tag = tablaParametros.Rows(contParametros).Item("ID")

                contParametros += 1
            End While

            Dim panBoton As New Panel
            Dim button As New System.Windows.Forms.Button
            button.Tag = "-"
            panBoton.Width = 19
            button.Height = 19
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = 0
            button.Image = My.Resources.edit_remove_3
            grupo.Controls.Add(panBoton)
            panBoton.Controls.Add(button)
            panBoton.Dock = DockStyle.Left
            button.Dock = DockStyle.Top
            Me.ToolTip1.SetToolTip(button, "Selecciona o deselecciona los parametros")
            AddHandler button.Click, AddressOf marcar_desmarcarParametros

            If grupo.Height < 250 Then
                grupo.Height = 250
            End If

            If tablaParametros.Rows.Count() * 18 > margen Then margen = tablaParametros.Rows.Count() * 18

            separador = New Panel
            separador.Dock = DockStyle.Left
            separador.Width = 15
            Me.PanParametros.Controls.Add(separador)

            contCategorias += 1
        End While

        PanParametros.SetAutoScrollMargin(0, margen)
    End Sub

    Private Sub marcar_desmarcarParametros(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim but As System.Windows.Forms.Button
        Dim grupo As GroupBox
        Dim obj As Object
        Dim cb As New System.Windows.Forms.CheckBox
        but = sender
        grupo = but.Parent.Parent

        If but.Tag = "+" Then
            For Each obj In grupo.Controls
                If obj.GetType = cb.GetType Then
                    cb = obj
                    cb.Checked = True
                End If
            Next

            but.Tag = "-"
            but.Image = My.Resources.edit_remove_3
        Else
            For Each obj In grupo.Controls
                If obj.GetType = cb.GetType Then
                    cb = obj
                    cb.Checked = False
                End If
            Next

            but.Tag = "+"
            but.Image = My.Resources.edit_add_2
        End If

    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty
        Dim cb_aux As System.Windows.Forms.CheckBox
        Dim contador_parametros As Integer = 0

        If Me.rdbLA.Checked Then
            Me.m_boletin.id_empresa = Convert.ToInt32(Me.rdbLA.Tag)
        ElseIf rdbJR.Checked Then
            Me.m_boletin.id_empresa = Convert.ToInt32(Me.rdbJR.Tag)
        End If

        If Me.txtNombre.Text = "" Then
            errores &= "No especificó un nombre" & Environment.NewLine
        Else
            m_boletin.nombre = Me.txtNombre.Text
        End If

        If Me.txtCabecera.Text = "" Then
            errores &= "No especificó una cabecera" & Environment.NewLine
        Else
            m_boletin.Cabecera = Me.txtCabecera.Text
        End If

        m_boletin.pie1 = if(Me.cbComentario1.Checked, txtComentario1.Text, String.Empty)
        m_boletin.pie2 = if(Me.cbComentario2.Checked, txtComentario2.Text, String.Empty)

        m_boletin.Cabecera = txtCabecera.Text

        m_boletin.Parametros = New Collection

        For Each cb_aux In Me.v_Parametros
            If cb_aux.Checked Then
                Dim m_parametro As New Dbo_BoletinesParametros
                m_parametro.IdParametro = Convert.ToInt32(cb_aux.Tag)
                m_boletin.Parametros.Add(m_parametro)
                contador_parametros += 1
            End If
        Next

        If contador_parametros = 0 Then
            errores &= "No marcó ningun parametro" & Environment.NewLine
        End If

        If errores = String.Empty Then
            dbo = m_boletin
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        'recuperar los parametros y almacenarlos en un dbo o coleccion
        If Me.GetValores Then
            Try
                If spBoletin.GrabarBoletin(dbo) Then
                    RaiseEvent afterSave(Me, Nothing)
                    Me.Close()
                Else
                    messagebox.show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                messagebox.show("No se pudo guardar el registro. Detalles:" & Environment.NewLine & Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Not rdbJR.Checked And Not rdbLA.Checked And Not rdbSinLogo.Checked Then
            MessageBox.Show("Selecciona Logo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Cursor = Cursors.WaitCursor
            Select Case m_BoletinTipo
                Case Is = TIPO_BOLETIN_ENVASADO
                    GenerarBoletinEnvasado()
                Case Is = TIPO_BOLETIN_GRANELL
                    GeneraBoletin()
            End Select
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub butCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelar.Click
        If Not padre Is Nothing Then padre.habilitarFormulario()
        Me.Close()
    End Sub

    Private Sub butGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If GetValores() Then
            If spBoletin.GrabarBoletin(Me.m_boletin) Then
                If Not Me.padre Is Nothing Then Me.padre.habilitarFormulario()
                Me.Close()
            End If
        End If
    End Sub


    Private Sub GeneraBoletin()
        Dim oWord As New Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTablaTitulo As Microsoft.Office.Interop.Word.Table
        Dim oTablaCabecera As Microsoft.Office.Interop.Word.Table
        Dim oTablaTituloAnalitica As Microsoft.Office.Interop.Word.Table

        Dim oPara1 As Microsoft.Office.Interop.Word.Paragraph, oPara2 As Microsoft.Office.Interop.Word.Paragraph
        Dim oPara3 As Microsoft.Office.Interop.Word.Paragraph, oPara4 As Microsoft.Office.Interop.Word.Paragraph
        Dim oPara5 As Microsoft.Office.Interop.Word.Paragraph, oPara6 As Microsoft.Office.Interop.Word.Paragraph

        oWord.Visible = False
        oDoc = oWord.Documents.Add

        With oDoc.PageSetup
            Try
                .PaperSize = Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4
            Catch ex As Exception
            End Try
            Try
                .Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientPortrait
            Catch ex As Exception
            End Try
            .LeftMargin = oWord.CentimetersToPoints(2)
            .BottomMargin = oWord.CentimetersToPoints(1)
            .TopMargin = oWord.CentimetersToPoints(1)
        End With

        oTablaTitulo = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 2)
        With oTablaTitulo
            .Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
            .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
            .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

            .Cell(1, 1).Range.InsertAfter("")
            .Cell(1, 1).Width = 63

            Dim Ruta As String = ""
            Dim bmp As Bitmap = Nothing
            If Me.rdbJR.Checked Then
                'Obtenemos la imagen del recurso
                Ruta = "C:\LogoJR.bmp"
                bmp = My.Resources.LogoJR
            End If

            If Me.rdbLA.Checked Then
                Ruta = "C:\LogoLA.bmp"
                bmp = My.Resources.LogoLA
            End If

            If Me.rdbSinLogo.Checked Then
                Ruta = ""
            End If

            If Ruta <> "" Then
                'Guardamos la imagen en disco
                bmp.Save(Ruta, Imaging.ImageFormat.Bmp)
                'Insertamos la imagen en una celda cualquiera, e indicamos que se guarde con el documento en lugar de vincularla.
                .Cell(1, 1).Range.InlineShapes.AddPicture(Ruta, False, True)
                'Eliminamos el archivo temporal
                IO.File.Delete(Ruta)
                .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
            End If

            .Cell(1, 2).Width = oWord.PixelsToPoints(560)
            .Cell(1, 2).Range.Font.Size = 24
            .Cell(1, 2).Range.InsertAfter(Me.txtCabecera.Text) '"BOLETIN DE CONTROL DE CALIDAD")
        End With

        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Format.SpaceAfter = 18

        oTablaCabecera = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 2)
        oTablaCabecera.Cell(1, 1).Width = oWord.PixelsToPoints(150)
        oTablaCabecera.Cell(1, 1).Range.Font.Size = 18
        oTablaCabecera.Cell(1, 1).Range.Font.Bold = True

        oTablaCabecera.Cell(2, 1).Width = oWord.PixelsToPoints(150)
        oTablaCabecera.Cell(2, 1).Range.Font.Size = 18
        oTablaCabecera.Cell(2, 1).Range.Font.Bold = True

        oTablaCabecera.Cell(1, 2).Width = oWord.PixelsToPoints(470)
        oTablaCabecera.Cell(1, 2).Range.Font.Size = 18
        oTablaCabecera.Cell(1, 2).Range.Font.Bold = False

        oTablaCabecera.Cell(2, 2).Width = oWord.PixelsToPoints(470)
        oTablaCabecera.Cell(2, 2).Range.Font.Size = 18
        oTablaCabecera.Cell(2, 2).Range.Font.Bold = False

        oTablaCabecera.Cell(1, 1).Range.InsertAfter("Producto:")
        oTablaCabecera.Cell(1, 2).Range.Text = BoletinTipoProducto
        oTablaCabecera.Cell(2, 1).Range.InsertAfter("Lote:")
        oTablaCabecera.Cell(2, 2).Range.Text = BoletinCodigoLote

        'oTablaCabecera.Cell(3, 1).Range.InsertAfter("Muestra:")
        'oTablaCabecera.Cell(3, 2).Range.Text = Me.txtReferencia.Text
        'oTablaCabecera.Cell(4, 1).Range.InsertAfter("Codigo Lote:")
        'oTablaCabecera.Cell(4, 2).Range.Text = clsLotesAnaliticasShared._CodigoLote
        'oTablaCabecera.Cell(5, 1).Range.InsertAfter("Litros:")
        'oTablaCabecera.Cell(5, 2).Range.Text = Me.txtCodigoLote.Text

        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Format.SpaceAfter = oWord.PixelsToPoints(24)

        oTablaTituloAnalitica = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 10, 6)
        With oTablaTituloAnalitica
            .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
            .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

            .Cell(2, 1).Range.Text = "Parámetro"
            .Cell(2, 2).Range.Text = "Valor"
            .Cell(2, 3).Range.Text = "Unidades"
            .Cell(2, 4).Range.Text = "Métodos análisis"
            .Cell(2, 5).Range.Text = "Limites legales"
            .Cell(2, 6).Range.Text = "Especificaciones"

            .Cell(3, 1).Range.Text = "Acidez total"
            .Cell(4, 1).Range.InsertAfter("Alcohol residual")
            .Cell(5, 1).Range.InsertAfter("Extracto seco")
            .Cell(6, 1).Range.InsertAfter("Extracto seco/grado")
            .Cell(7, 1).Range.InsertAfter("Azúcares reductores")
            .Cell(8, 1).Range.InsertAfter("Extracto neto")
            .Cell(9, 1).Range.InsertAfter("Anhídrido sulfuroso")
            .Cell(10, 1).Range.InsertAfter("Densidad")

            .Cell(3, 2).Range.Text = BoletinAcidez
            .Cell(4, 2).Range.Text = BoletinAlcoholResidual
            .Cell(5, 2).Range.Text = BoletinExtracto
            .Cell(6, 2).Range.Text = BoletinExtractoGrado
            .Cell(7, 2).Range.Text = BoletinAzucarTotal
            If BoletinExtracto.Length > 0 And BoletinAzucarTotal.Length > 0 Then
                .Cell(8, 2).Range.Text = (Convert.ToDouble(BoletinExtracto) - Convert.ToDouble(BoletinAzucarTotal)).ToString
            End If
            .Cell(9, 2).Range.Text = BoletinSulfuroso
            .Cell(10, 2).Range.Text = BoletinDensidad

            .Cell(3, 3).Range.InsertAfter("%")
            .Cell(4, 3).Range.InsertAfter("%")
            .Cell(5, 3).Range.InsertAfter("g/l")
            .Cell(6, 3).Range.InsertAfter("g/l/º")
            .Cell(7, 3).Range.InsertAfter("g/l")
            .Cell(8, 3).Range.InsertAfter("g/l")
            .Cell(9, 3).Range.InsertAfter("mg/l")
            .Cell(10, 3).Range.InsertAfter("kg/l")

            .Cell(3, 4).Range.Text = "MA-LA-01.2"
            .Cell(4, 4).Range.Text = "MA-LA-03.2"
            .Cell(5, 4).Range.Text = "MA-LA-05"
            .Cell(6, 4).Range.Text = ""
            .Cell(7, 4).Range.Text = "MA-LA-18.1"
            .Cell(8, 4).Range.Text = ""
            .Cell(9, 4).Range.Text = "MA-LA-09"
            .Cell(10, 4).Range.Text = "MA-LA-23"

            .Cell(3, 5).Range.Text = "Mínimo 6%"
            .Cell(4, 5).Range.Text = "Máximo 1,5%"
            .Cell(5, 5).Range.Text = "No aplica"
            .Cell(6, 5).Range.Text = "No aplica"
            .Cell(7, 5).Range.Text = "Mínimo 270 g/l"
            .Cell(8, 5).Range.Text = "Mínimo 30 g/l"
            .Cell(9, 5).Range.Text = "Máximo 100 mg/l"
            .Cell(10, 5).Range.Text = "Mínimo 1,06 kg/l"

            .Cell(3, 6).Range.Text = "6,03 % +- 0,03"
            .Cell(4, 6).Range.Text = "Menor de 0,5%"
            .Cell(5, 6).Range.Text = ""
            .Cell(6, 6).Range.Text = ""
            .Cell(7, 6).Range.Text = "Mínimo de 270 g/l"
            .Cell(8, 6).Range.Text = "Mínimo de 30 g/l"
            .Cell(9, 6).Range.Text = "50 mg/l +- 10"
            .Cell(10, 6).Range.Text = "1,12 +- 0,02"

            .Columns.Item(1).Select()
            oWord.Selection.Cells().Width = 90
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
            oWord.Selection.Font.Size = 9
            .Columns.Item(2).Select()
            oWord.Selection.Cells().Width = 50
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oWord.Selection.Font.Size = 9
            .Columns.Item(3).Select()
            oWord.Selection.Cells().Width = 54
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
            .Columns.Item(4).Select()
            oWord.Selection.Cells().Width = 90
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
            .Columns.Item(5).Select()
            oWord.Selection.Cells().Width = 96
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
            .Columns.Item(6).Select()
            oWord.Selection.Cells().Width = 90
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft

            .Rows.Item(1).Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
            .Rows.Item(1).Cells.Item(1).Merge(.Rows.Item(1).Cells.Item(6))
            .Rows.Item(1).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdYellow
            .Rows.Item(1).Range.Font.Size = 14
            .Rows.Item(1).Range.Font.Bold = True
            .Cell(1, 1).Range.Text = "CARACTERISTICAS QUIMICAS"

            .Rows.Item(2).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGray25
            .Rows.Item(2).Select()
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
            .Rows.Item(2).Range.Font.Size = 9
            .Rows.Item(2).Range.Font.Bold = True
            .Rows.Height = 9
        End With

        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Format.SpaceAfter = 14

        oPara2 = oDoc.Content.Paragraphs.Add
        oPara2.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify
        oPara2.Range.Text = "Los resultados obtenidos en nuestro laboratorio, mediante métodos estandarizados y siguiendo la legislación vigente, establecen que este lote cumple las condiciones especificas y reglamentarias para su envasado y consumo."

        oPara3 = oDoc.Content.Paragraphs.Add
        oPara3.Format.SpaceAfter = 36

        oPara4 = oDoc.Content.Paragraphs.Add
        oPara4.Range.Text = "Jerez,  " & String.Format("D", Me.dtpFecha.Value)
        oPara4.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight

        oPara5 = oDoc.Content.Paragraphs.Add
        oPara5.Format.SpaceAfter = 72

        oPara6 = oDoc.Content.Paragraphs.Add
        oPara6.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        oPara6.Range.Text = cboAnalistas.Text & Environment.NewLine & _
                            "Responsable de Laboratorio"

        oDoc.ActiveWindow.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter
        oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
        oWord.Selection.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlue
        oWord.Selection.Font.Size = 9
        oWord.Selection.TypeText(Text:="V. La Andaluza, S.L." & Environment.NewLine & _
                                       "C/ Marquetería, 7. 11408 Jerez de la Frontera. Cádiz. España." & Environment.NewLine & _
                                       "Teléfono: +34 956144538; Fax: +34 956142230" & Environment.NewLine & _
                                       "calidad@landaluza.es  www.landaluza.es")

        oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument
        oWord.Visible = True
        oWord.NormalTemplate.Saved = True
        oWord = Nothing
        oDoc = Nothing
        'Me.Close()
    End Sub


    Private Sub GenerarBoletinEnvasado()
        Dim oWord As New Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTabla, oTablaTitulo As Microsoft.Office.Interop.Word.Table

        Dim oPara1, oPara2, oPara3, oPara4, oPara5, oPara6 As Microsoft.Office.Interop.Word.Paragraph
        Dim tab, tabAnaliticas, tablaCategorias As System.Data.DataTable
        Dim contCategorias As Integer
        Dim pie, comentarios, Ruta As String
        Dim bmp As Bitmap = Nothing

        dtb.PrepararConsulta("LotesAnalizadosSelectDetallesByCodigoLote @cod")
        dtb.AñadirParametroConsulta("@cod", m_CodigoLote)
        tab = dtb.Consultar

        If tab.Rows.Count > 0 Then
            pie = ""
            Ruta = ""
            comentarios = ""

            'valores tomados del formulario
            'comentarios
            If Me.cbComentario1.Checked Then
                comentarios &= Me.txtComentario1.Text & Environment.NewLine
            End If

            If Me.cbComentario2.Checked Then
                comentarios &= Me.txtComentario2.Text & Environment.NewLine
            End If
            'logo y pie de pagina
            If Me.rdbJR.Checked Then
                Ruta = "C:\LogoJR.bmp"
                bmp = My.Resources.LogoJR
                pie = "J.R. Sabater, S.A." & Environment.NewLine & _
                                       "Avda. de Murcia, 61. 30110 Cabeza de Torres. Murcia. España." & Environment.NewLine & _
                                       "Teléfono: +34 968830979; Fax: +34 968832485" & Environment.NewLine & _
                                       "comercial@jrsabater.com  www.jrsabater.com" & Environment.NewLine
            ElseIf Me.rdbLA.Checked Then
                Ruta = "C:\LogoLA.bmp"
                bmp = My.Resources.LogoLA
                pie = "V. La Andaluza, S.L." & Environment.NewLine & _
                                       "C/ Marquetería, 7. 11408 Jerez de la Frontera. Cádiz. España." & Environment.NewLine & _
                                       "Teléfono: +34 956144538; Fax: +34 956142230" & Environment.NewLine & _
                                       "calidad@landaluza.es  www.landaluza.es" & Environment.NewLine
            ElseIf Me.rdbSinLogo.Checked Then
                Ruta = ""
            End If

            'seteo de opciones del documento
            oWord.Visible = False
            oDoc = oWord.Documents.Add
            oDoc.ActiveWindow.Selection.Style = Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStylePlainText

            With (oDoc.PageSetup)
                Try
                    .PaperSize = Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4
                Catch ex As Exception
                End Try
                Try
                    .Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientPortrait
                Catch ex As Exception
                End Try
                .LeftMargin = oWord.CentimetersToPoints(2)
                .BottomMargin = oWord.CentimetersToPoints(1)
                .TopMargin = oWord.CentimetersToPoints(1)
            End With

            oTablaTitulo = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 2)

            With oTablaTitulo
                .Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Cell(1, 1).Range.InsertAfter("")
                .Cell(1, 1).Width = 63

                If Ruta <> "" Then
                    bmp.Save(Ruta, Imaging.ImageFormat.Bmp)
                    .Cell(1, 1).Range.InlineShapes.AddPicture(Ruta, False, True)
                    IO.File.Delete(Ruta)
                    .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                End If

                .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                .Cell(1, 2).Width = oWord.PixelsToPoints(560)
                .Cell(1, 2).Range.Font.Size = 18
                .Cell(1, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                .Cell(1, 2).Range.InsertAfter(UCase(Me.txtCabecera.Text)) '"BOLETIN DE CONTROL DE CALIDAD PARA LOTE ENVASADO")
            End With

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Format.SpaceAfter = 18

            oTabla = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, If(tab.Rows(0).Item("CodigoLote").ToString.Contains("Env"), 3, 2), 2)

            With oTabla
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

                .mam_FormatoLinea(1, 1, 120, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Artículo:")
                If tab.Rows(0).Item("CodigoLote").ToString.Contains("Env") Then
                    .mam_FormatoLinea(2, 1, 120, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Lote envasado:")
                    .mam_FormatoLinea(3, 1, 120, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Lote producto:")
                Else
                    .mam_FormatoLinea(2, 1, 120, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Lote producto:")
                End If

                .mam_FormatoLinea(1, 2, 260, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(0).Item("Producto"))
                If tab.Rows(0).Item("CodigoLote").ToString.Contains("Env") Then
                    .mam_FormatoLinea(2, 2, 260, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "") 'tab.Rows(0).Item("Referencia"))
                    .mam_FormatoLinea(3, 2, 260, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(0).Item("CodigoLote"))
                Else
                    .mam_FormatoLinea(2, 2, 260, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(0).Item("CodigoLote"))
                End If
                oPara1 = oDoc.Content.Paragraphs.Add
                oPara1.Format.SpaceAfter = 14
            End With

            oTabla = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 2)

            With oTabla
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

                .mam_FormatoLinea(1, 1, 90, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Nº muestra:")
                .mam_FormatoLinea(2, 1, 90, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Depósito:")
                .mam_FormatoLinea(3, 1, 90, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Volumen:")

                .mam_FormatoLinea(1, 2, 90, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(0).Item("Referencia"))
                .mam_FormatoLinea(2, 2, 90, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(0).Item("Codigo"))
                .mam_FormatoLinea(3, 2, 90, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(0).Item("volumen"))

                oPara1 = oDoc.Content.Paragraphs.Add
                oPara1.Format.SpaceAfter = 14
            End With

            'generacion del cuerpo
            contCategorias = 0
            dtb.PrepararConsulta("LotesSelectCategoriasParametrosByCodigoLote @cod")
            dtb.AñadirParametroConsulta("@cod", m_CodigoLote)
            tablaCategorias = dtb.Consultar()

            While contCategorias < tablaCategorias.Rows.Count
                dtb.PrepararConsulta("LotesSelectByCodigoLoteYCatagoriaParametro @cod, @cat")
                dtb.AñadirParametroConsulta("@cod", m_CodigoLote)
                dtb.AñadirParametroConsulta("@cat", tablaCategorias.Rows(contCategorias).Item("ID"))
                tabAnaliticas = dtb.Consultar()

                If esCategoriaImprimible(tabAnaliticas) Then
                    TituloColumna(oDoc, tablaCategorias.Rows(contCategorias).Item("Nombre"))

                    Me.AñadirParametros(tabAnaliticas, oDoc, oWord.PixelsToPoints(38))
                End If

                contCategorias += 1
            End While




            'generacion del detalle
            If comentarios <> "" Then
                oDoc.Content.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify
                oPara2 = oDoc.Content.Paragraphs.Add
                oPara2.Range.Font.Size = 10
                'oPara2.Format.Alignment = WdParagraphAlignment.wdAlignParagraphDistribute
                oPara2.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify
                oPara2.Range.Text = comentarios


                oPara3 = oDoc.Content.Paragraphs.Add
                oPara3.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify
                oPara3.Format.SpaceAfter = 36
            End If

            oPara4 = oDoc.Content.Paragraphs.Add
            oPara4.Range.Text = "Jerez de la Frontera,  " & String.Format("D", Today).Replace(",", "")
            oPara4.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight

            oPara5 = oDoc.Content.Paragraphs.Add
            oPara5.Format.SpaceAfter = 42

            oPara6 = oDoc.Content.Paragraphs.Add
            oPara6.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oPara6.Range.Text = cboAnalistas.Text & Environment.NewLine & _
                                Me.spBoletin.cargo(Me.cboAnalistas.SelectedValue) '"Responsable de " & Me.spBoletin.cargoAnalista(Me.cboAnalistas.SelectedValue)

            Try
                oDoc.FitToPages()
            Catch ex As Exception
            End Try

            If pie <> "" Then
                oDoc.ActiveWindow.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                'oWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify
                oWord.Selection.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlue
                oWord.Selection.Font.Size = 6
                oWord.Selection.TypeText(Text:=pie)
            End If

            oDoc.ActiveWindow.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oWord.Selection.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlue
            oWord.Selection.Font.Size = 7
            oWord.Selection.TypeText(Text:=Me.dtpFecha.Value)

            'creacion del word
            oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument
            oWord.Visible = True
            oWord.NormalTemplate.Saved = True
            oWord = Nothing
            oDoc = Nothing
        Else
            messagebox.show("No se encuentra el lote " & m_CodigoLote, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Function esCategoriaImprimible(ByRef tabAnaliticas As System.Data.DataTable) As Boolean
        Dim imprimir As Boolean
        Dim j As Integer = 0
        Dim cbAux As System.Windows.Forms.CheckBox

        While (j < tabAnaliticas.Rows.Count) And Not imprimir

            For Each cbAux In Me.v_Parametros
                If cbAux.Text = tabAnaliticas.Rows(j).Item("Nombre") Then
                    If cbAux.Checked Then
                        imprimir = True
                    End If
                End If
            Next

            j += 1
        End While

        Return imprimir
    End Function

    Private Sub TituloColumna(ByRef oDoc As Microsoft.Office.Interop.Word.Document, ByVal titulo As String)
        Dim oTablaTituloAnaliticas As Microsoft.Office.Interop.Word.Table

        oDoc.Content.Paragraphs.Add()
        oTablaTituloAnaliticas = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 1)

        oTablaTituloAnaliticas.Range.Font.Bold = True

        With oTablaTituloAnaliticas
            .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
            .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
            .mam_FormatoLinea(1, 1, 212, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "Análisis " & titulo)
        End With
        oTablaTituloAnaliticas.Range.Font.Bold = False
        oTablaTituloAnaliticas.Cell(1, 1).Range.Font.Bold = True
        oDoc.Content.Paragraphs.Add().Format.SpaceAfter = 1
    End Sub

    Private Sub AñadirParametros(ByRef tabAnaliticas As System.Data.DataTable, ByRef oDoc As Microsoft.Office.Interop.Word.Document, ByVal anchoCelda As Integer)
        Dim j As Integer = 0
        Dim fila As Integer = 2
        Dim cbAux As System.Windows.Forms.CheckBox
        Dim oTablaAnaliticas As Microsoft.Office.Interop.Word.Table
        Dim para As Microsoft.Office.Interop.Word.Paragraph
        Dim especificacion As String
        Dim c1, c2, c3, c4, c5 As Integer
        c1 = 100
        c2 = 56
        c3 = 65
        c4 = 85
        c5 = 100


        oTablaAnaliticas = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 5)
        oTablaAnaliticas.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
        oTablaAnaliticas.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

        oTablaAnaliticas.Rows.HeadingFormat = True
        oTablaAnaliticas.Range.Font.Bold = True

        oTablaAnaliticas.mam_FormatoLinea(1, 1, c1, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Parámetro")
        oTablaAnaliticas.mam_FormatoLinea(1, 2, c2, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Valor")
        oTablaAnaliticas.mam_FormatoLinea(1, 3, c3, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Unidades")
        oTablaAnaliticas.mam_FormatoLinea(1, 4, c4, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Método análisis")
        oTablaAnaliticas.mam_FormatoLinea(1, 5, c5, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "Especificaciones")
        oTablaAnaliticas.Rows.Add()


        oTablaAnaliticas.Rows.HeadingFormat = False
        oTablaAnaliticas.Range.Font.Bold = False

        While j < tabAnaliticas.Rows.Count
            For Each cbAux In Me.v_Parametros
                If cbAux.Text = tabAnaliticas.Rows(j).Item("Nombre") Then
                    If cbAux.Checked Then
                        oTablaAnaliticas.Cell(fila, 1).Width = anchoCelda
                        oTablaAnaliticas.mam_FormatoLinea(fila, 1, c1, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Convert.ToString(tabAnaliticas.Rows(j).Item("Nombre")))
                        oTablaAnaliticas.mam_FormatoLinea(fila, 2, c2, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, _
                                                         Format(Convert.ToDouble(tabAnaliticas.Rows(j).Item("Valor")), "#0.000"))
                        oTablaAnaliticas.mam_FormatoLinea(fila, 3, c3, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Convert.ToString(tabAnaliticas.Rows(j).Item("Abreviatura")))
                        oTablaAnaliticas.mam_FormatoLinea(fila, 4, c4, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Convert.ToString(tabAnaliticas.Rows(j).Item("MetodoAnalisis")))

                        If Convert.ToString(tabAnaliticas.Rows(j).Item("Minimo")) = "" And Convert.ToString(tabAnaliticas.Rows(j).Item("Maximo")) <> "" Then
                            especificacion = "< " & Convert.ToString(tabAnaliticas.Rows(j).Item("Maximo"))
                        ElseIf Convert.ToString(tabAnaliticas.Rows(j).Item("Maximo")) = "" And Convert.ToString(tabAnaliticas.Rows(j).Item("Minimo")) <> "" Then
                            especificacion = "> " & Convert.ToString(tabAnaliticas.Rows(j).Item("Maximo"))
                        ElseIf tabAnaliticas.Rows(j).Item("Minimo").ToString = "" And Convert.ToString(tabAnaliticas.Rows(j).Item("Maximo")) = "" And _
                            Convert.ToString(tabAnaliticas.Rows(j).Item("desviacionMinimo")) <> "" And Convert.ToString(tabAnaliticas.Rows(j).Item("desviacionMaximo")) <> "" Then
                            especificacion = Convert.ToString(tabAnaliticas.Rows(j).Item("desviacionMinimo")) & "±" & Convert.ToString(tabAnaliticas.Rows(j).Item("desviacionMaximo"))
                        ElseIf Convert.ToString(tabAnaliticas.Rows(j).Item("Minimo")) <> "" And Convert.ToString(tabAnaliticas.Rows(j).Item("Maximo")) <> "" Then
                            especificacion = "Entre " & Convert.ToString(tabAnaliticas.Rows(j).Item("Minimo")) & " - " & Convert.ToString(tabAnaliticas.Rows(j).Item("Maximo"))
                        Else
                            especificacion = ""
                        End If

                        oTablaAnaliticas.mam_FormatoLinea(fila, 5, c5, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, especificacion)

                        oTablaAnaliticas.Rows.Add()
                    End If
                End If
            Next

            j += 1
            fila += 1
        End While

        oTablaAnaliticas.Rows.Last.Delete()
        'oDoc.Content.Paragraphs.Add().Format.SpaceAfter = 0
        para = oDoc.Content.Paragraphs.Add
        para.Range.Font.Size = 4
        para.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
        para.Range.Text = "Según Real Decreto 661/2012, de 13 de abril"
        oDoc.Content.Paragraphs.Add().Format.SpaceAfter = 14
    End Sub
End Class
