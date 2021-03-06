Imports BasesParaCompatibilidad.DataGridViewExtension


Public Class frmPaletsProducidos
    Inherits BasesParaCompatibilidad.GridSimpleForm
    Implements  BasesParaCompatibilidad.queriable ', BotleForm

    Private dboPaletsProducidos As DBO_PaletsProducidos
    Private frmCompletar As frmEntPaletsContenidos
    Private TipoFormato As Integer
    Private datasourceIncompletos As DataTable
    Private linea As Integer
    Private envasado As Integer
    'Private fechaEnvasado As date
    Public Const COMPLETAR As Byte = 98
    Private etiqueta As etiquetas.Etiqueta


    Public ReadOnly Property maestroId As Integer 'Implements BotleForm.maestroId
        Get
            Return Me.dboPaletsProducidos.FormatoID
        End Get
    End Property


    'Public WriteOnly Property FormatoEnvasado As Integer
    '    Set(value As Integer)
    '        Me.dboPaletsProducidos.FormatoID = value
    '        Me.m_MaestroID = value
    '        dgvFill(True)
    '    End Set
    'End Property

    Public Sub New(ByVal linea As Integer, Optional ByVal MaestroID As Integer = 0, Optional ByVal envasado As Integer = Nothing)
        MyBase.New(New spPaletsProducidos, MaestroID)
        InitializeComponent()

        MyBase.sp = sp

        dboPaletsProducidos = New DBO_PaletsProducidos
        Me.linea = linea
        Me.envasado = envasado
        sp.DataGridViewStoredProcedure= If(m_MaestroID = Nothing, sp.DataGridViewStoredProcedureForSelect, sp.DataGridViewStoredProcedureForFilteredSelect & " '" & Me.m_MaestroID & "'")
        MyBase.newRegForm = Nothing 'New frmEntPaletsProducidos()
        Me.SplitContainer1.Panel1.Controls.Add(dgvGeneral)

        butExcel.Visible = True
        Me.refrescar(MaestroID)

        'If Config.UserType = 1 Or Config.UserType = 9 Or Config.UserType = 4 Then
        Dim btnEtiqueta2 As ToolStripButton = Me.bdnGeneral.Items.Add("Etiqueta")
        btnEtiqueta2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        btnEtiqueta2.Image = My.Resources.print_ico
        btnEtiqueta2.TextDirection = ToolStripTextDirection.Horizontal
        btnEtiqueta2.TextAlign = ContentAlignment.MiddleRight
        AddHandler btnEtiqueta2.Click, AddressOf mostrarEtiqueta


        'Dim btnEtiqueta3 As ToolStripButton = Me.bdnGeneral.Items.Add("Imprimir etiqueta ivan")
        'btnEtiqueta3.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        'btnEtiqueta3.Image = My.Resources.print_ico
        'btnEtiqueta3.TextDirection = ToolStripTextDirection.Horizontal
        'btnEtiqueta3.TextAlign = ContentAlignment.MiddleRight
        'AddHandler btnEtiqueta3.Click, AddressOf mostrarEtiqueta2
        ' End If

        etiqueta = New etiquetas.Etiqueta(0, BasesParaCompatibilidad.Config.connectionString)
        Me.dgvPicos.BackgroundColor = Color.White
    End Sub


    Public Overrides Sub Action(TipoAction As String)
        If Me.m_MaestroID <> Nothing Then
            AddHandler newRegForm.afterSave, AddressOf dgvFill
            MyBase.newRegForm.ModoDeAperturaCadena = TipoAction
            'GUImain.a�adirPesta�a(newRegForm)
            newRegForm.ShowDialog()
        End If
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_maestroid <> 0 Then
            dboPaletsProducidos = New DBO_PaletsProducidos
            dboPaletsProducidos.FormatoID = m_MaestroID
            Dim frm As New frmEntPaletsProducidos(Me.linea, Me.TipoFormato, Me.envasado, _
                                                           BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp, dboPaletsProducidos)
            MyBase.newRegForm = frm
            AddHandler frm.afterSave, AddressOf dgvFill
        Else
            EventHandeld = True
        End If

    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboPaletsProducidos = CType(sp, spPaletsProducidos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboPaletsProducidos Is Nothing Then
            Dim frm As New frmEntPaletsProducidos(Me.linea, Me.TipoFormato, Me.envasado, BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, sp, dboPaletsProducidos)
            MyBase.newRegForm = frm
            AddHandler newRegForm.afterSave, AddressOf dgvFill
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(Me.sp.DataGridViewStoredProcedure)
        dataSource = dtb.Consultar()

        datasourceIncompletos = CType(Me.sp, spPaletsProducidos).devolver_palets_incompletos_por_TipoFormato(Me.TipoFormato, dtb)
    End Sub

    Protected Overrides Sub BindDataSource() Implements  BasesParaCompatibilidad.queriable.dataGridViewFill
        If Me.m_MaestroID <> Nothing Then
            'Dim dt As DataTable = DataTableFill(Me.sp.DataGridViewStoredProcedure)

            If Not dataSource Is Nothing Then
                GeneralBindingSource.DataSource = dataSource
                With dgvGeneral
                    .DataSource = GeneralBindingSource
                    '.Columns("Id").Visible = False
                    '.FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                    '.FormatoColumna("ObservacionesPalets", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    '.FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

                    If .Columns.Contains("PaletProducidoID") Then .Columns("PaletProducidoID").Name = "Id"

                    .Columns("Id").Visible = False
                    .Columns("Completa").Visible = False
                    '.FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 60, 1)
                    '.FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 58, 2)
                    '.FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 54, 3)
                    '.FormatoColumna("Tiempo", BasesParaCompatibilidad.TiposColumna.Miles, 63, 4)
                    '.FormatoColumna("Contenidos", BasesParaCompatibilidad.TiposColumna.Miles, 80, 5)
                    '.FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 55, 6)
                    '.FormatoColumna("Velocidad", BasesParaCompatibilidad.TiposColumna.Miles, 82, 7)
                    ''.FormatoColumna("Completa", BasesParaCompatibilidad.TiposColumna.Centro, 71, 8)
                    '.FormatoColumna("Completo", BasesParaCompatibilidad.TiposColumna.Centro, 71, 9)
                    '.FormatoColumna("Multilote", BasesParaCompatibilidad.TiposColumna.Centro, 71, 10)
                    '.FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 11)
                    .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 70, 1)
                    .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 48, 2)
                    .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 44, 3)
                    .FormatoColumna("Tiempo", BasesParaCompatibilidad.TiposColumna.Miles, 53, 4)
                    .FormatoColumna("Contenidos", BasesParaCompatibilidad.TiposColumna.Miles, 70, 5)
                    .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 45, 6)
                    .FormatoColumna("Velocidad", BasesParaCompatibilidad.TiposColumna.Miles, 72, 7)
                    '.FormatoColumna("Completa", BasesParaCompatibilidad.TiposColumna.Centro, 61, 8)
                    .FormatoColumna("Completo", BasesParaCompatibilidad.TiposColumna.Centro, 61, 9)
                    .FormatoColumna("Multilote", BasesParaCompatibilidad.TiposColumna.Centro, 61, 10)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 11)

                End With
            End If




            If Me.TipoFormato <> Nothing Then
                'Dim dtIncompletos As DataTable = Me.sp.devolver_palets_incompletos_por_TipoFormato(Me.TipoFormato)

                If Not datasourceIncompletos Is Nothing Then
                    With dgvPicos
                        .DataSource = datasourceIncompletos
                        .Columns("PaletProducidoID").Visible = False
                        .Columns("ConPaletID").Visible = False
                        .Columns("Articulo").Visible = False
                        .Columns("Cajas").Visible = True
                        .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Izquierda, 70)
                        .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 87)
                        .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)

                    End With
                End If
            End If


        End If
    End Sub

    Public Sub refrescar(ByVal maestroId As Integer) 'Implements BotleForm.refrescar
        Me.dboPaletsProducidos.FormatoID = maestroId


        If Me.m_MaestroID <> Nothing Then
            sp.DataGridViewStoredProcedure= If(m_MaestroID = Nothing, "", sp.DataGridViewStoredProcedureForFilteredSelect & "'" & Me.m_MaestroID & "'")
            Dim spformato As New spFormatosEnvasados
            Dim dtb As New BasesParaCompatibilidad.DataBase
            Dim dboformato As DBO_FormatosEnvasados = spformato.Select_Record(Me.dboPaletsProducidos.FormatoID, dtb)
            Me.TipoFormato = dboformato.TipoFormatoEnvasadoID
        End If
    End Sub

    Private Sub ToolStripOcultar_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripOcultar.Click
        Me.ToolStripCompletar.Enabled = False
        Me.ToolStripMostrar.Enabled = True
        Me.ToolStripOcultar.Enabled = False

        Me.SplitContainer1.SplitterDistance = Me.Height - 90
    End Sub

    Private Sub ToolStripMostrar_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMostrar.Click
        Me.ToolStripCompletar.Enabled = True
        Me.ToolStripMostrar.Enabled = False
        Me.ToolStripOcultar.Enabled = True

        Me.SplitContainer1.SplitterDistance = 273
    End Sub



    Private Sub ToolStripCompletar_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripCompletar.Click
        If m_maestroid <> 0 Then
            If Not Me.dgvPicos.CurrentRow Is Nothing Then
                Dim dboPalet As DBO_PaletsProducidos = Me.dboPaletsProducidos
                Dim spEnvasados As New spEnvasados
                Dim spFormatos As New spFormatosEnvasados
                Dim spTiposFormatos As New spFormatosArticulos
                Dim spContenidoas As New spPaletsContenidos
                Dim dboEnvasado As DBO_Envasados
                ' Dim dboFormato As DBO_FormatosEnvasados
                Dim dboFormatoActual As DBO_FormatosEnvasados
                Dim dboTemp As New DBO_PaletsContenidos



                Dim dtb As New BasesParaCompatibilidad.DataBase
                dboPalet = CType(Me.sp, spPaletsProducidos).Select_Record(CType(Me.dgvPicos.CurrentRow.Cells("PaletProducidoID").Value, Integer), dtb)
                'dboFormato = spFormatos.Select_Record(dboPalet.FormatoID)

                dboFormatoActual = spFormatos.Select_Record(Me.dboPaletsProducidos.FormatoID, dtb)
                dboEnvasado = spEnvasados.Select_Record(dboFormatoActual.EnvasadoID, dtb)

                dboTemp.PaletProducidoID = dboPalet.ID
                dboTemp.id_formatoEnvasado = maestroId
                dboPalet.FormatoID = m_MaestroID


                If Me.linea = 0 Then
                    Dim s As New spPaletsContenidos
                    linea = s.seleccionar_linea_por_formato(dboPaletsProducidos.FormatoID, dtb)
                End If

                Dim spmovimientos As New spPaletsMovimiento
                Dim monodosis As New DispensadorMonodosis
                If spmovimientos.comprobarFormatoEncajado(dboFormatoActual.TipoFormatoEnvasadoID, dtb) Then
                    If Not monodosis.EsDoyPack(dboFormatoActual.TipoFormatoEnvasadoID, dtb) Then
                        Dim frmCompletar As New frmEntPaletsContenidosMonodosis(Me.linea, dboFormatoActual.TipoFormatoEnvasadoID, dboEnvasado.ID, BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spPaletsContenidos, dboTemp)
                        frmCompletar.ModoDeApertura = frmPaletsProducidos.COMPLETAR
                        frmCompletar.Formato = Me.m_MaestroID
                        frmCompletar.Text = "Completar "
                        'GUImain.a�adirPesta�a(frmCompletar)
                        frmCompletar.ShowDialog()
                    Else
                        Dim frmCompletar As New frmEntPaletsContenidosDoypack(dboPaletsProducidos.FormatoID, Me.linea, dboFormatoActual.TipoFormatoEnvasadoID, dboEnvasado.ID, BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spPaletsContenidos, dboTemp)
                        frmCompletar.ModoDeApertura = frmPaletsProducidos.COMPLETAR
                        frmCompletar.Formato = Me.m_MaestroID
                        frmCompletar.Text = "Completar "
                        'GUImain.a�adirPesta�a(frmCompletar)
                        frmCompletar.ShowDialog()
                    End If
                Else
                    frmCompletar = New frmEntPaletsContenidos(Me.linea, dboPaletsProducidos.FormatoID, dboEnvasado.ID, ACCION_INSERTAR, New spPaletsContenidos, dboTemp) 'dboPalet.ID, New spPaletsContenidos, dboTemp)
                    '                AddHandler frmCompletar.afterSave, AddressOf dgvFill
                    frmCompletar.ModoDeApertura = frmPaletsProducidos.COMPLETAR
                    frmCompletar.Formato = Me.m_MaestroID
                    frmCompletar.Text = "Completar "
                    'GUImain.a�adirPesta�a(frmCompletar)
                    frmCompletar.ShowDialog()
                End If



                

                Try
                    Dim pal As New Palet(dboPalet.ID)
                    pal.recuperar_datos(dtb)
                    If pal.Cajas_restantes = 0 Then
                        dboPalet.Terminado = True
                        CType(Me.sp, spPaletsProducidos).Grabar(dboPalet, dtb)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error marcando como terminado el palet, actualice el dato manualmente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    dgvFill()
                End Try
                

            End If
        End If
        'newRegForm.SetDataBussinesObject(CType(Me.dboPaletsProducidos, BasesParaCompatibilidad.databussines))

    End Sub

    Private Sub mostrarEtiqueta()
        If Not Me.dgvGeneral.CurrentRow Is Nothing Then
            Dim spPaletsProducidos As New spPaletsProducidos
            Dim dtb As New BasesParaCompatibilidad.DataBase
            Dim dbo As DBO_PaletsProducidos = spPaletsProducidos.Select_Record(Me.dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
            If Not dbo Is Nothing Then
                If spPaletsProducidos.esMonodosis(Me.dboPaletsProducidos.FormatoID, dtb) Then
                    Return
                End If
                If MessageBox.Show("�Desea imprimir etiqueta?", "Etiqueta palet " & dbo.SCC, _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    'dtb.PrepararConsulta("select max(paletproducidoid) ,max(paletproducidoid), articulo " & _
                    '"from paletsproducidos, FormatosEnvasados, ArticulosEnvasadosHistoricoSinLinea " & _
                    '"where " & _
                    '"FormatoID = FormatoEnvasadoID " & _
                    '"and TipoFormatoEnvasadoID = tipoformato " & _
                    '" and marcaid = 49 " & _
                    '"group by articulo " & _
                    '" order by max(PaletProducidoID) desc")

                    'Dim dt As DataTable = dtb.Consultar
                    'For Each row As DataRow In dt.Rows
                    '    Try
                    '        etiqueta.id = row.Item(0)
                    '        etiqueta.print()
                    '    Catch ex As Exception
                    '        MessageBox.Show("errores :" & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    End Try
                    'Next



                    Try

                        'Dim frmEt As New etiquetas.frmEtiqueta(Me.dgvGeneral.CurrentRow.Cells("Id").Value, BasesParaCompatibilidad.Config.connectionString)
                        'frmEt.Show()
                        etiqueta = New etiquetas.Etiqueta(Me.dgvGeneral.CurrentRow.Cells("Id").Value, BasesParaCompatibilidad.Config.connectionString)
                        etiqueta.cargar()
                        Dim dataset As etiquetas.LADataSet = etiqueta.DataSet
                        Dim frm As New frnEtiquetaEditable(etiqueta.DataSet)
                        If frm.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                            Return
                        End If

                        etiqueta.DataSet = frm.Dataset
                        etiqueta.calcular()
                        etiqueta.print(2, False)

                        spPaletsProducidos.anadir_impresion_etiqueta(Me.dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
                        Dim textNotificar As String = "Se ha vuelto a imprimir la etiqueta de la matricula  " & Environment.NewLine() & Me.dgvGeneral.CurrentRow.Cells("SCC").Value.ToString & " el d�a " & DateTime.Now.ToString
                        Dim mail As New Mail.Mail1And1(True, "Reimpresion de etiqueta " & Me.dgvGeneral.CurrentRow.Cells("SCC").Value.ToString & _
                                                       "el " & DateTime.Now.ToString, textNotificar, _
                                                       String.Empty, _
                                                       Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                        String.Empty, String.Empty, Config.MailClientHost, False)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If
            Else
                MessageBox.Show("No se pudo recuperar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    ' Private Sub mostrarEtiqueta2()
    'Dim cs As New BasesParaCompatibilidad.Consola

    'Try
    '    etiqueta = New etiquetas.Etiqueta(55940, BasesParaCompatibilidad.Config.connectionString)
    '    etiqueta.print()
    '    cs.Espera(5000)

    '    etiqueta = New etiquetas.Etiqueta(56133, BasesParaCompatibilidad.Config.connectionString)
    '    etiqueta.print()
    '    cs.Espera(2000)
    'Catch ex As Exception

    'End Try

    'End Sub
End Class
