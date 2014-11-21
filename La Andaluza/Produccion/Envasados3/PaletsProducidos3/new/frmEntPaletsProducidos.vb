Public Class frmEntPaletsProducidos
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable

    Public Shadows Event afterSave(sender As System.Object, e As System.EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_PaletsProducidos As DBO_PaletsProducidos
    Private frmPaletsContenidos As frmPaletsContenidos
    Private mLinea As Integer
    Private mTipoFormatoEnvasadoID As Integer
    'Private mFecha As Date
    Private envasado As Integer
    'Private frmEtiqueta As frmEtiqueta0
    Private etiqueta As etiquetas.Etiqueta

    Public WriteOnly Property Linea As Integer
        Set(value As Integer)
            Me.mLinea = value
        End Set
    End Property

    Public WriteOnly Property Tipo_formato_envasado As Integer
        Set(value As Integer)
            Me.mTipoFormatoEnvasadoID = value
        End Set
    End Property

    'Public WriteOnly Property Fecha_envasado As Date
    '    Set(value As Date)
    '        Me.mFecha = value
    '    End Set
    'End Property


    Public Sub New(ByVal lineaEnvasado As Integer, ByVal tipoformato As Integer, ByVal envasado As Integer, ByVal modoDeApertura As String, Optional ByRef v_sp As spPaletsProducidos = Nothing, Optional ByRef v_dbo As DBO_PaletsProducidos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spPaletsProducidos, v_sp)
        m_DBO_PaletsProducidos = If(v_dbo Is Nothing, New DBO_PaletsProducidos, v_dbo)
        dbo = m_DBO_PaletsProducidos
        Me.mLinea = lineaEnvasado
        Me.mTipoFormatoEnvasadoID = tipoformato
        'Me.mFecha = fechaEnvasado
        Me.envasado = envasado


        If Me.ModoDeApertura = INSERCION Then
            dtb.EmpezarTransaccion()
            Try
                'Me.m_DBO_PaletsProducidos = dbo
                GetValores()
                dtb.PrepararConsulta("PaletsProducidos3GetMaxSCC")
                Me.m_DBO_PaletsProducidos.SCC = dtb.Consultar().Rows(0).Item(0)
                dbo = m_DBO_PaletsProducidos
                If sp.Grabar(dbo, dtb) Then
                    evitarCerrarSinGuardar = False
                    'RaiseEvent afterSave(Me, Nothing)

                    Dim spPaletsProducidos As New spPaletsProducidos
                    Me.m_DBO_PaletsProducidos.ID = spPaletsProducidos.devolver_ultimo_palet(dtb)
                    Me.m_DBO_PaletsProducidos = spPaletsProducidos.Select_Record(Me.m_DBO_PaletsProducidos.ID, dtb)

                    dtb.TerminarTransaccion()
                    ' Me.ModoDeApertura = MODIFICACION
                    'SetValores()
                    dbo = Me.m_DBO_PaletsProducidos
                Else
                    Me.m_DBO_PaletsProducidos.ID = 0
                    dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudo grabar el palet. Si el problema persiste reportelo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            Catch ex As Exception
                Me.m_DBO_PaletsProducidos.ID = 0
                dtb.CancelarTransaccion()
                MessageBox.Show("No se pudo grabar el palet. Si el problema persiste reportelo.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End Try
        End If



        Me.frmPaletsContenidos = New frmPaletsContenidos(Me.mLinea, Me.mTipoFormatoEnvasadoID, Me.envasado, m_DBO_PaletsProducidos.ID)
        AddHandler frmPaletsContenidos.completado, AddressOf Me.contenido_completo
        etiqueta = New etiquetas.Etiqueta(0, BasesParaCompatibilidad.Config.connectionString)
    End Sub

    'Public Sub New(ByVal lineaEnvasado As Integer, ByVal tipoformato As Integer, ByVal fechaEnvasado As Date)
    '    MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spPaletsProducidos, New DBO_PaletsProducidos)
    '    InitializeComponent()
    '    Me.mLinea = lineaEnvasado
    '    Me.mTipoFormatoEnvasadoID = tipoformato
    '    Me.mFecha = fechaEnvasado
    '    Me.frmPaletsContenidos = Nothing 'New frmPaletsContenidos(Me.mLinea, Me.mTipoFormatoEnvasadoID, Me.mFecha)
    'End Sub

    Private Sub frmEntPaletsProducidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetValores()

        Me.frmPaletsContenidos.Palet = m_DBO_PaletsProducidos.ID
        frmPaletsContenidos.Formato = m_DBO_PaletsProducidos.FormatoID


        Engine_LA.FormEnPestaña(Me.frmPaletsContenidos, Me.Panel2)

        Dim spTipoFormato As New spFormatosArticulos
        Me.Text = Me.Text & "palet " & Me.m_DBO_PaletsProducidos.SCC & ", " & spTipoFormato.Select_Record(Me.mTipoFormatoEnvasadoID, dtb).Descripcion
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores

        'Me.m_DBO_PaletsProducidos = dbo


        txtScc.Text = m_DBO_PaletsProducidos.SCC
        txtObservacionesPalets.Text = m_DBO_PaletsProducidos.ObservacionesPalets
        chbTerminado.Checked = m_DBO_PaletsProducidos.Terminado
        chbMultilote.Checked = m_DBO_PaletsProducidos.Multilote
        chbalamcen.checked = m_DBO_PaletsProducidos.EnAlmacen
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        m_DBO_PaletsProducidos.ObservacionesPalets = txtObservacionesPalets.Text

        m_DBO_PaletsProducidos.Terminado = chbTerminado.Checked

        m_DBO_PaletsProducidos.Multilote = chbMultilote.Checked

        If Me.ModoDeApertura = INSERCION Then
            m_DBO_PaletsProducidos.EnAlmacen = True
            m_DBO_PaletsProducidos.Id_Estado = 4
        Else
            m_DBO_PaletsProducidos.EnAlmacen = chbalamcen.Checked
        End If

        If errores = String.Empty Then
            dbo = m_DBO_PaletsProducidos
            Return True
        Else
            messageBox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Error")
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        If dtb Is Nothing Then
            MyBase.Guardar(Me.dtb)
        Else
            MyBase.Guardar(dtb)
        End If
    End Sub

    Private Sub frmEntPaletsProducidos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If Me.m_DBO_PaletsProducidos.ID = Nothing Then
            MessageBox.Show("No se ha podido crear el palet, vuelva a intentarlo en unos segundos", "Error guardando el palet", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        'Ya estarian lso datos grabados, solo resta abrir la ventana de añadir cotenido para comodidad del envasado
        If Me.ModoDeApertura = INSERCION Then
            Me.ModoDeApertura = MODIFICACION
            Me.frmPaletsContenidos.Insertar()
        End If
    End Sub


    Private Sub frmEntPaletsProducidos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If Not checkar_contenidos() Then
        '    e.Cancel = True
        'End If
        If Me.frmPaletsContenidos.Contenidos < 1 Then
            Dim msg As New frmSinContenidos

            Dim resp As DialogResult = BasesParaCompatibilidad.Pantalla.mostrarDialogo(msg)
            If resp = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True

            ElseIf resp = Windows.Forms.DialogResult.OK Then
                If Me.txtObservacionesPalets.Text = "" Then Me.txtObservacionesPalets.Text = "Generado sin contenidos por usuario " & Config.UserName
                GetValores()
                sp.Grabar(dbo, dtb)
                RaiseEvent afterSave(Nothing, Nothing)
            Else
                Dim s As New spPaletsProducidos
                s.Delete(Me.m_DBO_PaletsProducidos.ID, dtb)
                RaiseEvent afterSave(Nothing, Nothing)
            End If
        Else
            RaiseEvent afterSave(Nothing, Nothing)
        End If
    End Sub


    Private Function checkar_contenidos() As Boolean
        If Me.frmPaletsContenidos.Contenidos < 1 Then
            Dim resp As DialogResult = MessageBox.Show("Esta acción creará un palet vacio (sin contenidos)." & _
                                Environment.NewLine() & Environment.NewLine() & "¿Está seguro de querer continuar?", _
                                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = vbNo Then
                Return False
            Else
                If Me.txtObservacionesPalets.Text = "" Then Me.txtObservacionesPalets.Text = "Generado sin contenidos por usuario " & Config.UserName
                GetValores()
                sp.Grabar(dbo, dtb)
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        Me.txtObservacionesPalets.Text = ""
    End Sub

    Private Sub contenido_completo()
        Me.chbTerminado.Checked = True
        If Me.GetValores Then
            Try
                If sp.Grabar(dbo, dtb) Then
                    evitarCerrarSinGuardar = False
                    'RaiseEvent afterSave(Me, Nothing)
                    Me.Close()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub frmEntPaletsProducidos2_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If Me.chbTerminado.Checked Then
        '    Dim spp As spPaletsProducidos = CType(Me.sp, spPaletsProducidos)

        '    If Not spp.estaEtiquetado(Me.m_DBO_PaletsProducidos.ID) Then
        '        If spp.Etiquetar(Me.m_DBO_PaletsProducidos.ID) Then
        '            'Dim frm As New frmEtiqueta0(Me.m_DBO_PaletProducido.PaletProducidoID, False)
        '            'frm.Show()
        '        Else
        '            MessageBox.Show("No se pudo imprimir la etiqueta, vuelva a intentarlo manualmente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        '    End If
        'End If

        If Me.chbTerminado.Checked Then
            Dim spp As spPaletsProducidos = CType(Me.sp, spPaletsProducidos)

            If Not spp.estaEtiquetado(Me.m_DBO_PaletsProducidos.ID, dtb) Then
                If spPaletsProducidos.esMonodosis(Me.m_DBO_PaletsProducidos.FormatoID, dtb) Then
                    Return
                End If

                If MessageBox.Show("¿Desea imprimir etiqueta?", "Etiqueta palet " & Me.m_DBO_PaletsProducidos.SCC, _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If spp.Etiquetar(Me.m_DBO_PaletsProducidos.ID, dtb) Then
                        'Dim frm As New frmEtiqueta0(Me.m_DBO_PaletsProducidos.ID, False) ', False)
                        'Dim frm As New etiquetas.frmEtiqueta(Me.m_DBO_PaletsProducidos.ID, BasesParaCompatibilidad.Config.connectionString)
                        'frm.Show()
                        etiqueta.id = Me.m_DBO_PaletsProducidos.ID
                        etiqueta.print()
                        etiqueta.print()
                    Else
                        MessageBox.Show("No se pudo imprimir la etiqueta, vuelva a intentarlo manualmente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub
End Class
