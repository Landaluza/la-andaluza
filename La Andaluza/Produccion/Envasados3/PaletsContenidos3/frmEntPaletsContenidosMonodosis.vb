Imports BasesParaCompatibilidad.dtpExtension

Public Class frmEntPaletsContenidosMonodosis
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable, PaletContenido
    Private m_DBO_PaletsContenidos As DBO_PaletsContenidos
    Public Shadows Event afterSave(sender As System.Object, e As System.EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
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

    Public WriteOnly Property Formato As Integer
        Set(value As Integer)
            Me.m_DBO_PaletsContenidos.id_formatoEnvasado = value
        End Set
    End Property

    Public Sub New(ByVal lineaEnvasado As Integer, ByVal tipoformato As Integer, ByVal envasado As Integer, ByVal modoDeApertura As String, Optional ByRef v_sp As spPaletsContenidos = Nothing, Optional ByRef v_dbo As DBO_PaletsContenidos = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spPaletsContenidos, v_sp)
        m_DBO_PaletsContenidos = If(v_dbo Is Nothing, New DBO_PaletsContenidos, v_dbo)
        dbo = m_DBO_PaletsContenidos
        spContenidos = New spPaletsContenidos
        palet = New Palet(Me.m_DBO_PaletsContenidos.PaletProducidoID)
        Me.mLinea = lineaEnvasado
        Me.mTipoFormatoEnvasadoID = tipoformato
        Me.envasado = envasado
        Me.monodosis = New Monodosis

        Me.dtpHoraInicio.activarFoco()
        Me.dtpHoraInicio.activarFoco()
    End Sub

    'Public Sub New(ByVal lineaEnvasado As Integer, ByVal tipoformato As Integer, ByVal envasado As Integer)
    '    MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spPaletsContenidos, New DBO_PaletsContenidos)
    '    InitializeComponent()
    '    spContenidos = New spPaletsContenidos
    '    palet = New Palet(Me.m_DBO_PaletsContenidos.PaletProducidoID)
    '    Me.mLinea = lineaEnvasado
    '    Me.mTipoFormatoEnvasadoID = tipoformato
    '    Me.envasado = envasado
    '    Me.monodosis = New Monodosis
    'End Sub

    Private Sub frmEntPaletsContenidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lCajasSuperiores.Visible = False
        palet.recuperar_datos(dtb)
        Me.spContenidos.cargarComboDetallesMonodosis(Me.cboMonodosis, Me.mTipoFormatoEnvasadoID, dtb)
        Dim spPalet As New spPaletsProducidos
        Me.Text = Me.Text & "contenido para SSCC " & spPalet.Select_Record(Me.m_DBO_PaletsContenidos.PaletProducidoID, dtb).SCC
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_PaletsContenidos = CType(dbo, DBO_PaletsContenidos)


        If Me.ModoDeApertura = INSERCION Or Me.ModoDeApertura = frmPaletsProducidos.COMPLETAR Then

            txtCantidadCajas.Text = palet.Cajas_restantes.ToString
            dtpHoraInicio.Value = Me.spContenidos.ultima_hora(Me.mLinea, Me.envasado, dtb) 'm_DBO_PaletsContenidos.HoraInicio

            Dim minutos As Integer = CInt(Me.spContenidos.devolver_media_creacion_contenidos(Me.mLinea, Me.mTipoFormatoEnvasadoID, dtb))
            dtpHoraFin.Value = dtpHoraInicio.Value.AddMinutes(minutos)

        Else
            dtpHoraInicio.Text = m_DBO_PaletsContenidos.HoraInicio.ToString
            dtpHoraFin.Text = m_DBO_PaletsContenidos.HoraFin.ToString
            txtCantidadCajas.Text = m_DBO_PaletsContenidos.CantidadCajas.ToString
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
            If dtb Is Nothing Then dtb = Me.dtb
            dtb.EmpezarTransaccion()
            Try
                If Not sp.Grabar(dbo, dtb) Then
                    Throw New Exception("Error al guardar el contenido")
                End If
                evitarCerrarSinGuardar = False

                Dim spFe As New spFormatosEnvasados
                Dim dbpFe As DBO_FormatosEnvasados
                Dim spEnv As New spEnvasados
                Dim dboEnv As DBO_Envasados
                dbpFe = spFe.Select_Record(Me.m_DBO_PaletsContenidos.id_formatoEnvasado, dtb)
                dboEnv = spEnv.Select_Record(dbpFe.EnvasadoID, dtb)

                monodosis.añadirMovimientoEncajado(Me.m_DBO_PaletsContenidos.HoraFin, dboEnv.Fecha, Convert.ToInt32(Me.txtCantidadCajas.Text), Convert.ToInt32(Me.cboMonodosis.SelectedValue), Me.m_DBO_PaletsContenidos.PaletProducidoID, Me.mTipoFormatoEnvasadoID, dtb)

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
                '    BasesParaCompatibilidad.BD.CancelarTransaccion()
                'End If
                If Not dgvMermas.CurrentCell Is Nothing Then
                    dgvMermas.EndEdit()
                    For Each row As DataGridViewRow In Me.dgvMermas.Rows
                        If Not row.Cells("Mover").Value Is Nothing Then
                            If CInt(row.Cells("Mover").Value) > 0 Then
                                If Not monodosis.moverNC(dboEnv.Fecha, Me.m_DBO_PaletsContenidos.HoraFin, dtb, row.Cells("SCC").Value, row.Cells("Mover").Value) Then
                                    Throw New Exception("Error al guardar las no conformidades")
                                End If
                            End If
                        End If

                        If CType(row.Cells("Vaciar").Value, Boolean) = True Then
                            If Not monodosis.realizarDiferencia(dboEnv.Fecha, Me.m_DBO_PaletsContenidos.HoraFin, row.Cells("SCC").Value, dtb) Then
                                Throw New Exception("Error al guardar la diferencia")
                            End If
                        End If
                    Next
                End If

                dtb.TerminarTransaccion()
                RaiseEvent afterSave(Me, Nothing)
                Me.Close()

            Catch ex As Exception
                dtb.CancelarTransaccion()
                If Not dgvMermas.CurrentCell Is Nothing Then dgvMermas.BeginEdit(True)
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close() ' retirar deespues de adecuarlo para poder tener reintentos
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

        If mono.id <> 0 Then
            Me.cboMonodosis.SelectedValue = mono.id
            actualizarMermas()
        End If
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
                {Me.cboMonodosis.Items(j)(1), If(Convert.IsDBNull(Me.cboMonodosis.Items(j)(5)), "0", Me.cboMonodosis.Items(j)(5)), False})
        Next

        Me.dgvMermas.Refresh()
    End Sub

    Private Sub frmEntPaletsContenidosMonodosis_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me.SplitMermas.Panel1)
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

            row.Cells("Vaciar").Value = Me.chbVaciar.Checked
        Next
    End Sub
End Class
