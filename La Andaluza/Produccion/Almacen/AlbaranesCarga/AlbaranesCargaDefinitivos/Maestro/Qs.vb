Namespace AlbaranesCarga

    Public Class Qs
        Private macrosender As MacroAdapter.MacroSender
        Public Sub New()
        End Sub
        Public Sub SalidaJR(ByRef acumulados As DataGridViewRowCollection, ByRef totales As DataGridViewRowCollection)

            macrosender = New MacroAdapter.MacroSender

            Try
                If Not Me.macrosender.conectar() Then
                    MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                My.Computer.Clipboard.Clear()
                'Enviar las pulsaciones de teclas a la aplicación
                If macrosender.SiExisteTextoTeclea("Area Comercial", 8, 8, "13[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Venta y Facturación", 10, 8, "14[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Albaranes", 8, 8, "13[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Albarán", 3, 2, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Pedido", 4, 3, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Cliente", 4, 2, "1000002[tab][enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Dirección Envío", 4, 22, "[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Almacén", 10, 1, "10[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Serie", 10, 54, "E") Then Return
                If macrosender.SiExisteTextoTeclea("Negociación", 15, 2, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
                If macrosender.SiExisteTextoTeclea("Tarifa", 11, 2, "[enter]") Then Return

                For Each m_Row As DataGridViewRow In acumulados
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("CodigoQS").Value.ToString & "[tab]") Then Return
                    If macrosender.SiExisteTextoTeclea("Cantidad", 20, 6, m_Row.Cells("Cajas").Value.ToString & "[tab][enter]") Then Return

                    'Precio:
                    If macrosender.SiExisteTextoTeclea("Precio", 21, 52, "[enter][enter]") Then Return

                    'Lote:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter]") Then Return
                    If macrosender.SiExisteTextoTeclea("Texto", 21, 15, "L-" & m_Row.Cells("Lote").Value.ToString & "[enter]") Then Return
                Next

                For Each m_Row As DataGridViewRow In totales
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "462599120[tab]") Then Return
                    If macrosender.SiExisteTextoTeclea("Cantidad", 20, 6, m_Row.Cells("Cantidad").Value.ToString & "[tab][enter]") Then Return

                    'Precio:
                    If macrosender.SiExisteTextoTeclea("Precio", 21, 52, "[enter][enter]") Then Return
                Next

                Dim Respuesta As DialogResult = MessageBox.Show(" ¿Todo correcto?", " ¿Verificación ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If Not macrosender.espera Then
                    MessageBox.Show("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If Not macrosender.espera Then
                    MessageBox.Show("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If Respuesta = DialogResult.Yes Then
                    'Pulsar F20 para grabar:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                    'Tipo de porte:
                    If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab]N[enter]") Then Return
                    If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
                    'Pulsar F5 para imprimir
                    If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                    'Volver pantalla principal
                    If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3][pf12][pf12]") Then Return


                Else
                    'Volver a la pantalla principal
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][enter][pf12][pf12][pf12][pf3][pf12][pf12]") Then Return

                End If
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                macrosender.desconectar()
                macrosender = Nothing
            Catch ex As Exception

            End Try
        End Sub


        Public Sub EntradaJR(ByRef acumulados As DataGridViewRowCollection, ByRef totales As DataGridViewRowCollection)
            'QS.EntradaJR(dgvTotalPalets, dgvAcumulados)
            'http://publib.boulder.ibm.com/infocenter/pcomhelp/v5r9/index.jsp?topic=/com.ibm.pcomm.doc/books/html/host_access08.htm

            macrosender = New MacroAdapter.MacroSender

            Try
                If Not Me.macrosender.conectar() Then
                    MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                My.Computer.Clipboard.Clear()
                Dim Albaran As String = InputBox("Introduce numero de albaran", "Albaran")

                If macrosender.espera Then
                    macrosender.Enviar("[pf3][enter]")
                Else
                    MessageBox.Show("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    macrosender.Enviar("[pf3][enter]")
                End If

                If macrosender.SiExisteTextoTeclea("Usuario", 6, 17, "JEREZ999[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Contraseña", 7, 17, "JEREZ[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Ventas", 6, 8, "[pf1]") Then Return
                If macrosender.SiExisteTextoTeclea("Conexión a Empresa", 19, 32, "999[enter][enter]") Then Return
                If macrosender.SiExisteTextoTeclea("J.R. SABATER", 1, 31, "21[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Número Albarán", 3, 2, Albaran) Then Return
                If macrosender.SiExisteTextoTeclea("Número Albarán", 3, 2, "[tab]5000427[tab][enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Pedido", 5, 10, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Almacén", 7, 1, "40[tab][enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Tarifa", 8, 2, "[enter]") Then Return

                For Each m_Row As DataGridViewRow In acumulados
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("CodigoQS").Value.ToString & "[tab][tab]") Then Return
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("Cajas").Value.ToString & "[tab]") Then Return

                    Dim medida As String
                    Select Case m_Row.Cells("CodigoQS").Value.ToString
                        Case Is = 116001302.ToString, 117001302.ToString, 116607375.ToString
                            medida = "4"
                        Case Is = 462599120.ToString
                            medida = "8"
                        Case Is = 198174302.ToString
                            medida = "15"
                        Case Is = 170267375.ToString, 170167375.ToString, 170367375.ToString, 150166302.ToString, 150218375.ToString, 150318375.ToString
                            medida = "16"
                        Case Else
                            Medida = (InputBox("Introduce Medida", "Medida"))
                    End Select

                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, Medida & "[tab][enter]") Then Return

                    'Precio:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter][enter]") Then Return

                    'Lote:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter][enter][enter]") Then Return
                    If macrosender.SiExisteTextoTeclea("Texto", 21, 15, "L-" & m_Row.Cells("Lote").Value.ToString & "[enter]") Then Return
                Next

                For Each m_Row As DataGridViewRow In totales
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "462599120[tab][tab]") Then Return
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("Cantidad").Value.ToString & "[tab][enter]") Then Return

                    'Precio:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter][enter]") Then Return
                Next

                Dim Respuesta As DialogResult = MessageBox.Show(" ¿Todo correcto?", " ¿Verificación ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If Not macrosender.espera Then
                    MessageBox.Show("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If Not macrosender.espera Then
                    MessageBox.Show("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If Respuesta = DialogResult.Yes Then
                    'Pulsar F20 para grabar:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                    'Tipo de porte:
                    If macrosender.SiExisteTextoTeclea("Tipo", 7, 2, "N[enter]") Then Return
                    'Pulsar F5 para imprimir
                    If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                    'Volver pantalla principal
                    If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3]") Then Return
                Else
                    'Volver a la pantalla principal
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][enter][pf12][pf12][pf12][pf3][pf12][pf12]") Then Return
                End If

            Catch ex As Exception
                If ex.Message = "ECLErr object is unable to load error message number 37130, reason code 0.(Session error)" Then
                    MessageBox.Show("Hay un problema al crear en enlace con QS", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If macrosender.espera Then
                        MessageBox.Show("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End Try

            Try
                macrosender.desconectar()
                macrosender = Nothing
            Catch ex As Exception

            End Try
        End Sub


        Public Sub butJRaMercadona_Click(ByVal remolque As String, ByVal conductor As String, ByVal dni As String)
            ' QS.JR_a_Mercadona(txtRemolque1.Text, txtConductor.Text, txtDNI.Text)

            macrosender = New MacroAdapter.MacroSender
            Dim Pedido As String
            Dim Transportista As String
            Dim Matricula As String
            Dim Chofer As String
            Dim Fecha As String

            Try

                Pedido = InputBox("Introduce numero de pedido", "Pedido")


                If Not Me.macrosender.conectar() Then
                    MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                My.Computer.Clipboard.Clear()

                If macrosender.espera Then
                    macrosender.Enviar("[pf3][enter]")
                Else
                    MessageBox.Show("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    macrosender.Enviar("[pf3][enter]")
                End If

                If macrosender.SiExisteTextoTeclea("Usuario", 6, 17, "JEREZ999[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Contraseña", 7, 17, "JEREZ[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Ventas", 6, 8, "[pf1]") Then Return
                If macrosender.SiExisteTextoTeclea("Conexión a Empresa", 19, 32, "999[enter][enter]") Then Return
                If macrosender.SiExisteTextoTeclea("J.R. SABATER", 1, 31, "11[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Albarán", 3, 2, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Pedido", 4, 3, Pedido + "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Cliente", 4, 2, "[enter][enter]") Then Return


                Dim Respuesta As DialogResult
                Respuesta = MessageBox.Show(" ¿Hay que pulsar F23?", " ¿F23 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Respuesta = DialogResult.Yes Then
                    'Pulsar F23 para continuar
                    If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
                End If

                Respuesta = MessageBox.Show(" ¿Todo correcto?", " ¿Verificación ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If Not macrosender.espera Then
                    MessageBox.Show("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If Not macrosender.espera Then
                    MessageBox.Show("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If Respuesta = DialogResult.Yes Then
                    'Pulsar F20 para grabar:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                    'Tipo de porte:
                    If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab][tab]") Then Return

                    'Envio:Tiene que pedir la compañia que carga - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES) 
                    Transportista = InputBox("Introduce Transportista", "Transportista")
                    Transportista = Transportista + Space(20)
                    Transportista = Transportista.ToString.Substring(0, 20)
                    If macrosender.SiExisteTextoTeclea("Envio", 8, 37, Transportista) Then Return

                    'Matricula: Tiene que pedirla - OJO CON EL TAMAÑO DEL HUECO (8 POSICIONES)
                    Matricula = remolque
                    Matricula = Matricula + Space(8)
                    Matricula = Matricula.ToString.Substring(0, 8)
                    If macrosender.SiExisteTextoTeclea("Matrícula", 9, 2, Matricula) Then Return

                    'Chofer: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES)
                    Chofer = conductor
                    Chofer = Chofer + Space(20)
                    Chofer = Chofer.ToString.Substring(0, 20)
                    If macrosender.SiExisteTextoTeclea("Chofer", 9, 24, Chofer) Then Return

                    'DNI: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (15 POSICIONES)
                    dni = dni + Space(15)
                    dni = dni.ToString.Substring(0, 15)
                    If macrosender.SiExisteTextoTeclea("DNI", 9, 55, dni) Then Return

                    'Descarga: Tiene que poner la fecha de hoy
                    Fecha = System.DateTime.Today.ToString
                    If macrosender.SiExisteTextoTeclea("Descarga", 10, 2, Fecha + "[enter]") Then Return

                    Respuesta = MessageBox.Show(" ¿Hay que pulsar F23?", " ¿F23 ", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    If Respuesta = DialogResult.Yes Then
                        'Pulsar F23 para continuar
                        If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
                    End If

                    'If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then return
                    'Pulsar F5 para imprimir
                    If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                    'Volver pantalla principal
                    If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3]") Then Return

                Else
                    'Volver a la pantalla principal
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][pf12][pf12][pf3]") Then Return


                End If

                Try
                    macrosender.desconectar()
                    macrosender = Nothing
                Catch ex As Exception

                End Try
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Sub butLAaJR_Click(ByVal remolque As String, ByVal conductor As String, ByVal dni As String, ByRef acumulados As DataGridViewRowCollection)
            macrosender = New MacroAdapter.MacroSender
            '''QS.AlbaranJR(txtRemolque1.Text, txtConductor.Text, txtDNI.Text, dgvAcumulados)

            Dim Matricula As String
            Dim Chofer As String
            Dim Fecha As String
            Dim PrecioPorte As Double = 400 '352.8
            Dim PesoBruto As Double
            Dim PrecioKilo As Double

            Try
                If Not Me.macrosender.conectar() Then
                    MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                My.Computer.Clipboard.Clear()
                'Enviar las pulsaciones de teclas a la aplicación
                If macrosender.SiExisteTextoTeclea("Area Comercial", 8, 8, "13[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Venta y Facturación", 10, 8, "14[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Albaranes", 8, 8, "13[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Albarán", 3, 2, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Pedido", 4, 3, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Cliente", 4, 2, "1000002[tab][enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Dirección Envío", 4, 22, "[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Almacén", 10, 1, "10[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Serie", 10, 54, "E") Then Return
                If macrosender.SiExisteTextoTeclea("Negociación", 15, 2, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
                If macrosender.SiExisteTextoTeclea("Tarifa", 11, 2, "[enter]") Then Return

                Dim Respuesta As DialogResult

                For Each m_Row As DataGridViewRow In acumulados
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("CodigoQS").Value.ToString & "[tab]") Then Return
                    If macrosender.SiExisteTextoTeclea("Cantidad", 20, 6, m_Row.Cells("Cajas").Value.ToString & "[tab][enter]") Then Return

                    Respuesta = MessageBox.Show(" ¿Hay existencias suficientes?", " ¿Hay existencias ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If Respuesta <> DialogResult.Yes Then
                        'Pulsar F23 para continuar
                        If macrosender.SiExisteTextoTeclea("No hay existencias", 24, 2, "[pf23]") Then Return

                    End If

                    'Precio:
                    If macrosender.SiExisteTextoTeclea("Precio", 21, 52, "[enter][enter]") Then Return

                    'Lote:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter]") Then Return
                    If macrosender.SiExisteTextoTeclea("Texto", 21, 15, "L-" & m_Row.Cells("Lote").Value.ToString & "[enter]") Then Return
                Next

                MessageBox.Show("Introducir palets manualmente. Pulsa Aceptar para continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                respuesta = MessageBox.Show(" ¿Todo correcto?", " ¿Verificación ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If Not macrosender.espera Then
                    MessageBox.Show("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                If Not macrosender.espera Then
                    MessageBox.Show("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If



                If Respuesta = DialogResult.Yes Then

                    'Pulsar F20 para grabar:
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                    'Tipo de porte:
                    If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab]P[tab]") Then Return

                    'Envio:Tiene que pedir la compañia que carga - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES) 
                    If macrosender.SiExisteTextoTeclea("Envio", 8, 37, "FUENTES E HIJOS[tab]") Then Return

                    'Matricula: Tiene que pedirla - OJO CON EL TAMAÑO DEL HUECO (8 POSICIONES)
                    Matricula = remolque
                    Matricula = Matricula + Space(8)
                    Matricula = Matricula.ToString.Substring(0, 8)
                    If macrosender.SiExisteTextoTeclea("Matrícula", 9, 2, Matricula) Then Return

                    'Chofer: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES)
                    Chofer = conductor
                    Chofer = Chofer + Space(20)
                    Chofer = Chofer.ToString.Substring(0, 20)
                    If macrosender.SiExisteTextoTeclea("Chofer", 9, 24, Chofer) Then Return

                    'DNI: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (15 POSICIONES)                    
                    dni = dni + Space(15)
                    dni = dni.ToString.Substring(0, 15)
                    If macrosender.SiExisteTextoTeclea("DNI", 9, 55, dni) Then Return

                    'Descarga: Tiene que poner la fecha de hoy
                    Fecha = System.DateTime.Today.ToString
                    If macrosender.SiExisteTextoTeclea("Descarga", 10, 2, Fecha + "[tab][tab]") Then Return

                    'Precio Kilo: OJO SOLO PUEDE CONTENER 5 DoubleES
                    PesoBruto = InputBox("Introduce Peso bruto", "Peso bruto")
                    PrecioKilo = Format(PrecioPorte / PesoBruto, "#0.#0000")
                    If macrosender.SiExisteTextoTeclea("Precio", 11, 3, PrecioKilo.ToString + "[tab][enter]") Then Return
                    'El precio Kilo es lo que da dividir el precio acordado (352,80) entre el peso neto en QS


                    Respuesta = MessageBox.Show(" ¿Hay que pulsar F23?", " ¿F23 ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If Respuesta = DialogResult.Yes Then
                        'Pulsar F23 para continuar
                        If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
                    End If
                    'If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then return

                    'Pulsar F5 para imprimir
                    If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                    'Volver pantalla principal
                    If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3][pf12][pf12]") Then Return


                Else
                    'Volver a la pantalla principal
                    If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][enter][pf12][pf12][pf12][pf3][pf12][pf12]") Then Return

                End If


            Catch ex As Exception
                MessageBox.Show("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                macrosender.desconectar()
                macrosender = Nothing
            Catch ex As Exception

            End Try
        End Sub


    End Class
End Namespace
