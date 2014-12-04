Imports BasesParaCompatibilidad.dtpExtension

Public Class frmEntPaletsContenidosDoypack
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable, PaletContenido
    Private m_DBO_PaletsContenidos As DBO_PaletsContenidos
    Public Shadows Event afterSave(sender As Object, e As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private monodosis As Monodosis 'DispensadorMonodosis
    Private cbo_collection As Collection
    Private spContenidos As New spPaletsContenidos
    Private palet As Palet
    Private mLinea As Integer
    Private mTipoFormatoEnvasadoID As Integer
    Private envasado As Integer
    Private mTerminado As Boolean
    Private mFormatoEnvasadoID As Integer

    Public ReadOnly Property Completado As Boolean Implements PaletContenido.Completado
        Get
            If Me.txtCantidadCajas.Text = "" Then Return False
            If Not IsNumeric(Me.txtCantidadCajas.Text) Then Return False

            Return palet.Cajas_restantes <= CInt(Me.txtCantidadCajas.Text)
        End Get
    End Property


    Public WriteOnly Property Fuentes As Collection
        Set(value As Collection)
            Me.cbo_collection = value
        End Set
    End Property

    Public WriteOnly Property Formato As Integer
        Set(value As Integer)
            Me.m_DBO_PaletsContenidos.id_formatoEnvasado = value
        End Set
    End Property

    Public Sub New(ByVal formatoEnvasado As Integer, ByVal lineaEnvasado As Integer, ByVal tipoformato As Integer, ByVal envasado As Integer, ByVal modoDeApertura As String, Optional ByRef v_sp As spPaletsContenidos = Nothing, Optional ByRef v_dbo As DBO_PaletsContenidos = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()

        sp = If(v_sp Is Nothing, New spPaletsContenidos, v_sp)
        m_DBO_PaletsContenidos = If(v_dbo Is Nothing, New DBO_PaletsContenidos, v_dbo)
        dbo = m_DBO_PaletsContenidos

        Me.monodosis = New Monodosis 'New DispensadorMonodosis
        spContenidos = New spPaletsContenidos

        palet = New Palet(Me.m_DBO_PaletsContenidos.PaletProducidoID)

        Me.mLinea = lineaEnvasado
        Me.mTipoFormatoEnvasadoID = tipoformato
        Me.envasado = envasado
        Me.mFormatoEnvasadoID = formatoEnvasado

        Me.dtpHoraInicio.activarFoco()
        Me.dtpHoraFin.activarFoco()
    End Sub


    Private Sub frmEntPaletsContenidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.monodosis.CargarMonodosis(Me.PanDoypack, Me.mTipoFormatoEnvasadoID, dtb, Me)
        Me.dgvMermas.Rows.Clear()
        Me.lCajasSuperiores.Visible = False
        palet.recuperar_datos(dtb)

        Dim spPalet As New spPaletsProducidos
        Me.Text = Me.Text & "contenido para SSCC " & spPalet.Select_Record(Me.m_DBO_PaletsContenidos.PaletProducidoID, dtb).SCC
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_PaletsContenidos = dbo

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
            txtCantidadCajas.Text = m_DBO_PaletsContenidos.CantidadCajas
        End If
        txtObservaciones.Text = m_DBO_PaletsContenidos.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        m_DBO_PaletsContenidos.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        m_DBO_PaletsContenidos.HoraFin = New TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0)

        If dtpHoraInicio.Value > dtpHoraFin.Value Then
            errores = errores & "La hora de inicio no puede ser mayor que fin." & Environment.NewLine()
        Else
            If Not Me.spContenidos.ValidarRangoHorario(Me.m_DBO_PaletsContenidos, Me.mLinea, Me.envasado, dtb) Then
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
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Error")
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        If Me.GetValores Then
            Dim cbo As System.Windows.Forms.ComboBox
            If dtb Is Nothing Then dtb = Me.dtb
            dtb.EmpezarTransaccion()
            Try


                If Not sp.Grabar(dbo, dtb) Then
                    Throw New Exception("Error al guardar el contenido")
                End If

                evitarCerrarSinGuardar = False
                'RaiseEvent afterSave()
                Dim spFe As New spFormatosEnvasados
                Dim dbpFe As DBO_FormatosEnvasados
                Dim spEnv As New spEnvasados
                Dim dboEnv As DBO_Envasados
                dbpFe = spFe.Select_Record(Me.m_DBO_PaletsContenidos.id_formatoEnvasado, dtb)
                dboEnv = spEnv.Select_Record(dbpFe.EnvasadoID, dtb)

                For Each cbo In Me.cbo_collection                    
                    monodosis.añadirMovimientoEncajado(Me.m_DBO_PaletsContenidos.HoraFin, dboEnv.Fecha, Convert.ToInt32(Me.txtCantidadCajas.Text), Convert.ToInt32(cbo.SelectedValue), Me.m_DBO_PaletsContenidos.PaletProducidoID, Me.mTipoFormatoEnvasadoID, dtb, cbo.Tag, True)

                    'Dim indice As Integer = Me.cboMonodosis.SelectedIndex
                    'Dim cont As Integer
                    'Dim datarow As DataRowView
                    'For cont = 0 To cboMonodosis.Items.Count - 1
                    '    datarow = CType(cboMonodosis.Items(cont), DataRowView)
                    '    If CType(datarow.Item(4), Integer) = 3 Then indice = indice - 1
                    'Next

                    'If Me.cboMonodosis.SelectedIndex > 0 Then
                    '    If indice > 0 Then
                    '        Dim resp As DialogResult = messageBox.show("El palet desde el que se envasa no es el mas antiguo, ¿se han quedado sin cantidad los anteriores?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                    '        If resp = DialogResult.Yes Then
                    '            monodosis.realizarDiferencia(Me.cboMonodosis)
                    '        End If
                    '    End If
                    'Else
                    '    BasesParaCompatibilidad.BD.CancelarTransaccion()
                    'End If

                    If Not dgvMermas.CurrentCell Is Nothing Then

                        dgvMermas.EndEdit()
                        For Each row As DataGridViewRow In Me.dgvMermas.Rows
                            'If (Not row.Cells("Mover").Value Is Nothing) Then
                            '    If CInt(row.Cells("Mover").Value) <> 0 Then
                            '        monodosis.moverNC(row.Cells("SCC").Value, row.Cells("Mover").Value, BasesParaCompatibilidad.BD.transaction)
                            '    End If
                            'End If

                            If (CType(row.Cells("Vaciar").Value, Boolean) = True) Then
                                If Not monodosis.realizarDiferencia(dboEnv.Fecha, Me.m_DBO_PaletsContenidos.HoraFin, row.Cells("SCC").Value, dtb) Then
                                    Throw New Exception("Error al gaurdar las diferencias")
                                End If
                            End If
                        Next

                    End If

                Next

                dtb.TerminarTransaccion()
                RaiseEvent afterSave(Me, Nothing)
                Me.Close()

            Catch ex As Exception
                dtb.CancelarTransaccion()
                If Not dgvMermas.CurrentCell Is Nothing Then dgvMermas.BeginEdit(True)
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    'Public Sub cargarMermasCombo()
    '    For Each cbo As ComboBox In Me.cbo_collection
    '        Dim i As Integer = cbo.Items.Count

    '        For cont As Integer = 0 To i
    '            Me.dgvMermas.Rows.Add(New String() {cbo.Items(cont)(1), If(cbo.Items(cont)(4).ToString = "3", True, False), True, cbo.Items(cont)(5), cbo.Items(cont)(6)})
    '        Next
    '    Next
    'End Sub

    Public Sub actualizarMermas(ByVal cbobject As System.Object, ByVal e As System.EventArgs)
        Dim cbo As ComboBox = cbobject
        monodosis.cboDoypack_SelectedValueChanged(cbo, e)
        Dim sw As Boolean
        Dim cad As String

        For j As Integer = 0 To cbo.Items.Count - 1
            sw = False

            For Each row As DataGridViewRow In Me.dgvMermas.Rows
                cad = cbo.Items(j)(1).ToString
                If row.Cells("SCC").Value.ToString = cad Then
                    If j > cbo.SelectedIndex Then
                        Me.dgvMermas.Rows.Remove(row)
                    Else
                        sw = True
                    End If
                End If
            Next


            If j <= cbo.SelectedIndex Then If Not sw Then Me.dgvMermas.Rows.Add(New String() {cbo.Items(j)(1), cbo.Items(j)(5), False, "", cbo.Items(j)(6)})
        Next

        Me.dgvMermas.Refresh()

    End Sub



    Private Sub frmEntPaletsContenidosDoypack_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.Panel1, Me.SplitDoypack.Panel1)
    End Sub

    Private Sub txtCantidadCajas_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCantidadCajas.TextChanged
        Try
            If Convert.ToInt32(txtCantidadCajas.Text) > If(Me.ModoDeApertura = INSERCION, Me.palet.Cajas_restantes, Me.palet.Cajas_restantes + Me.m_DBO_PaletsContenidos.CantidadCajas) Then
                Me.mTerminado = False
                Me.lCajasSuperiores.Visible = True
            Else
                Me.mTerminado = True
                Me.lCajasSuperiores.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chbVaciar_CheckedChanged(sender As Object, e As EventArgs) Handles chbVaciar.CheckedChanged
        For Each row As DataGridViewRow In Me.dgvMermas.Rows

            row.Cells("Vaciar").Value = chbVaciar.Checked
        Next
    End Sub
End Class
