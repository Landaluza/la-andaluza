Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulos1
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboArticulos1 As DBO_Articulos1
    Private tsinformacionGeneral As ToolStripButton
    Private tsEvolucion As ToolStripButton
    Private tsVentas As ToolStripButton
    Private tsInactivos As ToolStripButton
    Private tsActivos As ToolStripButton
    Private tsCambiarTipo As ToolStripButton
    Private asist As wizard
    Private fileARticulo As BasesParaCompatibilidad.File


    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spArticulos1, MaestroID)
        InitializeComponent()

        dboArticulos1 = New DBO_Articulos1



        tsinformacionGeneral = Me.bdnGeneral.Items.Add("Información general")
        tsinformacionGeneral.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsinformacionGeneral.Image = My.Resources.document_16
        tsinformacionGeneral.TextDirection = ToolStripTextDirection.Horizontal
        tsinformacionGeneral.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsinformacionGeneral.Click, AddressOf verInformacion

        tsEvolucion = Me.bdnGeneral.Items.Add("Evolución de precios")
        tsEvolucion.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsEvolucion.Image = My.Resources.document_16
        tsEvolucion.TextDirection = ToolStripTextDirection.Horizontal
        tsEvolucion.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsEvolucion.Click, AddressOf verEvolucion

        tsVentas = Me.bdnGeneral.Items.Add("Ventas")
        tsVentas.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsVentas.Image = My.Resources.office_chart_area
        tsVentas.TextDirection = ToolStripTextDirection.Horizontal
        tsVentas.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsVentas.Click, AddressOf verVentas


        tsInactivos = Me.bdnGeneral.Items.Add("Ver inactivos")
        tsInactivos.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsInactivos.TextDirection = ToolStripTextDirection.Horizontal
        tsInactivos.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsInactivos.Click, AddressOf verInactivos

        tsActivos = Me.bdnGeneral.Items.Add("Ver activos")
        tsActivos.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsActivos.TextDirection = ToolStripTextDirection.Horizontal
        tsActivos.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsActivos.Click, AddressOf verActivos

        tsCambiarTipo = Me.bdnGeneral.Items.Add("Cambiar tipo")
        tsCambiarTipo.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsCambiarTipo.TextDirection = ToolStripTextDirection.Horizontal
        tsCambiarTipo.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsCambiarTipo.Click, AddressOf CambiarTipo
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert

        MyBase.EventHandeld = True
        Dim frm As New frmSelectorAsistente
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        dgvFill()
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboArticulos1 = CType(sp, spArticulos1).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboArticulos1 Is Nothing Then
            Dim frm As New frmModArticuloGenerico(dgvGeneral.CurrentRow.Cells("Id").Value)
            newRegForm = frm
            AddHandler frm.afterSave, AddressOf dgvFill
            newRegForm.SetDataBussinesObject(CType(Me.dboArticulos1, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            If sp.DataGridViewStoredProcedure = sp.DataGridViewStoredProcedureForSelect Then
                GeneralBindingSource.DataSource = dataSource
                With dgvGeneral
                    .DataSource = GeneralBindingSource

                    If .Columns.Contains("ArticuloID") Then .Columns("ArticuloID").Name = "Id"
                    .Columns("Id").Visible = False
                    .Columns("Column1").Visible = False
                    .Columns("InformacionGeneral").Visible = False
                    .Columns("EvolucionPrecios").Visible = False
                    .Columns("CodigoQS").Visible = False
                    .FormatoColumna("CodigoLA", BasesParaCompatibilidad.TiposColumna.QS)
                    .FormatoColumna("DescripcionLA", BasesParaCompatibilidad.TiposColumna.Izquierda, 250)
                    .FormatoColumna("ArticuloTipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 150)
                    .FormatoColumna("subtipo", "Subtipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 150)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                End With

            Else
                GeneralBindingSource.DataSource = dataSource
                With dgvGeneral
                    .DataSource = GeneralBindingSource

                    .Columns("ArticuloID").Visible = False
                    .Columns("ArticuloID").Name = "Id"
                    .Columns("Column1").Visible = False
                    .Columns("InformacionGeneral").Visible = False
                    .Columns("EvolucionPrecios").Visible = False
                    .Columns("CodigoQS").Visible = False
                    .FormatoColumna("CodigoLA", BasesParaCompatibilidad.TiposColumna.QS)
                    .FormatoColumna("DescripcionLA", BasesParaCompatibilidad.TiposColumna.Izquierda, 250)
                    .FormatoColumna("ArticuloTipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 150)
                    .FormatoColumna("subtipo", "Subtipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 150)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                End With
            End If
        End If
    End Sub

    Private Sub verActivos()
        sp.DataGridViewStoredProcedure = sp.DataGridViewStoredProcedureForSelect
        Me.dgvFill()
    End Sub

    Private Sub verInactivos()
        sp.DataGridViewStoredProcedure = CType(sp, spArticulos1).DatagridViewProcedureForSelectInactivos
        Me.dgvFill()
    End Sub

    Private Sub verVentas()
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim ExcelImporter As New ExcelImporter
            ExcelImporter.ExportToExcelNew(Me.dgvGeneral.CurrentRow.Cells("CodigoQS").Value.ToString.Trim, If(IsDBNull(Me.dgvGeneral.CurrentRow.Cells("DescripcionLA").Value), "", Convert.ToString(Me.dgvGeneral.CurrentRow.Cells("DescripcionLA").Value)))

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub verInformacion()
        For Each row As DataGridViewRow In dgvGeneral.SelectedRows
            If Not row.DataGridView Is Nothing Then
                Try
                    If Not IsDBNull(row.Cells("InformacionGeneral").Value) Then
                        If row.Cells("InformacionGeneral").Value <> "" Then
                            fileARticulo = New BasesParaCompatibilidad.File(Me.dgvGeneral.CurrentRow.Cells("InformacionGeneral").Value)
                            fileARticulo.open()
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    Private Sub verEvolucion()
        For Each row As DataGridViewRow In dgvGeneral.SelectedRows
            If Not row.DataGridView Is Nothing Then
                Try
                    If Not IsDBNull(row.Cells("EvolucionPrecios").Value) Then
                        If row.Cells("EvolucionPrecios").Value <> "" Then

                            fileARticulo = New BasesParaCompatibilidad.File(Me.dgvGeneral.CurrentRow.Cells("EvolucionPrecios").Value)
                            fileARticulo.open()
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
        Next

    End Sub

    Private Sub CambiarTipo()
        Me.Enabled = False
        Dim spArticulo As New spArticulos1

        Dim frmTipo As New frmCambiarTipo(Me.dgvGeneral.CurrentRow.Cells("Id").Value)
        If BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmTipo) = Windows.Forms.DialogResult.OK Then

            dgvFill()
        End If
        Me.Enabled = True
    End Sub
End Class
