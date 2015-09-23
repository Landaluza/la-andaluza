﻿Public Class Engine_LA
    Private conf As Config
    Private tabAdm As TabManager
    Private previousTab As TabPage
    Private notificador As Notificador
    Private frmGui As GUImain
    Private menu_dispatcher As MenuDispatcher

    Public Property Target_Cerrar_Pestana As SizeF
        Set(value As SizeF)
            Me.tabAdm.Target_Cerrar_Pestana = value
        End Set
        Get
            Return Me.tabAdm.Target_Cerrar_Pestana
        End Get
    End Property

    Public Sub New(ByRef frm As GUImain)
        conf = New Config
        tabAdm = New TabManager(frm.TabControl1, frm.TabControl2, frm)
        notificador = New Notificador
        Me.frmGui = frm
        menu_dispatcher = New MenuDispatcher

        AddHandler menu_dispatcher.cambio_sesion, AddressOf frmGui.CambiarSesion
    End Sub

    Public Sub AñadirPestaña(ByRef form As Form)
        Me.tabAdm.añadirPestaña(form)
    End Sub

    Public Sub añadirPestañasinCierre(ByRef form As Form)
        Me.tabAdm.añadirPestañaSinCierre(form)
    End Sub

    Public Sub añadirPestañaAutonoma(ByRef form As Form)
        Me.tabAdm.añadirPestañaAutonoma(form)
    End Sub

    Public Sub volverApestañaPrevia(Optional ByVal secundario As Boolean = False)
        If secundario Then
            Me.tabAdm.volverApestañaPrevia2()
        Else
            Me.tabAdm.volverApestañaPrevia()
        End If
    End Sub

    Public Shared Sub FormEnPestaña(ByVal mForm As Form, ByVal mPanel As Panel, Optional mFill As Boolean = True)
        mPanel.Controls.Clear()
        mForm.WindowState = FormWindowState.Normal
        mForm.TopLevel = False
        mForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        If mFill Then
            mForm.Dock = DockStyle.Fill
        End If

        'mObjeto.windowState = AppWinStyle.NormalFocus
        'mObjeto.butSalir.Visible = False
        'If mObjeto.name <> "frmOrdenesEnvasado2Detalle" Then
        'mObjeto.butVer.Visible = False
        'End If
        mPanel.Controls.Add(mForm)
        mForm.Show()
    End Sub

    Public Shared Sub FormEnPestaña(ByVal mForm As Object, ByVal mPanel As GroupBox)
        mPanel.Controls.Clear()
        mForm.WindowState = FormWindowState.Normal
        mForm.TopLevel = False
        mForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        mForm.Dock = DockStyle.Fill
        'mObjeto.windowState = AppWinStyle.NormalFocus
        'mObjeto.butSalir.Visible = False
        'If mObjeto.name <> "frmOrdenesEnvasado2Detalle" Then
        'mObjeto.butVer.Visible = False
        'End If
        mPanel.Controls.Add(mForm)
        mForm.Show()
    End Sub

    Public Function AdministrarPermisosFormulario() As MenuStrip
        Dim menu As MenuStrip
        Try
            menu = menu_dispatcher.get_menu()
            'PrepararMenuParaDragAnddrop(menu)
            Return menu

        Catch ex As Exception
            Return New MenuStrip
        End Try
    End Function

    'Public Sub PrepararMenuParaDragAnddrop(ByRef menustrip1 As MenuStrip)
    '    'Try
    '    '    For Each otroItem As ToolStripMenuItem In menustrip1.Items
    '    '        prepararParaDnd(otroItem)
    '    '    Next
    '    'Catch ex As Exception
    '    'End Try
    'End Sub

    'Private Sub prepararParaDnd(ByRef item As ToolStripMenuItem)
    '    'For Each otroItem As ToolStripMenuItem In item.DropDownItems
    '    '    If TypeOf otroItem Is ToolStripMenuItem Then
    '    '        If otroItem.DropDownItems.Count > 0 Then
    '    '            prepararParaDnd(otroItem)
    '    '        Else
    '    '            AddHandler otroItem.MouseMove, AddressOf frmGui.tsm_MouseDown
    '    '        End If
    '    '    End If
    '    'Next
    'End Sub

    'Public Sub cargarMenu(ByRef MenuStrip1 As MenuStrip, ByRef menuAcopiar As ToolStrip)
    '    Try
    '        Dim obj As Collection = Me.conf.CargarMenuPersonal
    '        If Not (obj Is Nothing) Then
    '            For i As Integer = 1 To obj.Count
    '                For Each otroItem As ToolStripMenuItem In MenuStrip1.Items
    '                    buscarMenu(obj(i), otroItem, menuAcopiar)
    '                Next
    '            Next
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Public Sub guardarMenu(ByRef tsCustomMenu As ToolStrip)
    '    Dim f As New File()
    '    Dim c As New Collection
    '    For Each element As ToolStripItem In tsCustomMenu.Items
    '        c.Add(element.Text)
    '    Next

    '    Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "menu.obj"
    '    f.saveObject(c, mydocpath)
    'End Sub

    'Private Sub buscarMenu(text As String, item As ToolStripMenuItem, ByRef tsCustomMenu As ToolStrip)

    '    For Each otroItem As ToolStripMenuItem In item.DropDownItems
    '        If TypeOf otroItem Is ToolStripMenuItem Then
    '            If otroItem.DropDownItems.Count > 0 Then
    '                buscarMenu(otroItem.Text, otroItem, tsCustomMenu)
    '            Else
    '                If text = otroItem.Text Then
    '                    tsCustomMenu.Items.Add(otroItem.Text, otroItem.Image, AddressOf otroItem.PerformClick)
    '                    Dim t As ToolStripItem = findToolStripItem(otroItem.Text, tsCustomMenu)
    '                    AddHandler t.MouseMove, AddressOf frmGui.tsmToTrash_MouseDown
    '                End If
    '            End If
    '        End If
    '    Next
    'End Sub

    Private Function findToolStripItem(ByVal text As String, tool As ToolStrip) As ToolStripItem
        For Each t As ToolStripItem In tool.Items
            If t.Text = text Then
                Return t
            End If
        Next
        Return Nothing
    End Function

    Sub reportarError(ByRef frm As GUImain, Optional external As Boolean = False)
        Dim Pant As New BasesParaCompatibilidad.Pantalla
        Dim img As Bitmap

        If external Then
            img = Pant.capturarPantallaEntera(frm)
        Else
            img = Pant.capturarPantalla(frm)
        End If

        Dim frmReporteErrores As New frmReporteErrores(img)

        If external Then
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmReporteErrores)
        Else
            añadirPestañaAutonoma(frmReporteErrores)
        End If
    End Sub

    Function comprobarNotificaciones(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return notificador.comprobarNotificaciones(dtb)
    End Function

    Function comprobarNumeroPedidos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Return notificador.comprobarNumeroPedidos(dtb)
    End Function

    Function comprobarNumeroOC(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Return notificador.comprobarNumeroOC(dtb)
    End Function

    Sub ayuda(url As String)
        Try
            Process.Start("FireFox.exe", url)
        Catch exc As Exception
            Try
                Process.Start(New System.Diagnostics.ProcessStartInfo("Chrome", url))
            Catch ex As Exception
                MessageBox.Show("Se necesita un navegador moderno para visualizar la ayuda. " & Environment.NewLine & _
                        "Visita una de las siguientes páginas:" & Environment.NewLine & _
                        "http://www.mozilla.org/es-ES/firefox/" & Environment.NewLine & _
                        "http://www.google.es/intl/es/chrome/" & Environment.NewLine, _
                        "Navegador desactualizado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Try
    End Sub

End Class
