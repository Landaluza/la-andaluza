Public Class frmExtenderPlantillaControlLote
    Public Event afterSave()
    Private spTiposProductos As spTiposProductos
    Private spTiposLotes As spTiposLotes
    Private dtLotes As DataTable
    Private dtProductos As DataTable
    Private spTiposControlesLotesPlantilla As spTiposControlesLotesPlantilla
    Private dbo As DBO_TiposControlesLotesPlantilla
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal id_plantilla As Integer)

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        spTiposLotes = New spTiposLotes
        spTiposProductos = New spTiposProductos
        spTiposControlesLotesPlantilla = New spTiposControlesLotesPlantilla
        dbo = Me.spTiposControlesLotesPlantilla.Select_Record(id_plantilla, dtb)
    End Sub



    Private Sub butGuardar_Click(sender As System.Object, e As System.EventArgs) Handles butGuardar.Click
        dgvProducto.EndEdit()
        dgvLote.EndEdit()

        dtb.EmpezarTransaccion()

        Try
            For Each rowProducto As DataGridViewRow In Me.dgvProducto.Rows

                If Not Convert.IsDBNull(rowProducto.Cells("check").Value) Then
                    If Convert.ToBoolean(rowProducto.Cells("check").Value) Then
                        dbo.Id_TipoProducto = Convert.ToInt32(rowProducto.Cells("TipoProductoID").Value)

                        For Each rowLote As DataGridViewRow In Me.dgvLote.Rows
                            If Not Convert.IsDBNull(rowLote.Cells("check").Value) Then
                                If Convert.ToBoolean(rowLote.Cells("check").Value) Then

                                    dbo.Id_TipoLote = Convert.ToInt32(rowLote.Cells("TipoLoteID").Value)

                                    If Not Me.spTiposControlesLotesPlantilla.Grabar(dbo, dtb) Then
                                        dtb.CancelarTransaccion()
                                        MessageBox.Show("Error al guardar los datos, en posible que exista un registro duplicado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    End If
                                End If
                            End If
                        Next
                    End If
                End If
            Next

            dtb.TerminarTransaccion()
            RaiseEvent afterSave()
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("Error al guardar, detalles:" & Environment.NewLine & ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            Me.Close()
        End Try

    End Sub

    Private Sub butSalir_Click(sender As System.Object, e As System.EventArgs) Handles butSalir.Click
        Me.Close()
    End Sub

    Private Sub cargar_datos() Handles BackgroundWorker1.DoWork
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtProductos = spTiposProductos.devolver_TiposProductos_Cbo(dtb)
        dtLotes = spTiposLotes.devolver_TiposLotes(dtb)
    End Sub

    Private Sub bindDatasource() Handles BackgroundWorker1.RunWorkerCompleted
        If Me.dbo Is Nothing Or dtLotes Is Nothing Or dtProductos Is Nothing Then
            MessageBox.Show("Error al recuperar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        dbo.ID = 0

        dtLotes.Columns.Add(New DataColumn("check", GetType(Boolean)))
        dgvLote.DataSource = dtLotes

        Me.dgvLote.Columns("TipoLoteID").Visible = False    

        dtProductos.Columns.Add(New DataColumn("check", GetType(Boolean)))
        dgvProducto.DataSource = dtProductos

        Me.dgvProducto.Columns("TipoProductoID").Visible = False
    End Sub

    Private Sub frmExtenderPlantillaControlLote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class