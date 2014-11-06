Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmRevisionLotes
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboRevisionLotes As DBO_RevisionLotes
    Private butRev As Button
    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spRevisionLotes(), MaestroID.ToString)
        InitializeComponent()
        dboRevisionLotes = New DBO_RevisionLotes
        Me.bdnGeneral.Visible = False
        Dim panRev As New Panel
        panRev.Dock = DockStyle.Bottom
        butRev = New Button        
        butRev.Dock = DockStyle.Fill
        butRev.FlatAppearance.BorderSize = 0
        butRev.FlatStyle = FlatStyle.Flat
        butRev.Image = My.Resources.edit_remove_3
        butRev.Cursor = Cursors.Hand
        panRev.Controls.Add(butRev)
        panRev.BackColor = Color.White
        Me.Controls.Add(panRev)
        AddHandler butRev.Click, AddressOf Revisado

        Me.dgvGeneral.RowHeadersVisible = False
        Me.dgvGeneral.ColumnHeadersVisible = False
        Me.dgvGeneral.CellBorderStyle = DataGridViewCellBorderStyle.None
        Me.dgvGeneral.DefaultCellStyle.BackColor = Color.White
        Me.dgvGeneral.DefaultCellStyle.SelectionBackColor = Color.White
        Me.dgvGeneral.BackgroundColor = Color.White
        Me.dgvGeneral.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvGeneral.GridColor = Color.White
        dgvGeneral.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Revisado(sender As Object, e As EventArgs)
        If Not Me.dgvGeneral.CurrentRow Is Nothing Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            dtb.PrepararConsulta("update lotes set revisar = null where loteid= @id")
            dtb.AñadirParametroConsulta("@id", Me.dgvGeneral.CurrentRow.Cells("Id").Value.ToString)

            If dtb.Execute Then
                dgvFill()
            Else
                MessageBox.Show("No se pudo marcar como revisado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        Me.EventHandeld = True
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Me.EventHandeld = True

        Dim Frm As New FrmEntLotes
        Frm.Text = "Modificar Lote"

        Frm.CargarDatos(0, _
                       Convert.ToInt32(Me.dgvGeneral.CurrentRow.Cells(0).Value), _
                       Convert.ToInt32(Me.dgvGeneral.CurrentRow.Cells("TipoLoteId").Value), _
                       Convert.ToInt32(Me.dgvGeneral.CurrentRow.Cells("TipoProductoId").Value), _
                       False)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        ' dboRevisionLotes = CType(sp, spRevisionLotes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        'If Not dboRevisionLotes Is Nothing Then
        '    newRegForm.SetDataBussinesObject(ctype(Me.dboRevisionLotes,BasesParaCompatibilidad.databussines))
        'Else
        '    MyBase.EventHandeld = True
        '    Messagebox.show("No se pudo recuperar los datos",  "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spRevisionLotes.DataGridViewStoredProcedure)

        If Not datasource Is Nothing Then
            GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .Columns("TipoLoteId").Visible = False
                .Columns("TipoProductoId").Visible = False
                .Columns("Fecha").Visible = False
                .Columns("Deposito").Visible = False
                .Columns("CantidadRestante").Visible = False
                .Columns("CodigoLote").Visible = False
                .FormatoColumna("Resumen", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
            If dataSource.Rows.Count > 0 Then
                Me.butRev.Visible = True
            Else
                Me.butRev.Visible = False
            End If
        Else
            Me.butRev.Visible = False
        End If

    End Sub

    Public Sub recargar()
        Me.dgvFill()
    End Sub


End Class
