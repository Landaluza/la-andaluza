Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmModMovimientoPalet
    Private Respuesta As DialogResult

    Private CajasOrigen As Integer = 0
    Private CajasDestino As Integer = 0
    Private CajasPaletOrigen As Integer = 0
    Private CajasPaletDestino As Integer = 0
    Private CajasFinales As Integer

    Private DBO_PaletsMovimientoTipo As New DBO_PaletsMovimientosTipos
    Private dbo_movimiento As Dbo_PaletsMovimiento
    Private dbo_MovimientoDB As New spPaletsMovimiento
    Private m_PaletProducidoOrigen As Envasado.DBO_PaletsProducidos2
    Private m_PaletProducidoDestino As Envasado.DBO_PaletsProducidos2
    Private tsMovimiento As ToolStripItem
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New(ByVal Dbo_PaletsMovimiento As Dbo_PaletsMovimiento)

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        Me.dbo_movimiento = Dbo_PaletsMovimiento
        dtpFecha.activarFoco()
    End Sub


    Private Sub frmModMovimientoPalet_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboMovimientoTipo.mam_DataSource("PaletsMovimientosTipos1CboNoEntrePalets", False, dtb)
        cboMovimientoTipo.MaxDropDownItems = cboMovimientoTipo.Items.Count

        setValores()
        If Me.dbo_movimiento.MovimientoEntrePaletsID <> Nothing Then
            Me.cboMovimientoTipo.Enabled = False

        End If
    End Sub

    Private Sub setValores()

        Try

            txtCajas.Text = dbo_movimiento.Cajas
            txtDocumento.Text = dbo_movimiento.DocumentoID


            txtPaletID.Text = dbo_movimiento.PaletID
            txtCajas.Text = dbo_movimiento.Cajas
            txtDocumento.Text = dbo_movimiento.DocumentoID
            dtpHora.Value = New DateTime(Now.Year, Now.Month, Now.Day, dbo_movimiento.Hora.Hours, dbo_movimiento.Hora.Minutes, 0)

            Me.cboMovimientoTipo.SelectedValue = dbo_movimiento.Tipo
            dtpFecha.Text = dbo_movimiento.Fecha
            txtObsMovimiento.Text = dbo_movimiento.Comentarios
            txtAutorizadoPor.Text = dbo_movimiento.AutorizadoPor

            txtReceptor.Text = dbo_movimiento.Receptor
            txtMotivo.Text = dbo_movimiento.Motivo
            txtSolicitante.Text = dbo_movimiento.Solicitante
            txtCliente.Text = dbo_movimiento.Cliente
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboMovimientoTipo_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboMovimientoTipo.SelectedValueChanged
        Try
            If cboMovimientoTipo.SelectedIndex = 0 Then
            Else
                Me.cboMovimientoSubTipo.mam_DataSource("PaletsMovimientoSubTipoByTipo " & Convert.ToString(cboMovimientoTipo.SelectedValue), False, dtb)
                cboMovimientoSubTipo.Refresh()
                Dim sp As New spPaletsMovimientosTipos
                DBO_PaletsMovimientoTipo = sp.Select_Record(Me.cboMovimientoTipo.SelectedValue, dtb)
            End If

            lblAutorizadoPor.Visible = False
            lblReceptor.Visible = False
            lblMotivo.Visible = False
            lblCliente.Visible = False
            lblSolicitante.Visible = False

            txtAutorizadoPor.Visible = False
            txtReceptor.Visible = False
            txtMotivo.Visible = False
            txtCliente.Visible = False
            txtSolicitante.Visible = False

            If cboMovimientoTipo.Text = "Envasar" Then

            ElseIf cboMovimientoTipo.Text = "Comprar" Then

            ElseIf cboMovimientoTipo.Text = "Regalar" Then
                lblAutorizadoPor.Visible = True
                lblReceptor.Visible = True
                lblMotivo.Visible = True
                txtAutorizadoPor.Visible = True
                txtReceptor.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Rotura" Then
                lblAutorizadoPor.Visible = True
                lblMotivo.Visible = True
                txtAutorizadoPor.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Diferencia" Then
                lblMotivo.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Muestra" Then
                lblSolicitante.Visible = True
                txtSolicitante.Visible = True

            ElseIf cboMovimientoTipo.Text = "Devolucion" Then
                lblMotivo.Visible = True
                lblCliente.Visible = True
                txtMotivo.Visible = True
                txtCliente.Visible = True

            ElseIf cboMovimientoTipo.Text = "Reetiquetar" Then
                lblMotivo.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Destruir" Then
                lblAutorizadoPor.Visible = True
                lblMotivo.Visible = True
                txtAutorizadoPor.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "ManipularExt" Then
                lblReceptor.Visible = True
                lblMotivo.Visible = True
                txtReceptor.Visible = True
                txtMotivo.Visible = True

            ElseIf cboMovimientoTipo.Text = "Mover" Then

            ElseIf cboMovimientoTipo.Text = "Expedir" Then

            ElseIf cboMovimientoTipo.Text = "Bloquear" Then

            ElseIf cboMovimientoTipo.Text = "Deposito" Then

            ElseIf cboMovimientoTipo.Text = "Tipos" Then

            ElseIf cboMovimientoTipo.Text = "Anular" Then

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function getValores() As Boolean
        Try

            dbo_movimiento.PaletID = txtPaletID.Text
            dbo_movimiento.Cajas = System.Convert.ToInt32(If(txtCajas.Text = "", Nothing, txtCajas.Text))

            dbo_movimiento.DocumentoID = System.Convert.ToInt32(If(txtDocumento.Text = "", Nothing, txtDocumento.Text))
            dbo_movimiento.DocumentoID_IsDBNull = If(txtDocumento.Text = "", True, False)

            dbo_movimiento.Tipo = Me.cboMovimientoTipo.SelectedValue
            dbo_movimiento.Tipo_IsDBNull = False
            dbo_movimiento.PaletID_IsDBNull = False
            dbo_movimiento.Fecha = dtpFecha.Value.Date
            dbo_movimiento.Fecha_IsDBNull = False
            dbo_movimiento.Hora = New TimeSpan(dtpHora.Value.Hour, dtpHora.Value.Minute, 0)
            dbo_movimiento.Cajas_IsDBNull = If(txtCajas.Text = "", True, False)

            dbo_movimiento.Comentarios = System.Convert.ToString(If(txtObsMovimiento.Text = "", String.Empty, txtObsMovimiento.Text))
            dbo_movimiento.Comentarios_IsDBNull = If(txtObsMovimiento.Text = "", True, False)
            dbo_movimiento.AutorizadoPor = Nothing
            dbo_movimiento.AutorizadoPor_IsDBNull = True
            dbo_movimiento.Receptor = Nothing
            dbo_movimiento.Receptor_IsDBNull = True
            dbo_movimiento.Motivo = "" ' Si pongo Nothing da error.
            dbo_movimiento.Motivo_IsDBNull = False
            dbo_movimiento.Solicitante = Nothing
            dbo_movimiento.Solicitante_IsDBNull = True
            dbo_movimiento.Cliente = Nothing
            dbo_movimiento.Cliente_IsDBNull = True

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        If getValores() Then
            If dbo_MovimientoDB.update(dbo_movimiento, dtb) Then
                Me.Close()
            Else
                MessageBox.Show("Error al guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class