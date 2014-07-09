Public Class frmEntPaletsContenidos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable, PaletContenido
    Private m_DBO_PaletsContenidos As DBO_PaletsContenidos
    Public Shadows Event afterSave(sender As System.Object, e As System.EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private spContenidos As New spPaletsContenidos
    Private palet As Palet    
    Private mLinea As Integer
    Private mTipoFormatoEnvasadoID As Integer
    'Private mFecha As Date
    Private mTerminado As Boolean
    Private envasado As Integer

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

    Public WriteOnly Property Formato As Integer
        Set(value As Integer)
            Me.m_DBO_PaletsContenidos.id_formatoEnvasado = value
        End Set
    End Property

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
    End Sub

    Private Sub frmEntPaletsContenidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lCajasSuperiores.Visible = False
        palet.recuperar_datos()

        
        Dim spPalet As New spPaletsProducidos
        Me.Text = Me.Text & "contenido para SSCC " & spPalet.Select_Record(Me.m_DBO_PaletsContenidos.PaletProducidoID).SCC
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_PaletsContenidos = dbo

        If Me.ModoDeApertura = INSERCION Or Me.ModoDeApertura = frmPaletsProducidos.COMPLETAR Then
            'dtpHoraInicio.Value = New DateTime(datetime.now.Year, datetime.now.Month, datetime.now.Day, datetime.now.Hour, datetime.now.Minute, datetime.now.Second)
           

            txtCantidadCajas.Text = palet.Cajas_restantes.ToString
            dtpHoraInicio.Value = Me.spContenidos.ultima_hora(Me.mLinea, Me.envasado) 'm_DBO_PaletsContenidos.HoraInicio

            Dim minutos As Integer = CInt(Me.spContenidos.devolver_media_creacion_contenidos(Me.mLinea, Me.mTipoFormatoEnvasadoID))
            dtpHoraFin.Value = dtpHoraInicio.Value.AddMinutes(minutos)

            'If dtpHoraInicio.Value.Day <> Me.mFecha.Day Then
            '    messageBox.show("El siguiente contenido debe envasarse en nuevo Lote.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'No se permiten mas contenidos hoy")
            '    Me.Close()
            'End If
        Else
            txtCantidadCajas.Text = m_DBO_PaletsContenidos.CantidadCajas.ToString
            dtpHoraInicio.Value = DateTime.Now.Add(m_DBO_PaletsContenidos.HoraInicio)
            dtpHoraFin.Value = DateTime.Now.Add(m_DBO_PaletsContenidos.HoraFin)
        End If

        txtObservaciones.Text = m_DBO_PaletsContenidos.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_PaletsContenidos.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        m_DBO_PaletsContenidos.HoraFin = New TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0)

        If dtpHoraInicio.Value > dtpHoraFin.Value Then
            errores = errores & "La hora de inicio no puede ser mayor que fin." & Environment.NewLine()
        Else
            If Not Me.spContenidos.ValidarRangoHorario(Me.m_DBO_PaletsContenidos, Me.mLinea) Then
                errores = errores & "La hora de produccion se suporpone con la de otro palet." & Environment.NewLine()
            End If
        End If

        Dim i As Integer = 0
        If Not Integer.TryParse(txtCantidadCajas.Text, i) Or txtCantidadCajas.Text = "" Then
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

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        If Me.GetValores Then
            Try
                If sp.Grabar(dbo, trans) Then
                    evitarCerrarSinGuardar = False
                    RaiseEvent afterSave(Me, Nothing)

                    Me.Close()
                Else
                    MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("No se pudo guardar el registro. Detalles:" & Environment.NewLine() & Environment.NewLine(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub frmEntPaletsContenidos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.Panel1, Me)
        'If Me.ModoDeApertura = frmPaletsProducidos.COMPLETAR Then
        '    Me.Text.Replace("Ver ", "")
        '    Me.butGuardar.Visible = True
        'End If
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
