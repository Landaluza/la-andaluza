Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsProducidos3
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboPaletsProducidos As DBO_PaletsProducidos
    Private butNroRegistros As ToolStripButton
    Private labelRegistros As ToolStripItem
    Private print As ToolStripButton
    Private spForamtosEnvasados As spFormatosEnvasados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPaletsProducidos, MaestroID)
        InitializeComponent()

        dboPaletsProducidos = New DBO_PaletsProducidos
        spForamtosEnvasados = New spFormatosEnvasados
        ' sp.DataGridViewStoredProcedure= sp.DataGridViewStoredProcedureForSelect
        sp.DataGridViewStoredProcedure = "PaletsProducidos6SelectDgv"
        butExcel.Visible = True

        If Config.UserType = 1 Or Config.UserType = 9 Or Config.UserType = 4 Then
            Dim btnEtiqueta2 As ToolStripButton = Me.bdnGeneral.Items.Add("Imprimir etiqueta")
            btnEtiqueta2.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            btnEtiqueta2.Image = My.Resources.print_ico
            btnEtiqueta2.TextDirection = ToolStripTextDirection.Horizontal
            btnEtiqueta2.TextAlign = ContentAlignment.MiddleRight
            AddHandler btnEtiqueta2.Click, AddressOf mostrarEtiqueta
        End If

        labelRegistros = Me.bdnGeneral.Items.Add("Se muestran solamente los ultimos 1.000 registros.")
        labelRegistros.Text = "Se muestran solamente los ultimos 1.000 registros."
        labelRegistros.DisplayStyle = ToolStripItemDisplayStyle.Text
        labelRegistros.Enabled = False
        Me.bdnGeneral.AddNewItem = labelRegistros

        butNroRegistros = Me.bdnGeneral.Items.Add("Mostrar todos")
        butNroRegistros.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        butNroRegistros.Image = My.Resources.view_refresh_4
        AddHandler butNroRegistros.Click, AddressOf butNroRegistros_Click

        'prueba
        print = Me.bdnGeneral.Items.Add("Imprimir resultados")
        print.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        print.Text = "Imprimir"
        print.TextDirection = ToolStripTextDirection.Horizontal
        print.TextAlign = ContentAlignment.MiddleRight
        print.Image = My.Resources.print_ico
        AddHandler print.Click, AddressOf print_Click


        bdnGeneral.BringToFront()
        Me.dgvGeneral.BringToFront()

        Dim dtb As New BasesParaCompatibilidad.DataBase
        CType(sp, spPaletsProducidos).cargar_PaletsProducidosEstados(Me.cboEstado, dtb)        
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        EventHandeld = True
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboPaletsProducidos = CType(sp, spPaletsProducidos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)


        If dboPaletsProducidos Is Nothing Then
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim dbpFormato As DBO_FormatosEnvasados = spForamtosEnvasados.Select_Record(dboPaletsProducidos.FormatoID, dtb)
            Me.newRegForm = New frmEntPaletsProducidos(0, dbpFormato.TipoFormatoEnvasadoID, dbpFormato.EnvasadoID, ACCION_MODIFICAR, sp, dboPaletsProducidos)
            AddHandler newRegForm.afterSave, AddressOf dgvFill
        End If
    End Sub


    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.sp3.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .DataSource = GeneralBindingSource
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 75)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 7, 125)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 3, 125)
                .FormatoColumna("ContadorImpresiones", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoGeneral()
            End With
        Else
            GeneralBindingSource.DataSource = Nothing
            dgvGeneral.DataSource = Nothing
        End If

    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintDocument1.Print()
    End Sub

    Private Sub mostrarEtiqueta()
        If Not Me.dgvGeneral.CurrentRow Is Nothing Then
            Dim spPaletsProducidos As New spPaletsProducidos
            Dim dtb As New BasesParaCompatibilidad.DataBase
            Dim dbo As DBO_PaletsProducidos = spPaletsProducidos.Select_Record(Me.dgvGeneral.CurrentRow.Cells("PaletProducidoID").Value, dtb)
            If Not dbo Is Nothing Then
                Dim frm As New frmEtiqueta0(dbo.ID, If(Config.UserType = 1 Or Config.UserType = 9 Or Config.UserType = 4, True, False))
                frm.Show()

                Try

                    spPaletsProducidos.anadir_impresion_etiqueta(Me.dgvGeneral.CurrentRow.Cells("PaletProducidoID").Value, dtb)
                    Dim textNotificar As String = "Se ha vuelto a imprimir la etiqueta de la matricula  " & Environment.NewLine() & Me.dgvGeneral.CurrentRow.Cells("SCC").Value.ToString & " el día " & DateTime.Now.ToString
                    Dim mail As New Mail.Mail1And1(True, "Reimpresion de etiqueta " & Me.dgvGeneral.CurrentRow.Cells("SCC").Value.ToString & _
                                                   "el " & DateTime.Now.ToString, textNotificar, _
                                                   String.Empty, _
                                                   Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                    String.Empty, String.Empty, Config.MailClientHost, False)
                Catch ex As Exception

                End Try
            Else
                MessageBox.Show("No se ppudo recuperar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub butNroRegistros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        If butNroRegistros.Text = "Mostrar 1000" Then
            sp.DataGridViewStoredProcedure = "PaletsProducidos6SelectDgv"
            labelRegistros.Text = "Se muestran los 1000 primeros registros."
            butNroRegistros.Text = "Mostrar todos"
        Else
            sp.DataGridViewStoredProcedure = "PaletsProducidos6SelectDgvAll"
            labelRegistros.Text = "Se muestran todos los registros."
            butNroRegistros.Text = "Mostrar 1000"
        End If
        'MyBase.sp = sp
        dgvFill()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim cabecera(1) As String
        cabecera(1) = "Informe de palets producidos"
        Dim p As New BasesParaCompatibilidad.Printer
        p.imprimirGrilla(dgvGeneral, cabecera, Nothing, False, False)
    End Sub

    Private Sub cbEstado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbEstado.CheckedChanged
        Me.cboEstado.Enabled = Me.cbEstado.Checked

        If Me.cbEstado.Checked Then
            sp.DataGridViewStoredProcedure = "PaletsProducidos6SelectDgvByEstado " & Me.cboEstado.SelectedValue
            'MyBase.sp = sp
            Me.dgvFill()
        Else
            butNroRegistros_Click(CType(butNroRegistros, Object), Nothing)
        End If
    End Sub

    Private Sub cboEstado_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboEstado.SelectedValueChanged
        If Me.cbEstado.Checked Then
            sp.DataGridViewStoredProcedure = "PaletsProducidos6SelectDgvByEstado " & Me.cboEstado.SelectedValue
            'MyBase.sp = sp
            Me.dgvFill()
        End If
    End Sub
End Class
