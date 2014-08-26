Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsProducidos2
    Inherits BasesParaCompatibilidad.FrmAheredarOld



    Public m_DBO_Envasado As DBO_Envasados2
    'Private m_DBO_FormatoEnvasado As DBO_FormatosEnvasados2
    Private formatoId As Integer
    Private butNroRegistros As ToolStripButton
    Private labelRegistros As ToolStripItem
    Private controlDePintado As Boolean
    Private print As ToolStripButton
    Private btnEtiqueta2 As ToolStripButton

    Sub New(ByVal FormatoId As Integer, Optional embebido As Boolean = False)
        MyBase.New(New spPaletsProducidos2, FormatoId)
        InitializeComponent()
        controlDePintado = False
        m_DBO_Envasado = DBO_Envasados2.Instance
        'm_DBO_FormatoEnvasado = DBO_FormatosEnvasados2.Instance        
        Me.formatoId = FormatoId
        Me.Embebido = embebido
        spSelectDgv = "PaletsProducidos5SelectDgv"

        If Me.Embebido <> True Then
            Me.MinimumSize = New Size(1149, 488)
            Me.butNuevo.Visible = False
            Me.butEliminar.Visible = False
            butSalir.Visible = True
            Me.filterManager = New DgvFilterPopup.DgvFilterManager(Me.dgvGeneral)
        End If

        If Not (Config.UserType = 1 Or Config.UserType = 9 Or Config.UserType = 4) Then
            Me.butEliminar.Visible = False
            Me.butEliminar.Enabled = False
        End If

        btnEtiqueta2 = Me.bdnGeneral.Items.Add("Imprimir etiqueta")
        btnEtiqueta2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        btnEtiqueta2.Image = My.Resources.print_ico
        btnEtiqueta2.TextDirection = ToolStripTextDirection.Horizontal
        btnEtiqueta2.TextAlign = ContentAlignment.MiddleRight
        AddHandler btnEtiqueta2.Click, AddressOf mostrarEtiqueta

        Me.dgvGeneral.BringToFront()
        dtb.TimeOut = 300
    End Sub

    Private Sub frmPaletsProducidos2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not Me.Embebido Then
            labelRegistros = Me.bdnGeneral.Items.Add("Se muestran solamente los ultimos 1.000 registros.")
            labelRegistros.Text = "Se muestran solamente los ultimos 1.000 registros."
            labelRegistros.DisplayStyle = ToolStripItemDisplayStyle.Text
            labelRegistros.Enabled = False
            Me.bdnGeneral.AddNewItem = labelRegistros

            butNroRegistros = Me.bdnGeneral.Items.Add("Mostrar todos")
            butNroRegistros.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            butNroRegistros.Image = My.Resources.view_refresh_4
            AddHandler butNroRegistros.Click, AddressOf butNroRegistros_Click

            ''prueba
            'print = Me.bdnGeneral.Items.Add("Imprimir resultados")
            'print.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            'print.Text = "Imprimir"
            'print.TextDirection = ToolStripTextDirection.Horizontal
            'print.TextAlign = ContentAlignment.MiddleRight
            'print.Image = My.Resources.print_ico
            'AddHandler print.Click, AddressOf PrintDocument1_PrintPage

            Dim sp As New spPaletsProducidos
            sp.cargar_PaletsProducidosEstados(Me.cboEstado)
        Else
            Me.Panel1.Visible = False
        End If

    End Sub

    'Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    printGrilla.Print()
    'End Sub

    Private Sub butNroRegistros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If butNroRegistros.Text = "Mostrar 1000" Then
            spSelectDgv = "PaletsProducidos5SelectDgv"
            labelRegistros.Text = "Se muestran los 1000 primeros registros."
            butNroRegistros.Text = "Mostrar todos"
        Else
            spSelectDgv = "PaletsProducidos5SelectDgvAll"
            labelRegistros.Text = "Se muestran todos los registros."
            butNroRegistros.Text = "Mostrar 1000"
        End If

        dgvFill()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Overrides Sub Eliminar()
        Try
            If dgvGeneral.CurrentRow Is Nothing Then
                MessageBox.Show("Pulse antes sobre el palet a eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Dim response As DialogResult
            Dim multiopcion As Boolean


            If CType(sp, spPaletsProducidos2).isDeleteAllowed(dgvGeneral.CurrentRow.Cells("PaletProducidoID").Value) Then
                response = MessageBox.Show("El palet seleccionado se encuentra entre los ultimos 15 producidos" & Environment.NewLine & _
                                  "y , por tanto, puede eliminar completamente" & Environment.NewLine & _
                                  "¿Eliminar el palet por completo?" & Environment.NewLine & _
                                  "(pulse 'No' para borrar los contenidos) ", _
                                  "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                multiopcion = True
            Else
                response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                               "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                multiopcion = False
            End If

            If response = DialogResult.Yes Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                CType(sp, spPaletsProducidos2).DeletePaletsProducidos2(dgvGeneral.CurrentRow.Cells("PaletProducidoID").Value, If(multiopcion = True, True, False))

                dtb.PrepararConsulta("PaletsProducidos3SelectByFormatoEnvasadoID @for")
                dtb.AñadirParametroConsulta("@for", Me.formatoId)
                GeneralBindingSource.DataSource = dtb.Consultar()
                '                GeneralBindingSource.DataSource = dtb.Consultar("PaletsProducidos3SelectByFormatoEnvasadoID " & Me.formatoId)
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ElseIf response = DialogResult.No And multiopcion Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                CType(sp, spPaletsProducidos2).DeletePaletsProducidos2(dgvGeneral.CurrentRow.Cells("PaletProducidoID").Value, False)

                dtb.PrepararConsulta("PaletsProducidos3SelectByFormatoEnvasadoID @for")
                dtb.AñadirParametroConsulta("@for", Me.formatoId)
                GeneralBindingSource.DataSource = dtb.Consultar()
                'GeneralBindingSource.DataSource = dtb.Consultar("PaletsProducidos3SelectByFormatoEnvasadoID " & Me.formatoId)
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim frmEnt As frmEntPaletsProducidos2
        Dim m_DBO_PaletsProducidos2 As DBO_PaletsProducidos2 = DBO_PaletsProducidos2.Instance

        frmEnt = New frmEntPaletsProducidos2(Me.formatoId, Me.Embebido)
        Dim resp As Long = vbYes

        If TipoAction = ACCION_INSERTAR Then
            'Asignar los campos que tenemos que pasar de este form a frmEntPaletsProducidos2 para poder imprimir boletines
            m_DBO_PaletsProducidos2.PaletProducidoID = 0
            m_DBO_PaletsProducidos2.FormatoID = Me.formatoId
            m_DBO_PaletsProducidos2.LineaID = m_DBO_Envasado.LineaID
            If dataSource Is Nothing Then
                m_DBO_PaletsProducidos2.EsPrimerPalet = False
                frmEnt.ModoDeApertura = frmEntPaletsProducidos2.INSERTAR_PRIMER_PALET
            Else
                If dataSource.Rows.Count = 0 Then
                    m_DBO_PaletsProducidos2.EsPrimerPalet = False
                    frmEnt.ModoDeApertura = frmEntPaletsProducidos2.INSERTAR_PRIMER_PALET
                Else
                    m_DBO_PaletsProducidos2.EsPrimerPalet = True
                    frmEnt.ModoDeApertura = BasesParaCompatibilidad.FrmAHeredarEntOld.INSERCION
                End If
            End If
        ElseIf TipoAction = ACCION_MODIFICAR Then
            Try
                m_DBO_PaletsProducidos2 = CType(sp, spPaletsProducidos2).Select_Record(Me.dgvGeneral.SelectedRows(0).Cells("PaletProducidoID").Value)
                m_DBO_PaletsProducidos2.EsPrimerPalet = False
                frmEnt.ModoDeApertura = BasesParaCompatibilidad.FrmAHeredarEntOld.MODIFICACION
                If Convert.ToString(Me.dgvGeneral.SelectedRows(0).Cells("Contenidos").Value) = "" Or _
                    Convert.ToString(Me.dgvGeneral.SelectedRows(0).Cells("Contenidos").Value) = "0" Then
                    resp = MessageBox.Show("Este palet no tiene contenidos." & _
                                Environment.NewLine & Environment.NewLine & "¿Desea volver a utilizarlo?", _
                                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If resp = vbYes Then
                        frmEnt.reusado = True
                    End If
                End If
            Catch ex As Exception
                resp = vbNo
                MessageBox.Show("Asegurese de seleccionar una fila.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            Try
                m_DBO_PaletsProducidos2 = CType(sp, spPaletsProducidos2).Select_Record(Me.dgvGeneral.SelectedRows(0).Cells("PaletProducidoID").Value)
                m_DBO_PaletsProducidos2.EsPrimerPalet = False
                frmEnt.ModoDeApertura = BasesParaCompatibilidad.FrmAHeredarEntOld.VISION
            Catch ex As Exception
                resp = vbNo
                MessageBox.Show("Asegurese de seleccionar una fila.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If

        If resp = vbYes Then
            frmEnt.padre = Me
            frmEnt.ShowDialog()
            If Not Me.dgvGeneral Is Nothing Then dgvFill()
        End If
    End Sub


    Protected Overrides Sub dgvFill()

        ' Protected Overrides Sub cargar_datos()
        If Me.Embebido Then
            dtb.PrepararConsulta("PaletsProducidos6SelectByFormatoEnvasadoID @for")
            dtb.AñadirParametroConsulta("@for", Me.formatoId)
            dataSource = dtb.Consultar()
            'dataSource = dtb.Consultar("PaletsProducidos6SelectByFormatoEnvasadoID " & Me.formatoId)
        Else

            If Me.cbEstado.Checked Then
                dtb.PrepararConsulta("PaletsProducidos5SelectDgvByEstado @estado")
                dtb.AñadirParametroConsulta("@estado", Me.cboEstado.SelectedValue)
                dataSource = dtb.Consultar()
                'dataSource = dtb.Consultar("PaletsProducidos5SelectDgvByEstado " & Me.cboEstado.SelectedValue)
            Else
                dataSource = dtb.Consultar(spSelectDgv)
            End If
        End If
        'End Sub

        'Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            dgvGeneral.SuspendLayout()
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("PaletProducidoID").Visible = False
            End With



            If Not Me.Embebido Then
                With dgvGeneral
                    If Me.cbEstado.Checked Then
                        .Columns("Cajas").Visible = False
                        .Columns("Contenidos").Visible = False
                        .Columns("Completo").Visible = False
                        .Columns("EnAlmacen").Visible = False
                        .Columns("Multilote").Visible = False
                    Else
                        .Columns("Cajas").Visible = True
                        .Columns("Contenidos").Visible = True
                        .Columns("Completo").Visible = True
                        .Columns("EnAlmacen").Visible = True
                        .Columns("Multilote").Visible = True
                    End If

                    .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 90, 1)
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 2)
                    .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 3)
                    .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 45, 4)
                    .FormatoColumna("Contenidos", BasesParaCompatibilidad.TiposColumna.Miles, 70, 5)
                    .FormatoColumna("Completo", BasesParaCompatibilidad.TiposColumna.Centro, 61, 6)
                    .FormatoColumna("EnAlmacen", BasesParaCompatibilidad.TiposColumna.Centro, 61, 7)
                    .FormatoColumna("Multilote", BasesParaCompatibilidad.TiposColumna.Centro, 61, 8)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 9)
                End With
            Else
                With dgvGeneral
                    .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 90, 1)
                    .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 88, 2)
                    .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 84, 3)
                    .FormatoColumna("Tiempo", BasesParaCompatibilidad.TiposColumna.Miles, 53, 4)
                    .FormatoColumna("Contenidos", BasesParaCompatibilidad.TiposColumna.Miles, 70, 5)
                    .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 45, 6)
                    .FormatoColumna("Velocidad", BasesParaCompatibilidad.TiposColumna.Miles, 72, 7)
                    .FormatoColumna("Completa", BasesParaCompatibilidad.TiposColumna.Centro, 61, 8)
                    .FormatoColumna("Completo", BasesParaCompatibilidad.TiposColumna.Centro, 61, 9)
                    .FormatoColumna("Multilote", BasesParaCompatibilidad.TiposColumna.Centro, 61, 10)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 11)
                End With
            End If

            dgvGeneral.ResumeLayout()
        End If
    End Sub

    'Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintGrilla.PrintPage
    '    Dim cabecera(1) As String
    '    cabecera(1) = "Informe de palets producidos"
    '    Dim p As New Printer
    '    p.imprimirGrilla(Me.dgvGeneral, cabecera, Nothing, False, False)
    'End Sub

    Private Sub cbEstado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbEstado.CheckedChanged, lEstado.Click
        Me.cboEstado.Enabled = Me.cbEstado.Checked
        Me.dgvFill()
    End Sub

    Private Sub cboEstado_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboEstado.SelectedValueChanged
        Me.dgvFill()
    End Sub

    Private Sub mostrarEtiqueta()
        If Not Me.dgvGeneral.CurrentRow Is Nothing Then
            Dim sp As New spPaletsProducidos
            Dim dbo As DBO_PaletsProducidos = sp.Select_Record(Me.dgvGeneral.CurrentRow.Cells("PaletProducidoID").Value)
            If Not dbo Is Nothing Then
                If MessageBox.Show("¿Desea imprimir etiqueta?", "Etiqueta palet " & dbo.SCC, _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim frm As New frmEtiqueta0(dbo.ID, True)
                    frm.Show()
                    Try
                        Dim spPalet As New spPaletsProducidos
                        spPalet.anadir_impresion_etiqueta(Me.dgvGeneral.CurrentRow.Cells("PaletProducidoID").Value)
                        Dim textNotificar As String = "Se ha vuelto a imprimir la etiqueta de la matricula  " & Environment.NewLine & Me.dgvGeneral.CurrentRow.Cells("SCC").Value & " el día " & Now.Date.ToString
                        Dim mail As New Mail.Mail1And1(True, "Reimpresion de etiqueta " & Me.dgvGeneral.CurrentRow.Cells("SCC").Value & _
                                                       "el " & Now.Date.ToString, textNotificar, _
                                                       String.Empty, _
                                                       Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                        String.Empty, String.Empty, Config.MailClientHost, False)
                    Catch ex As Exception

                    End Try
                End If
            Else
                MessageBox.Show("No se ppudo recuperar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub


End Class
