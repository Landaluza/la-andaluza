Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPanDoypack
    Implements wizardable

    Private id As Integer
    Private mododeapertura As Byte
    Private asistente As Boolean
    Private dbo As Dbo_DoyPack
    Private monodosis As Collection
    Public Event actualizarExtras()
    Private spdoypack As spdoypack
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New(ByVal id As Integer, Optional ByVal asistente As Boolean = False)
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        Me.dbo = New Dbo_DoyPack
        spdoypack = New spdoypack
        Me.id = id

        If id = Nothing Then
            Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION
            Me.monodosis = New Collection
            Me.tsmod.Visible = False
        Else
            Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION
        End If

        Dim s As New spArticulosEnvasadosHistoricos
        s.cargar_TiposFormatos(Me.cboFormato, dtb)
        Dim sp As New spmarcas
        sp.cargar_marcas(Me.cboMarca, dtb)
        Dim s2 As New spTiposCajas
        s2.cargar_TiposCajas(Me.cboCaja, dtb)
        Dim s3 As New spTiposProductos
        s3.cargar_ComboBox(Me.cboProducto, dtb)

        EstablecerValores()
    End Sub

    Public Function comprobarCampos() As Boolean Implements wizardable.comprobarCampos
        If Me.DataGridView1.Rows.Count = 0 Then
            Return False
        End If

        getValores()
        Return True
    End Function

    Private Sub getValores()
        Me.dbo.CajaId = Me.cboCaja.SelectedValue
        Me.dbo.MarcaId = Me.cboMarca.SelectedValue
        Me.dbo.ProductoId = Me.cboProducto.SelectedValue
        Me.dbo.TipoFormatoID = Me.cboFormato.SelectedValue
        Me.dbo.Palet_NO_Conforme_ID = Me.cboSccNC.SelectedValue
    End Sub
    Public Sub EstablecerValores() Implements wizardable.EstablecerValores
        dgvFill()

        If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION Then
            Me.cboFormato.SelectedValue = spdoypack.FormatoPorArticulo(Me.id, dtb)
            Me.cboProducto.SelectedValue = spdoypack.ProductoPorArticulo(Me.id, dtb)
            Me.cboCaja.SelectedValue = spdoypack.CajaPorArticulo(Me.id, dtb)
            Me.txtEan.Text = spdoypack.EanPorArticulo(Me.id, dtb)
            Me.cboSccNC.SelectedValue = spdoypack.PaletNCPorArticulo(Me.id, dtb)
            Me.cboMarca.SelectedValue = spdoypack.MarcaPorArticulo(Me.id, dtb)
        End If
    End Sub

    Public Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean Implements wizardable.grabarDatos
        If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION Then
            Return spdoypack.actualizarFormatoPorArticulo(dtb, Me.id, Me.cboFormato.SelectedValue, Me.cboMarca.SelectedValue, Me.cboCaja.SelectedValue, Me.cboSccNC.SelectedValue, Me.cboProducto.SelectedValue, Me.txtEan.Text)
        Else
            Dim retorno As Boolean = True
            Dim aux As Dbo_DoyPack
            Dim formato As Integer

            If cbEnvasado.Checked Then
                formato = Me.cboFormato.SelectedValue
            Else
                formato = spdoypack.crear_formato("", dtb)
            End If
            Dim articulo As Integer = spdoypack.UltimoArticuloInsertado(dtb)

            For i As Integer = 1 To Me.monodosis.Count
                aux = Me.monodosis.Item(i)
                aux.ArticuloPrimarioID = articulo
                aux.TipoFormatoID = formato
                aux.MarcaId = cboMarca.SelectedValue
                aux.ProductoId = cboProducto.SelectedValue
                aux.CajaId = cboCaja.SelectedValue

                retorno = retorno And spdoypack.add(aux, dtb)

                retorno = retorno And spdoypack.InsertarCompuestoPor(aux.ArticuloPrimarioID, aux.MonodosisID, aux.Cantidad, dtb)
            Next

            Return retorno
        End If
    End Function

    Public Function recuperarValor(nombre As String) As Object Implements wizardable.recuperarValor
        Return Nothing
    End Function

    Private Sub frmPanDoypack_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        MsgBox("hola")
        'BasesParaCompatibilidad.Pantalla.centerIn(Me.Pancontenidos, Me)
    End Sub

    Private Sub tsadd_Click(sender As System.Object, e As System.EventArgs) Handles tsadd.Click
        añadir(dtb)
    End Sub

    Private Sub tsmod_Click(sender As System.Object, e As System.EventArgs) Handles tsmod.Click
        modificar()
    End Sub

    Private Sub tsdel_Click(sender As System.Object, e As System.EventArgs) Handles tsdel.Click
        eliminar()
    End Sub

    Private Sub dgvFill()
        If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION Then
            Dim dt As DataTable = spdoypack.selectRecords(Me.id, dtb)

            If dt Is Nothing Then Return
            Me.DataGridView1.DataSource = dt
        Else
            Me.DataGridView1.Columns.Add("id", "id")
            Me.DataGridView1.Columns.Add("id_monodosis", "id_monodosis")
            Me.DataGridView1.Columns.Add("descripcionLA", "descripcionLA")
            Me.DataGridView1.Columns.Add("cantidad", "cantidad")
        End If

        Me.DataGridView1.Columns("id").Visible = False
        Me.DataGridView1.Columns("id_monodosis").Visible = False
        Me.DataGridView1.FormatoColumna("descripcionLA", "Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        Me.DataGridView1.FormatoColumna("cantidad", "Cantidad", BasesParaCompatibilidad.TiposColumna.Double2, 120)


    End Sub

    Private Function esDuplicado(ByVal id_monodosis As Integer) As Boolean
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            If row.Cells("id_monodosis").Value = id_monodosis Then
                Return True
                Exit Function
            End If
        Next

        Return False
    End Function

    Private Sub añadir(ByRef dtb As BasesParaCompatibilidad.DataBase)
        Dim frm As New frmSeleccionMonodosis()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        dbo = New Dbo_DoyPack


        If Not dbo Is Nothing Then
            dbo.ArticuloPrimarioID = Me.id
            Me.dbo.Cantidad = frm.monodosis.Cantidad
            dbo.MonodosisID = frm.monodosis.MonodosisID

            If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
                If Not esDuplicado(dbo.MonodosisID) Then
                    Me.monodosis.Add(dbo)
                    'añadir la fila

                    Dim row As String() = New String() {0, dbo.MonodosisID, frm.Descripcion, dbo.Cantidad}
                    DataGridView1.Rows.Add(row)
                Else
                    MessageBox.Show("Ya se ha incluido esta monodosis", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                getValores()
                dtb.EmpezarTransaccion()

                If spdoypack.add(dbo, dtb) Then

                    If spdoypack.InsertarCompuestoPor(dbo.ArticuloPrimarioID, dbo.MonodosisID, dbo.Cantidad, dtb) Then
                        dtb.TerminarTransaccion()
                        dgvFill()
                        RaiseEvent actualizarExtras()
                    Else
                        dtb.CancelarTransaccion()
                        MessageBox.Show("Ocurrio un error al añadir el registro.", "No se pudo guardar el registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    dtb.CancelarTransaccion()
                    MessageBox.Show("Ocurrio un error al añadir el registro.", "No se pudo guardar el registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If

        frm.Dispose()
    End Sub

    Private Sub eliminar()
        If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
            Dim dbo As Dbo_DoyPack
            For i As Integer = 1 To Me.monodosis.Count
                dbo = monodosis.Item(i)
                If Me.DataGridView1.CurrentRow.Cells("id_monodosis").Value = dbo.MonodosisID Then
                    monodosis.Remove(i)
                    Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
                    Return
                End If
            Next
        Else


            If spdoypack.delete(Me.DataGridView1.CurrentRow.Cells("id").Value, dtb) Then

                dgvFill()
                RaiseEvent actualizarExtras()

            Else

                MessageBox.Show("No se pudo eliminar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub modificar()
        Dim frm As New BasesParaCompatibilidad.frmEntrada("Nueva cantidad de la monodosis", "Cantidad")
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        If frm.Result <> String.Empty Then
            Dim dbo As Dbo_DoyPack = spdoypack.selectRecordById(Me.DataGridView1.CurrentRow.Cells("id").Value, dtb)
            dbo.Cantidad = frm.Result

            If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
                Me.DataGridView1.CurrentRow.Cells("Cantidad").Value = frm.Result

            Else
                If spdoypack.modify(dbo, dtb) Then
                    dgvFill()
                    RaiseEvent actualizarExtras()
                Else
                    MessageBox.Show("Ocurrio un error al modifucar el registro.", "No se pudo modificar el registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If

        frm.Dispose()
    End Sub

    Public Sub ActualizarDatos()
        Try
            Me.dgvFill()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboFormato_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboFormato.SelectedValueChanged
        Try
            Dim spPalets As New spPaletsProducidos
            spPalets.cargar_PaletsProducidosNC_byArticulo(Me.cboSccNC, Me.cboFormato.SelectedValue, dtb)
        Catch ex As Exception

        End Try

        Try
            Dim sp As New spArticulosEnvasadosHistoricos
            Dim dbo As DBO_ArticulosEnvasadoHistorico = sp.Select_Record(Me.cboFormato.SelectedValue, dtb)
            Me.cboProducto.SelectedValue = dbo.TipoProductoID
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnverMarcas_Click(sender As System.Object, e As System.EventArgs) Handles btnverMarcas.Click
        Dim frm As New frmmarcas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Dim sp As New spmarcas
        sp.cargar_marcas(Me.cboMarca, dtb)
    End Sub

    Private Sub btnaddMarcas_Click(sender As System.Object, e As System.EventArgs) Handles btnaddMarcas.Click
        Dim frm As New frmEntmarcas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Dim sp As New spmarcas
        sp.cargar_marcas(Me.cboMarca, dtb)
    End Sub
End Class