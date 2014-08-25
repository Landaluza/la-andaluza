Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmSelectorArticulo
    Private formatoID As Integer
    Private tipoArticulo As String
    Private subtipoArticulo As String
    Private idExcluido As Integer

    Public Sub New(ByVal tipoArticulo As String, ByVal subtipoArticulo As String, ByVal idExcluido As Integer)
        InitializeComponent()

        Me.tipoArticulo = tipoArticulo
        Me.subtipoArticulo = subtipoArticulo
        Me.idExcluido = idExcluido
        dgvFill()
        Dim filterManager As New DgvFilterPopup.DgvFilterManager(DataGridView1)
    End Sub

    Public Sub New()

        InitializeComponent()
    End Sub

    Public ReadOnly Property ArticuloSeleccionado As Integer
        Get
            Return Me.formatoID
        End Get
    End Property

    Private Sub dgvFill()
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("Articulos1SelectDgvBy @idexcluido")
        dtb.AñadirParametroConsulta("@idexcluido", idExcluido)
        Dim dt As DataTable = dtb.Consultar()
        'Dim dt As DataTable = dtb.Consultar("exec Articulos1SelectDgvBy " & idExcluido)
        Dim row As DataRow
        Dim c As New Collection
        For Each row In dt.Rows
            If row.Item("ArticuloTipo") <> Me.tipoArticulo Or If(IsDBNull(row.Item("subtipo")), Nothing, row.Item("subtipo")) <> Me.subtipoArticulo Then
                c.Add(row)
            End If
        Next

        For Each row In c
            dt.Rows.Remove(row)
        Next

        With DataGridView1
            .DataSource = dt

            .Columns("ArticuloID").Visible = False
            .FormatoColumna("CodigoLA", BasesParaCompatibilidad.TiposColumna.QS)
            .FormatoColumna("DescripcionLA", BasesParaCompatibilidad.TiposColumna.Izquierda, 250)
            .FormatoColumna("ArticuloTipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 150)
            .FormatoColumna("subtipo", "Subtipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 150)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            .FormatoGeneral()
        End With
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Me.formatoID = Me.DataGridView1.CurrentRow.Cells("ArticuloID").Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmSelectorArticulo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.formatoID = Nothing Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
End Class