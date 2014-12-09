Public Class GUIstandar
    Inherits GUImain
    Private updater As Updater
    Public Sub New(ByRef frm As FrmInicio)
        MyBase.new(frm)
        ' This call is required by the designer.
        InitializeComponent()
        Me.Text = Config.Version_seriada
        Me.updater = New Updater
        TimerActualizaciones.Start()
    End Sub

    Public Overrides Sub terminarDeIniciar(ByVal tablausada As String, ByVal ServidorUsado As String, ByVal UsuarioUsado As String, ByVal usua As String)
        MyBase.terminarDeIniciar(tablausada, ServidorUsado, UsuarioUsado, usua)
        
        Select Case Config.UserType
            Case 1
                Me.controlador = New Controler_control
                AddHandler tsNavegacion.Click, AddressOf ToolStripLabel1_ClicknoFocus

            Case 9
                Me.controlador = New Controler_control
                AddHandler tsNavegacion.Click, AddressOf ToolStripLabel1_ClicknoFocus
                'RemoveHandler Me.tsNavegacion.MouseEnter, AddressOf ToolStripLabel1_Click
                'RemoveHandler Me.tsNavegacion.MouseLeave, AddressOf ToolStripLabel1_Click
                'AddHandler Me.tsNavegacion.Click, AddressOf ToolStripLabel1_Click
            Case 4
                Me.controlador = New Controler_control
                AddHandler tsNavegacion.Click, AddressOf ToolStripLabel1_ClicknoFocus
                'RemoveHandler Me.tsNavegacion.MouseEnter, AddressOf ToolStripLabel1_Click
                'RemoveHandler Me.tsNavegacion.MouseLeave, AddressOf ToolStripLabel1_Click
                'AddHandler Me.tsNavegacion.Click, AddressOf ToolStripLabel1_Click
            Case 5
                Me.controlador = New Controller_administrativo
                AddHandler tsNavegacion.MouseEnter, AddressOf ToolStripLabel1_Clickfocused
                AddHandler Me.SplitContainer1.Panel1.MouseLeave, AddressOf ToolStripLabel1_Clickfocused
            Case 10
                Me.controlador = New Controler_control
                AddHandler tsNavegacion.Click, AddressOf ToolStripLabel1_ClicknoFocus
                'RemoveHandler Me.tsNavegacion.MouseEnter, AddressOf ToolStripLabel1_Click
                'RemoveHandler Me.tsNavegacion.MouseLeave, AddressOf ToolStripLabel1_Click
                'AddHandler Me.tsNavegacion.Click, AddressOf ToolStripLabel1_Click
            Case Else
                AddHandler tsNavegacion.MouseEnter, AddressOf ToolStripLabel1_ClicknoFocus
                AddHandler Me.SplitContainer1.Panel1.MouseLeave, AddressOf ToolStripLabel1_ClicknoFocus
                Me.controlador = Nothing
        End Select

        TimerNotificaciones.Enabled = True
        TimerNotificaciones.Start()
        Me.Show()

        Me.actualizarnotificaciones()
    End Sub

    Public Overrides Sub stopGUI()
        Try
            'LAengine.guardarMenu(Me.tsCustomMenu)
            Me.TimerNotificaciones.Stop()
            Me.TimerNotificaciones.Enabled = False
            Me.TimerNotificaciones.Dispose()            
        Catch ex As Exception
        End Try

        MyBase.stopGUI()
    End Sub

    Public Shadows Sub actualizarnotificaciones()

        Dim notificacion As DataTable
        Select Case Config.UserType
            'Case 7
            '    Me.cmsNotificaciones.Items.Clear()

            '    Dim nOC As Integer = LAengine.comprobarNumeroOC
            '    Dim nPed As Integer = LAengine.comprobarNumeroPedidos

            '    Dim sms2 As New ToolStripMenuItem
            '    sms2.Text = "Pedidos: " & nPed & "  Ordenes de carga: " & nOC
            '    sms2.Name = "tsnEscan"
            '    sms2.Image = My.Resources.emblem_package
            '    Me.cmsNotificaciones.Items.Add(sms2)
            '    AddHandler sms2.Click, AddressOf Escanear

            '    'If nOC + nPed > 0 Then
            '    '    Me.PanNotificaciones.Visible = True
            '    '    Me.lMensajeNotificacion.Text = "Pedidos: " & nPed & "|  Ordenes de carga: " & nOC
            '    '    AddHandler lMensajeNotificacion.Click, AddressOf tsmEscaneoSCC_Click
            '    'End If

            '    notificacion = LAengine.comprobarNotificaciones


            '    If notificacion.Rows.Count > 0 Then
            '        Dim separador As New ToolStripSeparator
            '        Me.cmsNotificaciones.Items.Add(separador)
            '        MyBase.actualizarNotificaciones(notificacion.Rows.Count)

            '        For Each row As DataRow In notificacion.Rows
            '            Dim sms As New ToolStripMenuItem
            '            sms.Text = row.Item(0)
            '            sms.Image = My.Resources.emblem_documents
            '            Me.cmsNotificaciones.Items.Add(sms)
            '            AddHandler sms.Click, AddressOf lMensajes_Click
            '        Next

            '        Me.lMensajes.Enabled = True

            '        Dim frm As New frmMensajesPendientes(lMensajes, Me)

            '        resetearMenuNotificaciones(True)
            '        Me.frmNews.actualizarNotificacion(frm)
            '    Else
            '        resetearMenuNotificaciones(False)
            '        lMensajes.Enabled = False
            '    End If
            Case 9 '4

                If Envasado.spEnvasados2.personalPendiente(dtb) Then
                    Me.lPersonalSinFin.Visible = True
                End If

                Me.cmsNotificaciones.Items.Clear()

                notificacion = LAengine.comprobarNotificaciones(dtb)


                If notificacion.Rows.Count > 0 Then
                    Dim separador As New ToolStripSeparator
                    Me.cmsNotificaciones.Items.Add(separador)
                    MyBase.actualizarNotificaciones(notificacion.Rows.Count)

                    For Each row As DataRow In notificacion.Rows
                        Dim sms As New ToolStripMenuItem
                        sms.Text = row.Item(0)
                        sms.Image = My.Resources.emblem_documents
                        Me.cmsNotificaciones.Items.Add(sms)
                        AddHandler sms.Click, AddressOf lMensajes_Click
                    Next

                    Me.lMensajes.Enabled = True

                    Dim frm As New frmMensajesPendientes(lMensajes, Me)

                    resetearMenuNotificaciones(True)
                    Me.frmNews.actualizarNotificacion(frm)
                    Me.frmNews.ActualizarRevisiones()
                Else
                    resetearMenuNotificaciones(False)
                    lMensajes.Enabled = False
                End If
            Case 4
                Me.frmNews.ActualizarRevisiones()
            Case Else
                TimerNotificaciones.Stop()
                TimerNotificaciones.Enabled = False              
        End Select

    End Sub

    Protected Sub TimerNotificaciones_Tick(sender As System.Object, e As System.EventArgs) Handles TimerNotificaciones.Tick
        actualizarnotificaciones()

    End Sub

    Private Sub GUIstandar_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        ' If Not Me.controlador Is Nothing Then


        BackgroundWorker1.RunWorkerAsync()
        'End If
    End Sub

    
    Private Sub TimerActualizaciones_Tick(sender As Object, e As EventArgs) Handles TimerActualizaciones.Tick
        If Me.updater.InstallOnlyRequired() Then
            lActualizaciones.Visible = True
        Else
            If lActualizaciones.Visible Then lActualizaciones.Visible = False
        End If
    End Sub

    Private Sub lActualizaciones_Click(sender As Object, e As EventArgs) Handles lActualizaciones.Click
        updater.InstallUpdateSyncWithInfo()
    End Sub
End Class