Public Class frmEntCargaNecesidadesJRDetalles
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_MaestroID As Integer
    Private ArticuloDescripcion As String
    Private Tabla As New DataTable
    Private m_currentRow As DataGridViewRow
    Private tsb As ToolStripItem = Me.bdnGeneral.Items.Add("+")
    Private sp As New spCargasNecesidades

    Public Sub New(ByVal MaestroID As Integer) 'Insertar
        InitializeComponent()
        m_MaestroID = MaestroID
    End Sub

    Public Sub New(ByVal currentRow As DataGridViewRow)  'Modificar
        InitializeComponent()
        m_currentRow = currentRow
        m_MaestroID = m_currentRow.Cells("DetalleID").Value
    End Sub

    Private Sub frmEntCargaNecesidadesJRDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()

        Me.bdnGeneral.Items.Insert((0), tsb)
        tsb.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsb.Image = My.Resources.edit_add_2
        tsb.Name = "toolStripMas"
        tsb.ToolTipText = "Añadir registro y no BasesParaCompatibilidad.BD.Cerrar"

        AddHandler tsb.Click, AddressOf BindingNavigatorItemOnClick

        Dim sp As New spArticulosEnvasadosHistoricos
        sp.cargar_TiposFormatos(cboArticulos, dtb)
        'RellenarComboBox(c, RealizarConsulta("SelectTiposFormatosAll"), False)

        If Me.Text = "Insertar" Then 'Solo necesitamos este campo
            Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Text = m_MaestroID.ToString
        Else
            With m_currentRow
                Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Text = .Cells("DetalleID").Value.ToString
                Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Text = .Cells("MaestroID").Value.ToString
                ArticuloIDCuadroDeTexto.Text = .Cells("Descripcion").Value.ToString
                cboArticulos.SelectedIndex = cboArticulos.FindString(.Cells("Descripcion").Value)
                CargaCuadroDeTexto.Text = .Cells("Carga").Value.ToString
                StockCuadroDeTexto.Text = .Cells("Stock").Value.ToString
                ObservacionesCuadroDeTexto.Text = .Cells("Observaciones").Value.ToString
            End With
        End If
    End Sub

    Overrides Sub Guardar()
        InsertUpdate(True)
    End Sub

    Private Sub InsertUpdate(ByVal CerrarForm As Boolean)
        If Me.Text.Substring(0, 3) = "Mod" Then
            m_currentRow.Cells(0).Value = CargaNecesidadesJRDetalleIDCuadroDeTexto.Text
            m_currentRow.Cells(1).Value = CargaNecesidadesJRMaestroIDCuadroDeTexto.Text
            m_currentRow.Cells("Descripcion").Value = cboArticulos.Text
            m_currentRow.Cells(3).Value = CargaCuadroDeTexto.Text
            m_currentRow.Cells(4).Value = StockCuadroDeTexto.Text
            m_currentRow.Cells(5).Value = ObservacionesCuadroDeTexto.Text
        End If

        Dim Action As Integer
        If Me.Text = "Insertar" Then
            CargaNecesidadesJRDetalleIDCuadroDeTexto.Text = "1" 'Solamente para que no de error
            Action = Me.sp.insert
        Else
            Action = Me.sp.Update
        End If

        Me.sp.spCargaNecesidadesJRDetalle(Action, _
                 CargaNecesidadesJRDetalleIDCuadroDeTexto.Text, _
                 CargaNecesidadesJRMaestroIDCuadroDeTexto.Text, _
                 cboArticulos.SelectedValue, _
                 If(CargaCuadroDeTexto.Text = "", 0, CInt(CargaCuadroDeTexto.Text)), _
                  If(StockCuadroDeTexto.Text = "", 0, CInt(StockCuadroDeTexto.Text)), _
                 ObservacionesCuadroDeTexto.Text, _
                 Reserva1CuadroDeTexto.Text, _
                 Reserva2CuadroDeTexto.Text, _
                 Reserva3CuadroDeTexto.Text, _
                 Now(), _
                 1, dtb)

        If CerrarForm Then
            Me.Close()
        Else
            cboArticulos.Focus()
            CargaCuadroDeTexto.Text = ""
            StockCuadroDeTexto.Text = ""
        End If

    End Sub

    Private Sub cboArticulos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboArticulos.GotFocus
        lblAñadirArticulo.Visible = True
        cboArticulos.DroppedDown = True
    End Sub

    Private Sub cboArticulos_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboArticulos.SelectedValueChanged
        ArticuloIDCuadroDeTexto.Text = cboArticulos.Text
        lblAñadirArticulo.Visible = False
    End Sub

    Private Sub BindingNavigatorItemOnClick(ByVal sender As Object, ByVal e As EventArgs)
        ' Referenciamos el objeto que ha desencadenado el evento
        Dim tsb As ToolStripButton = DirectCast(sender, ToolStripButton)
        InsertUpdate(False)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            tsb.PerformClick()
        End If
    End Sub
End Class
