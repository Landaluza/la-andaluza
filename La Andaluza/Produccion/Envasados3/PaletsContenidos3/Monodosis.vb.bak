Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class Monodosis
    Private spPaletsContenidos As spPaletsContenidos
    Private spPMovimientos As spPaletsMovimiento
    Private spPaletsProducidos As spPaletsProducidos

    Public Sub New()
        spPMovimientos = New spPaletsMovimiento
        spPaletsContenidos = New spPaletsContenidos
        spPaletsProducidos = New spPaletsProducidos
    End Sub

    Public Sub añadirMovimientoEncajado(ByVal cantidadCajas As Integer, _
                                        ByVal PaletProducidoId_origen As Integer, _
                                        ByVal PaletProducidoId As Integer, _
                                        ByVal TipoFormatoEnvasadoID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)


        'If Not dbomovimiento Is Nothing Then spPMovimientos.Delete(dbomovimiento.ID)
        Dim spTipoFormato As New spFormatosArticulos
        Dim descripcion As String = spTipoFormato.Select_Record(TipoFormatoEnvasadoID, dtb).Descripcion

        Dim dbo_movimiento As New Dbo_PaletsMovimiento
        Dim m_PaletProducidoOrigen As DBO_PaletsProducidos
        Dim m_PaletProducidoDestino As DBO_PaletsProducidos

        dbo_movimiento.Fecha = DateTime.Now
        dbo_movimiento.Cajas = cantidadCajas
        Dim cajasInicioMail As String = dbo_movimiento.Cajas.ToString

        m_PaletProducidoOrigen = spPaletsProducidos.Select_Record(PaletProducidoId_origen, dtb) 'spPaletsProducidos2.Select_RecordBySSCCSinMachacar(cbo.SelectedItem(1),dtb)
        m_PaletProducidoDestino = spPaletsProducidos.Select_Record(PaletProducidoId, dtb)



        ComprobarCantidadesEncajado(dbo_movimiento, m_PaletProducidoOrigen, m_PaletProducidoDestino, _
                                    True, TipoFormatoEnvasadoID, dtb)
        'Movimiento del palets Origen
        dbo_movimiento.ContenidoDestinoID = CType(dtb.Consultar("select max(paletcontenidoid) from paletscontenidos", False).Rows(0).Item(0), Integer)
        spPMovimientos.Add(dbo_movimiento, dtb)

        Dim fecha As String = DateTime.Now.Day & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year
        'Deprecated.ConsultaInsertarSinDatosUsuario("'Envasado de " & descripcion & " el " & fecha & ". SCC origen: " & m_PaletProducidoOrigen.SCC & "SCC destino:" & m_PaletProducidoDestino.SCC & "', 9, 0", "notificaciones(texto, id_tipousuario, leido)")
        'Dim mail As New Mail.Mail1And1(True, "Envasado de " & descripcion, "Envasado de " & descripcion & " el " & datetime.now.ToString & "." & Environment.NewLine() & "SCC origen: " & m_PaletProducidoOrigen.SCC & ", cajas de origen: " & dbo_movimiento.Cajas & "; SCC destino:" & m_PaletProducidoDestino.SCC & ", Cajas encajadas: " & cajasInicioMail, String.Empty, _
        '                                                                            Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
        '                                                                            String.Empty, String.Empty, Config.MailClientHost, False)
    End Sub

    Private Sub ComprobarCantidadesEncajado(ByRef dbo_movimiento As Dbo_PaletsMovimiento, _
                                            ByRef m_PaletProducidoOrigen As DBO_PaletsProducidos, _
                                            ByVal m_PaletProducidoDestino As DBO_PaletsProducidos, _
                                            ByVal origen As Boolean, ByVal TipoFormatoEnvasadoID As Integer, _
                                            ByRef dtb As BasesParaCompatibilidad.DataBase)


        'If origen Then
        dbo_movimiento.PaletID = m_PaletProducidoOrigen.ID

        dbo_movimiento.DocumentoID = System.Convert.ToInt32(m_PaletProducidoDestino.SCC)
        dbo_movimiento.DocumentoID_IsDBNull = False

        Dim capacidad As Integer
        dtb.PrepararConsulta("select capacidadcaja from ArticulosEnvasadosHistoricoSinLinea where tipoformato = @tf")
        dtb.AñadirParametroConsulta("@tf", TipoFormatoEnvasadoID)
        capacidad = dtb.Consultar().Rows(0).Item(0)


        dbo_movimiento.Cajas = dbo_movimiento.Cajas * capacidad
        Dim tope As Long = spPaletsProducidos.calcularCajasAntesExpedir(m_PaletProducidoOrigen.SCC, dtb)
        If tope < dbo_movimiento.Cajas Then
            Throw New Exception("No hay suficientes cajas para realizar el movimiento. Solo quedan " & tope & " monodosis (" & Convert.ToInt32(tope / capacidad) & "cajas)")
        End If

        dtb.PrepararConsulta("select id_MovimentoEncajado from tiposcajas, ArticulosEnvasadosHistoricoSinLinea where ArticulosEnvasadosHistoricoSinLinea.tipocajaID = tiposcajas.tipocajaID and tipoformato = @tf")
        dtb.AñadirParametroConsulta("@tf", TipoFormatoEnvasadoID)
        dbo_movimiento.Tipo = dtb.Consultar().Rows(0).Item(0)
        dbo_movimiento.Tipo_IsDBNull = False
        dbo_movimiento.PaletID_IsDBNull = False
        dbo_movimiento.Fecha = DateTime.Now
        dbo_movimiento.Fecha_IsDBNull = False
        dbo_movimiento.Cajas_IsDBNull = False
        dbo_movimiento.Inicial_IsDBNull = True
        dbo_movimiento.Comentarios = "Movimiento de encajado para envasar el palet " & m_PaletProducidoDestino.SCC
        dbo_movimiento.Comentarios_IsDBNull = False
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

    End Sub

    'Public Sub realizarDiferencia(ByRef cbo As ComboBox)
    '    Dim cont As Integer
    '    Dim textNotificar As String = ""
    '    Dim fecha As String = datetime.now.Day & "/" & datetime.now.Month & "/" & datetime.now.Year
    '    Dim linea As String

    '    For cont = 0 To cbo.SelectedIndex - 1
    '        Dim m_palet As DBO_PaletsProducidos2 = spPaletsProducidos2.Select_RecordBySSCCSinMachacar(cbo.Items(cont)(1),dtb)
    '        Dim dbo_movimiento As New Dbo_PaletsMovimiento
    '        Dim dbo_MovimientoDB As New spPaletsMovimiento

    '        If m_palet.Id_Estado <> 3 Then
    '            dbo_movimiento.Tipo = 8
    '            dbo_movimiento.Tipo_IsDBNull = False
    '            dbo_movimiento.PaletID_IsDBNull = False
    '            dbo_movimiento.Cajas = spPaletsProducidos2.calcularCajasAntesExpedir(cbo.Items(cont)(1),dtb)
    '            dbo_movimiento.Fecha = datetime.now
    '            dbo_movimiento.Comentarios = "Diferencia automatizada"
    '            dbo_movimiento.Comentarios_IsDBNull = False
    '            dbo_movimiento.AutorizadoPor = Nothing
    '            dbo_movimiento.AutorizadoPor_IsDBNull = True
    '            dbo_movimiento.Receptor = Nothing
    '            dbo_movimiento.Receptor_IsDBNull = True
    '            dbo_movimiento.Inicial_IsDBNull = True
    '            dbo_movimiento.Motivo = "" ' Si pongo Nothing da error.
    '            dbo_movimiento.Motivo_IsDBNull = False
    '            dbo_movimiento.Solicitante = Nothing
    '            dbo_movimiento.Solicitante_IsDBNull = True
    '            dbo_movimiento.Cliente = Nothing
    '            dbo_movimiento.Cliente_IsDBNull = True
    '            'dbo_movimiento.Tipo = 5
    '            dbo_movimiento.ContenidoDestinoID = RealizarConsulta("select max(paletcontenidoid) from paletscontenidos").Rows(0).Item(0)
    '            dbo_movimiento.PaletID = m_palet.PaletProducidoID
    '            dbo_MovimientoDB.Add(dbo_movimiento)

    '            m_palet.EnAlmacen = 0
    '            spPaletsProducidos2.UpdatePaletsProducidos2(m_palet,dtb)
    '            textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine()
    '            linea = "Diferencia automatizada. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

    '            Deprecated.ConsultaInsertarSinDatosUsuario("'" & linea & "', 4, 0", "notificaciones(texto, id_tipousuario, leido)")
    '        Else
    '            'Dim frmNoConforme As New frmEncajadoNoConforme
    '            'frmNoConforme.ShowDialog()

    '            'If frmNoConforme.Result <> -1 Then
    '            '    dbo_movimiento.Tipo = 18
    '            '    dbo_movimiento.Tipo_IsDBNull = False
    '            '    dbo_movimiento.PaletID_IsDBNull = False
    '            '    dbo_movimiento.Cajas = frmNoConforme.Cantidad
    '            '    dbo_movimiento.Fecha = datetime.now
    '            '    dbo_movimiento.Comentarios = "No conforme automatizado"
    '            '    dbo_movimiento.Comentarios_IsDBNull = False
    '            '    dbo_movimiento.AutorizadoPor = Nothing
    '            '    dbo_movimiento.AutorizadoPor_IsDBNull = True
    '            '    dbo_movimiento.Receptor = Nothing
    '            '    dbo_movimiento.Receptor_IsDBNull = True
    '            '    dbo_movimiento.Inicial_IsDBNull = True
    '            '    dbo_movimiento.Motivo = ""
    '            '    dbo_movimiento.Motivo_IsDBNull = False
    '            '    dbo_movimiento.Solicitante = Nothing
    '            '    dbo_movimiento.Solicitante_IsDBNull = True
    '            '    dbo_movimiento.Cliente = Nothing
    '            '    dbo_movimiento.Cliente_IsDBNull = True
    '            '    'dbo_movimiento.Tipo = 5
    '            '    dbo_movimiento.ContenidoDestinoID = RealizarConsulta("select max(paletcontenidoid) from paletscontenidos").Rows(0).Item(0)
    '            '    dbo_movimiento.PaletID = m_palet.PaletProducidoID
    '            '    dbo_MovimientoDB.Add(dbo_movimiento)

    '            '    'm_palet.EnAlmacen = 0
    '            '    spPaletsProducidos2.UpdatePaletsProducidos2(m_palet,dtb)
    '            '    textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine()
    '            '    linea = "No conforme automatizado. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

    '            '    Deprecated.ConsultaInsertarSinDatosUsuario("'" & linea & "', 4, 0", "notificaciones(texto, id_tipousuario, leido)")

    '            'End If
    '        End If
    '    Next

    '    If textNotificar <> "" Then
    '        textNotificar = "Lista de matriculas afectadas por diferencias automaticas: " & Environment.NewLine() & textNotificar
    '        Dim mail As New Mail.Mail1And1(True, "Diferencias automatizadas. Fecha: " & datetime.now.ToString, textNotificar, String.Empty, _
    '                                                                                  Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
    '                                                                                  String.Empty, String.Empty, Config.MailClientHost, False)
    '    End If



    'End Sub

    Public Function realizarDiferencia(ByVal scc As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim textNotificar As String = ""
        Dim fecha As String = DateTime.Now.Day & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year
        Dim linea As String
        Dim spPalet As New spPaletsProducidos
        Dim m_palet As DBO_PaletsProducidos = spPalet.Select_RecordBySSCC(scc, dtb)
        Dim dbo_movimiento As New Dbo_PaletsMovimiento
        Dim dbo_MovimientoDB As New spPaletsMovimiento
 

        If m_palet.Id_Estado <> 3 Then
            dbo_movimiento.Tipo = 8
            dbo_movimiento.Tipo_IsDBNull = False
            dbo_movimiento.PaletID_IsDBNull = False
            dbo_movimiento.Cajas = spPalet.calcularCajasAntesExpedir(scc, dtb)
            dbo_movimiento.Fecha = DateTime.Now
            dbo_movimiento.Comentarios = "Diferencia automatizada"
            dbo_movimiento.Comentarios_IsDBNull = False
            dbo_movimiento.AutorizadoPor = Nothing
            dbo_movimiento.AutorizadoPor_IsDBNull = True
            dbo_movimiento.Receptor = Nothing
            dbo_movimiento.Receptor_IsDBNull = True
            dbo_movimiento.Inicial_IsDBNull = True
            dbo_movimiento.Motivo = "" ' Si pongo Nothing da error.
            dbo_movimiento.Motivo_IsDBNull = False
            dbo_movimiento.Solicitante = Nothing
            dbo_movimiento.Solicitante_IsDBNull = True
            dbo_movimiento.Cliente = Nothing
            dbo_movimiento.Cliente_IsDBNull = True
            'dbo_movimiento.Tipo = 5
            dbo_movimiento.ContenidoDestinoID = CType(dtb.Consultar("select max(paletcontenidoid) from paletscontenidos", False).Rows(0).Item(0), Integer)
            dbo_movimiento.PaletID = m_palet.ID
            dbo_MovimientoDB.Add(dbo_movimiento, dtb)

            m_palet.EnAlmacen = False
            spPalet.Grabar(CType(m_palet, BasesParaCompatibilidad.DataBussines), dtb)

            textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine()
            linea = "Diferencia automatizada. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

            dtb.PrepararConsulta("insert into notificaciones(texto, id_tipousuario, leido) values('" & linea & "', 9, 0)")
            dtb.Consultar(True)
        End If

        If textNotificar <> "" Then
            textNotificar = "Lista de matriculas afectadas por diferencias automaticas: " & Environment.NewLine() & textNotificar
            Dim mail As New Mail.Mail1And1(True, "Diferencias automatizadas. Fecha: " & DateTime.Now.ToString, textNotificar, String.Empty, _
                                                                                      Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                                                      String.Empty, String.Empty, Config.MailClientHost, False)
        End If


        Return True
    End Function

    Public Function moverNC(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal scc As Integer, ByVal cantidad As Integer) As Boolean
        Dim textNotificar As String = ""
        Dim fecha As String = DateTime.Now.Day & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year
        Dim linea As String
        Dim spPalet As New spPaletsProducidos
        Dim m_palet As DBO_PaletsProducidos = spPalet.Select_RecordBySSCC(scc, dtb)
        Dim spFormatosEnvasados As New spFormatosEnvasados
        Dim dboFormato As DBO_FormatosEnvasados = spFormatosEnvasados.Select_Record(m_palet.FormatoID, dtb)
        Dim dbo_movimiento As New Dbo_PaletsMovimiento
        Dim dbo_MovimientoDB As New spPaletsMovimiento
        Dim paletNC As Integer = spPalet.No_conforme_por_formato(dboFormato.TipoFormatoEnvasadoID, dtb)
        Dim m_paletNC As DBO_PaletsProducidos = spPalet.Select_Record(paletNC, dtb)
        Dim ultimoMovimiento As Integer

        If m_palet.Id_Estado <> 3 Then
            dbo_movimiento.Tipo = 18
            dbo_movimiento.Tipo_IsDBNull = False
            dbo_movimiento.PaletID_IsDBNull = False
            dbo_movimiento.Cajas = cantidad
            dbo_movimiento.Fecha = DateTime.Now
            dbo_movimiento.Comentarios = "no conformidad automatizada"
            dbo_movimiento.Comentarios_IsDBNull = False
            dbo_movimiento.AutorizadoPor = Nothing
            dbo_movimiento.AutorizadoPor_IsDBNull = True
            dbo_movimiento.Receptor = Nothing
            dbo_movimiento.Receptor_IsDBNull = True
            dbo_movimiento.Inicial_IsDBNull = True
            dbo_movimiento.Motivo = ""
            dbo_movimiento.Motivo_IsDBNull = False
            dbo_movimiento.Solicitante = Nothing
            dbo_movimiento.Solicitante_IsDBNull = True
            dbo_movimiento.Cliente = Nothing
            dbo_movimiento.Cliente_IsDBNull = True
            dbo_movimiento.DocumentoID = m_paletNC.SCC
            dbo_movimiento.DocumentoID_IsDBNull = False
            dbo_movimiento.PaletID = m_palet.ID
            dbo_MovimientoDB.Add(dbo_movimiento, dtb)

            ultimoMovimiento = dbo_MovimientoDB.ultimo_registro(dtb)
            'movimiento al nc
            If ultimoMovimiento = 0 Then Throw New Exception("No se pudo recuperar el movimiento guardado")
            dbo_movimiento.MovimientoEntrePaletsID = ultimoMovimiento


            dbo_movimiento.Tipo = 18
            dbo_movimiento.Tipo_IsDBNull = False
            dbo_movimiento.PaletID_IsDBNull = False
            dbo_movimiento.Cajas = -1 * cantidad
            dbo_movimiento.Fecha = DateTime.Now
            dbo_movimiento.Comentarios = "no conformidad automatizada"
            dbo_movimiento.Comentarios_IsDBNull = False
            dbo_movimiento.AutorizadoPor = Nothing
            dbo_movimiento.AutorizadoPor_IsDBNull = True
            dbo_movimiento.Receptor = Nothing
            dbo_movimiento.Receptor_IsDBNull = True
            dbo_movimiento.Inicial_IsDBNull = True
            dbo_movimiento.Motivo = ""
            dbo_movimiento.Motivo_IsDBNull = False
            dbo_movimiento.Solicitante = Nothing
            dbo_movimiento.Solicitante_IsDBNull = True
            dbo_movimiento.Cliente = Nothing
            dbo_movimiento.Cliente_IsDBNull = True
            dbo_movimiento.DocumentoID = m_palet.SCC
            dbo_movimiento.DocumentoID_IsDBNull = False
            dbo_movimiento.PaletID = paletNC
            dbo_MovimientoDB.Add(dbo_movimiento, dtb)

            textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine()
            linea = "No conformidad automatizada. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

            dtb.PrepararConsulta("insert into notificaciones(texto, id_tipousuario, leido) values('" & linea & "', 9, 0)")
            dtb.Consultar(True)
        End If

        If textNotificar <> "" Then
            textNotificar = "Lista de matriculas afectadas por no conformidades automaticas: " & Environment.NewLine() & textNotificar
            Dim mail As New Mail.Mail1And1(True, "No conformidades automatizadas. Fecha: " & DateTime.Now.ToString, textNotificar, String.Empty, _
                                                                                      Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                                                      String.Empty, String.Empty, Config.MailClientHost, False)
        End If


        Return True
    End Function

    Public Sub cargarComboDetallesMonodosisParaDoypack(ByRef combo As ComboBox, ByVal tipoFormato As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        combo.mam_DataSource("PaletsContenidosSelectMonodosisParaDoypack2 " & tipoFormato, False, dtb)
    End Sub

    Public Sub CargarMonodosis(ByRef pan As Panel, ByVal FormatoEnvasado As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByRef frmDoypack As frmEntPaletsContenidosDoypack = Nothing)

        Dim combos As New Collection
        Dim dt As DataTable = Me.spPaletsContenidos.devolver_monodosis_para_doypack(FormatoEnvasado, dtb)

        Dim lbl As Label
        Dim cbo As ComboBox
        Dim pl As Panel
        Dim adv As Label

        For Each row As DataRow In dt.Rows
            adv = New Label
            adv.Dock = DockStyle.Bottom
            adv.Text = "Palet no conforme"
            adv.Font = New Font(adv.Font.FontFamily, 5)
            adv.ForeColor = Color.Red
            adv.Visible = False

            lbl = New Label
            lbl.Dock = DockStyle.Fill
            lbl.Text = row.Item(0).ToString
            lbl.Font = New Font(lbl.Font.FontFamily, 7)

            cbo = New ComboBox
            cbo.Dock = DockStyle.Right
            cargarComboDetallesMonodosisParaDoypack(cbo, CInt(row.Item(1)), dtb)
            If frmDoypack Is Nothing Then
                AddHandler cbo.SelectedValueChanged, AddressOf Me.cboDoypack_SelectedValueChanged
            Else
                combos.Add(cbo)
                AddHandler cbo.SelectedValueChanged, AddressOf frmDoypack.actualizarMermas
            End If

            cbo.Tag = row.Item(2)

            pl = New Panel
            adv.Parent = pl
            lbl.Parent = pl
            cbo.Parent = pl

            pl.Dock = DockStyle.Top
            pl.Parent = pan
            pl.Height = 50
        Next

        If Not frmDoypack Is Nothing Then
            frmDoypack.Fuentes = combos
        End If
    End Sub

    Public Sub cboDoypack_SelectedValueChanged(sender As System.Object, e As System.EventArgs)
        Dim cbo As ComboBox = sender
        Dim pan As Panel = CType(cbo.Parent, Panel)
        Dim etiqueta As Label = Nothing

        For Each obj As Object In pan.Controls
            If TypeOf obj Is Label Then
                etiqueta = CType(obj, Label)

                If etiqueta.ForeColor <> Color.Red Then
                    etiqueta = Nothing
                    Exit For
                End If
            End If
        Next

        If Not etiqueta Is Nothing Then
            If CInt(cbo.SelectedItem(4)) = 3 Then
                cbo.BackColor = Color.Red
                etiqueta.Visible = True
            Else
                cbo.BackColor = Color.White
                etiqueta.Visible = False
            End If
        End If
    End Sub
End Class
