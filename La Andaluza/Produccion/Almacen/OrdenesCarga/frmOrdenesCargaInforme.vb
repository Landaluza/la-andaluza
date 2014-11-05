Imports BasesParaCompatibilidad.DataGridViewExtension


Public Class frmOrdenesCargaInforme
    Private dtAlbaranes As DataTable
    Private dtLineas As DataTable
    Private filasVisibles As Integer
    Private visible2 As Boolean
    Private OriginalValue As Integer
    ''Private WithEvents WinSockCliente As New Cliente
    Private intentosConexion As Integer
    Private extracolumns As Collection
    Private dt As DataTable
    Public FechaSeleccionada As String
    Private spOrdenesCarga As spOrdenesCarga
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        spOrdenesCarga = New spOrdenesCarga

    End Sub
    Private Shadows Sub frmOrdenesCargaInforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ToolTip1.SetToolTip(Me.butExcel, "Abre una ventana para la edicion del formato de excel")
        'Me.ToolTip1.SetToolTip(Me.butOK, "muestra el detalle de la fila seleccionada")
        'Me.ToolTip1.SetToolTip(Me.btnclean, "muestra/oculta las filas seleccionadas")
        Dim spInformePedidos As New spInformePedidos
        intentosConexion = 0

        dgvAlbaranes.DataSource = spInformePedidos.SelectInformePedidos_AlbaranesCarga(dtb)
        dtAlbaranes = dgvAlbaranes.DataSource
        Me.dgvAlbaranes.ClearSelection()
        If (Me.dgvAlbaranes.Columns.Count > 0) Then
            With dgvAlbaranes
                .Columns("AlbaranCargaMaestroID").Visible = False
                .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 80, 0)
                .FormatoColumna("NumeroQS", "Numero", BasesParaCompatibilidad.TiposColumna.QS, 75, 1)
                .FormatoColumna("ClienteID", "Cliente", BasesParaCompatibilidad.TiposColumna.QS, , 2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True, 3)
                .FormatoGeneral()
            End With
        End If

        '''Timer1.Enabled = True
        '''Timer1.Start()
    End Sub

    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        dgvFill()
    End Sub

    Private Sub dgvFill()
        Me.Cursor = Cursors.WaitCursor
        Dim spInformePedidos As New spInformePedidos
        Dim i As Integer
        Dim chColumn As DataColumn
        i = 0
        dt = dtb.Consultar("OrdenesCargasInformeNew6", True)

        If Not Me.extracolumns Is Nothing Then
            For Each chColumn In Me.extracolumns
                Me.dgv.Columns.Remove(chColumn.ColumnName)
            Next
        End If

        Me.extracolumns = New Collection

        While i < dgvAlbaranes.SelectedRows.Count
            spInformePedidos.InsertInformePedidos_TablaTemporal(dtb, (dgvAlbaranes.SelectedRows(i).Cells("AlbaranCargaMaestroID").Value))
            i += 1
        End While

        chColumn = New DataColumn("CargaPicos")
        chColumn.DataType = System.Type.GetType("System.String")
        dt.Columns.Add(chColumn)

        chColumn = New DataColumn("CargaPicosSCC")
        chColumn.DataType = System.Type.GetType("System.String")
        dt.Columns.Add(chColumn)

        chColumn = New DataColumn("Exportar")
        chColumn.DataType = System.Type.GetType("System.Boolean")
        dt.Columns.Add(chColumn)
        'Me.dgv.addCheckBoxColumn("Exportar")
        'Me.dgv.Columns("Exportar").ValueType = System.Type.GetType("Boolean")
        'Me.dgv.InvalidateColumn(Me.dgv.Columns("Exportar").Index)

        Dim row As DataRow
        Dim paletsTotales As Integer = 0
        Dim picosmaximos As Integer = 0
        Dim cont As Integer
        Dim sccs() As String
        Dim listasccs() As String
        Dim scc, nombre As String

        For Each row In dt.Rows
            paletsTotales += If(IsDBNull(row.Item("PaletsCarga")), 0, row.Item("PaletsCarga"))

            If Not IsDBNull(row.Item("sccPicos")) Then
                If row.Item("sccPicos") <> "" Then
                    sccs = Split(row.Item("sccPicos").ToString.Substring(0, row.Item("sccPicos").ToString.Length - 1), " ")
                    listasccs = Split(row.Item("listaSCCPicos").ToString.Substring(0, row.Item("listaSCCPicos").ToString.Length - 1), " ")

                    cont = 0
                    If sccs.Length > 1 Then
                        For Each scc In sccs
                            nombre = "Pico" & (cont + 1)

                            If cont >= picosmaximos Then
                                dt.Columns.Add(nombre)
                                dt.Columns.Add("scc" & nombre)
                                picosmaximos += 1
                                Me.extracolumns.Add(dt.Columns(nombre))
                                Me.extracolumns.Add(dt.Columns("scc" & nombre))
                            End If

                            row.Item("scc" & nombre) = listasccs(cont)
                            row.Item(nombre) = scc
                            cont += 1
                        Next
                    Else
                        row.Item("Pico") = If(IsDBNull(row.Item("sccPicos")) Or row.Item("sccPicos") = Nothing, 0, row.Item("sccPicos"))
                    End If
                Else
                    row.Item("Pico") = If(IsDBNull(row.Item("sccPicos")) Or row.Item("sccPicos") = Nothing, 0, row.Item("sccPicos"))
                End If
            End If
        Next

        dgv.DataSource = dt
        dtLineas = dgv.DataSource
        With dgv
            .Width = 825
            .DataSource = dtLineas
            .Columns("Pico").Visible = False
            .FormatoColumna("CodigoQS", BasesParaCompatibilidad.TiposColumna.QS, True, 0, 60)
            .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True, 1, 315)
            .FormatoColumna("Palets", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("Existen", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("Merca", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("Dispo", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("PedidosLA", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("PedidosJR", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("StockJR", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("Transito", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("TotalJR", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("Reponer", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("Cargar", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("CajasPalet", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("PaletsCarga", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .FormatoColumna("CargaSinPedidos", BasesParaCompatibilidad.TiposColumna.Miles, True)
            .Columns("CargaSinPedidos").Visible = False
            .Columns("id_tipoFormato").Visible = False
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True, 99, 250)
            .Columns("sccPicos").Visible = False
            .Columns("listaSCCPicos").Visible = False
            .Columns("CargaPicosSCC").Visible = False
            .FormatoGeneral(True)
        End With
        'Me.dgv.addCheckBoxColumn("Exportar")
        Me.dgv.Columns("Exportar").ValueType = System.Type.GetType("Boolean")
        'Me.dgv.InvalidateColumn(Me.dgv.Columns("Exportar").Index)
        Me.dgv.Columns("sccPicos").Visible = False
        Me.dgv.Columns("listaSCCPicos").Visible = False
        Me.dgv.Columns("CargaPicosSCC").Visible = False
        Me.txtTotalPalets.Text = paletsTotales

        cont = 0
        For Each chColumn In Me.extracolumns
            If chColumn.ColumnName.Contains("scc") Then
                Me.dgv.Columns(chColumn.ColumnName).Visible = False
            Else
                Me.dgv.FormatoColumna(chColumn.ColumnName, BasesParaCompatibilidad.TiposColumna.Derecha, 45, (5 + cont))
            End If
        Next

        visible2 = True
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub butExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExcel.Click
        If Me.dgv.RowCount > 0 Then
            Me.filasVisibles = 0

            Me.dgv.Refresh()
            Dim cm As CurrencyManager = BindingContext(Me.dgv.DataSource)
            cm.ResumeBinding()
            cm.SuspendBinding()
            cm.EndCurrentEdit()

            Dim cont As Integer = 0
            Dim tope As Integer = Me.dgv.RowCount
            Dim i As Integer

            While cont < tope And cont < Me.dgv.RowCount
                i = dgv.Rows(cont).Index

                If IsDBNull(Me.dt.Rows(i).Item("Exportar")) Then
                    Try
                        Me.dgv.Rows(cont).Visible = False
                    Catch ex As Exception
                    End Try
                ElseIf Not Convert.ToBoolean(Me.dt.Rows(i).Item("Exportar")) Then
                    'If dgv.Rows(cont).Cells("Exportar").Value Is Nothing Or dgv.Rows(cont).Cells("Exportar").Value = False Then
                    Try
                        If Me.dgv.Rows(cont).Selected Then
                            'Dim cm As CurrencyManager = BindingContext(Me.dgv.DataSource)
                            'cm.SuspendBinding()
                            Me.dgv.Rows(cont).Selected = False
                        End If
                        Me.dgv.Rows(cont).Visible = False
                    Catch ex As Exception

                    End Try
                Else
                    Me.filasVisibles += 1
                End If

                cont += 1
            End While

            Me.visible2 = False

            If Me.filasVisibles > 0 Then

                'frm.Show()
                exportar()
                'frm.Close()
            Else
                messagebox.show("No hay filas seleccionadas para crear la orden de carga", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Function AddOrdenCarga(ByVal Ruta As String, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        Dim m_DBO_OrdenesCarga As New DBO_OrdenesCarga
        m_DBO_OrdenesCarga.Fecha = Now.Date
        m_DBO_OrdenesCarga.Ruta = Ruta
        m_DBO_OrdenesCarga.Observaciones = ""
        Return spOrdenesCarga.GrabarOrdenesCarga(m_DBO_OrdenesCarga, dtb, True)
    End Function

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        ActualizarCelda()
    End Sub

    Private Sub VerdeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerdeToolStripMenuItem.Click
        Dim style As New DataGridViewCellStyle(Me.dgv.CurrentRow.DefaultCellStyle)
        style.BackColor = Color.Green
        Me.dgv.CurrentRow.DefaultCellStyle = style
        Dim index As Integer = Me.dgv.CurrentRow.Index
        If Not IsDBNull(Me.dt.Rows(index).Item("Exportar")) Then
            If Me.dt.Rows(index).Item("Exportar") <> True Then
                actualizarCelda()
            End If
        End If
    End Sub

    Private Sub RojoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RojoToolStripMenuItem.Click
        Dim style As New DataGridViewCellStyle(Me.dgv.CurrentRow.DefaultCellStyle)
        style.BackColor = Color.Red
        Me.dgv.CurrentRow.DefaultCellStyle = style
        Dim index As Integer = Me.dgv.CurrentRow.Index
        If Not IsDBNull(Me.dt.Rows(index).Item("Exportar")) Then
            If Me.dt.Rows(index).Item("Exportar") <> True Then
                actualizarCelda()
            End If
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Dim style As New DataGridViewCellStyle(Me.dgv.CurrentRow.DefaultCellStyle)
        style.BackColor = New DataGridViewRow().DefaultCellStyle.BackColor
        Me.dgv.CurrentRow.DefaultCellStyle = style
        Dim index As Integer = Me.dgv.CurrentRow.Index
        If Not IsDBNull(Me.dt.Rows(index).Item("Exportar")) Then
            If Me.dt.Rows(index).Item("Exportar") <> True Then
                actualizarCelda()
            End If
        End If
    End Sub

    Private Sub OtroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtroToolStripMenuItem.Click
        If Me.ColorDialog1.ShowDialog() = DialogResult.OK Then
            Dim style As New DataGridViewCellStyle(Me.dgv.CurrentRow.DefaultCellStyle)
            style.BackColor = Me.ColorDialog1.Color
            Me.dgv.CurrentRow.DefaultCellStyle = style
            Dim index As Integer = Me.dgv.CurrentRow.Index
            If Not IsDBNull(Me.dt.Rows(index).Item("Exportar")) Then
                If Me.dt.Rows(index).Item("Exportar") <> True Then
                    actualizarCelda()
                End If
            End If
        End If
    End Sub

    Private Sub btnclean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclean.Click
        Me.dgv.Refresh()

        Dim cont As Integer = 0
        Dim tope As Integer = Me.dgv.RowCount

        If Not Me.visible2 Then
            Me.filasVisibles = 0
            Me.visible2 = True
            'dgvFill()
            While cont < tope And cont < Me.dgv.RowCount
                Me.dgv.Rows(cont).Visible = True
                cont += 1
            End While

            Dim cm As CurrencyManager = BindingContext(Me.dgv.DataSource)
            cm.ResumeBinding()

        Else
            Me.filasVisibles = 0
            Dim i As Integer
            Dim cm As CurrencyManager = BindingContext(Me.dgv.DataSource)
            'cm.ResumeBinding()
            cm.SuspendBinding()
            cm.EndCurrentEdit()
            'Me.dgv.CurrentRow.Selected = False

            While cont < tope And cont < Me.dgv.RowCount
                i = dgv.Rows(cont).Index
                'If dgv.Rows(cont).Cells("Exportar").Value Is Nothing Or dgv.Rows(cont).Cells("Exportar").Value = False Then
                If IsDBNull(Me.dt.Rows(i).Item("Exportar")) Then
                    Try
                        Me.dgv.Rows(cont).Visible = False
                    Catch ex As Exception
                    End Try
                ElseIf Not Convert.ToBoolean(Me.dt.Rows(i).Item("Exportar")) Then
                    Try
                        Me.dgv.Rows(cont).Visible = False
                    Catch ex As Exception
                    End Try
                Else
                    Me.filasVisibles += 1
                End If
                cont += 1
            End While

            Me.visible2 = False
        End If
    End Sub

    Private Sub contarCarga()
        Me.Cursor = Cursors.WaitCursor
        Dim cuenta As Integer = 0
        If Me.dgv.RowCount > 0 Then
            If Not Me.filasVisibles > 0 Then
                Me.dgv.Refresh()

                Dim cont As Integer = 0
                Dim tope As Integer = Me.dgv.RowCount

                While cont < tope And cont < Me.dgv.RowCount
                    If Not IsDBNull(dgv.Rows(cont).Cells("Exportar").Value) Then
                        If Convert.ToBoolean(dgv.Rows(cont).Cells("Exportar").Value) Then
                            cuenta += If(dgv.Rows(cont).Cells("PaletsCarga").Value Is Convert.DBNull, 0, dgv.Rows(cont).Cells("PaletsCarga").Value)
                        End If
                    End If
                    cont += 1
                End While
            End If
        End If
        Me.txtTotalPalets.Text = cuenta
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub actualizarCelda()
        If IsDBNull(Me.dgv.CurrentRow.Cells("Exportar").Value) Then
            marcarParaExportar()
        Else

            If Convert.ToBoolean(Me.dgv.CurrentRow.Cells("Exportar").Value) Then
                marcarParanoExportar()
                'Me.dgv.CurrentRow.Cells("Exportar").Value = False
                'Me.txtTotalPalets.Text = if(txtTotalPalets.Text = "", 0, txtTotalPalets.Text) - if(dgv.CurrentRow.Cells("PaletsCarga").Value Is Convert.DBNull, 0, dgv.CurrentRow.Cells("PaletsCarga").Value)
                'contarCarga()
            Else
                marcarParaExportar()
                'Me.dgv.CurrentRow.Cells("Exportar").Value = True
                'contarCarga()
                'dgv.CurrentRow.Cells("Cargar").Value = if(IsDBNull(dgv.CurrentRow.Cells("PaletsCarga").Value) Or dgv.CurrentRow.Cells("PaletsCarga").Value = Nothing, 0, dgv.CurrentRow.Cells("PaletsCarga").Value) * dgv.CurrentRow.Cells("CajasPalet").Value
            End If
        End If
    End Sub

    'Private Sub exportar()
    '    Dim frm As New BasesParaCompatibilidad.frmEspera("Creando archivo excel")
    '    frm.Show()

    '    Try
    '        Dim m_detalles As New DBO_OrdenesCargaDetalles

    '        'preparativos para guardar el archivo
    '        Dim RutaCompleta As String
    '        Dim Unidad As String
    '        Dim NombreHoja As String
    '        Dim Ruta As String = "Almacen\Ordenes de carga\"

    '        FechaSeleccionada = Now.Year & "." & _
    '                            Convert.ToString(Now.Month) & "." & _
    '                            Convert.ToString(Now.Day) & " " & _
    '                            Convert.ToString(Now.Hour) & "-" & _
    '                           Convert.ToString(Now.Minute)

    '        If BasesParaCompatibilidad.Config.Server = 0 Then ' = "GERENTE1\SQLEXPRESS") Or (GUImain.ServidorUsado = "W7U\SQLEXPRESS2005") Then
    '            Unidad = "C:\"
    '        Else
    '            Unidad = "Z:\"
    '        End If

    '        'Unidad = "C:\"
    '        RutaCompleta = Unidad & Ruta
    '        'RutaCompleta = Unidad
    '        NombreHoja = RutaCompleta & FechaSeleccionada & " Orden de carga.xlsx"





    '        If dgv.Columns.Count > 0 Then
    '            'guardamos el registro maestro
    '            dtb.EmpezarTransaccion()

    '            Try
    '                If Not AddOrdenCarga(NombreHoja, dtb) Then Throw New Exception("No se pudo guardar la orden de carga")
    '                'Dim dat As DataTable = ConsultaVer("max(OrdenCargaID)", "OrdenesCarga")
    '                Dim dat As DataTable = dtb.Consultar("select max(OrdenCargaID) from OrdenesCarga", False)
    '                m_detalles.Id_OrdenCarga = dat.Rows(0).Item(0)
    '                'Header
    '                'Dim DataArrayHead(0, 0 To dtLineas.Columns.Count - 2) As Object
    '                'For s As Integer = 0 To dtLineas.Columns.Count - 2
    '                '    DataArrayHead(0, s) = dtLineas.Columns(s + 1).Caption
    '                'Next
    '                Dim DataArrayHead(0, 0 To 6) As Object
    '                DataArrayHead(0, 0) = "Descripcion"
    '                DataArrayHead(0, 1) = "Palets"
    '                DataArrayHead(0, 2) = "Pico"
    '                DataArrayHead(0, 3) = "PaletsCarga"
    '                DataArrayHead(0, 4) = "PicosCarga"
    '                DataArrayHead(0, 5) = "Observaciones"


    '                Dim contLetra As Integer = 8
    '                Dim conFilas As Integer = 0
    '                'Detail
    '                Dim DataArray(0 To dgv.Rows.Count - 1, 0 To 6) As Object
    '                For mRow As Integer = 0 To Me.dgv.Rows.Count - 1
    '                    If Me.dgv.Rows(mRow).Visible Then
    '                        If Me.dgv.Rows(mRow).DefaultCellStyle.BackColor <> New DataGridViewRow().DefaultCellStyle.BackColor Then
    '                        End If

    '                        m_detalles.Observaciones = If(IsDBNull(dgv.Rows(mRow).Cells("Observaciones").Value), String.Empty, dgv.Rows(mRow).Cells("Observaciones").Value)
    '                        m_detalles.Palets = If(IsDBNull(dgv.Rows(mRow).Cells("Palets").Value), 0, dgv.Rows(mRow).Cells("Palets").Value)
    '                        m_detalles.PaletsCarga = If(IsDBNull(dgv.Rows(mRow).Cells("PaletsCarga").Value), 0, dgv.Rows(mRow).Cells("PaletsCarga").Value)
    '                        m_detalles.carga = If(IsDBNull(dgv.Rows(mRow).Cells("Cargar").Value), 0, dgv.Rows(mRow).Cells("Cargar").Value)
    '                        m_detalles.CargaSinPedidos = If(IsDBNull(dgv.Rows(mRow).Cells("Cargar").Value), 0, dgv.Rows(mRow).Cells("Cargar").Value) 'if(IsDBNull(dgv.Rows(mRow).Cells("CargaSinPedidos").Value), 0, dgv.Rows(mRow).Cells("CargaSinPedidos").Value)
    '                        m_detalles.Pico = If(IsDBNull(dgv.Rows(mRow).Cells("Pico").Value), 0, dgv.Rows(mRow).Cells("Pico").Value)
    '                        m_detalles.Descripcion = If(IsDBNull(dgv.Rows(mRow).Cells("Descripcion").Value), String.Empty, dgv.Rows(mRow).Cells("Descripcion").Value)
    '                        m_detalles.id_tipoFormato = If(IsDBNull(dgv.Rows(mRow).Cells("id_tipoFormato").Value), Convert.DBNull, dgv.Rows(mRow).Cells("id_tipoFormato").Value)
    '                        m_detalles.cargaPicos = If(IsDBNull(dgv.Rows(mRow).Cells("CargaPicos").Value), String.Empty, dgv.Rows(mRow).Cells("CargaPicos").Value)
    '                        m_detalles.cargaPicosSCC = If(IsDBNull(dgv.Rows(mRow).Cells("CargaPicosSCC").Value), String.Empty, dgv.Rows(mRow).Cells("CargaPicos").Value)

    '                        If Not spOrdenesCarga.OrdenesCargaInsertDetail(m_detalles, dtb) Then Throw New Exception("No se pudo guardar la orden de carga")

    '                        DataArray(conFilas, 0) = dgv.Rows(mRow).Cells("Descripcion").Value
    '                        DataArray(conFilas, 1) = dgv.Rows(mRow).Cells("Palets").Value
    '                        DataArray(conFilas, 2) = dgv.Rows(mRow).Cells("Pico").Value
    '                        DataArray(conFilas, 3) = dgv.Rows(mRow).Cells("PaletsCarga").Value
    '                        DataArray(conFilas, 4) = dgv.Rows(mRow).Cells("CargaPicos").Value
    '                        DataArray(conFilas, 5) = dgv.Rows(mRow).Cells("Observaciones").Value

    '                        conFilas += 1
    '                    End If
    '                Next


    '                dtb.ConsultaAlteraciones("insert into notificaciones(texto, id_tipousuario, leido) values('Tiene una orden de carga nueva', 7, 0)")

    '                Try 'TEmporal hasta dar de alta el tablet nuevo
    '                    Dim web As New BasesParaCompatibilidad.Web
    '                    web.send_GET("Nueva orden de carga", web.recuperar_id_tablet(24, dtb))
    '                Catch ex As Exception
    '                End Try

    '                ''dtb.CancelarTransaccion ()
    '                dtb.TerminarTransaccion()
    '                '''If Not Me.WinSockCliente Is Nothing Then If Me.WinSockCliente.conected Then WinSockCliente.EnviarDatos("99")

    '            Catch ex As Exception
    '                dtb.CancelarTransaccion()
    '                'MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Throw
    '                'Finally
    '                'oExcel.Quit()
    '                ' oExcel = Nothing
    '                'oSheet = Nothing
    '            End Try
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        frm.Close()
    '    End Try

    'End Sub


    Private Sub exportar()
        Dim frm As New BasesParaCompatibilidad.frmEspera("Creando archivo excel")
        frm.Show()

        Try
            Dim m_detalles As New DBO_OrdenesCargaDetalles
            Dim oExcel As Microsoft.Office.Interop.Excel.Application
            Dim oBook As Microsoft.Office.Interop.Excel.Workbook
            Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet

            'preparativos para guardar el archivo
            Dim RutaCompleta As String
            Dim Unidad As String
            Dim NombreHoja As String
            Dim Ruta As String = "Almacen\Ordenes de carga\"

            FechaSeleccionada = Now.Year & "." & _
                                Convert.ToString(Now.Month) & "." & _
                                Convert.ToString(Now.Day) & " " & _
                                Convert.ToString(Now.Hour) & "-" & _
                               Convert.ToString(Now.Minute)

            If BasesParaCompatibilidad.Config.Server = 0 Then ' = "GERENTE1\SQLEXPRESS") Or (GUImain.ServidorUsado = "W7U\SQLEXPRESS2005") Then
                Unidad = "C:\"
            Else
                Unidad = "Z:\"
            End If

            'Unidad = "C:\"
            RutaCompleta = Unidad & Ruta
            'RutaCompleta = Unidad
            NombreHoja = RutaCompleta & FechaSeleccionada & " Orden de carga.xlsx"

            'creacion de excel
            oExcel = CreateObject("Excel.Application")
            oExcel.Visible = True
            oBook = oExcel.Workbooks.Add
            oSheet = oBook.Worksheets(1)
            oSheet.Range("B2").Value = "Orden de carga "
            oSheet.Range("D2").Value = "FECHA " & Format("dd/MM/yyyy", Today)
            oSheet.Range("B2:D2").Font.Bold = True
            oSheet.Range("B2:D2").Font.Size = 22
            oSheet.Range("B2:D2").Font.Color = Color.Black
            oSheet.Range("B2:D2").Cells.HorizontalAlignment = HorizontalAlignment.Center

            oSheet.Range("B4").Value = "Siempre completar hasta maximo de kilos del camión"
            oSheet.Range("B4").Font.Bold = True
            oSheet.Range("B4").Font.Size = 14
            oSheet.Range("B4").Font.Color = Color.Black
            oSheet.Range("B5").Value = "No cargar palets de salsas en paralelo"
            oSheet.Range("B5").Font.Bold = True
            oSheet.Range("B5").Font.Size = 14
            oSheet.Range("B5").Font.Color = Color.Red
            oSheet.Range("B6").Value = "La referencia subrayada en verde es con la que se debe completar hasta maximo de kilos."
            oSheet.Range("B6").Font.Bold = True
            oSheet.Range("B6").Font.Size = 14
            oSheet.Range("B6").Font.Color = Color.Green

            If dgv.Columns.Count > 0 Then
                'guardamos el registro maestro
                dtb.EmpezarTransaccion()

                Try
                    If Not AddOrdenCarga(NombreHoja, dtb) Then Throw New Exception("No se pudo guardar la orden de carga")
                    'Dim dat As DataTable = ConsultaVer("max(OrdenCargaID)", "OrdenesCarga")
                    Dim dat As DataTable = dtb.Consultar("select max(OrdenCargaID) from OrdenesCarga", False)
                    m_detalles.Id_OrdenCarga = dat.Rows(0).Item(0)
                    'Header
                    'Dim DataArrayHead(0, 0 To dtLineas.Columns.Count - 2) As Object
                    'For s As Integer = 0 To dtLineas.Columns.Count - 2
                    '    DataArrayHead(0, s) = dtLineas.Columns(s + 1).Caption
                    'Next
                    Dim DataArrayHead(0, 0 To 6) As Object
                    DataArrayHead(0, 0) = "Descripcion"
                    DataArrayHead(0, 1) = "Palets"
                    DataArrayHead(0, 2) = "Pico"
                    DataArrayHead(0, 3) = "PaletsCarga"
                    DataArrayHead(0, 4) = "PicosCarga"
                    DataArrayHead(0, 5) = "Observaciones"

                    oSheet.Range("B8").Resize(1, 6).Value = DataArrayHead
                    oSheet.Range("B8").Resize(1, 6).Font.Bold = True
                    oSheet.Range("B8").Resize(1, 6).HorizontalAlignment = HorizontalAlignment.Center

                    Dim contLetra As Integer = 8
                    Dim conFilas As Integer = 0
                    'Detail
                    Dim DataArray(0 To dgv.Rows.Count - 1, 0 To 6) As Object
                    For mRow As Integer = 0 To Me.dgv.Rows.Count - 1
                        If Me.dgv.Rows(mRow).Visible Then
                            If Me.dgv.Rows(mRow).DefaultCellStyle.BackColor <> New DataGridViewRow().DefaultCellStyle.BackColor Then
                                oSheet.Range("B" & (9 + conFilas) & ":G" & (9 + conFilas)).Interior.Color = Me.dgv.Rows(mRow).DefaultCellStyle.BackColor
                            End If

                            m_detalles.Observaciones = If(IsDBNull(dgv.Rows(mRow).Cells("Observaciones").Value), String.Empty, dgv.Rows(mRow).Cells("Observaciones").Value)
                            m_detalles.Palets = If(IsDBNull(dgv.Rows(mRow).Cells("Palets").Value), 0, dgv.Rows(mRow).Cells("Palets").Value)
                            m_detalles.PaletsCarga = If(IsDBNull(dgv.Rows(mRow).Cells("PaletsCarga").Value), 0, dgv.Rows(mRow).Cells("PaletsCarga").Value)
                            m_detalles.carga = If(IsDBNull(dgv.Rows(mRow).Cells("Cargar").Value), 0, dgv.Rows(mRow).Cells("Cargar").Value)
                            m_detalles.CargaSinPedidos = If(IsDBNull(dgv.Rows(mRow).Cells("Cargar").Value), 0, dgv.Rows(mRow).Cells("Cargar").Value) 'if(IsDBNull(dgv.Rows(mRow).Cells("CargaSinPedidos").Value), 0, dgv.Rows(mRow).Cells("CargaSinPedidos").Value)
                            m_detalles.Pico = If(IsDBNull(dgv.Rows(mRow).Cells("Pico").Value), 0, dgv.Rows(mRow).Cells("Pico").Value)
                            m_detalles.Descripcion = If(IsDBNull(dgv.Rows(mRow).Cells("Descripcion").Value), String.Empty, dgv.Rows(mRow).Cells("Descripcion").Value)
                            m_detalles.id_tipoFormato = If(IsDBNull(dgv.Rows(mRow).Cells("id_tipoFormato").Value), Convert.DBNull, dgv.Rows(mRow).Cells("id_tipoFormato").Value)
                            m_detalles.cargaPicos = If(IsDBNull(dgv.Rows(mRow).Cells("CargaPicos").Value), String.Empty, dgv.Rows(mRow).Cells("CargaPicos").Value)
                            m_detalles.cargaPicosSCC = If(IsDBNull(dgv.Rows(mRow).Cells("CargaPicosSCC").Value), String.Empty, dgv.Rows(mRow).Cells("CargaPicos").Value)

                            If Not spOrdenesCarga.OrdenesCargaInsertDetail(m_detalles, dtb) Then Throw New Exception("No se pudo guardar la orden de carga")

                            DataArray(conFilas, 0) = dgv.Rows(mRow).Cells("Descripcion").Value
                            DataArray(conFilas, 1) = dgv.Rows(mRow).Cells("Palets").Value
                            DataArray(conFilas, 2) = dgv.Rows(mRow).Cells("Pico").Value
                            DataArray(conFilas, 3) = dgv.Rows(mRow).Cells("PaletsCarga").Value
                            DataArray(conFilas, 4) = dgv.Rows(mRow).Cells("CargaPicos").Value
                            DataArray(conFilas, 5) = dgv.Rows(mRow).Cells("Observaciones").Value

                            conFilas += 1
                        End If
                    Next

                    oSheet.Range("B9").Resize(filasVisibles, 6).Value = DataArray
                    oSheet.Range("B" & (11 + filasVisibles)).Value = Me.txtComentarios.Text
                    'Resize Columns

                    oSheet.Columns("B:B").ColumnWidth = 50
                    oSheet.Columns("C:G").ColumnWidth = 8.5
                    oSheet.Columns("G:G").ColumnWidth = 50

                    dtb.ConsultaAlteraciones("insert into notificaciones(texto, id_tipousuario, leido) values('Tiene una orden de carga nueva', 7, 0)")

                    Try 'TEmporal hasta dar de alta el tablet nuevo
                        Dim web As New BasesParaCompatibilidad.Web
                        web.send_GET("Nueva orden de carga", web.recuperar_id_tablet(24, dtb))
                    Catch ex As Exception
                    End Try

                    oSheet.SaveAs(NombreHoja)
                    ''dtb.CancelarTransaccion ()
                    dtb.TerminarTransaccion()
                    '''If Not Me.WinSockCliente Is Nothing Then If Me.WinSockCliente.conected Then WinSockCliente.EnviarDatos("99")
                    oExcel.DisplayFullScreen = True

                Catch ex As Exception
                    dtb.CancelarTransaccion()
                    'MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Throw
                    'Finally
                    'oExcel.Quit()
                    ' oExcel = Nothing
                    'oSheet = Nothing
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Close()
        End Try

    End Sub

    Private Sub dgv_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgv.CellBeginEdit

        marcarParaNoExportar()
    End Sub

    Private Sub dgv_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
      
        If Me.dgv.Columns(e.ColumnIndex).Name = "PaletsCarga" Then
            dgv.Rows(e.RowIndex).Cells("Cargar").Value = if(IsDBNull(dgv.Rows(e.RowIndex).Cells("PaletsCarga").Value) Or dgv.Rows(e.RowIndex).Cells("PaletsCarga").Value Is Nothing, 0, dgv.Rows(e.RowIndex).Cells("PaletsCarga").Value) * if(IsDBNull(dgv.Rows(e.RowIndex).Cells("CajasPalet").Value) Or dgv.Rows(e.RowIndex).Cells("CajasPalet").Value Is Nothing, 0, dgv.Rows(e.RowIndex).Cells("CajasPalet").Value)
            dgv.Rows(e.RowIndex).Cells("CargaSinPedidos").Value = (dgv.Rows(e.RowIndex).Cells("Cargar").Value )
        End If
        marcarParaExportar()
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex > -1 Then
            If Me.dgv.Columns(e.ColumnIndex).Name = "PaletsCarga" Or Me.dgv.Columns(e.ColumnIndex).Name = "Observaciones" Then
                Me.dgv.ReadOnly = False
            Else
                If Me.dgv.Columns(e.ColumnIndex).Name.Contains("Pico") And Me.dgv.Columns(e.ColumnIndex).Name <> "CargaPicos" Then
                    If Not IsDBNull(dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
                        If dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> 0 Then
                            Dim cargado As Boolean = False
                            Dim cargaPicos As String = if(IsDBNull(dgv.Rows(e.RowIndex).Cells("CargaPicos").Value), "", dgv.Rows(e.RowIndex).Cells("CargaPicos").Value)
                            Dim cargaPicosSCC As String = if(IsDBNull(dgv.Rows(e.RowIndex).Cells("CargaPicosSCC").Value), "", dgv.Rows(e.RowIndex).Cells("CargaPicosSCC").Value)
                            Dim listaPicosSCC As String = if(IsDBNull(dgv.Rows(e.RowIndex).Cells("listaSCCPicos").Value), "", dgv.Rows(e.RowIndex).Cells("listaSCCPicos").Value)

                            If cargaPicos <> "" Then
                                Dim cp As String() = dgv.Rows(e.RowIndex).Cells("CargaPicos").Value.ToString.Split(",")
                                Dim pico As String

                                For Each pico In cp
                                    If pico = dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                                        cargado = True
                                        Exit For
                                    End If
                                Next
                            End If

                            If Not cargado Then
                                dgv.Rows(e.RowIndex).Cells("CargaPicos").Value = cargaPicos & if(cargaPicos = "", "", ",") & dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                                If dgv.Columns(e.ColumnIndex).Name = "Pico" Then
                                    dgv.Rows(e.RowIndex).Cells("CargaPicosSCC").Value = listaPicosSCC
                                Else
                                    dgv.Rows(e.RowIndex).Cells("CargaPicosSCC").Value = cargaPicosSCC & if(cargaPicosSCC = "", "", ",") & dgv.Rows(e.RowIndex).Cells("scc" & dgv.Columns(e.ColumnIndex).Name).Value
                                End If
                                marcarParaExportar()
                            End If
                        End If
                    End If
                End If
                Me.dgv.ReadOnly = True
            End If
        Else
            Me.dgv.Columns("Exportar").ValueType = System.Type.GetType("Boolean")
        End If
    End Sub

    Private Sub marcarParaExportar()
        Dim index As Integer = Me.dgv.CurrentRow.Index

        If Not IsDBNull(dgv.CurrentRow.Cells("PaletsCarga").Value) Then
            If dgv.CurrentRow.Cells("PaletsCarga").Value > 0 Then
                If IsDBNull(Me.dt.Rows(index).Item("Exportar")) Then
                    Me.dt.Rows(index).Item("Exportar") = True                    
                    dgv.CurrentRow.Cells("Cargar").Value = if(IsDBNull(dgv.CurrentRow.Cells("PaletsCarga").Value) Or dgv.CurrentRow.Cells("PaletsCarga").Value Is Nothing, 0, dgv.CurrentRow.Cells("PaletsCarga").Value) * if(IsDBNull(dgv.CurrentRow.Cells("CajasPalet").Value) Or dgv.CurrentRow.Cells("CajasPalet").Value Is Nothing, 0, dgv.CurrentRow.Cells("CajasPalet").Value)
                    contarCarga()
                ElseIf Not IsDBNull(dgv.CurrentRow.Cells("Exportar").Value) Then
                    If Not Convert.ToBoolean(Me.dgv.CurrentRow.Cells("Exportar").Value) Then
                        Me.dt.Rows(index).Item("Exportar") = True
                        dgv.CurrentRow.Cells("Cargar").Value = If(IsDBNull(dgv.CurrentRow.Cells("PaletsCarga").Value) Or dgv.CurrentRow.Cells("PaletsCarga").Value Is Nothing, 0, dgv.CurrentRow.Cells("PaletsCarga").Value) * If(IsDBNull(dgv.CurrentRow.Cells("CajasPalet").Value) Or dgv.CurrentRow.Cells("CajasPalet").Value Is Nothing, 0, dgv.CurrentRow.Cells("CajasPalet").Value)
                        contarCarga()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub marcarParanoExportar()
        Dim index As Integer = Me.dgv.CurrentRow.Index

        If IsDBNull(Me.dt.Rows(index).Item("Exportar")) Then
            Me.dt.Rows(index).Item("Exportar") = False
            Me.txtTotalPalets.Text = If(txtTotalPalets.Text = "", "0", txtTotalPalets.Text) - If(dgv.CurrentRow.Cells("PaletsCarga").Value Is Convert.DBNull, 0, dgv.CurrentRow.Cells("PaletsCarga").Value)
            contarCarga()
        ElseIf Convert.ToBoolean(Me.dt.Rows(index).Item("Exportar")) Then
            Me.dt.Rows(index).Item("Exportar") = False
            Me.txtTotalPalets.Text = If(txtTotalPalets.Text = "", "0", txtTotalPalets.Text) - If(dgv.CurrentRow.Cells("PaletsCarga").Value Is Convert.DBNull, 0, dgv.CurrentRow.Cells("PaletsCarga").Value)
            contarCarga()
        End If
    End Sub

    Private Sub BorrarCargaDePicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarCargaDePicosToolStripMenuItem.Click
        Me.dgv.CurrentRow.Cells("CargaPicos").Value = ""
    End Sub

    Private Sub cbPicos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbPicos.CheckedChanged

        If Not Me.extracolumns Is Nothing Then
            For Each col As DataColumn In Me.extracolumns
                If Not col.ColumnName.Contains("scc") Then
                    Me.dgv.Columns(col.ColumnName).Visible = cbPicos.Checked
                End If
            Next
        End If
    End Sub
End Class

