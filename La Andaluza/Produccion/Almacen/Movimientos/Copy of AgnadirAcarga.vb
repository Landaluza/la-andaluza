﻿Public Class AgnadirAcarga
    Private spAlamacen As spAlmacenPalets
    Private Tabla As DataTable
    Private O_Item As ListViewItem

    Private ctlAlbDet As ctlAlbaranesCargaProviDetalles
    Private codigoMaestro As String
    Public Event AfterSave(ByRef sender As Object, e As EventArgs)
    Public Event AfterAdd(ByRef sender As Object, e As EventArgs)
    Public Event BeforeScan(ByRef sender As Object, ByVal scc As String)
    Public EventHandled As Boolean
    Private loteOriginal As String
    Private spPaletsProducidos2 As spPaletsProducidos2
    Private dtb as BasesParaCompatibilidad.Database
    Public Sub New(ByVal MaestroProID As Integer)
        InitializeComponent()

        ctlAlbDet = New ctlAlbaranesCargaProviDetalles
        spAlamacen = New spAlmacenPalets
        Me.codigoMaestro = MaestroProID
        spPaletsProducidos2 = New spPaletsProducidos2
        dtb = New BasesParaCompatibilidad.Database()
    End Sub

    Private Sub EscaneoSCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spTipos As New spPaletsTipos
        spTipos.cargar_PaletsTipos(Me.cboTipoPalet, dtb)

        txtSCCEscaneado.Focus()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Cursor = Cursors.WaitCursor
        If txtSCCEscaneado.Text = "" Then
            messagebox.show("No has escaneado el palet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If True Then 'revisar que el palet esta deisponible

                'Compruebo que no supere el maximo de palets o kilos que admite el camión.


                dtb.EmpezarTransaccion()

                Try

                    Dim Linea As String = "PaletsProducidosSelectArticuloCodigoQSBySCC @scc"

                    'ctlAlbDet.SetAlbaranCargaProviDetalleID(0)
                    dtb.PrepararConsulta(Linea)
                    dtb.AñadirParametroConsulta("@scc", txtSCC.Text)
                    Tabla = dtb.Consultar()




                    'Para que no sume el peso del palet
                    txtPesoPalet.Text = "0"
                    ' hay que añadir el tipo de palet
                    If ctlAlbDet.GuardarAlbaranCargaProviDetalle(dtb, Me.codigoMaestro, _
                                                              txtSCC.Text, _
                                                              Tabla.Rows(0).Item("CodigoQS"), _
                                                              txtDescripcion.Text, _
                                                              txtCajas.Text, _
                                                              33, _
                                                               txtLote.Text, _
                                                               Me.cboTipoPalet.SelectedValue, _
                                                              txtObsEnvasado.Text, _
                                                              "Reserva1", _
                                                              "Reserva2", _
                                                              "Reserva3", "") Then
                        Dim sp As New spPaletsProducidos
                        Dim DBO_PaletsProducidos As DBO_PaletsProducidos = sp.Select_RecordBySSCC(txtSCC.Text, dtb)
                        DBO_PaletsProducidos.EnAlmacen = 0
                        sp.Grabar(DBO_PaletsProducidos, dtb)
                        dtb.TerminarTransaccion()
                        RaiseEvent AfterSave(Me, Nothing)
                        Me.Close()
                    Else
                        dtb.CancelarTransaccion()
                        MessageBox.Show("No se pudo completar la operación. Vuelva a intentarlo en unos segundos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch ex As Exception
                    dtb.CancelarTransaccion()
                    messagebox.show("Hubo un problema al realizar las operaciones. Detalles:" & Environment.NewLine & Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                messagebox.show("Este SSCC esta repetido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                borrarTextos()
            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        borrarTextos()
    End Sub

    Private Sub txtSCCEscaneado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtSCCEscaneado.BackColor = Color.Lime
        btnOK.Visible = False
    End Sub

    Private Sub txtSCCEscaneado_Validated(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSCCEscaneado.Validating



        rellenarForm()
    End Sub

    Private Sub rellenarForm()

        Dim LongitudOK As Boolean = True
        btnOK.Enabled = True
        Try
            If txtSCCEscaneado.Text = "" Then
                'messagebox.show("No has escaneado el palet", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                txtSCCEscaneado.BackColor = Color.White

                'Se escanea el codigo de la parte inferior
                Select Case txtSCCEscaneado.Text.Length
                    Case Is = 5 'Entrada manual
                        txtSCC.Text = txtSCCEscaneado.Text

                    Case Is = 20
                        Select Case txtSCCEscaneado.Text.Substring(2, 1)
                            Case Is = 1 ' Coviran
                                txtSCC.Text = txtSCCEscaneado.Text.Substring(14, 5)
                            Case Is = 0 'Resto
                                txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)
                        End Select

                    Case Is = 26 'Desarrollo de Marcas, Spar, Vivo....
                        txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)

                    Case Is = 28 'Articulos con fecha caducidad 15 + 5 + (17) + AAMMDD  Este el el formato requerido por Mercadona
                        txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)

                    Case Is = 29 'Monodosis
                        txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)

                    Case Else
                        MessageBox.Show("Numero de digitos erroneo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtSCCEscaneado.Text = ""
                        txtSCCEscaneado.Focus()
                        LongitudOK = False
                End Select

                If LongitudOK Then
                    'EventHandled = False
                    'RaiseEvent BeforeScan(Me, txtSCC.Text)
                    'If EventHandled Then
                    btnOK.Enabled = True

                    dtb.PrepararConsulta("SelectSCC @scc")
                    dtb.AñadirParametroConsulta("@scc", Me.txtSCC.Text)
                    Tabla = dtb.Consultar


                    If Tabla.Rows.Count > 0 Then
                        'Compruebo que el palets este en almacen, es decir que le campo EnAlmacen = True, por si se ha dado salida anteriormente.
                        If Tabla.Rows(0).Item(4) Then
                            If spPaletsProducidos2.estaCargado(txtSCC.Text, dtb) Then
                                btnOK.Enabled = False
                                MessageBox.Show("Este palet figura en una carga. AVISAR A MIGUEL ANGEL", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                txtObsCarga.Text = "Palet Cargado."
                            Else
                                If Convert.ToString(Tabla.Rows(0).Item(2)) = "0" Or Convert.ToString(Tabla.Rows(0).Item(2)) = "" Then
                                    btnOK.Enabled = False
                                    'messagebox.show("Este palet figura sin contenidos. AVISAR A MIGUEL ANGEL", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txtObsCarga.Text = "Palet sin contenidos."

                                    Dim resp As DialogResult = MessageBox.Show("Este palet figura sin contenidos. ¿Desea continuar con su carga?" & Environment.NewLine & "En caso afirmativo se notificara a control.", "atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                    If resp = DialogResult.No Then
                                        Return
                                    Else
                                        Me.Cursor = Cursors.WaitCursor

                                        If Not dtb.ConsultaAlteraciones("insert into notificaciones(texto, id_tipousuario, leido) values('El palet " & txtSCC.Text & " se ha expedido sin contenidos el " & Convert.ToString(Now.Date) & "' , 4, 0)") Then
                                            MessageBox.Show("No se pudo notificar a control. Vuelva a intentarlo en unos segundos.", "Error al notificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Me.Cursor = Cursors.Default
                                        Else
                                            Try
                                                Dim mail As New Mail.Mail1And1(True, "Palet sin movimientos. Fecha" & Convert.ToString(Now.Date) & " SCC: " & txtSCC.Text, _
                                                                               "El palet con matrícula " & txtSCC.Text & " se ha expedido sin movimientos sobre él (con 0 cajas).", String.Empty, _
                                                                                Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                                                String.Empty, String.Empty, Config.MailClientHost, False)

                                                Me.Cursor = Cursors.Default
                                            Catch ex As Exception
                                                Me.Cursor = Cursors.Default
                                                MessageBox.Show("Error al enviar el email. Detalles:" & Environment.NewLine & ex.Message)
                                            End Try
                                            Me.Cursor = Cursors.Default
                                        End If

                                    End If
                                End If

                                Dim lotes As String

                                Dim calendar As New BasesParaCompatibilidad.Calendar

                                If Tabla.Rows(0).Item(6) = "1" Then
                                    lotes = "Multilote: " & Environment.NewLine

                                    dtb.PrepararConsulta("SelectSCClotes @scc")
                                    dtb.AñadirParametroConsulta("@scc", Me.txtSCC.Text)
                                    Dim dt As DataTable = dtb.Consultar()
                                    For Each row As DataRow In dt.Rows
                                        lotes = lotes & calendar.DevuelveFechaJuliana(row.Item(0)) & ", "
                                    Next

                                    Me.btnNoMultilote.Visible = True
                                    Me.btnMultilote.Visible = False
                                    Me.txtLote.Font = New System.Drawing.Font(Me.txtLote.Font.FontFamily.Name, 15)
                                Else
                                    lotes = calendar.DevuelveFechaJuliana(Tabla.Rows(0).Item(0))
                                    Me.btnMultilote.Visible = True
                                    Me.btnNoMultilote.Visible = False
                                    Me.txtLote.Font = New System.Drawing.Font(Me.txtLote.Font.FontFamily.Name, 72)
                                End If

                                If Tabla.Rows(0).Item(7) = 3 Then
                                    Me.panNoConforme.Visible = True
                                Else
                                    Me.panNoConforme.Visible = False
                                End If

                                txtFecha.Text = Convert.ToString(Tabla.Rows(0).Item(0)).Substring(0, Convert.ToString(Len(Tabla.Rows(0).Item(0))) - 8)
                                txtDescripcion.Text = Convert.ToString(Tabla.Rows(0).Item(1))
                                txtCajas.Text = If(Convert.ToString(Tabla.Rows(0).Item(2)) = "", "0", Convert.ToString(Tabla.Rows(0).Item(2)))
                                txtLote.Text = lotes
                                txtObsEnvasado.Text = Convert.ToString(Tabla.Rows(0).Item(3))
                                txtPesoPalet.Text = Convert.ToString(Tabla.Rows(0).Item("Peso"))
                                If Not IsDBNull(Tabla.Rows(0).Item("TipoPalet")) Then
                                    cboTipoPalet.SelectedValue = Tabla.Rows(0).Item("TipoPalet")
                                End If

                                Tabla = Nothing
                                loteOriginal = txtLote.Text


                                If txtObsEnvasado.Text.Contains("NO CARGAR") Or txtObsEnvasado.Text.Contains("no cargar") Then
                                    'btnOK.Enabled = False
                                    txtObsEnvasado.BackColor = Color.Yellow
                                    MessageBox.Show("Este palet no se puede cargar." & Environment.NewLine & _
                                           "Comprobar Observaciones de envasado.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    txtObsEnvasado.BackColor = Color.White
                                End If

                                'ActualizarContadoresPalets()
                            End If
                        Else
                            Dim resp As DialogResult = MessageBox.Show("Este palet no se encuentra en el almacen. ¿Desea marcalo como 'en almacen' y continuar?" & Environment.NewLine & _
                                                              "(Pulse 'No' si la información es correcta y no esta en almacen)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If resp = DialogResult.Yes Then
                                dtb.PrepararConsulta("update paletsproducidos set enalmacen=1 where scc = @scc")
                                dtb.AñadirParametroConsulta("@scc", txtSCCEscaneado.Text)
                                If Not dtb.Execute Then Throw New Exception("Error actualizando el palet")
                                rellenarForm()
                            Else
                                btnOK.Enabled = False
                                txtObsCarga.Text = "Este palet no figuraba en las existencias del almacen."
                            End If
                        End If
                    Else
                        'Si algun campo de la consulta esta vacio esta falla, por ejemplo CajasPalets o PesoPalet
                        MessageBox.Show("No se ha encontrado este SSCC" & Environment.NewLine & _
                               "Comprobar que el palet tiene todos los datos" & Environment.NewLine & _
                               "En menu envasado submenu ArticulosEnvasados puede faltar el dato de cajas por palet" & Environment.NewLine & _
                               "y submenu Datos palets terminados comprobar que existe el Articulo con sus datos correspondientes", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        borrarTextos()
                    End If
                    'Else
                    '    borrarTextos()
                    '    btnOK.Enabled = False
                    'End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en txtSCCEscaneado_Validating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSCC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSCCEscaneado.Validating
        'Para evitar se escanee por error en este campo
        If txtSCC.Text.Length > 6 Then
            txtSCC.Text = txtSCCEscaneado.Text.Substring(15, 5)
            e.Cancel = True
        End If
    End Sub

    Private Sub borrarTextos()
        For Each oControl As Control In Me.Controls
            If TypeOf (oControl) Is TextBox Then
                If oControl.Name <> "txtPaletsTotales" And oControl.Name <> "txtPesoTotal" Then
                    oControl.Text = ""
                End If
            End If
        Next
        txtSCCEscaneado.Focus()
    End Sub

    Private Sub btnBorrar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBorrar.Click
        borrarTextos()
    End Sub

    Private Sub btnNoMultilote_Click(sender As System.Object, e As System.EventArgs) Handles btnNoMultilote.Click
        dtb.PrepararConsulta("update paletsproducidos set multilote = 0 where scc = @scc")
        dtb.AñadirParametroConsulta("@scc", txtSCCEscaneado.Text)
        dtb.Execute()
        rellenarForm()
    End Sub

    Private Sub btnMultilote_Click(sender As System.Object, e As System.EventArgs) Handles btnMultilote.Click
        dtb.PrepararConsulta("update paletsproducidos set multilote = 1 where scc = @scc")
        dtb.AñadirParametroConsulta("@scc", txtSCCEscaneado.Text)
        dtb.Execute()
        rellenarForm()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles txtSCCEscaneado.Validated

    End Sub
End Class