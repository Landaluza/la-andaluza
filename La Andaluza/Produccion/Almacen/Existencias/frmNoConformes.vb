Imports BasesParaCompatibilidad.DataGridViewExtension
Imports System.Threading

Public Class frmNoConformes

    Private mThreadFic As Thread
    Private mThreadFic2 As Thread
    Private mThreadFic3 As Thread
    Private UpdateThreadStart As New ThreadStart(AddressOf Me.dfvFillSecondary)
    Private UpdateThreadStart2 As New ThreadStart(AddressOf Me.dgvFillTerciary)
    Private UpdateThreadStart3 As New ThreadStart(AddressOf Me.dgvFillMain)
    Private CallDataBindToDataGrid As New MethodInvoker(AddressOf Me.DataBindToDataGrid)
    Private CallDataBindToDataGrid2 As New MethodInvoker(AddressOf Me.DataBindToDataGrid2)
    Private CallDataBindToDataGrid3 As New MethodInvoker(AddressOf Me.DataBindToDataGrid3)
    Private tab1, tab2, tab3 As Boolean
    Public Event FinishedFill()
    Private dt, dt2, dt3 As DataTable
    Private extracolumns As Collection

    Private spPalet As String = "PaletsProducidosByEnAlmacen2_noconforme "
    Private spLote As String = "PaletsProducidosByLote_noconforme "
    Private spArticulo As String = "PaletsProducidosByArticulo7_noconforme "
    Private spEcelCajas As String = "SumCajasEnAlmacenByCodigoQSMAM_noconforme"
    Private spEcellote As String = "SumCajasEnAlmacenByCodigoLote_noconforme "
    Private spEcelAlmacen As String = "PaletsProducidosByEnAlmacen2_noconforme "
    Private FechaSeleccionada As String


    Private Sub initdgvMain()        
        tab1 = False
        mThreadFic3 = New Thread(UpdateThreadStart3)
        mThreadFic3.IsBackground = True
        mThreadFic3.Priority = ThreadPriority.Highest
        mThreadFic3.Name = "UpdateThread3"
        mThreadFic3.Start()
    End Sub

    Private Sub initDgvPalets()
        tab2 = False
        mThreadFic = New Thread(UpdateThreadStart)
        mThreadFic.IsBackground = True
        mThreadFic.Priority = ThreadPriority.Normal
        mThreadFic.Name = "UpdateThread"
        mThreadFic.Start()
    End Sub

    Private Sub initDgvLotes()
        tab3 = False
        mThreadFic2 = New Thread(UpdateThreadStart2)
        mThreadFic2.IsBackground = True
        mThreadFic2.Priority = ThreadPriority.BelowNormal
        mThreadFic2.Name = "UpdateThread2"
        mThreadFic2.Start()
    End Sub

    Private Sub dfvFillSecondary()
        'Dim dt, dt2 As DataTable
        Try
            Dim dtb2 As New BasesParaCompatibilidad.Database()
            dtb2.PrepararConsulta(spPalet)
            dt = dtb2.Consultar()
            'dt = DataTableFill(spPalet)

            Me.BeginInvoke(CallDataBindToDataGrid)
        Catch ex As Exception
            messagebox.show("Error al cargar grilla 1. Vuelva a recargarla en unos segundos" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub dgvFillTerciary()
        Try
            Dim dtb3 As New BasesParaCompatibilidad.DataBase()
            dtb3.PrepararConsulta(spLote)
            dt2 = dtb3.Consultar()
            'dt2 = DataTableFill(spLote)
            Me.BeginInvoke(CallDataBindToDataGrid2)
        Catch ex As Exception
            messagebox.show("Error al cargar grilla 2. Vuelva a recargarla en unos segundos" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub dgvFillMain()
        Try
            Dim dtb As New BasesParaCompatibilidad.DataBase
            dtb.PrepararConsulta(spArticulo)
            dt3 = dtb.Consultar()

            'dt3 = DataTableFill(spArticulo)
            Me.BeginInvoke(CallDataBindToDataGrid3)
        Catch ex As Exception
            MessageBox.Show("Error al cargar grilla 3. Vuelva a recargarla en unos segundos" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub DataBindToDataGrid3()
        Try
            If Not dt3 Is Nothing Then
                'If dgvTotales.Columns.Contains("Pico") Then
                '    For i As Integer = dgvTotales.Columns("Pico").Index To dgvTotales.Columns.Count - 1
                '        dgvTotales.Columns.RemoveAt(i)
                '    Next
                'End If

                If Not Me.extracolumns Is Nothing Then
                    ' dgvTotales.DataSource = Nothing
                    For Each c As DataColumn In Me.extracolumns
                        dgvTotales.Columns.Remove(c.ColumnName)
                    Next
                    Me.extracolumns = New Collection
                Else
                    Me.extracolumns = New Collection
                End If

                Dim TotalBultos As Integer = 0
                Dim paletsTotales As Integer = 0
                Dim picosmaximos As Integer = 0
                Dim cont As Integer
                Dim sccs() As String
                Dim scc, nombre As String

                For Each row As DataRow In dt3.Rows
                    TotalBultos += row.Item("Cajas")

                    If Not IsDBNull(row.Item("sccPicos")) Then
                        If row.Item("sccPicos") <> "" Then
                            row.Item("sccPicos").ToString.Substring(0, row.Item("sccPicos").ToString.Length - 1)
                            'sccs = Split(row.Cells("sccPicos").Value, ",")
                            sccs = Split(row.Item("sccPicos").ToString.Substring(0, row.Item("sccPicos").ToString.Length - 1), ",")

                            If sccs.Length > 1 Then
                                cont = 0

                                For Each scc In sccs
                                    nombre = "Pico" & (cont + 1)

                                    If cont >= picosmaximos Then
                                        Me.dt3.Columns.Add(nombre)
                                        Me.extracolumns.Add(Me.dt3.Columns(nombre))
                                        picosmaximos += 1
                                        'Me.dgvTotales.FormatoColumna(nombre, BasesParaCompatibilidad.TiposColumna.Izquierda, 40, (5 + cont))
                                    End If

                                    row.Item(nombre) = scc
                                    cont += 1
                                Next
                            End If
                        End If
                    End If
                Next
                txtSumTotales.Text = Format(TotalBultos, "##,###")

                With dgvTotales
                    .DataSource = dt3
                    .FormatoColumna("Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 560)
                    .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles)
                    .FormatoColumna("Palets", BasesParaCompatibilidad.TiposColumna.Miles)
                    .FormatoGeneral(True)
                End With

                Me.dgvTotales.Columns("sccPicos").Visible = False
                Me.dgvTotales.Columns("Pico").Visible = False

                cont = 0
                If Not Me.extracolumns Is Nothing Then
                    For Each c As DataColumn In extracolumns
                        dgvTotales.FormatoColumna(c.ColumnName, BasesParaCompatibilidad.TiposColumna.Izquierda, 40, 5 + cont)
                        cont += 1
                    Next
                End If


                Dim filterManager3 As DgvFilterPopup.DgvFilterManager
                filterManager3 = New DgvFilterPopup.DgvFilterManager(Me.dgvTotales)

                tab1 = True
                Me.dgvTotales.EndEdit()

            End If
            RaiseEvent FinishedFill()
        Catch ex As Exception
            messagebox.show("Error al cargar grilla. Vuelva a recargarla en unos segundos" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub DataBindToDataGrid()
        Try
            If Not dt Is Nothing Then
                Dim row As DataGridViewRow
                Dim TotalBultos As Integer
                Dim filterManager2 As DgvFilterPopup.DgvFilterManager

                With dgvPalet
                    .DataSource = dt
                    .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Derecha, 40)
                    .FormatoColumna("Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles)
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 4)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                    .FormatoGeneral(True)
                End With


                TotalBultos = 0
                For Each row In dgvPalet.Rows
                    TotalBultos += row.Cells("Cajas").Value
                Next
                txtSumPalets.Text = Format(TotalBultos, "##,###")

                '        actualizartxt()

                filterManager2 = New DgvFilterPopup.DgvFilterManager(Me.dgvPalet)
                'Me.StatusStrip1.Hide()
                tab2 = True
            End If
            RaiseEvent FinishedFill()
        Catch ex As Exception
            messagebox.show("Error al cargar grilla. Vuelva a recargarla en unos segundos" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub DataBindToDataGrid2()
        Try
            If Not dt2 Is Nothing Then

                Dim row As DataGridViewRow
                Dim TotalBultos As Integer
                Dim filterManager As DgvFilterPopup.DgvFilterManager

                With dgvLotes
                    .DataSource = dt2
                    .Columns("CodigoQS").Visible = False
                    .FormatoColumna("Descripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1)
                    .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 2)
                    .FormatoColumna("Palets", "Palets", BasesParaCompatibilidad.TiposColumna.Miles, , 3)
                    .FormatoColumna("Pico", BasesParaCompatibilidad.TiposColumna.Miles, , 4)
                    .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 5)
                    .FormatoGeneral(True)
                End With

                TotalBultos = 0
                For Each row In dgvLotes.Rows
                    TotalBultos += row.Cells("Cajas").Value
                Next
                txtSumLotes.Text = Format(TotalBultos, "##,###")

                'actualizartxt()

                filterManager = New DgvFilterPopup.DgvFilterManager(Me.dgvLotes)

                tab3 = True
            End If
            RaiseEvent FinishedFill()
        Catch ex As Exception
            messagebox.show("Error al cargar grilla. Vuelva a recargarla en unos segundos" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub actualizartxt()
        If txtSumPalets.Text <> txtSumLotes.Text Or txtSumPalets.Text <> txtSumTotales.Text Then
            txtSumPalets.BackColor = Color.Red
        Else
            txtSumPalets.BackColor = Color.LightGreen
            txtSumTotales.BackColor = Color.LightGreen
        End If

        If txtSumLotes.Text <> txtSumTotales.Text Then
            txtSumLotes.BackColor = Color.Red
        Else
            txtSumLotes.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub _finished_fill() Handles Me.FinishedFill
        If tab1 AndAlso tab2 AndAlso tab3 Then
            actualizartxt()
            Me.StatusStrip1.Hide()
            Me.tstotales.Enabled = True
            Me.tsPalets.Enabled = True
            Me.tsLotes.Enabled = True
        End If
    End Sub

    Private Sub tstotales_Click(sender As System.Object, e As System.EventArgs) Handles tstotales.Click
        Me.tstotales.Enabled = False
        Me.StatusStrip1.Show()
        initdgvMain()
        'dt3 = DataTableFill("PaletsProducidosByArticulo7 ")
        ' Me.DataBindToDataGrid3() 
    End Sub

    Private Sub tsPalets_Click(sender As System.Object, e As System.EventArgs) Handles tsPalets.Click
        Me.tsPalets.Enabled = False
        Me.StatusStrip1.Show()
        initDgvPalets()
    End Sub

    Private Sub tsLotes_Click(sender As System.Object, e As System.EventArgs) Handles tsLotes.Click
        Me.tsLotes.Enabled = False
        Me.StatusStrip1.Show()
        initDgvLotes()

    End Sub

    Private Sub butExcel_Click(sender As System.Object, e As System.EventArgs) Handles butExcel.Click
        Try
            FechaSeleccionada = Now.Year & ".0" & _
                                Convert.ToString(Now.Month) & "." & _
                                Convert.ToString(Now.Day) & " " & _
                                Convert.ToString(Now.Hour) & "-" & _
                                Convert.ToString(Now.Minute)

            Dim Unidad As String
            Dim Ruta As String = "Almacen\Recuentos\"
            Dim RutaCompleta As String
            Dim NombreHoja As String = ""

            If BasesParaCompatibilidad.Config.Server = 0 Then '= "MAM1\SQLEXPRESS" Then
                Unidad = "C:\"
            Else
                Unidad = "Z:\"
            End If
            RutaCompleta = Unidad & Ruta

            Dim mse As New BasesParaCompatibilidad.MicrosoftOfficeExporter
            Dim dtb As New BasesParaCompatibilidad.DataBase

            If tabDatos.SelectedTab Is tabPagPalets Then
                NombreHoja = RutaCompleta & FechaSeleccionada & " Existencias por palets-noconformes.xls"
                dtb.PrepararConsulta(spEcelAlmacen)
            ElseIf tabDatos.SelectedTab Is tabPagAcumulados Then
                NombreHoja = RutaCompleta & FechaSeleccionada & " Existencias por lotes por referencia-noconformes.xls"
                dtb.PrepararConsulta(spEcellote)
            ElseIf tabDatos.SelectedTab Is tpTotales Then
                NombreHoja = RutaCompleta & FechaSeleccionada & " Existencias totales por referencia-noconformes.xls"
                dtb.PrepararConsulta(spEcelCajas)
            End If

            mse.ExportarTablaExcel(dtb.Consultar(), "C:\DataTable.txt", "Existencias", NombreHoja, "DataTable.txt")
            'IO.File.Delete("C:\DataTable.txt")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmNoConformes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.Cursor = Cursors.WaitCursor
        Me.StatusStrip1.Show()
        Me.tsTotales.Enabled = False
        Me.tsPalets.Enabled = False
        Me.tsLotes.Enabled = False
        'initdgvMain()
        'dt3 = DataTableFill("PaletsProducidosByArticulo3 ")
        'dt3 = DataTableFill("PaletsProducidosByArticulo6 ")

        'dt3 = dtb.Consultar(spArticulo, True)
        'Me.DataBindToDataGrid3()

        'dt2 = DataTableFill("PaletsProducidosByLote ")
        'DataBindToDataGrid2()
        'dt = DataTableFill("PaletsProducidosByEnAlmacen2 ")
        'DataBindToDataGrid()
        initdgvMain()
        initDgvPalets()

        initDgvLotes()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsConforme_Click(sender As System.Object, e As System.EventArgs) Handles tsConforme.Click
        Try

            Dim resp As DialogResult = MessageBox.Show("¿Seguro que desea marcar el palet como 'no conforme'?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If resp = DialogResult.OK Then
                Dim dtb As New BasesParaCompatibilidad.DataBase
                dtb.PrepararConsulta("update paletsproducidos set id_estado=1 where scc = @scc")
                dtb.AñadirParametroConsulta("@scc", Me.dgvPalet.CurrentRow.Cells("SCC").Value)
                If dtb.Execute() Then
                    tsPalets.PerformClick()
                Else
                    MessageBox.Show("No se pudo realizar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("No se pudo realizar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub tabDatos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles tabDatos.SelectedIndexChanged
        If tabDatos.SelectedTab.Name = tabPagPalets.Name Then
            Me.tsConforme.Visible = True
        Else
            Me.tsConforme.Visible = False
        End If
    End Sub

    Private Sub dgvPalet_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPalet.CellDoubleClick
        Dim dtb As New BasesParaCompatibilidad.DataBase
        Dim spForamtos As New Envasado.spFormatosEnvasados
        Dim spEnvasados2 As New Envasado.spEnvasados2
        Dim sppp As New Envasado.spPaletsProducidos
        Dim dboPaletsProducidos As Envasado.DBO_PaletsProducidos = sppp.Select_RecordBySSCC(Me.dgvPalet.CurrentRow.Cells("SCC").Value, dtb)

        Dim dbpFormato As Envasado.DBO_FormatosEnvasados = spForamtos.Select_Record(dboPaletsProducidos.FormatoID, dtb)
        Dim frm As New Envasado.frmEntPaletsProducidos(0, dbpFormato.TipoFormatoEnvasadoID, dbpFormato.EnvasadoID, BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, sppp, dboPaletsProducidos)

        'Dim m_dbo As New DBO_PaletsProducidos2
        'Dim spFormato As New spFormatosEnvasados
        'Dim spPaletsProducidos2 As New spPaletsProducidos2
        'Dim dtb As New BasesParaCompatibilidad.DataBase

        'm_dbo = spPaletsProducidos2.Select_RecordBySSCC(Me.dgvPalet.CurrentRow.Cells("SCC").Value, dtb)
        'Dim f_dbo As DBO_FormatosEnvasados = spFormato.Select_Record(m_dbo.FormatoID, dtb)
        'Dim frm As New frmEntPaletsProducidos2(True)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub
End Class