Imports BasesParaCompatibilidad.DataGridViewExtension

Public Class frmEntPaletsProducidos2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Dim m_Tabla As DataTable
    Public m_DBO_Envasado As DBO_Envasados2
    'Public m_DBO_FormatoEnvasado As DBO_FormatosEnvasados2
    Private formatoId As Integer
    Public m_DBO_PaletProducido As DBO_PaletsProducidos2
    Public paletCreado As Boolean = False
    Public reusado As Boolean
    Public frContenidos As frmPaletsContenidos2
    Public padre As frmPaletsProducidos2
    Public Const INSERTAR_PRIMER_PALET As Integer = 3
    Private editable As Boolean
    Private spPaletsProducidos2 As spPaletsProducidos2

    Public Sub New(formatoid As Integer, Optional ByVal editable As Boolean = True)
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()
        Me.instance(formatoid, editable)
    End Sub

    Private Sub instance(ByVal formatoid As Integer, Optional ByVal editable As Boolean = True)
        spPaletsProducidos2 = New spPaletsProducidos2
        Me.reusado = False
        Me.editable = editable
        m_DBO_Envasado = DBO_Envasados2.Instance
        Me.formatoId = formatoid
        m_DBO_PaletProducido = DBO_PaletsProducidos2.Instance
    End Sub

    Private Sub init()
        If Me.editable Then
            If (Me.formatoId = 0 Or Me.formatoId = Nothing) And (Me.ModoDeApertura <> VISION) Then
                MessageBox.Show("No se ha guardado aun el formato de envasado.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Dispose()
                Return
            End If
        End If

        SetValores()
        OcultarBotonSinRegistros()
        butSalir.Visible = True
        butGuardar.Visible = True
        spPaletsProducidos2.scc = Me.lblSSCCtext.Text
        MoveLast(dgvIncompletos)
        If Not dgvIncompletos.CurrentRow Is Nothing Then If Me.dgvIncompletos.Visible Then Me.ActualizarMovimientos(dgvIncompletos.CurrentRow.Cells("SCC").Value)
        Me.txtObservaciones.Focus()

        If (Me.ModoDeApertura = MODIFICACION) Then
            Me.paletCreado = True
        ElseIf Me.ModoDeApertura = VISION Then
            Me.paletCreado = True
            Me.txtObservaciones.Enabled = False
            Me.grbIncompletos.Visible = False
            Me.OcultarBotonGrabar(True)
            Me.Pactions.Visible = False
            Me.MinimumSize = New Size(325, 625)
            Me.Height = 625
            Me.CenterToParent()
        End If

        If Not Me.editable Then
            Me.frContenidos.butNuevo.Visible = False
            Me.frContenidos.butModificar.Visible = False
            Me.frContenidos.butEliminar.Visible = False
        End If

        Me.Text = Me.Text & "    " & frmFormatosEnvasados2.CadenaFormato 'Me.m_DBO_PaletProducido.FormatoDescripcion
    End Sub

    Private Sub frmEntPaletsProducidos2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.init()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Public Function getPaletId() As Integer
        Return Me.m_DBO_PaletProducido.PaletProducidoID
    End Function

    Public Overrides Sub SetValores()
        If m_DBO_PaletProducido.PaletProducidoID > 0 Then
            Dim PrimerPaletAux As Boolean = m_DBO_PaletProducido.EsPrimerPalet
            m_DBO_PaletProducido = spPaletsProducidos2.Select_Record(m_DBO_PaletProducido.PaletProducidoID, dtb)
            spPaletsProducidos2.GetCajasPalet(m_DBO_PaletProducido, dtb)
            m_DBO_PaletProducido.EsPrimerPalet = PrimerPaletAux
            grbContenido.Visible = True
            grbIncompletos.Visible = False

            If reusado Then
                txtObservaciones.Text = ""
            Else
                txtObservaciones.Text = m_DBO_PaletProducido.observacionesPalets
            End If
        Else
            m_DBO_PaletProducido.SCC = spPaletsProducidos2.GetUltimoSCCmas1(dtb)
            grbContenido.Visible = True
            Me.TimerSSCC.Start()
        End If

        VerificarPaletsSinTerminar()
        lblPaletProducidoID.Text = m_DBO_PaletProducido.PaletProducidoID
        lblSSCCtext.Text = m_DBO_PaletProducido.SCC
        ActualizarTabs()

        Me.chbEnAlmacen.Checked = Me.m_DBO_PaletProducido.EnAlmacen
        Me.chbTerminado.Checked = Me.m_DBO_PaletProducido.Terminado
        Me.chbMultilote.Checked = Me.m_DBO_PaletProducido.MultiLote
    End Sub

    Overrides Sub Guardar()
        GetValores()

        If (Me.ModoDeApertura = MODIFICACION) Or (Me.ModoDeApertura = VISION) Then
            If checkPaletContents(frmEntPaletsProducidos2.MODIFICACION) Then

                Me.Close()
            End If
        Else
            If checkPaletContents(frmEntPaletsProducidos2.INSERCION) Then
                Me.TimerSSCC.Stop()
                If spPaletsProducidos2.message <> "" Then
                    Dim frmAuto As New PaletsEntAutoGuardado(Me)
                    frmAuto.ShowDialog()
                End If
                Me.paletCreado = True
                VerificarPaletsSinTerminar()
                MyBase.Guardar()
                SetValores()
                'etiquetar()
                Me.Close()
            End If
        End If

    End Sub

    Public Sub guardado(ByRef dtb As BasesParaCompatibilidad.DataBase)
        Me.dtb = dtb
        GetValores()
        If (Me.ModoDeApertura = MODIFICACION) Or (Me.ModoDeApertura = VISION) Then
            If checkPaletContents(frmEntPaletsProducidos2.MODIFICACION) Then

                Me.Close()
            End If
        Else
            Me.TimerSSCC.Stop()
            spPaletsProducidos2.GrabarPaletProducido2(m_DBO_PaletProducido, dtb)
            If spPaletsProducidos2.message <> "" Then
                Dim frmAuto As New PaletsEntAutoGuardado(Me)
                frmAuto.ShowDialog()
            End If
            Me.paletCreado = True
            VerificarPaletsSinTerminar()
            SetValores()
            ' etiquetar()
            MyBase.Guardar()
        End If
    End Sub

    Private Sub GetValores()
        m_DBO_PaletProducido.observacionesPalets = txtObservaciones.Text
        m_DBO_PaletProducido.FechaModificacion = System.DateTime.Now.date
        m_DBO_PaletProducido.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        m_DBO_PaletProducido.Terminado = Me.chbTerminado.Checked
        m_DBO_PaletProducido.EnAlmacen = Me.chbEnAlmacen.Checked
        m_DBO_PaletProducido.MultiLote = Me.chbMultilote.Checked
    End Sub

    Public Sub VerificarPaletsSinTerminar()
        Dim cell As Integer = 0
        Try
            cell = dgvIncompletos.CurrentRow.Index
        Catch ex As Exception
        End Try

        Try
            'm_Tabla = DataTableFill("PaletsProducidos3SelectPaletsIncompletos " & m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID)
            Dim sp As New spFormatosEnvasados
            Dim dbo As DBO_FormatosEnvasados = sp.Select_Record(If(Me.formatoId = Nothing, Me.m_DBO_PaletProducido.FormatoID, Me.formatoId), dtb)
            If dbo Is Nothing Then Return

            dtb.PrepararConsulta("PaletsProducidos3SelectPaletsIncompletos @id")
            dtb.AñadirParametroConsulta("@id", dbo.TipoFormatoEnvasadoID)
            m_Tabla = dtb.Consultar()

            If m_Tabla.Rows.Count > 0 Then
                grbIncompletos.Visible = True
                Me.dgvIncompletos.Visible = True
                Me.dgvMovimientos.Visible = True
                Me.Pactions.Visible = True

                Me.grbContenido.Height = 186
                With dgvIncompletos
                    SuspendLayout()
                    .DataSource = m_Tabla
                    .Columns("PaletProducidoID").Visible = False
                    .Columns("ConPaletID").Visible = False
                    .Columns("Articulo").Visible = False
                    .Columns("Cajas").Visible = True
                    .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Izquierda, 50)
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                    .FormatoGeneral()
                    .MoveLast()
                    .ResumeLayout()
                    ActualizarTabs()
                End With
            Else
                grbIncompletos.Visible = False
                Me.dgvIncompletos.Visible = False
                Me.dgvMovimientos.Visible = False
                Me.Pactions.Visible = False

                Me.grbContenido.Height = Me.Height - 200
            End If
        Catch ex As Exception

        End Try

        Dim SSCC As Integer
        Try
            Me.dgvIncompletos.Rows(cell).Selected = True
            SSCC = dgvIncompletos.CurrentRow.Cells("SCC").Value
        Catch ex As Exception
        End Try
        ActualizarMovimientos(SSCC)
    End Sub

    Private Sub ActualizarMovimientos(ByVal SSCC As String)
        Dim dtr As DataTable
        Try
            dtb.PrepararConsulta("PaletsProducidos2SelectPaletsIncompletosMAM @scc")
            dtb.AñadirParametroConsulta("@scc", SSCC)
            dtr = dtb.Consultar()
            If Not dtr Is Nothing Then
                With dgvMovimientos
                    SuspendLayout()
                    .DataSource = dtr
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 77)
                    .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85)
                    .FormatoColumna("Final", BasesParaCompatibilidad.TiposColumna.Hora, 85)
                    .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 140)
                    .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 40)
                    .FormatoColumna("Documento", BasesParaCompatibilidad.TiposColumna.Izquierda, 140)
                    .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                    .FormatoGeneral()
                    .MoveLast()
                    ResumeLayout()
                End With

                Me.dgvMovimientos.Refresh()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ActualizarTabs()
        If Me.Text.Substring(0, 3) = "Mod" Then
            frContenidos = New frmPaletsContenidos2(Me.formatoId, m_DBO_PaletProducido.PaletProducidoID)
        ElseIf Me.Text.Substring(0, 3) = "Ver" Then
            frContenidos = New frmPaletsContenidos2(Me.formatoId, m_DBO_PaletProducido.PaletProducidoID, True)
        Else
            frContenidos = New frmPaletsContenidos2(Me.formatoId, 0)
        End If

        frContenidos.Embebido = True
        frContenidos.padre = Me
        Engine_LA.FormEnPestaña(frContenidos, panConPal)
        If Not Me.editable Then
            Me.frContenidos.butNuevo.Visible = False
            Me.frContenidos.butModificar.Visible = False
            Me.frContenidos.butEliminar.Visible = False
        End If
    End Sub

    Private Sub btnCompletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompletar.Click
        Try
            Me.TimerSSCC.Stop()
            Me.TimerSSCC.Enabled = False
            Me.frContenidos.completar()
        Catch ex As Exception
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub btnNoUtilizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoUtilizar.Click
    '    grbIncompletos.Visible = False

    '    Me.instance(Me.formatoId)
    '    m_DBO_PaletProducido.PaletProducidoID = 0
    '    Me.Text = "Insertar"
    '    Me.init()
    '    Me.paletCreado = False
    '    Me.ModoDeApertura = INSERCION
    '    grbIncompletos.Visible = False
    '    Me.dgvIncompletos.Visible = False
    '    Me.dgvMovimientos.Visible = False
    '    Me.btnCompletar.Visible = False
    '    Me.btnNoAlmacen.Visible = False
    '    Me.btnNoCoincide.Visible = False
    '    Me.btnNoUtilizar.Visible = False
    '    Me.frContenidos.Action("Insertar")
    'End Sub

    Private Sub btnNoAlmacen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoAlmacen.Click
        Me.enviarMail(0)
    End Sub

    Private Sub btnNoCoincide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoCoincide.Click
        Me.enviarMail(1)
    End Sub
    Private Sub enviarMail(ByVal opcion As Integer)
        Dim sSubject As String
        Dim data As String = ""
        Dim cont As Integer = 0

        data &= "<th width=""100%"" scope=""col"" align=""left"" >SCC:" & dgvIncompletos.CurrentRow.Cells("SCC").Value & "</th>"
        data &= "<th width=""100%"" scope=""col"" align=""left"" >Cajas:" & dgvIncompletos.CurrentRow.Cells("Cajas").Value & "</th>"

        If (opcion = 0) Then
            sSubject = "SCC " & dgvIncompletos.CurrentRow.Cells("SCC").Value & " no encontrado en almacen"
        Else
            sSubject = "SCC " & dgvIncompletos.CurrentRow.Cells("SCC").Value & " no coincide."
            Dim s As String = InputBox("Cajas en almacen:")
            If s = "" Then Return
            data &= "<th width=""100%"" scope=""col"" align=""left"" >Cajas en almacen:" & s & "</th>"
        End If

        Dim sHTMLBody As String = "<html>" & _
                   "   <head><title></title></head>" & _
                   "   <body>" & _
                   "       <table width=""100%"" border=""0"" align=""left"" >" & _
                   "           <tr align=""left"" >" & data & _
                   "</tr>" & _
                   "           <tr align=""left"" ><th width=""100%"" scope=""col"" align=""left"" >&nbsp;</th></tr>" & _
                   "           <tr align=""left"" ><th width=""100%"" scope=""col"" align=""left"" >&nbsp;</th></tr>" & _
                   "           <tr align=""left"" ><th width=""100%"" scope=""col"" align=""left"" >&nbsp;</th></tr>" & _
                   "        </table>" & _
                   "   <body>" & _
                   "<html>"
        Try
            ' LINEAS COMENTADAS HASTA QUE SE REALICE EL CAMBIO EN LA TABLA USUARIOS EN PRODUCCION
            'Dim usuario As Integer = FrmPrincipal.CtlAcc.clsUsu.UsuarioID
            'Dim mdbo_usuarios = spUsuarios.select_record(usuario)

            Dim mail As New Mail.Mail(sSubject, sHTMLBody, Nothing, "administracion@landaluza.es", "Administracion2008", "gerente@landaluza.es", "calidad@landaluza.es", Nothing, "smtp.1and1.es")

            'Dim mail As New Mail.Mail(sSubject, sHTMLBody, Nothing, mdbo_usuarios.m_mail, mdbo_usuarios.m_pass, "gerente@landaluza.es", "calidad@landaluza.es", Nothing, mdbo_usuarios.m_servidorDeCorreo)
            mail.sendMail()
        Catch ex As Exception
            messagebox.show("Error. Asegurese de tener configurado sus datos para el envio de correo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dgvIncompletos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIncompletos.CellClick
        Try
            Dim SSCC As Integer = dgvIncompletos.CurrentRow.Cells("SCC").Value
            ActualizarMovimientos(SSCC)
        Catch ex As Exception
        Finally
            ActualizarTabs()
        End Try
    End Sub

    Private Sub frmEntPaletsProducidos2_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown        
        If Not dgvIncompletos.Visible And (Me.ModoDeApertura = INSERCION Or Me.ModoDeApertura = INSERTAR_PRIMER_PALET) Then
            frContenidos.Action("Insertar")
        End If
    End Sub



    Public Overrides Sub salir()
        If checkPaletContents(frmEntPaletsProducidos2.CERRADO) Then Me.Close()
    End Sub

    Private Function checkPaletContents(ByVal operation As Integer) As Boolean
        Me.frContenidos.DatagridViewFill()
        Dim resp As Long
        'Dim mDBO_usuarios As New DBO_Usuarios
        ''-Dim auspaux As New spUsuarios
        'mDBO_usuarios = auspaux.Select_Record(BasesParaCompatibilidad.Config.User)

        If operation = INSERCION Then
            If (Me.frContenidos.RowCount = 0) Then '(Me.paletCreado = True) And 

                resp = MessageBox.Show("Esta acción creará un palet vacio (sin contenidos)." & _
                            Environment.NewLine & Environment.NewLine & "¿Está seguro de querer continuar?", _
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resp = vbNo Then
                    Return False
                Else
                    If Me.txtObservaciones.Text = "" Then Me.txtObservaciones.Text = "Generado sin contenidos por usuario " & Config.UserName
                    GetValores()
                    spPaletsProducidos2.GrabarPaletProducido2(m_DBO_PaletProducido, dtb)
                End If
            End If
        ElseIf operation = MODIFICACION Then
            If (Me.frContenidos.RowCount = 0) Then


                resp = MessageBox.Show("Esta acción creará un palet vacio (sin contenidos)." & _
                                    Environment.NewLine & Environment.NewLine & "¿Está seguro de querer continuar?", _
                                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resp = DialogResult.No Then Return False


                If Me.txtObservaciones.Text = "" Then Me.txtObservaciones.Text = "Generado sin contenidos por usuario " & Config.UserName
            End If
            GetValores()
            spPaletsProducidos2.GrabarPaletProducido2(m_DBO_PaletProducido, dtb)

        ElseIf operation = CERRADO Then
            If (Me.frContenidos.RowCount = 0 And Me.ModoDeApertura = MODIFICACION) Then '(Me.paletCreado = True) And 
                resp = MessageBox.Show("Esta acción creará un palet vacio (sin contenidos)." & _
                            Environment.NewLine & Environment.NewLine & "¿Está seguro de querer continuar?", _
                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resp = DialogResult.No Then
                    Return False
                Else
                    If Me.ModoDeApertura = MODIFICACION Then
                        Me.txtObservaciones.Text = "Generado sin contenidos por usuario " & Config.UserName
                        GetValores()
                        spPaletsProducidos2.GrabarPaletProducido2(m_DBO_PaletProducido, dtb)
                    Else
                        If Me.paletCreado Then
                            Me.txtObservaciones.Text = "Generado sin contenidos por usuario " & Config.UserName
                            GetValores()
                            spPaletsProducidos2.GrabarPaletProducido2(m_DBO_PaletProducido, dtb)
                        End If
                    End If
                End If
            End If
        End If

        Return True
    End Function

    Private Sub frmEntPaletsProducidos2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Me.frContenidos.gestionarEventosDeTeclado(e)
    End Sub

    Private Sub TimerSSCC_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSSCC.Tick
        Actualizar_sscc()
    End Sub

    Public Sub actualizar_sscc()
        m_DBO_PaletProducido.SCC = spPaletsProducidos2.GetUltimoSCCmas1(dtb)
        lblSSCCtext.Text = m_DBO_PaletProducido.SCC
    End Sub

    'Private Sub frmEntPaletsProducidos2_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    'If Me.chbTerminado.Checked Then
    '    If Not spPaletsProducidos2.estaEtiquetado(Me.m_DBO_PaletProducido.PaletProducidoID) Then
    '        If spPaletsProducidos2.Etiquetar(Me.m_DBO_PaletProducido.PaletProducidoID) Then
    '            'Dim frm As New frmEtiqueta0(Me.m_DBO_PaletProducido.PaletProducidoID, False)
    '            'frm.Show()
    '        Else
    '            MessageBox.Show("No se pudo imprimir la etiqueta, vuelva a intentarlo manualmente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    End If
    'End If

    'etiquetar

    'End Sub

    Public Sub etiquetar()
        ' If Not spPaletsProducidos2.estaEtiquetado(Me.m_DBO_PaletProducido.PaletProducidoID) Then
        If Me.m_DBO_PaletProducido.PaletProducidoID <> 0 Then
            'If MessageBox.Show("¿Desea imprimir etiqueta?", "Etiqueta palet " & Me.m_DBO_PaletProducido.SCC, _
            '                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If spPaletsProducidos2.Etiquetar(Me.m_DBO_PaletProducido.PaletProducidoID, dtb) Then
                Try
                    Dim frm As New frmEtiqueta0(Me.m_DBO_PaletProducido.PaletProducidoID, False, False)
                    frm.Show()
                Catch ex As Exception
                    MessageBox.Show("No se pudo mostrar los datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                MessageBox.Show("No se pudo imprimir la etiqueta, vuelva a intentarlo manualmente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'End If
        End If
        'End If
    End Sub

    Private Sub frmEntPaletsProducidos2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.TimerSSCC.Enabled Then
            TimerSSCC.Stop()
            TimerSSCC.Enabled = False
        End If
    End Sub
End Class
