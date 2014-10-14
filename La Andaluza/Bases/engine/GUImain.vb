
Public Class GUImain

    Protected Shared LAengine As Engine_LA
    Protected frmIni As FrmInicio
    Protected frmNews As frmNews
    Protected controlador As Controller
    Protected Event extras_showed()

    'Public Sub New()
    '    MyBase.new()
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    LAengine = New Engine_LA(Me)        
    '    Me.Icon = My.Resources.LogoBandejaLa21
    '    Me.NotifyIcon1 = New NotifyIcon
    '    Me.NotifyIcon1.Icon = My.Resources.LogoBandejaLa21
    '    Me.NotifyIcon1.Visible = True
    '    Me.NotifyIcon1.ContextMenuStrip = Me.cmsNotificaciones
    'End Sub

    Public Sub New()

        InitializeComponent()

        ' Environment.Exit(69)
    End Sub
    Public Sub New(ByRef frm As FrmInicio)
        InitializeComponent()
        'segundaSesion = False
        LAengine = New Engine_LA(Me)
        'Me.frmNews = New frmNews
        'añadirPestañaSinCierre(frmNews)
        Me.Icon = My.Resources.LogoBandejaLa21        
        Me.frmIni = frm

        Me.NotifyIcon1 = New NotifyIcon
        Me.NotifyIcon1.Icon = My.Resources.LogoBandejaLa21
        Me.NotifyIcon1.Visible = True
        Me.NotifyIcon1.ContextMenuStrip = Me.cmsNotificaciones

        
        cargarAgenda()
    End Sub


#Region "Funciones y Subrutinas"

    Public Sub CambiarSesion()
        Dim frm As New BasesParaCompatibilidad.frmEspera("Cerrando sesión")
        frm.Show()
        stopGUI()
        FrmInicio.Show()
        frm.Close()
        Me.Hide()
    End Sub

    Public Overridable Sub terminarDeIniciar(ByVal tablausada As String, ByVal ServidorUsado As String, ByVal UsuarioUsado As String, ByVal usua As String)
        Me.SuspendLayout()
        Me.Controls.Remove(msMenu)
        msMenu = LAengine.AdministrarPermisosFormulario()
        Me.Controls.Add(msMenu)
        Me.frmNews = New frmNews
        añadirPestañaSinCierre(frmNews)
       
        Me.ToolTip1.SetToolTip(Me.lServ, "Usuario: " & UsuarioUsado & Environment.NewLine & "Base de datos: " & tablausada & Environment.NewLine & "Servidor: " & ServidorUsado)
        Me.ToolTip1.SetToolTip(Me.lUser, "Usuario conectado: " & usua & Environment.NewLine & "click para acceder a la configuración de usuario")


        Me.ResumeLayout()
    End Sub
