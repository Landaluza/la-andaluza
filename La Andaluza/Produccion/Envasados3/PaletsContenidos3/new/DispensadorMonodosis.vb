Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class DispensadorMonodosis
    Private spPaletsContenidos As spPaletsContenidos

    Public Sub New()
        spPaletsContenidos = New spPaletsContenidos
    End Sub

    Public Function EsDoyPack(ByVal tipoformato As Integer) As Boolean
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("ComprobarDoypack @tf")
        dtb.AñadirParametroConsulta("@tf", tipoformato)
        Dim dt As DataTable = dtb.Consultar()
        If dt Is Nothing Then Return False
        If dt.Rows.Count = 0 Then Return False
        If CType(dt.Rows(0).Item(0), Integer) > 0 Then Return True

        Return False
    End Function

    Public Sub CargarMonodosis(ByRef pan As Panel, ByVal FormatoEnvasado As Integer, Optional ByRef frmDoypack As frmEntPaletsContenidosDoypack = Nothing)

        Dim combos As New Collection
        Dim dt As DataTable = Me.spPaletsContenidos.devolver_monodosis_para_doypack(FormatoEnvasado)

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
            cargarComboDetallesMonodosis(cbo, CInt(row.Item(1)))
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

    Public Sub cargarComboDetallesMonodosis(ByRef combo As ComboBox, ByVal tipoFormato As Integer)
        combo.mam_DataSource("PaletsContenidosSelectMonodosisParaDoyPack " & tipoFormato, False)
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
                End If
            End If
        Next


        'Dim dr As DataRowView = cbo.SelectedItem
        Try
            If cbo.SelectedItem(4) = 3 Then
                cbo.BackColor = Color.Red
                etiqueta.Visible = True
            Else
                cbo.BackColor = Color.White
                etiqueta.Visible = False
            End If
        Catch ex As Exception

        End Try
        'Dim cad As String() = cbo.SelectedItem
        'If cad(4) = 3 Then
        '    cbo.BackColor = Color.Red
        '    etiqueta.Visible = True
        'Else
        '    cbo.BackColor = Color.White
        '    etiqueta.Visible = False
        'End If
    End Sub

    'Public Sub realizarDiferencia(ByRef cbo As ComboBox)
    '    Dim cont As Integer
    '    Dim textNotificar As String = ""
    '    Dim fecha As String = DateTime.Now.Day & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year
    '    Dim linea As String
    '    Dim dtb as BasesParaCompatibilidad.Database
    '    If BasesParaCompatibilidad.BD.transaction Is Nothing Then
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    '    Else
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, transaction)
    '    End If

    '    For cont = 0 To cbo.SelectedIndex - 1
    '        Dim item As System.Windows.Forms.ComboBox.ObjectCollection = cbo.Items(cont)
    '        Dim m_palet As DBO_PaletsProducidos2 = spPaletsProducidos2.Select_RecordBySSCCSinMachacar(CInt(item(1)), BasesParaCompatibilidad.BD.transaction)
    '        Dim dbo_movimiento As New Dbo_PaletsMovimiento
    '        Dim dbo_MovimientoDB As New spPaletsMovimiento

    '        If m_palet.Id_Estado <> 3 Then
    '            dbo_movimiento.Tipo = 8
    '            dbo_movimiento.Tipo_IsDBNull = False
    '            dbo_movimiento.PaletID_IsDBNull = False
    '            dbo_movimiento.Cajas = spPaletsProducidos2.calcularCajasAntesExpedir(item(1), BasesParaCompatibilidad.BD.transaction)
    '            dbo_movimiento.Fecha = DateTime.Now
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
    '            dbo_movimiento.ContenidoDestinoID = dtb.Consultar("select max(paletcontenidoid) from paletscontenidos", False).Rows(0).Item(0)
    '            dbo_movimiento.PaletID = m_palet.PaletProducidoID
    '            dbo_MovimientoDB.Add(dbo_movimiento)

    '            m_palet.EnAlmacen = 0
    '            spPaletsProducidos2.UpdatePaletsProducidos2(m_palet, BasesParaCompatibilidad.BD.transaction)
    '            textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine()
    '            linea = "Diferencia automatizada. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

    '            Deprecated.ConsultaInsertarSinDatosUsuario("'" & linea & "', 9, 0", "notificaciones(texto, id_tipousuario, leido)")
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
    '            '    spPaletsProducidos2.UpdatePaletsProducidos2(m_palet, BasesParaCompatibilidad.BD.transaction)
    '            '    textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine()
    '            '    linea = "No conforme automatizado. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

    '            '    Deprecated.ConsultaInsertarSinDatosUsuario("'" & linea & "', 9, 0", "notificaciones(texto, id_tipousuario, leido)")

    '            'End If
    '        End If
    '    Next

    '    If textNotificar <> "" Then
    '        textNotificar = "Lista de matriculas afectadas por diferencias automaticas: " & Environment.NewLine() & textNotificar
    '        Dim mail As New Mail.Mail1And1(True, "Diferencias automatizadas. Fecha: " & DateTime.Now.ToString, textNotificar, String.Empty, _
    '                                                                                  Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
    '                                                                                  String.Empty, String.Empty, Config.MailClientHost, False)
    '    End If



    'End Sub

    'Public Sub añadirMovimientoEncajado(ByRef padre As frmEntPaletsProducidos2, ByRef cbo As ComboBox, _
    '                                    ByVal cantidadCajas As Integer, ByRef m_DBO_PaletsContenidos2 As DBO_PaletsContenidos2, _
    '                                    ByRef spPMovimientos As spPaletsMovimiento, ByRef dbomovimiento As Dbo_PaletsMovimiento, _
    '                                    ByRef m_DBO_FormatoEnvasado As DBO_FormatosEnvasados, Optional ByVal Doypack As Boolean = False)

    '    If Not dbomovimiento Is Nothing Then spPMovimientos.Delete(dbomovimiento.ID)

    '    Dim dbo_movimiento As New Dbo_PaletsMovimiento
    '    Dim m_PaletProducidoOrigen As DBO_PaletsProducidos2
    '    Dim m_PaletProducidoDestino As DBO_PaletsProducidos2
    '    Dim dbo_MovimientoDB As New spPaletsMovimiento
    '    Dim fuente As String = ""
    '    Dim dtb as BasesParaCompatibilidad.Database
    '    If BasesParaCompatibilidad.BD.transaction Is Nothing Then
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    '    Else
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, transaction)
    '    End If

    '    dbo_movimiento.Fecha = datetime.now
    '    dbo_movimiento.Cajas = cantidadCajas
    '    Dim cajasInicioMail As String = dbo_movimiento.Cajas.ToString

    '    m_PaletProducidoOrigen = spPaletsProducidos2.Select_RecordBySSCCSinMachacar(CInt(cbo.SelectedItem(1)), BasesParaCompatibilidad.BD.transaction)
    '    m_PaletProducidoDestino = spPaletsProducidos2.Select_RecordSinMachacar(m_DBO_PaletsContenidos2.PaletProducidoID, BasesParaCompatibilidad.BD.transaction)

    '    If Doypack Then
    '        Dim pl As Panel = CType(cbo.Parent, Panel)
    '        For Each obj As Object In pl.Controls
    '            If TypeOf obj Is Label Then
    '                Dim l As Label = CType(obj, Label)
    '                If l.ForeColor <> Color.Red Then
    '                    fuente = l.Text
    '                End If
    '            End If
    '        Next
    '    End If

    '    ComprobarCantidadesEncajado(padre, dbo_movimiento, m_PaletProducidoOrigen, m_PaletProducidoDestino, _
    '                                True, m_DBO_FormatoEnvasado, if(Doypack, cbo.Tag, Nothing), fuente)
    '    'Movimiento del palets Origen
    '    dbo_movimiento.ContenidoDestinoID = dtb.Consultar("select max(paletcontenidoid) from paletscontenidos", False).Rows(0).Item(0)
    '    dbo_MovimientoDB.Add(dbo_movimiento)
    '    'Añadir Observaciones en PaletsProducidos

    '    'm_PaletProducidoOrigen.observacionesPalets = "Encajado de monodosis"
    '    'spPaletsProducidos2.GrabarPaletProducido2(m_PaletProducidoOrigen)

    '    '
    '    'dbo_MovimientoDB.Add(dbo_movimiento)
    '    Dim fecha As String = datetime.now.Day & "/" & datetime.now.Month & "/" & datetime.now.Year
    '    Deprecated.ConsultaInsertarSinDatosUsuario("'Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion & " el " & fecha & ". SCC origen: " & m_PaletProducidoOrigen.SCC & "SCC destino:" & m_PaletProducidoDestino.SCC & "', 9, 0", "notificaciones(texto, id_tipousuario, leido)")
    '    Dim mail As New Mail.Mail1And1(True, "Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion, "Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion & " el " & datetime.now.ToString & "." & Environment.NewLine() & "SCC origen: " & m_PaletProducidoOrigen.SCC & ", cajas de origen: " & dbo_movimiento.Cajas & "; SCC destino:" & m_PaletProducidoDestino.SCC & ", Cajas encajadas: " & cajasInicioMail, String.Empty, _
    '                                                                                Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
    '                                                                                String.Empty, String.Empty, Config.MailClientHost, False)
    'End Sub

    'Private Sub ComprobarCantidadesEncajado(ByRef padre As frmEntPaletsProducidos2, _
    '                                        ByRef dbo_movimiento As Dbo_PaletsMovimiento, _
    '                                        ByRef m_PaletProducidoOrigen As DBO_PaletsProducidos2, _
    '                                        ByVal m_PaletProducidoDestino As DBO_PaletsProducidos2, _
    '                                        ByVal origen As Boolean, ByRef m_DBO_FormatoEnvasado As DBO_FormatosEnvasados, _
    '                                        Optional ByVal CantidadUds As Integer = Nothing, Optional fuente As String = "")

    '    Dim dtb as BasesParaCompatibilidad.Database
    '    If BasesParaCompatibilidad.BD.transaction Is Nothing Then
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    '    Else
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, transaction)
    '    End If

    '    'If origen Then
    '    dbo_movimiento.PaletID = m_PaletProducidoOrigen.PaletProducidoID

    '    dbo_movimiento.DocumentoID = System.Convert.ToInt32(m_PaletProducidoDestino.SCC)
    '    dbo_movimiento.DocumentoID_IsDBNull = False

    '    'Dim capacidad As Integer = DataTableFill("PaletsProducidosCapacidadFormatoByPaletProducidoID " & m_PaletProducidoDestino.PaletProducidoID).Rows(0).Item(0)
    '    Dim capacidad As Integer

    '    capacidad = dtb.Consultar("select capacidadcaja from ArticulosEnvasadosHistorico where tipoformato = " & m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID, False).Rows(0).Item(0)
    '    If CantidadUds <> Nothing Then
    '        capacidad = CantidadUds * capacidad
    '    End If

    '    dbo_movimiento.Cajas = dbo_movimiento.Cajas * capacidad
    '    Dim tope As Long = spPaletsProducidos2.calcularCajasAntesExpedir(m_PaletProducidoOrigen.SCC, BasesParaCompatibilidad.BD.transaction)
    '    If tope < dbo_movimiento.Cajas Then
    '        padre.Close()
    '        If fuente <> "" Then
    '            Throw New Exception("No hay suficientes cajas para realizar el movimiento de " & fuente & "." & Environment.NewLine() & _
    '                                "Solo quedan " & tope & " monodosis (" & Convert.ToInt32(tope / capacidad) & "cajas)")
    '        Else
    '            Throw New Exception("No hay suficientes cajas para realizar el movimiento. Solo quedan " & tope & " monodosis (" & Convert.ToInt32(tope / capacidad) & "cajas)")
    '        End If
    '        'Me.Close()            
    '    End If
    '    'End If

    '    dbo_movimiento.Tipo = dtb.Consultar("select id_MovimentoEncajado from tiposcajas, ArticulosEnvasadosHistorico where ArticulosEnvasadosHistorico.tipocajaID = tiposcajas.tipocajaID and tipoformato = " & m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID, False).Rows(0).Item(0)
    '    dbo_movimiento.Tipo_IsDBNull = False
    '    dbo_movimiento.PaletID_IsDBNull = False
    '    dbo_movimiento.Fecha = datetime.now
    '    dbo_movimiento.Fecha_IsDBNull = False
    '    dbo_movimiento.Cajas_IsDBNull = False
    '    dbo_movimiento.Inicial_IsDBNull = True
    '    dbo_movimiento.Comentarios = "Movimiento de encajado para envasar el palet " & m_PaletProducidoDestino.SCC
    '    dbo_movimiento.Comentarios_IsDBNull = False
    '    dbo_movimiento.AutorizadoPor = Nothing
    '    dbo_movimiento.AutorizadoPor_IsDBNull = True
    '    dbo_movimiento.Receptor = Nothing
    '    dbo_movimiento.Receptor_IsDBNull = True
    '    dbo_movimiento.Motivo = "" ' Si pongo Nothing da error.
    '    dbo_movimiento.Motivo_IsDBNull = False
    '    dbo_movimiento.Solicitante = Nothing
    '    dbo_movimiento.Solicitante_IsDBNull = True
    '    dbo_movimiento.Cliente = Nothing
    '    dbo_movimiento.Cliente_IsDBNull = True

    'End Sub



    'Public Sub añadirMovimientoEncajado(ByRef cbo As ComboBox, _
    '                                    ByVal cantidadCajas As Integer, ByRef m_DBO_PaletsContenidos2 As DBO_PaletsContenidos, _
    '                                    ByRef spPMovimientos As spPaletsMovimiento, ByRef dbomovimiento As Dbo_PaletsMovimiento, _
    '                                    ByRef m_DBO_FormatoEnvasado As DBO_FormatosEnvasados, Optional ByVal Doypack As Boolean = False)

    '    If Not dbomovimiento Is Nothing Then spPMovimientos.Delete(dbomovimiento.ID)

    '    Dim dbo_movimiento As New Dbo_PaletsMovimiento
    '    Dim m_PaletProducidoOrigen As DBO_PaletsProducidos2
    '    Dim m_PaletProducidoDestino As DBO_PaletsProducidos2
    '    Dim dbo_MovimientoDB As New spPaletsMovimiento
    '    Dim fuente As String = ""
    '    Dim dtb as BasesParaCompatibilidad.Database
    '    If BasesParaCompatibilidad.BD.transaction Is Nothing Then
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    '    Else
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, transaction)
    '    End If

    '    dbo_movimiento.Fecha = DateTime.Now
    '    dbo_movimiento.Cajas = cantidadCajas
    '    Dim cajasInicioMail As String = dbo_movimiento.Cajas.ToString

    '    m_PaletProducidoOrigen = spPaletsProducidos2.Select_RecordBySSCCSinMachacar(CInt(cbo.SelectedItem(1)), BasesParaCompatibilidad.BD.transaction)
    '    m_PaletProducidoDestino = spPaletsProducidos2.Select_RecordSinMachacar(m_DBO_PaletsContenidos2.PaletProducidoID, BasesParaCompatibilidad.BD.transaction)

    '    If Doypack Then
    '        Dim pl As Panel = CType(cbo.Parent, Panel)
    '        For Each obj As Object In pl.Controls
    '            If TypeOf obj Is Label Then
    '                Dim l As Label = CType(obj, Label)
    '                If l.ForeColor <> Color.Red Then
    '                    fuente = l.Text
    '                End If
    '            End If
    '        Next
    '    End If

    '    ComprobarCantidadesEncajado(dbo_movimiento, m_PaletProducidoOrigen, m_PaletProducidoDestino, _
    '                                True, m_DBO_FormatoEnvasado, If(Doypack, cbo.Tag, Nothing), fuente)
    '    'Movimiento del palets Origen
    '    dbo_movimiento.ContenidoDestinoID = dtb.Consultar("select max(paletcontenidoid) from paletscontenidos", False).Rows(0).Item(0)
    '    dbo_MovimientoDB.Add(dbo_movimiento)
    '    'Añadir Observaciones en PaletsProducidos

    '    'm_PaletProducidoOrigen.observacionesPalets = "Encajado de monodosis"
    '    'spPaletsProducidos2.GrabarPaletProducido2(m_PaletProducidoOrigen)

    '    '
    '    'dbo_MovimientoDB.Add(dbo_movimiento)
    '    Dim fecha As String = DateTime.Now.Day & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year
    '    Deprecated.ConsultaInsertarSinDatosUsuario("'Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion & " el " & fecha & ". SCC origen: " & m_PaletProducidoOrigen.SCC & "SCC destino:" & m_PaletProducidoDestino.SCC & "', 9, 0", "notificaciones(texto, id_tipousuario, leido)")
    '    Dim mail As New Mail.Mail1And1(True, "Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion, "Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion & " el " & DateTime.Now.ToString & "." & Environment.NewLine() & "SCC origen: " & m_PaletProducidoOrigen.SCC & ", cajas de origen: " & dbo_movimiento.Cajas & "; SCC destino:" & m_PaletProducidoDestino.SCC & ", Cajas encajadas: " & cajasInicioMail, String.Empty, _
    '                                                                                Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
    '                                                                                String.Empty, String.Empty, Config.MailClientHost, False)
    'End Sub

    'Private Sub ComprobarCantidadesEncajado(ByRef dbo_movimiento As Dbo_PaletsMovimiento, _
    '                                        ByRef m_PaletProducidoOrigen As DBO_PaletsProducidos, _
    '                                        ByVal m_PaletProducidoDestino As DBO_PaletsProducidos, _
    '                                        ByVal origen As Boolean, ByRef m_DBO_FormatoEnvasado As DBO_FormatosEnvasados, _
    '                                        Optional ByVal CantidadUds As Integer = Nothing, Optional fuente As String = "")

    '    Dim dtb as BasesParaCompatibilidad.Database
    '    If BasesParaCompatibilidad.BD.transaction Is Nothing Then
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    '    Else
    '        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, transaction)
    '    End If
    '    'If origen Then
    '    dbo_movimiento.PaletID = m_PaletProducidoOrigen.ID

    '    dbo_movimiento.DocumentoID = System.Convert.ToInt32(m_PaletProducidoDestino.SCC)
    '    dbo_movimiento.DocumentoID_IsDBNull = False

    '    'Dim capacidad As Integer = DataTableFill("PaletsProducidosCapacidadFormatoByPaletProducidoID " & m_PaletProducidoDestino.PaletProducidoID).Rows(0).Item(0)
    '    Dim capacidad As Integer

    '    capacidad = dtb.Consultar("select capacidadcaja from ArticulosEnvasadosHistorico where  tipoformato = " & m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID, False).Rows(0).Item(0)
    '    If CantidadUds <> Nothing Then
    '        capacidad = CantidadUds * capacidad
    '    End If

    '    dbo_movimiento.Cajas = dbo_movimiento.Cajas * capacidad
    '    Dim tope As Long = spPaletsProducidos2.calcularCajasAntesExpedir(m_PaletProducidoOrigen.SCC, BasesParaCompatibilidad.BD.transaction)
    '    If tope < dbo_movimiento.Cajas Then
    '        If fuente <> "" Then
    '            Throw New Exception("No hay suficientes cajas para realizar el movimiento de " & fuente & "." & Environment.NewLine() & _
    '                                "Solo quedan " & tope & " monodosis (" & Convert.ToInt32(tope / capacidad) & "cajas)")
    '        Else
    '            Throw New Exception("No hay suficientes cajas para realizar el movimiento. Solo quedan " & tope & " monodosis (" & Convert.ToInt32(tope / capacidad) & "cajas)")
    '        End If
    '        'Me.Close()            
    '    End If
    '    'End If

    '    dbo_movimiento.Tipo = dtb.Consultar("select id_MovimentoEncajado from tiposcajas, ArticulosEnvasadosHistorico where ArticulosEnvasadosHistorico.tipocajaID = tiposcajas.tipocajaID and tipoformato = " & m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID, False).Rows(0).Item(0)
    '    dbo_movimiento.Tipo_IsDBNull = False
    '    dbo_movimiento.PaletID_IsDBNull = False
    '    dbo_movimiento.Fecha = DateTime.Now
    '    dbo_movimiento.Fecha_IsDBNull = False
    '    dbo_movimiento.Cajas_IsDBNull = False
    '    dbo_movimiento.Inicial_IsDBNull = True
    '    dbo_movimiento.Comentarios = "Movimiento de encajado para envasar el palet " & m_PaletProducidoDestino.SCC
    '    dbo_movimiento.Comentarios_IsDBNull = False
    '    dbo_movimiento.AutorizadoPor = Nothing
    '    dbo_movimiento.AutorizadoPor_IsDBNull = True
    '    dbo_movimiento.Receptor = Nothing
    '    dbo_movimiento.Receptor_IsDBNull = True
    '    dbo_movimiento.Motivo = "" ' Si pongo Nothing da error.
    '    dbo_movimiento.Motivo_IsDBNull = False
    '    dbo_movimiento.Solicitante = Nothing
    '    dbo_movimiento.Solicitante_IsDBNull = True
    '    dbo_movimiento.Cliente = Nothing
    '    dbo_movimiento.Cliente_IsDBNull = True

    'End Sub

    'Public Function moverNC(ByVal scc As Integer, ByVal cantidad As Integer, ByRef trans As SqlClient.SqlTransaction) As Boolean
    '    Dim textNotificar As String = ""
    '    Dim fecha As String = DateTime.Now.Day & "/" & DateTime.Now.Month & "/" & DateTime.Now.Year
    '    Dim linea As String
    '    Dim spPalet As New spPaletsProducidos
    '    Dim m_palet As DBO_PaletsProducidos = spPalet.Select_RecordBySSCC(scc, trans)
    '    Dim spFormatosEnvasados As New spFormatosEnvasados
    '    Dim dboFormato As DBO_FormatosEnvasados = spFormatosEnvasados.Select_Record(m_palet.FormatoID, trans)
    '    Dim dbo_movimiento As New Dbo_PaletsMovimiento
    '    Dim dbo_MovimientoDB As New spPaletsMovimiento
    '    Dim paletNC As Integer = spPalet.No_conforme_por_formato(dboFormato.TipoFormatoEnvasadoID, trans)

    '    If m_palet.Id_Estado <> 3 Then
    '        dbo_movimiento.Tipo = 18
    '        dbo_movimiento.Tipo_IsDBNull = False
    '        dbo_movimiento.PaletID_IsDBNull = False
    '        dbo_movimiento.Cajas = cantidad
    '        dbo_movimiento.Fecha = DateTime.Now
    '        dbo_movimiento.Comentarios = "no conformidad automatizada"
    '        dbo_movimiento.Comentarios_IsDBNull = False
    '        dbo_movimiento.AutorizadoPor = Nothing
    '        dbo_movimiento.AutorizadoPor_IsDBNull = True
    '        dbo_movimiento.Receptor = Nothing
    '        dbo_movimiento.Receptor_IsDBNull = True
    '        dbo_movimiento.Inicial_IsDBNull = True
    '        dbo_movimiento.Motivo = ""
    '        dbo_movimiento.Motivo_IsDBNull = False
    '        dbo_movimiento.Solicitante = Nothing
    '        dbo_movimiento.Solicitante_IsDBNull = True
    '        dbo_movimiento.Cliente = Nothing
    '        dbo_movimiento.Cliente_IsDBNull = True
    '        'dbo_movimiento.Tipo = 5

    '        dbo_movimiento.PaletID = m_palet.ID
    '        dbo_MovimientoDB.Add(dbo_movimiento)


    '        'movimiento al nc

    '        dbo_movimiento.Tipo = 18
    '        dbo_movimiento.Tipo_IsDBNull = False
    '        dbo_movimiento.PaletID_IsDBNull = False
    '        dbo_movimiento.Cajas = -1 * cantidad
    '        dbo_movimiento.Fecha = DateTime.Now
    '        dbo_movimiento.Comentarios = "no conformidad automatizada"
    '        dbo_movimiento.Comentarios_IsDBNull = False
    '        dbo_movimiento.AutorizadoPor = Nothing
    '        dbo_movimiento.AutorizadoPor_IsDBNull = True
    '        dbo_movimiento.Receptor = Nothing
    '        dbo_movimiento.Receptor_IsDBNull = True
    '        dbo_movimiento.Inicial_IsDBNull = True
    '        dbo_movimiento.Motivo = ""
    '        dbo_movimiento.Motivo_IsDBNull = False
    '        dbo_movimiento.Solicitante = Nothing
    '        dbo_movimiento.Solicitante_IsDBNull = True
    '        dbo_movimiento.Cliente = Nothing
    '        dbo_movimiento.Cliente_IsDBNull = True
    '        'dbo_movimiento.Tipo = 5

    '        dbo_movimiento.PaletID = paletNC
    '        dbo_MovimientoDB.Add(dbo_movimiento)

    '        textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine()
    '        linea = "No conformidad automatizada. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

    '        Deprecated.ConsultaInsertarSinDatosUsuario("'" & linea & "', 9, 0", "notificaciones(texto, id_tipousuario, leido)")
    '    End If

    '    If textNotificar <> "" Then
    '        textNotificar = "Lista de matriculas afectadas por no conformidades automaticas: " & Environment.NewLine() & textNotificar
    '        Dim mail As New Mail.Mail1And1(True, "No conformidades automatizadas. Fecha: " & DateTime.Now.ToString, textNotificar, String.Empty, _
    '                                                                                  Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
    '                                                                                  String.Empty, String.Empty, Config.MailClientHost, False)
    '    End If


    '    Return True
    'End Function

    Public Sub realizarDiferencia(ByRef dtb As BasesParaCompatibilidad.DataBase, ByRef cbo As ComboBox)
        Dim cont As Integer
        Dim textNotificar As String = ""
        Dim fecha As String = Now.Date.Day & "/" & Now.Date.Month & "/" & Now.Date.Year
        Dim linea As String
        Dim spPaletsProducidos2 As New spPaletsProducidos2


        For cont = 0 To cbo.SelectedIndex - 1
            Dim m_palet As DBO_PaletsProducidos2 = spPaletsProducidos2.Select_RecordBySSCCSinMachacar(cbo.Items(cont)(1), BasesParaCompatibilidad.BD.transaction)
            Dim dbo_movimiento As New Dbo_PaletsMovimiento
            Dim dbo_MovimientoDB As New spPaletsMovimiento

            If m_palet.Id_Estado <> 3 Then
                dbo_movimiento.Tipo = 8
                dbo_movimiento.Tipo_IsDBNull = False
                dbo_movimiento.PaletID_IsDBNull = False
                dbo_movimiento.Cajas = spPaletsProducidos2.calcularCajasAntesExpedir(cbo.Items(cont)(1), BasesParaCompatibilidad.BD.transaction)
                dbo_movimiento.Fecha = Now.Date
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
                dbo_movimiento.ContenidoDestinoID = dtb.Consultar("select max(paletcontenidoid) from paletscontenidos", False).Rows(0).Item(0)
                dbo_movimiento.PaletID = m_palet.PaletProducidoID
                dbo_MovimientoDB.Add(dbo_movimiento)

                m_palet.EnAlmacen = 0
                spPaletsProducidos2.UpdatePaletsProducidos2(m_palet, BasesParaCompatibilidad.BD.transaction)
                textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine
                linea = "Diferencia automatizada. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

                dtb.PrepararConsulta("insert into notificaciones(texto, id_tipousuario, leido) values('" & linea & "', 9, 0)")
                dtb.Consultar(True)
            Else
                'Dim frmNoConforme As New frmEncajadoNoConforme
                'frmNoConforme.ShowDialog()

                'If frmNoConforme.Result <> -1 Then
                '    dbo_movimiento.Tipo = 18
                '    dbo_movimiento.Tipo_IsDBNull = False
                '    dbo_movimiento.PaletID_IsDBNull = False
                '    dbo_movimiento.Cajas = frmNoConforme.Cantidad
                '    dbo_movimiento.Fecha = Now.Date
                '    dbo_movimiento.Comentarios = "No conforme automatizado"
                '    dbo_movimiento.Comentarios_IsDBNull = False
                '    dbo_movimiento.AutorizadoPor = Nothing
                '    dbo_movimiento.AutorizadoPor_IsDBNull = True
                '    dbo_movimiento.Receptor = Nothing
                '    dbo_movimiento.Receptor_IsDBNull = True
                '    dbo_movimiento.Inicial_IsDBNull = True
                '    dbo_movimiento.Motivo = ""
                '    dbo_movimiento.Motivo_IsDBNull = False
                '    dbo_movimiento.Solicitante = Nothing
                '    dbo_movimiento.Solicitante_IsDBNull = True
                '    dbo_movimiento.Cliente = Nothing
                '    dbo_movimiento.Cliente_IsDBNull = True
                '    'dbo_movimiento.Tipo = 5
                '    dbo_movimiento.ContenidoDestinoID = RealizarConsulta("select max(paletcontenidoid) from paletscontenidos").Rows(0).Item(0)
                '    dbo_movimiento.PaletID = m_palet.PaletProducidoID
                '    dbo_MovimientoDB.Add(dbo_movimiento)

                '    'm_palet.EnAlmacen = 0
                '    spPaletsProducidos2.UpdatePaletsProducidos2(m_palet, BasesParaCompatibilidad.BD.transaction)
                '    textNotificar = textNotificar & "Scc: " & m_palet.SCC & ", cajas: " & dbo_movimiento.Cajas & Environment.NewLine
                '    linea = "No conforme automatizado. Scc: " & m_palet.SCC & ", cajas:" & dbo_movimiento.Cajas & " , fecha: " & fecha & ""

                '    Deprecated.ConsultaInsertarSinDatosUsuario("'" & linea & "', 9, 0", "notificaciones(texto, id_tipousuario, leido)")

                'End If
            End If
        Next

        If textNotificar <> "" Then
            textNotificar = "Lista de matriculas afectadas por diferencias automaticas: " & Environment.NewLine & textNotificar
            Dim mail As New Mail.Mail1And1(True, "Diferencias automatizadas. Fecha: " & Now.Date.ToString, textNotificar, String.Empty, _
                                                                                      Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                                                      String.Empty, String.Empty, Config.MailClientHost, False)
        End If



    End Sub

    Public Sub añadirMovimientoEncajado(ByRef dtb As BasesParaCompatibilidad.DataBase, ByRef padre As frmEntPaletsProducidos2, ByRef cbo As ComboBox, _
                                       ByVal cantidadCajas As Integer, ByRef m_DBO_PaletsContenidos2 As DBO_PaletsContenidos2, _
                                       ByRef spPMovimientos As spPaletsMovimiento, ByRef dbomovimiento As Dbo_PaletsMovimiento, _
                                       ByRef m_DBO_FormatoEnvasado As DBO_FormatosEnvasados, Optional ByVal Doypack As Boolean = False)

        If Not dbomovimiento Is Nothing Then spPMovimientos.Delete(dbomovimiento.ID)

        Dim dbo_movimiento As New Dbo_PaletsMovimiento
        Dim m_PaletProducidoOrigen As DBO_PaletsProducidos2
        Dim m_PaletProducidoDestino As DBO_PaletsProducidos2
        Dim dbo_MovimientoDB As New spPaletsMovimiento
        Dim fuente As String = ""
        Dim spPaletsProducidos2 As New spPaletsProducidos2

        dbo_movimiento.Fecha = Now.Date
        dbo_movimiento.Cajas = cantidadCajas
        Dim cajasInicioMail As String = dbo_movimiento.Cajas

        m_PaletProducidoOrigen = spPaletsProducidos2.Select_RecordBySSCCSinMachacar(cbo.SelectedItem(1), BasesParaCompatibilidad.BD.transaction)
        m_PaletProducidoDestino = spPaletsProducidos2.Select_RecordSinMachacar(m_DBO_PaletsContenidos2.PaletProducidoID, BasesParaCompatibilidad.BD.transaction)

        If Doypack Then
            Dim pl As Panel = cbo.Parent
            For Each obj As Object In pl.Controls
                If TypeOf obj Is Label Then
                    If obj.forecolor <> Color.Red Then
                        fuente = obj.text
                    End If
                End If
            Next
        End If

        ComprobarCantidadesEncajado(padre, dbo_movimiento, m_PaletProducidoOrigen, m_PaletProducidoDestino, _
                                    True, m_DBO_FormatoEnvasado, If(Doypack, cbo.Tag, Nothing), fuente)
        'Movimiento del palets Origen
        dbo_movimiento.ContenidoDestinoID = dtb.Consultar("select max(paletcontenidoid) from paletscontenidos", False).Rows(0).Item(0)
        dbo_MovimientoDB.Add(dbo_movimiento)
        'Añadir Observaciones en PaletsProducidos

        'm_PaletProducidoOrigen.observacionesPalets = "Encajado de monodosis"
        'spPaletsProducidos2.GrabarPaletProducido2(m_PaletProducidoOrigen)

        '
        'dbo_MovimientoDB.Add(dbo_movimiento)
        Dim fecha As String = Now.Date.Day & "/" & Now.Date.Month & "/" & Now.Date.Year
        dtb.PrepararConsulta("insert into notificaciones(texto, id_tipousuario, leido) values('Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion & " el " & fecha & ". SCC origen: " & m_PaletProducidoOrigen.SCC & "SCC destino:" & m_PaletProducidoDestino.SCC & "', 9, 0)")
        dtb.Consultar(True)
        Try
            Dim mail As New Mail.Mail1And1(True, "Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion, "Envasado de " & m_PaletProducidoOrigen.FormatoDescripcion & " el " & Convert.ToString(DateTime.Today.Date) & "." & Environment.NewLine & "SCC origen: " & m_PaletProducidoOrigen.SCC & ", cajas de origen: " & dbo_movimiento.Cajas & "; SCC destino:" & m_PaletProducidoDestino.SCC & ", Cajas encajadas: " & cajasInicioMail, String.Empty, _
                                                                                   Config.MailReportAddress, Config.MailReportPass, "control@landaluza.es", _
                                                                                   String.Empty, String.Empty, Config.MailClientHost, False)
        Catch ex As Exception
            MessageBox.Show("No se pudo notificar a cotnrol de este movimiento. Por favor, notifiquelo telefonicamente.", "Error de notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub ComprobarCantidadesEncajado(ByRef padre As frmEntPaletsProducidos2, _
                                          ByRef dbo_movimiento As Dbo_PaletsMovimiento, _
                                          ByRef m_PaletProducidoOrigen As DBO_PaletsProducidos2, _
                                          ByVal m_PaletProducidoDestino As DBO_PaletsProducidos2, _
                                          ByVal origen As Boolean, ByRef m_DBO_FormatoEnvasado As DBO_FormatosEnvasados, _
                                          Optional ByVal CantidadUds As Integer = Nothing, Optional fuente As String = "")

        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Dim spPaletsProducidos2 As New spPaletsProducidos2
        'If origen Then
        dbo_movimiento.PaletID = m_PaletProducidoOrigen.PaletProducidoID

        dbo_movimiento.DocumentoID = System.Convert.ToInt32(m_PaletProducidoDestino.SCC)
        dbo_movimiento.DocumentoID_IsDBNull = False

        'Dim capacidad As Integer = DataTableFill("PaletsProducidosCapacidadFormatoByPaletProducidoID " & m_PaletProducidoDestino.PaletProducidoID).Rows(0).Item(0)
        Dim capacidad As Integer

        dtb.PrepararConsulta("select capacidadCaja from articulosEnvasadosHistorico where tipoformato = @tf")
        dtb.AñadirParametroConsulta("@tf", m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID)
        capacidad = dtb.Consultar().Rows(0).Item(0)
        If CantidadUds <> Nothing Then
            capacidad = CantidadUds * capacidad
        End If

        dbo_movimiento.Cajas = dbo_movimiento.Cajas * capacidad
        Dim tope As Long = spPaletsProducidos2.calcularCajasAntesExpedir(m_PaletProducidoOrigen.SCC, BasesParaCompatibilidad.BD.transaction)
        If tope < dbo_movimiento.Cajas Then
            padre.Close()
            If fuente <> "" Then
                Throw New Exception("No hay suficientes cajas para realizar el movimiento de " & fuente & "." & Environment.NewLine & _
                                    "Solo quedan " & tope & " monodosis (" & Convert.ToInt32(tope / capacidad) & "cajas)")
            Else
                Throw New Exception("No hay suficientes cajas para realizar el movimiento. Solo quedan " & tope & " monodosis (" & Convert.ToInt32(tope / capacidad) & "cajas)")
            End If
            'Me.Close()            
        End If
        'End If

        dtb.PrepararConsulta("select id_MovimentoEncajado from tiposcajas, articulosEnvasadoshistorico where articulosEnvasadoshistorico.tipocajaID = tiposcajas.tipocajaID and tipoformato = @tf")
        dtb.AñadirParametroConsulta("@tf", m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID)
        dbo_movimiento.Tipo = dtb.Consultar().Rows(0).Item(0)
        dbo_movimiento.Tipo_IsDBNull = False
        dbo_movimiento.PaletID_IsDBNull = False
        dbo_movimiento.Fecha = Today.Date
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
End Class
