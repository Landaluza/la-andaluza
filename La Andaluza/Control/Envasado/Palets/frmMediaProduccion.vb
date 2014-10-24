Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmMediaProduccion
    Private envasado As Integer
    Private linea As Integer
    Private articulo As Integer
    Private filtro As String
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()
        InitializeComponent()
        Dim spLineasEnvasado As New spLineasEnvasado
        spLineasEnvasado.cargar_LineasEnvasado(Me.cboLinea, dtb)
        Me.dtpEnvasado.activarFoco()
        dtb = New BasesParaCompatibilidad.DataBase()
    End Sub

    Private Sub chbArticulo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbArticulo.CheckedChanged
        Me.cboArticulo.Enabled = chbArticulo.Checked
        Me.lArticulo.Enabled = Me.chbArticulo.Checked
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Try
            recargar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub dtpEnvasado_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpEnvasado.ValueChanged
        Try
            cargar_lineas()
            cargar_articulos()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboLinea_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboLinea.SelectedIndexChanged
        Try
            cargar_articulos()
            If Not Me.cboArticulo.Enabled Then Me.cboArticulo.Enabled = True
        Catch ex As Exception
            Me.cboArticulo.Enabled = False
        End Try
    End Sub

    Private Sub cargar_lineas()
        Try
            dtb.PrepararConsulta("select envasadoid from envasados where fecha = @fecha")
            dtb.AñadirParametroConsulta("@fecha", Me.dtpEnvasado.Value.ToShortDateString)
            Me.envasado = dtb.Consultar().Rows(0).Item(0)
            '            Me.envasado = dtb.Consultar("select envasadoid from envasados where convert(varchar(10), fecha, 103) ='" & Me.dtpEnvasado.Value.ToShortDateString & "'", False).Rows(0).Item(0)
            If Not Me.cboLinea.Enabled Then Me.cboLinea.Enabled = True
        Catch ex As Exception
            Me.cboLinea.Enabled = False
        End Try
    End Sub

    Private Sub cargar_articulos()
        If cboLinea.SelectedValue <> Nothing Then
            Me.linea = cboLinea.SelectedValue

            If Me.envasado <> Nothing And linea <> Nothing Then
                dtb.PrepararConsulta("select formatoEnvasadoID, articulo descripcion from formatosEnvasados, tiposformatosLineas, articulosenvasadoshistorico where formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid and formatosEnvasados.tipoformatoEnvasadoid = tipoformato and lineaEnvasadoid = @linea and envasadoid = @env")
                dtb.AñadirParametroConsulta("@linea", Me.linea)
                dtb.AñadirParametroConsulta("@env", Me.envasado)

                Me.cboArticulo.mam_DataSource(dtb.Consultar, False)
            End If
        End If
    End Sub

    Private Sub recargar()
        Me.articulo = Me.cboArticulo.SelectedValue
        Me.filtro = If(Me.txtFiltro.Text = "" Or Not IsNumeric(Me.txtFiltro.Text), 0, Convert.ToInt32(Me.txtFiltro.Text))


        If Me.chbArticulo.Checked Then
            dtb.PrepararConsulta("select isnull(avg(datediff(minute, horainicio, horafin)), 1) " & _
                                             "from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas " & _
                                             "where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid " & _
                                             "and formatoid = formatoEnvasadoid " & _
                                             "and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid " & _
                                             "and lineaEnvasadoid = @linea " & _
                                             "and formatoEnvasadoid= @articulo " & _
                                             "and envasadoid = @envasado ")
            dtb.AñadirParametroConsulta("@linea", Me.linea)
            dtb.AñadirParametroConsulta("@articulo", Me.articulo)
            dtb.AñadirParametroConsulta("@envasado", Me.envasado)

            Me.txtMedia.Text = dtb.Consultar().Rows(0).Item(0)


            dtb.PrepararConsulta("select isnull(avg(datediff(minute, horainicio, horafin)), 1) " & _
                                                "from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas " & _
                                                "where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid " & _
                                                "and formatoid = formatoEnvasadoid " & _
                                                "and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid " & _
                                                "and lineaEnvasadoid = @linea " & _
                                                "and formatoEnvasadoid= @articulo " & _
                                                "and envasadoid = @envasado " & _
                                                "and datediff(minute, horainicio, horafin) > @filtro ")

            dtb.AñadirParametroConsulta("@linea", Me.linea)
            dtb.AñadirParametroConsulta("@articulo", Me.articulo)
            dtb.AñadirParametroConsulta("@envasado", Me.envasado)
            dtb.AñadirParametroConsulta("@filtro", Me.filtro)

            Me.txtSuperior.Text = dtb.Consultar().Rows(0).Item(0)


            dtb.PrepararConsulta("select SCC, datediff(minute, horainicio, horafin) Minutos from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid and formatoid = formatoEnvasadoid and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid  and lineaEnvasadoid = @linea and formatoEnvasadoid= @articulo and envasadoid = @envasado ")
            dtb.AñadirParametroConsulta("@linea", Me.linea)
            dtb.AñadirParametroConsulta("@articulo", Me.articulo)
            dtb.AñadirParametroConsulta("@envasado", Me.envasado)
            Me.dgvProduccion.DataSource = dtb.Consultar()


            dtb.PrepararConsulta("select SCC, datediff(minute, horainicio, horafin) Minutos from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid and formatoid = formatoEnvasadoid and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid  and lineaEnvasadoid = @linea and formatoEnvasadoid= @articulo and envasadoid = @envasado and datediff(minute, horainicio, horafin) > @filtro")
            dtb.AñadirParametroConsulta("@linea", Me.linea)
            dtb.AñadirParametroConsulta("@articulo", Me.articulo)
            dtb.AñadirParametroConsulta("@envasado", Me.envasado)
            dtb.AñadirParametroConsulta("@filtro", Me.filtro)

            Me.dgvSuperior.DataSource = dtb.Consultar()

        Else
            dtb.PrepararConsulta("select isnull(avg(datediff(minute, horainicio, horafin)), 1) from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid and formatoid = formatoEnvasadoid and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid and lineaEnvasadoid = @linea and envasadoid = @envasado")
            dtb.AñadirParametroConsulta("@linea", Me.linea)
            dtb.AñadirParametroConsulta("@envasado", Me.envasado)

            Me.txtMedia.Text = dtb.Consultar().Rows(0).Item(0)

            dtb.PrepararConsulta("select isnull(avg(datediff(minute, horainicio, horafin)), 1) from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid and formatoid = formatoEnvasadoid and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid and lineaEnvasadoid = @linea and envasadoid = @envasado and datediff(minute, horainicio, horafin) > @filtro ")
            dtb.AñadirParametroConsulta("@linea", Me.linea)
            dtb.AñadirParametroConsulta("@envasado", Me.envasado)
            dtb.AñadirParametroConsulta("@filtro", Me.filtro)
            Me.txtSuperior.Text = dtb.Consultar().Rows(0).Item(0)


            dtb.PrepararConsulta("select SCC, datediff(minute, horainicio, horafin) Minutos from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid and formatoid = formatoEnvasadoid and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid  and lineaEnvasadoid = @linea and envasadoid = @envasado")
            dtb.AñadirParametroConsulta("@linea", Me.linea)
            dtb.AñadirParametroConsulta("@envasado", Me.envasado)
            Me.dgvProduccion.DataSource = dtb.Consultar()


            dtb.PrepararConsulta("select SCC, datediff(minute, horainicio, horafin) Minutos from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid and formatoid = formatoEnvasadoid and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid  and lineaEnvasadoid = @linea and envasadoid = @envasado and datediff(minute, horainicio, horafin) > @filtro ")
            dtb.AñadirParametroConsulta("@linea", Me.linea)
            dtb.AñadirParametroConsulta("@envasado", Me.envasado)
            dtb.AñadirParametroConsulta("@filtro", Me.filtro)
            Me.dgvSuperior.DataSource = dtb.Consultar()

        End If

        With Me.dgvSuperior
            .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
        End With

        With Me.dgvProduccion
            .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
        End With

    End Sub
End Class