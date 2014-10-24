Public Class frmEntPaletsContenidosMonodosis
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable, PaletContenido
    Private m_DBO_PaletsContenidos As DBO_PaletsContenidos
    Public Shadows Event afterSave(sender As System.Object, e As System.EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private spContenidos As New spPaletsContenidos
    Private monodosis As Monodosis
    Private palet As Palet
    'pedir linea, tipoforamto, fecha envasado o dboFormato y dboEnvasado y linea
    Private mLinea As Integer
    Private mTipoFormatoEnvasadoID As Integer
    'Private mFecha As Date
    Private envasado As Integer
    Private mTerminado As Boolean

    Public ReadOnly Property Completado As Boolean Implements PaletContenido.Completado
        Get
            If Me.txtCantidadCajas.Text = "" Then Return False
            If Not IsNumeric(Me.txtCantidadCajas.Text) Then Return False

            Return palet.Cajas_restantes <= CInt(Me.txtCantidadCajas.Text)
        End Get
    End Property
    'Public ReadOnly Property Terminado As Boolean
    '    Get
    '        Return Me.mTerminado
    '    End Get
    'End Property

    'Public WriteOnly Property Linea As Integer
    '    Set(value As Integer)
    '        Me.mLinea = value
    '    End Set
    'End Property

    'Public WriteOnly Property Tipo_formato_envasado As Integer
    '    Set(value As Integer)
    '        Me.mTipoFormatoEnvasadoID = value
    '    End Set
    'End Property

    'Public WriteOnly Property Fecha_envasado As Date
    '    Set(value As Date)
    '        Me.mFecha = value
    '    End Set
    'End Property

    Public WriteOnly Property Formato As Integer
        Set(value As Integer)
            Me.m_DBO_PaletsContenidos.id_formatoEnvasado = value
        End Set
    End Property

    Public Sub New(ByVal lineaEnvasado As Integer, ByVal tipoformato As Integer, ByVal envasado As Integer, ByVal modoDeApertura As String, Optional ByRef v_sp As spPaletsContenidos = Nothing, Optional ByRef v_dbo As DBO_PaletsContenidos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spPaletsContenidos, v_sp)
        m_DBO_PaletsContenidos = If(v_dbo Is Nothing, New DBO_PaletsContenidos, v_dbo)
        dbo = m_DBO_PaletsContenidos
        spContenidos = New spPaletsContenidos
        palet = New Palet(Me.m_DBO_PaletsContenidos.PaletProducidoID)
        Me.mLinea = lineaEnvasado
        Me.mTipoFormatoEnvasadoID = tipoformato
        'Me.mFecha = fechaEnvasado
        Me.envasado = envasado
        Me.monodosis = New Monodosis
    End Sub

    Public Sub New(ByVal lineaEnvasado As Integer, ByVal tipoformato As Integer, ByVal envasado As Integer)
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spPaletsContenidos, New DBO_PaletsContenidos)
        InitializeComponent()
        spContenidos = New spPaletsContenidos
        palet = New Palet(Me.m_DBO_PaletsContenidos.PaletProducidoID)
        Me.mLinea = lineaEnvasado
        Me.mTipoFormatoEnvasadoID = tipoformato
        'Me.mFecha = fechaEnvasado
        Me.envasado = envasado
        Me.monodosis = New Monodosis
    End Sub

    Private Sub frmEntPaletsContenidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lCajasSuperiores.Visible = False
        palet.recuperar_datos(dtb)
        Me.spContenidos.cargarComboDetallesMonodosis(Me.cboMonodosis, Me.mTipoFormatoEnvasadoID, dtb)
        Dim spPalet As New spPaletsProducidos
        Me.Text = Me.Text & "contenido para SSCC " & spPalet.Select_Record(Me.m_DBO_PaletsContenidos.PaletProducidoID, dtb).SCC
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_PaletsContenidos = CType(dbo, DBO_PaletsContenidos)

        If Me.ModoDeApertura = INSERCION Or Me.ModoDeApertura = frmPaletsProducidos.COMPLETAR Then
            'dtpHoraInicio.Value = New DateTime(datetime.now.Year, datetime.now.Month, datetime.now.Day, datetime.now.Hour, datetime.now.Minute, datetime.now.Second)


            txtCantidadCajas.Text = palet.Cajas_restantes.ToString
            dtpHoraInicio.Value = Me.spContenidos.ultima_hora(Me.mLinea, Me.envasado, dtb) 'm_DBO_PaletsContenidos.HoraInicio

            Dim minutos As Integer = CInt(Me.spContenidos.devolver_media_creacion_contenidos(Me.mLinea, Me.mTipoFormatoEnvasadoID, dtb))
            dtpHoraFin.Value = dtpHoraInicio.Value.AddMinutes(minutos)

            'If dtpHoraInicio.Value.Day <> Me.mFecha.Day Then
            '    messageBox.show("El siguiente contenido debe envasarse en nuevo Lote.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'No se permiten mas contenidos hoy")
            '    Me.Close()
            'End If
        Else
            dtpHoraInicio.Text = m_DBO_PaletsContenidos.HoraInicio.ToString
            dtpHoraFin.Text = m_DBO_PaletsContenidos.HoraFin.ToString
            txtCantidadCajas.Text = m_DBO_PaletsContenidos.CantidadCajas.ToString           
        End If

        txtObservaciones.Text = m_DBO_PaletsContenidos.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty

        m_DBO_PaletsContenidos.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Date.Hour, dtpHoraInicio.Value.Date.Minute, 0)
        m_DBO_PaletsContenidos.HoraFin = New TimeSpan(dtpHoraFin.Value.Date.Hour, dtpHoraFin.Value.Date.Minute, 0)

        If dtpHoraInicio.Value > dtpHoraFin.Value Then
            errores = errores & "La hora de inicio no puede ser mayor que fin." & Environment.NewLine()
        Else
            If Not Me.spContenidos.ValidarRangoHorario(Me.m_DBO_PaletsContenidos, Me.mLinea, dtb) Then
                errores = errores & "La hora de produccion se suporpone con la de otro palet." & Environment.NewLine()
            End If
        End If

        If Not IsNumeric(txtCantidadCajas.Text) Or txtCantidadCajas.Text = "" Then
            If errores = "" Then txtCantidadCajas.Focus()
            errores = errores & "El campo CantidadCajas debe ser numérico." & Environment.NewLine()
        Else
            m_DBO_PaletsContenidos.CantidadCajas = System.Convert.ToInt32(txtCantidadCajas.Text)
        End If

        m_DBO_PaletsContenidos.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_PaletsContenidos
            Return True
        Else
            messageBox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Error")
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        If Me.GetValores Then
            dtb.EmpezarTransaccion()


            Try
                If sp.Grabar(dbo, dtb) Then
                    evitarCerrarSinGuardar = False
                    RaiseEvent afterSave(Me, Nothing)

                    monodosis.añadirMovimientoEncajado(Convert.ToInt32(Me.txtCantidadCajas.Text), Convert.ToInt32(Me.cboMonodosis.SelectedValue), Me.m_DBO_PaletsContenidos.PaletProducidoID, Me.mTipoFormatoEnvasadoID, dtb)

                    Dim indice As Integer = Me.cboMonodosis.SelectedIndex
                    Dim cont As Integer
                    Dim datarow As DataRowView
                    For cont = 0 To cboMonodosis.Items.Count - 1
                        datarow = CType(cboMonodosis.Items(cont), DataRowView)
                        If CType(datarow.Item(4), Integer) = 3 Then indice = indice - 1
                    Next

                    'If Me.cboMonodosis.SelectedIndex > 0 Then
                    '    If indice > 0 Then
                    '        Dim resp As DialogResult = messageBox.show("El palet desde el que se envasa no es el mas antiguo, ¿se han quedado sin cantidad los anteriores?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                    '        If resp = DialogResult.Yes Then
                    '            monodosis.realizarDiferencia(Me.cboMonodosis)
                    '        End If
                    '    End If
                    'Else
                    '    dtb.CancelarTransaccion ()
                    'End If

                    For Each row As DataGridViewRow In Me.dgvMermas.Rows
                        If Not row.Cells("Mover").Value Is Nothing Then
                            If CInt(row.Cells("Mover").Value) > 0 Then
                                monodosis.moverNC(dtb, row.Cells("SCC").Value, row.Cells("Mover").Value)
                            End If
                        End If

                        If CType(row.Cells("Vaciar").Value, Boolean) Then
                            monodosis.realizarDiferencia(row.Cells("SCC").Value, dtb)
                        End If
                    Next

                    dtb.TerminarTransaccion()
                    RaiseEvent afterSave(Me, Nothing)
                    Me.Close()
                Else
                    dtb.CancelarTransaccion()
                End If
            Catch ex As Exception
                dtb.CancelarTransaccion()
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub





    Private Sub cboMonodosis_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMonodosis.SelectedIndexChanged
        If CInt(Me.cboMonodosis.SelectedItem(4)) = 3 Then
            Me.lnoconforme.Visible = True
        Else
            Me.lnoconforme.Visible = False
        End If

        actualizarMermas()
    End Sub

    Private Sub btnMonodosis_Click(sender As System.Object, e As System.EventArgs) Handles btnMonodosis.Click
        Dim mono As New frmContenidosDetallesMonodosis2(Me.mTipoFormatoEnvasadoID)
        mono.ShowDialog()
        Me.cboMonodosis.SelectedValue = mono.id
        actualizarMermas()
    End Sub

    Private Sub actualizarMermas()
        'Me.dgvMermas.Rows.Clear()
        'Dim i As Integer = cboMonodosis.SelectedIndex
        'For cont As Integer = 0 To i
        '    Me.dgvMermas.Rows.Add(New String() {Me.cboMonodosis.Items(cont)(1), if(Me.cboMonodosis.Items(cont)(4) = 3, True, False), True})
        'Next


        Dim sw As Boolean

        For j As Integer = 0 To cboMonodosis.Items.Count - 1
            sw = False

            For Each row As DataGridViewRow In Me.dgvMermas.Rows
                If row.Cells("SCC").Value.ToString = cboMonodosis.Items(j)(1).ToString Then
                    If j > cboMonodosis.SelectedIndex Then
                        Me.dgvMermas.Rows.Remove(row)
                    Else
                        sw = True
                    End If
                End If
            Next

            If j <= cboMonodosis.SelectedIndex Then If Not sw Then Me.dgvMermas.Rows.Add(New String() _
                {Me.cboMonodosis.Items(j)(1), If(Convert.IsDBNull(Me.cboMonodosis.Items(j)(5)), "0", Me.cboMonodosis.Items(j)(5)), True})
        Next

        Me.dgvMermas.Refresh()
    End Sub

    Private Sub frmEntPaletsContenidosMonodosis_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me.SplitMermas.Panel1)
    End Sub

    Private Sub txtCantidadCajas_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCantidadCajas.TextChanged
        Try
            If Convert.ToInt32(txtCantidadCajas.Text) > if(Me.ModoDeApertura = INSERCION, Me.palet.Cajas_restantes, Me.palet.Cajas_restantes + Me.m_DBO_PaletsContenidos.CantidadCajas) Then
                Me.mTerminado = False
                Me.lCajasSuperiores.Visible = True
            Else
                Me.mTerminado = True
                Me.lCajasSuperiores.Visible = False
            End If
        Catch ex As Exception
            messageBox.show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
