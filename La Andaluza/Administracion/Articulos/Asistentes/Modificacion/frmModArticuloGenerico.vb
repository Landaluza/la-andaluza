Public Class frmModArticuloGenerico
    inherits BasesParaCompatibilidad.DetailedSimpleForm

    Private m_dbo_articulos1 As DBO_Articulos1
    Private frmGeneral As frmWstepArticulos1
    Private frmExtras As frmModDetExtras
    Private frmDetalle As frmModDetalle
    Public Shadows Event afterSave()
    Public Sub New(ByVal articuloid As Integer)

        InitializeComponent()
        Dim spArticulos1 As New spArticulos1

        Me.m_dbo_articulos1 = spArticulos1.Select_Record(articuloid)
        Me.frmGeneral = New frmWstepArticulos1(m_dbo_articulos1.ID)
        Me.frmDetalle = New frmModDetalle(m_dbo_articulos1.ID, m_dbo_articulos1.ArticuloTpoID)
        Me.frmExtras = New frmModDetExtras(articuloid, m_dbo_articulos1.ArticuloTpoID)

        AddHandler frmExtras.actualizarDatos, AddressOf frmDetalle.actualizarDatos
        AddHandler frmDetalle.actualizarExtras, AddressOf frmExtras.refrescar

        Engine_LA.FormEnPestaña(frmExtras, Me.slGeneral_Extras.Panel2)
        Engine_LA.FormEnPestaña(frmGeneral, Me.slGeneral_detalles.Panel1)

        If Me.frmDetalle.Enabled Then
            Engine_LA.FormEnPestaña(Me.frmDetalle, Me.slGeneral_detalles.Panel2)

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

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing)

        'Dim retorno As Boolean = True
        'BasesParaCompatibilidad.BD.EmpezarTransaccion()

        'Try
        '    If Me.frmGeneral.comprobarCampos Then

        '        If Not Me.slGeneral_detalles.Panel2Collapsed Then

        '            If Me.frmDetalle.comprobarCampos() Then
        '                retorno = retorno And Me.frmGeneral.grabarDatos

        '                retorno = retorno And Me.frmDetalle.grabarDatos()

        '                If retorno Then
        '                    BasesParaCompatibilidad.BD.TerminarTransaccion()
        '                    Me.Close()
        '                Else
        '                    BasesParaCompatibilidad.BD.CancelarTransaccion()
        '                    messagebox.show("Ocurrio un error al grabar el registro.","", MessageBoxButtons.OK, MessageBoxIcon.Error )
        '                End If
        '            Else
        '                BasesParaCompatibilidad.BD.CancelarTransaccion()
        '            End If

        '        Else

        '            If Me.frmGeneral.grabarDatos() Then
        '                BasesParaCompatibilidad.BD.TerminarTransaccion()
        '                Me.Close()
        '            Else
        '                BasesParaCompatibilidad.BD.CancelarTransaccion()
        '                messagebox.show("Ocurrio un error al grabar el registro.","", MessageBoxButtons.OK, MessageBoxIcon.Error )
        '            End If
        '        End If
        '    Else
        '        BasesParaCompatibilidad.BD.CancelarTransaccion()
        '    End If
        'Catch ex As Exception
        '    BasesParaCompatibilidad.BD.CancelarTransaccion()
        '    messagebox.show("Ocurrio un error al grabar el registro. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        Dim retorno As Boolean = True
        Dim comprobado As Boolean = True

        If Not Me.frmGeneral.comprobarCampos Then
            comprobado = False
        Else
            If Not Me.slGeneral_detalles.Panel2Collapsed Then
                If Not Me.frmDetalle.comprobarCampos() Then comprobado = False
            End If
        End If

        If comprobado Then
            BasesParaCompatibilidad.BD.EmpezarTransaccion()
            Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)

            If Not Me.slGeneral_detalles.Panel2Collapsed Then
                retorno = retorno And Me.frmGeneral.grabarDatos(dtb)

                retorno = retorno And Me.frmDetalle.grabarDatos()

                If retorno Then
                    BasesParaCompatibilidad.BD.TerminarTransaccion()
                    RaiseEvent afterSave()
                    Me.Close()
                Else
                    BasesParaCompatibilidad.BD.CancelarTransaccion()
                    MessageBox.Show("Ocurrio un error al grabar el registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else

                If Me.frmGeneral.grabarDatos(dtb) Then
                    BasesParaCompatibilidad.BD.TerminarTransaccion()
                    RaiseEvent afterSave()
                    Me.Close()
                Else
                    BasesParaCompatibilidad.BD.CancelarTransaccion()
                    MessageBox.Show("Ocurrio un error al grabar el registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub tsbEstructura_Click(sender As System.Object, e As System.EventArgs) Handles tsbEstructura.Click
        Dim frm As New frmModCompuestoPorMAM(129)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub
End Class