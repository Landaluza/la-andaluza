Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmFormatosEnvasados2
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_Envasado As DBO_Envasados2
    Private frmPadre As frmEntEnvasados2
    Public Shared CadenaFormato As String
    Private linea As Integer

    Public Sub New()
        MyBase.New(New spFormatosEnvasados2, 0)
        InitializeComponent()
        init()
    End Sub

    Public Sub New(padre As frmEntEnvasados2)
        MyBase.New(New spFormatosEnvasados2, 0)
        InitializeComponent()
        init()
        Me.frmPadre = padre
    End Sub

    Private Sub init()

        m_Envasado = DBO_Envasados2.Instance
        spSelectDgv = "Envasados4SelectFormatos " & Convert.ToString(m_Envasado.EnvasadoID) & " ," & Convert.ToString(m_Envasado.LineaID)
    End Sub

    Private Sub frmFormatosEnvasados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        butExcel.Visible = True
        butSalir.Visible = False
        butImprimir.Visible = True



        If Not (Config.UserType = 1 Or Config.UserType = 9 Or Config.UserType = 4) Then
            Me.butEliminar.Visible = False
            Me.butEliminar.Enabled = False
        End If
    End Sub

    Overrides Sub Eliminar()
        Try
            Dim response As DialogResult = DialogResult.Cancel
            Dim multiopcion As Boolean
            If CType(sp, spFormatosEnvasados2).isDeleteAllowed(dgvGeneral.CurrentRow.Cells("FormatoEnvasadoID").Value) Then
                response = MessageBox.Show("El formato seleccionado se puede eliminar completamente" & Environment.NewLine & _
                                    "(sus palets estan entre los ultimos 15 producidos o esta vacio)" & Environment.NewLine & _
                                    "¿Eliminar el palet por completo?" & Environment.NewLine & _
                                    "(pulse 'No' para borrar solamente los contenidos de los palets) ", _
                                   "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                multiopcion = True
            Else
                response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                                "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                multiopcion = False
            End If

            If response = DialogResult.Yes And multiopcion Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                CType(sp, spFormatosEnvasados2).DeleteFormatosEnvasados2(dgvGeneral.CurrentRow.Cells("FormatoEnvasadoID").Value, True)
                dgvFill()
            ElseIf (response = DialogResult.No And multiopcion = True) Or (response = DialogResult.Yes And multiopcion = False) Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                CType(sp, spFormatosEnvasados2).DeleteFormatosEnvasados2(dgvGeneral.CurrentRow.Cells("FormatoEnvasadoID").Value, False)
                dgvFill()
            End If

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            MessageBox.Show("Error al eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Overrides Sub Action(ByVal TipoAction As String)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim m_Envasado As DBO_Envasados2 = DBO_Envasados2.Instance
        Dim m_FormatoEnvasado As New DBO_FormatosEnvasados
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If (TipoAction = ACCION_INSERTAR) Then
            If Me.linea = 0 Then
                'messagebox.show("No hay linea seleccionada")
                Try
                    frmPadre.cboLineas.DroppedDown = True
                    frmPadre.cboLineas.Focus()
                Catch ex As Exception
                End Try
            Else
                Dim spAux As New spempleados_formatosEnvasados
                Dim result As DialogResult = DialogResult.OK
                If spAux.hay_empleados_pendientes(Me.m_Envasado.EnvasadoID, Me.linea) Then
                    Dim frm As New frmEntPersonalEnvasadoFinArticulo(Me.m_Envasado.EnvasadoID, Me.linea)
                    frm.ShowDialog()
                    result = frm.resultado
                End If
                If result = DialogResult.OK Then
                    If spAux.hay_empleados_pendientes_dias_anteriores(Me.linea) Then
                        Dim env As Integer = spAux.recuperar_envasado_empleados_pendientes_dias_anteriores(Me.linea)
                        Dim frm As New frmEntPersonalEnvasadoFinArticulo(env, Me.linea)
                        frm.ShowDialog()
                        result = frm.resultado
                    End If

                    If result = DialogResult.OK Then
                        m_FormatoEnvasado.ID = 0
                        m_FormatoEnvasado.TipoFormatoLineaID = Me.linea
                        Dim FrmEnt As New frmEntFormatosEnvasados2(TipoAction, Me.linea)

                        FrmEnt.ShowDialog()
                    End If
                End If
            End If
        ElseIf TipoAction = ACCION_MODIFICAR Then
            Try
                m_Envasado.LineaID = dgvGeneral.CurrentRow.Cells("LineaEnvasadoID").Value
                m_FormatoEnvasado.ID = dgvGeneral.CurrentRow.Cells("FormatoEnvasadoID").Value

                Dim CantidadEnvasada As Integer
                CantidadEnvasada = dgvGeneral.CurrentRow.Cells("Litros").Value

                Dim FrmEnt As New frmEntFormatosEnvasados2(TipoAction, CantidadEnvasada, m_FormatoEnvasado, Me.linea)

                FrmEnt.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Asegurese de seleccionar una fila.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If

        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .Width = 825
                .DataSource = GeneralBindingSource
                .Columns("FormatoEnvasadoID").Visible = False
                .Columns("EnvasadoID").Visible = False
                .Columns("LineaEnvasadoID").Visible = False
                .Columns("Descripcion").Visible = False
                .Columns("TiposFormatoslineas").Visible = False
                .Columns("CodigoQS").Visible = False
                If Config.UserType = 9 Then
                    .FormatoColumna("minutosTotales", "Tiempo", BasesParaCompatibilidad.TiposColumna.Miles, 42)
                Else
                    .Columns("minutosTotales").Visible = False
                End If

                .FormatoColumna("HoraInicio", "Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85)
                .FormatoColumna("HoraFin", "Fin", BasesParaCompatibilidad.TiposColumna.Hora, 85)
                .FormatoColumna("Articulos_envasados", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Min", BasesParaCompatibilidad.TiposColumna.Derecha, 35)
                .FormatoColumna("Veloc", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Efect", BasesParaCompatibilidad.TiposColumna.Double2, 40)
                .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 45)
                .FormatoColumna("Botellas", "Botellas", BasesParaCompatibilidad.TiposColumna.Miles, 54)
                .FormatoColumna("Litros", "Litros", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Palets", BasesParaCompatibilidad.TiposColumna.Derecha, 45)
                .FormatoColumna("Sueltas", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoGeneral()
            End With
        End If

        BindingNavigatorActualizar(dgvGeneral.RowCount)
        If Me.dgvGeneral.RowCount > 0 Then
            butImprimir.Enabled = True
            butImprimir.Visible = True
        Else
            Me.butImprimir.Enabled = False
            Me.butImprimir.Visible = False
        End If
        butVer.Visible = False

    End Sub

    Public Overrides Sub Imprimir()
        Dim cs As New BasesParaCompatibilidad.Consola

        Try
            Dim App As String = "Sesión A"
            'Para puebas con Notepad
            'Dim App As String = "Nuevo Documento"
            Dim Fecha As String
            Dim AlmacenEntrada As String = "10"
            Dim AlmacenSalida As String = "10"
            Dim Operario As String = "1"
            Dim Cantidad As Integer
            Dim CantidadCorrecta As String
            Dim EnvasadosAConfirmar As Integer = 0

            AppActivate(App)
            My.Computer.Clipboard.Clear()

            cs.Espera(300)
            'Enviar las pulsaciones de teclas a la aplicación
            cs.Teclea("15")
            cs.Teclea("42")
            cs.Teclea("44")
            cs.Teclea("~") 'Enter normal ALT +126
            cs.CambioPantalla()

            Dim fechaQS As New BasesParaCompatibilidad.FechaQs
            fechaQS.mam_FechaQS(m_Envasado.Fecha)
            'A fabricar el: INDICAR LA FECHA
            Fecha = fechaQS.mam_FechaQS(m_Envasado.Fecha) 'm_Envasado.Fecha.mam_FechaQS
            cs.Teclea(Fecha)
            cs.Teclea("{TAB}")

            'Dim Respuesta As MsgBoxResult
            'AppActivate("LA")
            'Respuesta = MsgBox(" Continuamos con la macro? ", _
            '                   MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
            '                   " Continuar ")

            'If Respuesta = MsgBoxResult.Yes Then
            '    AppActivate(App)
            'Else

            'End If


            'Almacen de entrada productos
            cs.Teclea(AlmacenEntrada)
            cs.Teclea("{TAB}")

            'Almacen de salida materias primas
            cs.Teclea(AlmacenSalida)
            cs.Teclea("{TAB}")
            cs.Teclea("~") 'Teclado normal

            'Para empezar a insertar articulos
            cs.Teclea("{F6}")

            For Each m_Row As DataGridViewRow In dgvGeneral.Rows
                AppActivate(App)
                cs.Espera(500)
                cs.Teclea(m_Row.Cells("CodigoQS").Value.ToString)
                'MsgBox("Confirma codigo articulo")
                cs.Teclea("~") 'Teclado normal
                EnvasadosAConfirmar += 1

                If m_Row.Cells("Descripcion").Value.ToString.Contains("Monodosis") Then
                    'MsgBox("Monodosis")
                    Cantidad = m_Row.Cells("Cajas").Value / 1000
                Else
                    Cantidad = m_Row.Cells("Cajas").Value
                End If

                Dim Respuesta As MsgBoxResult
                AppActivate("LA")
                Respuesta = MsgBox(" ¿Existe estructura para " & m_Row.Cells("Articulos_envasados").Value.ToString & "?", _
                                    MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                    " Estructura ")

                AppActivate(App)
                If Respuesta = MsgBoxResult.Yes Then

                Else
                    cs.Teclea("{F12}")
                End If

                Dim Respuesta2 As MsgBoxResult
                AppActivate("LA")
                Respuesta2 = MsgBox(" ¿Es la cantidad correcta " & Cantidad & "?", _
                                MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                " Cantidad ")

                If Respuesta2 = MsgBoxResult.Yes Then
                    cs.Espera(500)
                    AppActivate(App)
                    cs.Teclea(Cantidad)
                Else
                    CantidadCorrecta = InputBox("Numero de cajas", "CantidadCorrecta")
                    AppActivate(App)
                    cs.Teclea(CantidadCorrecta)
                End If

                cs.Teclea("{TAB}")
                cs.Teclea("~") 'Teclado normal
                cs.Teclea("~") 'Teclado normal
            Next

            cs.Espera(500)

            'Para acabar de meter articulos
            cs.Teclea("{F12}")

            'PONER UN 1 DELANTE DE CADA LINEA
            Dim Contador As Integer = 0
            For Contador = 0 To EnvasadosAConfirmar + 1
                cs.Teclea("1")
                Contador += 1
            Next
            MsgBox("Comprobar que todas las lineas tienen el 1", MsgBoxStyle.Exclamation)

            'Pulsar F20 para grabar:
            cs.Teclea("+({F8})")

            cs.Teclea("~") 'Teclado normal
            cs.Teclea("~") 'Teclado normal

            cs.Espera(5000)

            'SEGUNDO PASO
            'Enviar las pulsaciones de teclas a la aplicación
            'Teclea("15")
            'Teclea("42")
            cs.Teclea("45")
            cs.Teclea("~") 'Enter normal ALT +126

            'A fabricar el: INDICAR LA FECHA
            cs.Teclea(Fecha)
            cs.Teclea("{TAB}")

            'Operario:
            cs.Teclea(Operario)
            cs.Teclea("{TAB}")
            cs.Teclea("~") 'Teclado normal

            'CambioPantalla()
            'AppActivate("LA")
            'MsgBox("Macro terminada")
            AppActivate(App)
            'HAY QUE PONER LA MISMA CANTIDAD QUE APARECE PARA PODER VALIDARLO
        Catch ex As Exception
            MsgBox("Error al Imprimir. " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Public Overrides Sub Imprimir()
    '    'dgvFill()
    '    Dim cs As New Consola
    '    Dim fechaQS As New fechaQS

    '    Dim App As String
    '    'Para puebas con Notepad
    '    'Dim App As String = "Nuevo Documento"
    '    Dim Fecha As String
    '    Dim AlmacenEntrada As String
    '    Dim AlmacenSalida As String
    '    Dim Operario As String
    '    Dim Cantidad As Integer
    '    Dim CantidadCorrecta As String
    '    Dim EnvasadosAConfirmar As Integer

    '    Try
    '        App = Config.QS_Sesion
    '        AlmacenEntrada = "10"
    '        AlmacenSalida = "10"
    '        Operario = "1"
    '        EnvasadosAConfirmar = 0


    '        AppActivate(App)
    '        My.Computer.Clipboard.Clear()

    '        cs.Espera(300)
    '        'Enviar las pulsaciones de teclas a la aplicación
    '        cs.Teclea("15")
    '        cs.Teclea("42")
    '        cs.Teclea("44")
    '        cs.Teclea("~") 'Enter normal ALT +126
    '        cs.CambioPantalla()

    '        'A fabricar el: INDICAR LA FECHA
    '        Fecha = fechaQS.mam_FechaQS(m_Envasado.Fecha)
    '        cs.Teclea(Fecha)
    '        cs.Teclea("{TAB}")

    '        'Dim Respuesta As DialogResult
    '        'AppActivate(Config.Version_seriada)  'AppActivate("LA ")
    '        'Respuesta = messagebox.show(" Continuamos con la macro? ", _
    '        '                   "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '        '                   " Continuar ")

    '        'If Respuesta = DialogResult.Yes Then
    '        '    AppActivate(App)
    '        'Else

    '        'End If


    '        'Almacen de entrada productos
    '        cs.Teclea(AlmacenEntrada)
    '        cs.Teclea("{TAB}")

    '        'Almacen de salida materias primas
    '        cs.Teclea(AlmacenSalida)
    '        cs.Teclea("{TAB}")
    '        cs.Teclea("~") 'Teclado normal

    '        'Para empezar a insertar articulos
    '        cs.Teclea("{F6}")

    '        For Each m_Row As DataGridViewRow In dgvGeneral.Rows
    '            AppActivate(App)
    '            cs.Espera(500)
    '            cs.Teclea(Convert.ToString(m_Row.Cells("CodigoQS").Value))
    '            'messagebox.show("Confirma codigo articulo")
    '            cs.Teclea("~") 'Teclado normal
    '            EnvasadosAConfirmar += 1

    '            If Convert.ToString(m_Row.Cells("Descripcion").Value).Contains("Monodosis") Then
    '                'messagebox.show("Monodosis")
    '                Cantidad = m_Row.Cells("Cajas").Value / 1000
    '            Else
    '                Cantidad = m_Row.Cells("Cajas").Value
    '            End If

    '            Dim Respuesta As DialogResult
    '            AppActivate(Config.Version_seriada)  'AppActivate("LA ")

    '            Respuesta = MessageBox.Show(" ¿Existe estructura para " & Convert.ToString(m_Row.Cells("Articulos_envasados").Value) & "?", _
    '                                "Estructura", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '            AppActivate(App)
    '            If Respuesta = DialogResult.Yes Then

    '            Else
    '                cs.Teclea("{F12}")
    '            End If

    '            Dim Respuesta2 As DialogResult
    '            AppActivate(Config.Version_seriada)  'AppActivate("LA ")
    '            Respuesta2 = MessageBox.Show(" ¿Es la cantidad correcta " & Cantidad & "?", _
    '                            "Cantidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '            If Respuesta2 = DialogResult.Yes Then
    '                cs.Espera(500)
    '                AppActivate(App)
    '                cs.Teclea(Cantidad)
    '            Else
    '                CantidadCorrecta = InputBox("Numero de cajas", "CantidadCorrecta")
    '                AppActivate(App)
    '                cs.Teclea(CantidadCorrecta)
    '            End If

    '            cs.Teclea("{TAB}")
    '            cs.Teclea("~") 'Teclado normal
    '            cs.Teclea("~") 'Teclado normal
    '        Next

    '        cs.Espera(500)

    '        'Para acabar de meter articulos
    '        cs.Teclea("{F12}")

    '        'PONER UN 1 DELANTE DE CADA LINEA
    '        Dim Contador As Integer = 0
    '        For Contador = 0 To EnvasadosAConfirmar + 1
    '            cs.Teclea("1")
    '            Contador += 1
    '        Next
    '        MessageBox.Show("Comprobar que todas las lineas tienen el 1", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    '        'Pulsar F20 para grabar:
    '        cs.Teclea("+({F8})")

    '        cs.Teclea("~") 'Teclado normal
    '        cs.Teclea("~") 'Teclado normal

    '        cs.Espera(5000)

    '        'SEGUNDO PASO
    '        'Enviar las pulsaciones de teclas a la aplicación
    '        'Teclea("15")
    '        'Teclea("42")
    '        cs.Teclea("45")
    '        cs.Teclea("~") 'Enter normal ALT +126

    '        'A fabricar el: INDICAR LA FECHA
    '        cs.Teclea(Fecha)
    '        cs.Teclea("{TAB}")

    '        'Operario:
    '        cs.Teclea(Operario)
    '        cs.Teclea("{TAB}")
    '        cs.Teclea("~") 'Teclado normal

    '        'CambioPantalla()
    '        'AppActivate(Config.Version_seriada)  'AppActivate("LA ")
    '        'messagebox.show("Macro terminada")
    '        AppActivate(App)
    '        'HAY QUE PONER LA MISMA CANTIDAD QUE APARECE PARA PODER VALIDARLO
    '    Catch ex As Exception
    '        MessageBox.Show("Error al Imprimir. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub




    Overrides Sub Insertar()
        Me.linea = frmPadre.Linea
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.Cursor = Cursors.WaitCursor
        Try
            If Me.butNuevo.Enabled Then
                Action(ACCION_INSERTAR)
            End If
        Catch ex As Exception
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Overrides Sub Modificar()
        Me.linea = frmPadre.Linea
        Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.Cursor = Cursors.WaitCursor
        Try
            If Me.butModificar.Enabled Then Action(ACCION_MODIFICAR)
        Catch ex As Exception
        Finally
            Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
