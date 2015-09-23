Public Class frmModArticuloGenerico
    Inherits BasesParaCompatibilidad.DetailedSimpleForm

    Private m_dbo_articulos1 As DBO_Articulos1
    Private frmGeneral As frmWstepArticulos1
    Private frmExtras As frmModDetExtras
    Private frmDetalle As frmModDetalle
    Public Shadows Event afterSave()

    Public Sub New(ByVal articuloid As Integer)

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()
        Dim spArticulos1 As New spArticulos1

        Me.m_dbo_articulos1 = spArticulos1.Select_Record(articuloid, dtb)
        Me.frmGeneral = New frmWstepArticulos1(m_dbo_articulos1.ID)
        Me.frmDetalle = New frmModDetalle(m_dbo_articulos1.ID, m_dbo_articulos1.ArticuloTpoID)
        Me.frmExtras = New frmModDetExtras(articuloid, m_dbo_articulos1.ArticuloTpoID)

        AddHandler frmExtras.actualizarDatos, AddressOf frmDetalle.actualizarDatos
        AddHandler frmDetalle.actualizarExtras, AddressOf frmExtras.refrescar
        AddHandler frmGeneral.avisos, AddressOf frmExtras.ver_avisos

        Me.frmDetalle.Dock = DockStyle.Left

        Engine_LA.FormEnPestaña(frmGeneral, Me.slGeneral_detalles.Panel1, False)
        Engine_LA.FormEnPestaña(frmExtras, Me.slGeneral_Extras.Panel2)

        Separator1.Visible = False

        If Me.frmDetalle.Enabled Then
            Engine_LA.FormEnPestaña(Me.frmDetalle, Me.slGeneral_detalles.Panel2, False)

            'If Me.m_dbo_articulos1.ArticuloTpoID = 9 Or Me.m_dbo_articulos1.ArticuloTpoID = 10 Then
            '    'no se puede cambiar la descricpion hasta que articulos secundarios y terciarios esten realacionados. Por los cambios de formato que pueda suponer
            '    Me.tsDescripcion.Visible = True
            'End If
        Else
            Me.slGeneral_detalles.Panel2Collapsed = True
        End If
    End Sub

    Private Sub tsSalir_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    'Private Sub tsDescripcion_Click(sender As System.Object, e As System.EventArgs) Handles tsDescripcion.Click
    '    Dim aux As New frmModDescripcionEnvasado(Me.m_dbo_articulos1)
    '    AddHandler aux.guardado, AddressOf Me.Close
    '    aux.ShowDialog()
    'End Sub

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing)
        Dim retorno As Boolean = True
        Dim comprobado As Boolean = True

        If Not Me.frmGeneral.comprobarCampos Then
            comprobado = False
        Else
            If Not Me.slGeneral_detalles.Panel2Collapsed Then
                If Not Me.frmDetalle.comprobarCampos() Then comprobado = False
            End If
        End If

        Dim terminar As Boolean
        If Not dtb Is Nothing Then
            Me.dtb = dtb
            terminar = False
        Else
            terminar = True
        End If

        If comprobado Then
            If terminar Then Me.dtb.EmpezarTransaccion()
            If Not Me.slGeneral_detalles.Panel2Collapsed Then
                retorno = retorno And Me.frmGeneral.grabarDatos(Me.dtb)
                retorno = retorno And Me.frmDetalle.grabarDatos(Me.dtb)
                If retorno Then
                    If terminar Then Me.dtb.TerminarTransaccion()
                    RaiseEvent afterSave()
                    Me.Close()
                Else
                    If terminar Then
                        Me.dtb.CancelarTransaccion()
                        MessageBox.Show("Ocurrio un error al grabar el registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Throw New Exception("Error 1 al guardar el registro")
                    End If
                End If
            Else
                If Me.frmGeneral.grabarDatos(Me.dtb) Then
                    If terminar Then Me.dtb.TerminarTransaccion()
                    RaiseEvent afterSave()
                    Me.Close()
                Else
                    If terminar Then
                        Me.dtb.CancelarTransaccion()
                        MessageBox.Show("Ocurrio un error al grabar el registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Throw New Exception("Error al guardar los datos genericos")
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub OcultarPanelIzquierdoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OcultarPanelIzquierdoToolStripMenuItem.Click
        Me.slGeneral_detalles.Panel1Collapsed = True
    End Sub

    Private Sub OcultarPanelDerechoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OcultarPanelDerechoToolStripMenuItem.Click
        Me.slGeneral_detalles.Panel2Collapsed = True
    End Sub

    Private Sub MostrarLosDosPanelesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MostrarLosDosPanelesToolStripMenuItem.Click
        Me.slGeneral_detalles.Panel1Collapsed = False
        Me.slGeneral_detalles.Panel2Collapsed = False
    End Sub

    Private Sub OcultarmostrarPanelInferiorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OcultarmostrarPanelInferiorToolStripMenuItem.Click
        If Me.slGeneral_Extras.Panel2Collapsed Then
            Me.slGeneral_Extras.Panel2Collapsed = False
        Else
            Me.slGeneral_Extras.Panel2Collapsed = True
        End If
    End Sub
End Class