#End Region

    Protected Sub lblDragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        e.Effect = DragDropEffects.Copy
        sender.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Protected Sub lblDragLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        sender.BorderStyle = BorderStyle.None
    End Sub

    Public Sub tsm_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Me.SplitContainer1.Panel1Collapsed Then
                Me.SplitContainer1.Panel1Collapsed = False
            End If
            Me.tsCustomMenu.AllowDrop = True
            sender.DoDragDrop(sender, DragDropEffects.Copy)
        End If
    End Sub

    Public Sub tsmToTrash_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            sender.DoDragDrop(sender, DragDropEffects.Copy)
        End If
    End Sub

    Public Sub CerrarPestaña()
        Try
            'Me.TabControl1.SelectedTab.Controls.Clear()
            Me.TabControl1.TabPages.Remove(Me.TabControl1.SelectedTab)
            LAengine.volverApestañaPrevia()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub TabControl1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseUp
        With TabControl1
            If .SelectedTab.Tag <> TabManager.PESTAÑA_SIN_CIERRE Then
                'If .SelectedTab.Text.EndsWith("   x") Then
                Dim ItemRect As Rectangle = .GetTabRect(.SelectedIndex)
                If ItemRect.Contains(e.Location) Then
                    If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                        ' Code you want to happen when the x is selected.
                        .TabPages.Remove(.SelectedTab)
                        ' BasesParaCompatibilidad.BD.CerrarPestaña()
                        LAengine.volverApestañaPrevia()
                    End If
                End If
                'End If
            End If
        End With
    End Sub

    Protected Sub TabControl1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            'If Me.scExtra.Panel2Collapsed Then

            '    Me.scExtra.Panel2Collapsed = False

            'If Me.TabControl2.TabPages.Count = 0 Then
            '    Dim pan As New Panel
            '    pan.Dock = DockStyle.Fill
            '    pan.BackColor = Color.LightSteelBlue

            '    Dim tb As New TabPage
            '    tb.Text = "Arrastra aquí  x"
            '    tb.Name = "Arrastra aquí  x"

            '    TabControl2.TabPages.Add(tb)
            '    pan.Parent = tb

            '    Dim l As New Label
            '    l.Text = "Para una vista dual"
            '    l.Dock = DockStyle.Top

            '    Dim l2 As New Label
            '    l2.Text = "Arrastra aquí"
            '    l2.Dock = DockStyle.Top

            '    pan.Controls.Add(l)
            '    pan.Controls.Add(l2)
            'End If

            'End If
            sender.DoDragDrop(Me.TabControl1.SelectedTab, DragDropEffects.Copy)

        Else
            Try
                With TabControl1
                    If .SelectedTab.Tag <> TabManager.PESTAÑA_SIN_CIERRE Then
                        'If .SelectedTab.Text.EndsWith("   x") Then
                        Dim ItemRect As Rectangle = .GetTabRect(.SelectedIndex)
                        If ItemRect.Contains(e.Location) Then
                            If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                                Dim df As Graphics = Me.TabControl1.CreateGraphics
                                df.DrawRectangle(Pens.LightSteelBlue, New Rectangle(ItemRect.Right - 15, 5, 11, 11))
                                df.Dispose()
                            End If
                        End If
                        ' End If
                    End If
                End With
            Catch ex As Exception
            End Try
        End If
    End Sub

    Public Sub ToolStripLabel1_ClicknoFocus(sender As System.Object, e As System.EventArgs)
        If Me.SplitContainer1.Panel1Collapsed Then
            Me.SplitContainer1.Panel1Collapsed = False
        Else
            Me.SplitContainer1.Panel1Collapsed = True
        End If
    End Sub

    Public Sub ToolStripLabel1_Clickfocused(sender As System.Object, e As System.EventArgs)
        If Me.SplitContainer1.Panel1Collapsed Then
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel1.Focus()
        Else
            Me.SplitContainer1.Panel1Collapsed = True
        End If
    End Sub

    Protected Sub ToolStrip2_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles tsCustomMenu.DragDrop
        Dim ts As ToolStripItem = e.Data.GetData("System.Windows.Forms.ToolStripItem")
        For Each tsm As ToolStripItem In Me.tsCustomMenu.Items
            If tsm.Text = ts.Text Then
                Return
            End If
        Next
        tsCustomMenu.Items.Add(ts.Text, ts.Image, AddressOf ts.PerformClick)
        'tsCustomMenu.Items.Add(ts.Text, ts.Image, AddressOf ts.PerformClick)
        Dim t As ToolStripItem = findToolStripItem(ts.Text, tsCustomMenu)
        AddHandler t.MouseMove, AddressOf tsmToTrash_MouseDown
        Me.tsCustomMenu.AllowDrop = False
    End Sub

    Protected Function findToolStripItem(ByVal text As String, tool As ToolStrip) As ToolStripItem
        For Each t As ToolStripItem In tool.Items
            If t.Text = text Then
                Return t
            End If
        Next
        Return Nothing
    End Function

    Protected Sub ToolStrip2_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles tsCustomMenu.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Protected Sub TabControl1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl1.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Protected Sub TabControl1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl1.DragDrop

        If sender Is TabControl1 Then

            Try
                Dim ts As ToolStripItem = e.Data.GetData("System.Windows.Forms.ToolStripItem")
                Dim t As ToolStripItem = findToolStripItem(ts.Text, tsCustomMenu)
                tsCustomMenu.Items.Remove(t)
            Catch ex As Exception

            End Try

            'Dim o As Object = e.Data.GetData("System.Windows.Forms.Object")

            'If o.GetType Is GetType(System.Windows.Forms.TabPage) Then
            '    'Dim ts As TabPage = e.Data.GetData("System.Windows.Forms.TabPage")
            '    'Me.TabControl1.TabPages.Add(ts)
            '    ''Me.TabControl1.TabPages.Remove(ts)
            'ElseIf o.GetType Is GetType(System.Windows.Forms.ToolStripItem) Then

            'End If
        End If
    End Sub

    Protected Sub FrmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.stopGUI()
        Config.save()
    End Sub

    Public Overridable Sub stopGUI()
        Try
            'LAengine.guardarMenu(Me.tsCustomMenu)
            'Me.TimerNotificaciones.Stop()
            'Me.TimerNotificaciones.Enabled = False
            'Me.TimerNotificaciones.Dispose()
            Me.TabControl1.TabPages.Clear()
            Me.TabControl2.TabPages.Clear()
            Me.NotifyIcon1.Visible = False
            Me.NotifyIcon1.Dispose()

            BasesParaCompatibilidad.BD.Cerrar()
        Catch ex As Exception
        End Try
    End Sub

    Protected Sub FrmPrincipal_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CerrarPestaña()
        Environment.Exit(0)
    End Sub

    Protected Sub lUser_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmConfiguracionUsuario
        LAengine.añadirPestañaAutonoma(frm)
    End Sub

    Protected Sub lReportBug_Click_1(sender As System.Object, e As System.EventArgs) Handles lReportBug.Click
        LAengine.reportarError(Me)
    End Sub

    Public Sub reportBug()
        LAengine.reportarError(Me, True)
    End Sub

    Protected Sub lUser_Click_1(sender As System.Object, e As System.EventArgs) Handles lUser.Click
        Dim frm As New frmConfiguracionUsuario
        LAengine.añadirPestañaAutonoma(frm)
    End Sub

    Protected Sub TabControl2_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl2.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Protected Sub TabControl2_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles TabControl2.DragDrop

        Try
            Dim ts As TabPage = e.Data.GetData("System.Windows.Forms.TabPage")
            Me.TabControl2.TabPages.Add(ts)
            'Me.TabControl1.TabPages.Remove(ts)

            Me.TabControl1.Invalidate()
            Me.TabControl2.Invalidate()
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub TabControl2_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl2.MouseUp
        If sender Is TabControl2 Then
            With TabControl2
                'If .SelectedTab.Text.EndsWith("   x") Then
                Dim ItemRect As Rectangle = .GetTabRect(.SelectedIndex)
                If ItemRect.Contains(e.Location) Then
                    If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                        ' Code you want to happen when the x is selected.
                        .TabPages.Remove(.SelectedTab)
                        ' BasesParaCompatibilidad.BD.CerrarPestaña()
                        LAengine.volverApestañaPrevia(True)

                        If Me.TabControl2.TabPages.Count = 0 Then
                            Me.scExtra.Panel2Collapsed = True
                        End If
                    End If
                End If
                'End If
            End With
        Else
        End If
    End Sub

    Protected Sub TabControl2_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TabControl2.MouseMove

        'If sender Is TabControl2 Then
        '    If e.Button = Windows.Forms.MouseButtons.Left Then
        '        sender.DoDragDrop(Me.TabControl2.SelectedTab, DragDropEffects.Copy)
        '    End If
        'End If
        Try
            With TabControl2
                Dim ItemRect As Rectangle = .GetTabRect(.SelectedIndex)
                If ItemRect.Contains(e.Location) Then
                    If e.Location.X > (ItemRect.Right - GUImain.LAengine.Target_Cerrar_Pestana.Width) Then
                        Dim df As Graphics = Me.TabControl2.CreateGraphics
                        df.DrawRectangle(Pens.LightSteelBlue, New Rectangle(ItemRect.Right - 15, 5, 11, 11))
                        df.Dispose()
                    End If
                End If
            End With

        Catch ex As Exception
        End Try
    End Sub

    'Protected Sub TimerNotificaciones_Tick(sender As System.Object, e As System.EventArgs)
    '    'actualizarnotificaciones()
    'End Sub

    Protected Sub actualizarNotificaciones(ByVal text As String)
        If text <> "" Then
            Me.NotifyIcon1.ShowBalloonTip(36000000, "Nuevas notificaciones", "Tiene " & text & " notificacioens nuevas", ToolTipIcon.Info)
        End If
    End Sub

    Protected Sub resetearMenuNotificaciones(mensaje As Boolean)
        If Not mensaje Then
            Dim sms As New ToolStripMenuItem
            sms.Text = "No tiene mensajes nuevos"
            sms.Name = "tssms"
            sms.Image = My.Resources.emblem_documents
            Me.cmsNotificaciones.Items.Add(sms)
        End If

        Dim separador As New ToolStripSeparator
        Me.cmsNotificaciones.Items.Add(separador)

        Dim err As New ToolStripMenuItem
        err.Text = "Notificar error"
        err.Name = "tsError"
        err.Image = My.Resources.mail_forward_4_16
        AddHandler err.Click, AddressOf reportBug
        Me.cmsNotificaciones.Items.Add(err)

        Dim scr As New BasesParaCompatibilidad.Pantalla
        If scr.isMultiScreen Then
            Dim Monitor As New ToolStripMenuItem
            Monitor.Text = "Monitor"
            Monitor.Name = "tsMonitor"
            Me.cmsNotificaciones.Items.Add(Monitor)

            Dim Monitor1 As New ToolStripMenuItem
            Monitor1.Text = "Monitor 1"
            Monitor1.Name = "tsMonitor1"
            AddHandler Monitor1.Click, AddressOf monitor1click
            Monitor.DropDownItems.Add(Monitor1)

            Dim Monitor2 As New ToolStripMenuItem
            Monitor2.Text = "Monitor 2"
            Monitor2.Name = "tsMonitor2"
            AddHandler Monitor2.Click, AddressOf monitor2click
            Monitor.DropDownItems.Add(Monitor2)
        End If

        Dim salir As New ToolStripMenuItem
        salir.Text = "Salir"
        salir.Name = "tssalir"
        salir.Image = My.Resources.application_exit_3_256
        AddHandler salir.Click, AddressOf Me.salir
        Me.cmsNotificaciones.Items.Add(salir)
    End Sub

    Private Sub monitor1click(sender As Object, e As EventArgs)
        BasesParaCompatibilidad.Config.activeScreen = 0
    End Sub
    Private Sub monitor2click(sender As Object, e As EventArgs)
        BasesParaCompatibilidad.Config.activeScreen = 1
    End Sub
    Protected Sub salir()
        Application.Exit()
    End Sub

    Public Sub lMensajes_Click(sender As System.Object, e As System.EventArgs) Handles lMensajes.Click
        Dim frm As New frmMensajesPendientes(Me.lMensajes, Me)
        LAengine.añadirPestañaAutonoma(frm)
    End Sub

    Protected Sub tsPetañalateral_Click(sender As System.Object, e As System.EventArgs) Handles tsPetañalateral.Click
        If Me.scExtra.Panel2Collapsed Then
            Me.scExtra.Panel2Collapsed = False

            If Me.TabControl2.TabPages.Count = 0 Then
                Dim pan As New Panel
                pan.Dock = DockStyle.Fill
                pan.BackColor = Color.LightSteelBlue

                Dim tb As New TabPage
                tb.Text = "Arrastra aquí  x"
                tb.Name = "Arrastra aquí  x"

                TabControl2.TabPages.Add(tb)
                pan.Parent = tb

                Dim l As New Label
                l.Text = "Para una vista dual"
                l.Dock = DockStyle.Top

                Dim l2 As New Label
                l2.Text = "Arrastra aquí"
                l2.Dock = DockStyle.Top

                pan.Controls.Add(l)
                pan.Controls.Add(l2)
            End If
        Else
            Me.scExtra.Panel2Collapsed = True
        End If
    End Sub

    Protected Sub lAyuda_Click(sender As System.Object, e As System.EventArgs) Handles lAyuda.Click
        Dim url As String = Config.HelpUrl & "?cat=" & Me.TabControl1.SelectedTab.Text.Replace(TabManager.CIERRE_PESTAÑA, "").Replace(" ", "_")
        LAengine.ayuda(url)

    End Sub

    Shared Sub OpenHelp(ByVal categoria As String)
        Dim url As String = Config.HelpUrl & "?cat=" & categoria
        LAengine.ayuda(url)
    End Sub

    Shared Sub añadirPestañaSinCierre(ByRef frmEnt As Object)
        LAengine.añadirPestañasinCierre(frmEnt)
    End Sub

    Shared Sub añadirPestaña(ByRef frmEnt As Object)
        LAengine.añadirPestañaAutonoma(frmEnt)
    End Sub

    Shared Sub añadirPestaña_standar(ByRef frmEnt As Object)
        LAengine.AñadirPestaña(frmEnt)
    End Sub

    Protected Sub NotificarErrorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotificarErrorToolStripMenuItem.Click
        reportBug()
    End Sub


    'protected Sub cambiar_sesion()
    '    ini = New FrmInicio
    '    If ini.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        Me.Controls.Remove(msMenu)
    '        msMenu = LAengine.AdministrarPermisosFormulario()
    '        Me.Controls.Add(msMenu)
    '    End If
    'End Sub

    Private Sub cargarExtras(ByVal sender As System.Object, _
      ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'AddHandler tsNavegacion.MouseEnter, AddressOf ToolStripLabel1_Click
        'AddHandler Me.SplitContainer1.Panel1.MouseLeave, AddressOf ToolStripLabel1_Click

        'calculo del tamaño del cierre de las pestañas
        'TabTarget = CreateGraphics.MeasureString(" x", TabControl1.Font)
        GUImain.LAengine.Target_Cerrar_Pestana = CreateGraphics.MeasureString(TabManager.CIERRE_PESTAÑA, TabControl1.Font)

        If Not Me.controlador Is Nothing Then
            Me.SplitContainer1.Panel1.Cursor = Cursors.WaitCursor
            Me.controlador.cargar_extras()
        End If
    End Sub

    Private Sub ended(ByVal sender As System.Object, _
      ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If Not Config.dataFillNotificaction Then
            frmNews.ocultarNotificaciones() 'Me.PanNot1.Visible = False
        End If

        If Not Me.controlador Is Nothing Then
            Engine_LA.FormEnPestaña(Me.controlador.form, Me.SplitContainer1.Panel1)
            Me.SplitContainer1.Panel1.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub lPersonalSinFin_Click(sender As System.Object, e As System.EventArgs) Handles lPersonalSinFin.Click
        Dim frm As New frmPersonalEnvasadoSinFin
        LAengine.añadirPestañaAutonoma(frm)
    End Sub

    Private Sub LAgenda_Click(sender As System.Object, e As System.EventArgs) Handles LAgenda.Click
        mAgenda.Show(LAgenda, LAgenda.Location)
    End Sub

    Protected Sub cargarAgenda()
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Dim dt As DataTable = dtb.Consultar("ComunicacionesSelectDgv", True)
        If Not dt Is Nothing Then
            Me.mAgenda.Items.Clear()
            Dim sms2 As ToolStripMenuItem

            For Each row As DataRow In dt.Rows
                sms2 = New ToolStripMenuItem
                sms2.Text = Convert.ToString(row.Item(1)) & "  " & _
                        If(Convert.IsDBNull(row.Item(4)), "-", Convert.ToString(row.Item(4))) & " " & _
                        If(Convert.IsDBNull(row.Item(3)), "-", Convert.ToString(row.Item(3))) & " " & _
                        If(Convert.IsDBNull(row.Item(2)), "-", Convert.ToString(row.Item(2)))

                Me.mAgenda.Items.Add(sms2)
            Next
        End If
    End Sub
End Class

