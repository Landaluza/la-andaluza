Public Class MacroSender
    Private TiempoEspera As Integer
    Private Respuesta As DialogResult
    Private oMensajesQS As Object
    Private oQS As Object
    Public Property TiempoDeEspera As Integer
        Set(value As Integer)
            TiempoEspera = value
        End Set
        Get
            Return TiempoEspera
        End Get
    End Property

    Public ReadOnly Property Mensaje As Object
        Get
            Return oMensajesQS
        End Get
    End Property

    Public ReadOnly Property QS As Object
        Get
            Return oQS
        End Get
    End Property
    Public Sub New()
        TiempoEspera = 600
    End Sub

    Public Function conectar() As Boolean
        Try
            oQS = CreateObject("PCOMM.autECLPS")
            oQS.SetConnectionByName("A")
            oMensajesQS = CreateObject("PCOMM.autECLOIA")
            oMensajesQS.SetconnectionByName("A")

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function desconectar() As Boolean
        Try
            oQS.StopCommunication()
            oMensajesQS.StopCommunication()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function espera() As Boolean
        Return CType(oMensajesQS.WaitForInputReady(TiempoEspera), Boolean)
    End Function

    Public Sub Enviar(ByVal cadena As String)
        oQS.SendKeys(cadena)
    End Sub
    Public Function SiExisteTextoTeclea(ByVal Texto As String, ByVal Row As Integer, ByVal Col As Integer, ByVal Teclas As String) As Boolean
        'Dim Len As String = Texto.Length
        Dim cont As Integer = 0
        While Not (CBool(oQS.WaitForStringInRect(Texto, Row, Col, Row, (Col + Texto.Length), TiempoEspera)))
            cont += 1

            If cont >= 100 Then
                Respuesta = MsgBox(" No encuentro " & Texto & " en la linea " & Row.ToString & Chr(13) & "Verificar el problema." & Chr(13) & "¿Paramos la macro?", _
                            MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                            " ¿Verificación? ")

                If Respuesta = MsgBoxResult.Yes Then
                    Return True
                Else
                    cont = 0
                End If
            End If
        End While

        oQS.SendKeys(Teclas)
        Return False

    End Function

    'Public Function SiExisteTextoTecleaEnvasado(ByVal Texto As String, ByVal Row As Integer, ByVal Col As Integer, ByVal Teclas As String) As Boolean
    '    'Dim Len As String = Texto.Length
    '    Try
    '        If Not (oQS.WaitForStringInRect(Texto, Row, Col, Row, (Col + Texto.Length), TiempoEspera)) Then
    '            Respuesta = MessageBox.Show(" No encuentro " & Texto & " en la linea " & Convert.ToString(Row) & Environment.NewLine & "Verificar el problema." & Environment.NewLine & "¿Paramos la macro?", _
    '                        "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '            If Respuesta = DialogResult.Yes Then
    '                Return True
    '            Else
    '                If (oMensajesQS.WaitForInputReady(TiempoEspera)) Then
    '                    oQS.SendKeys(Teclas)
    '                    Return False
    '                Else
    '                    Respuesta = MessageBox.Show("Hay un error esperando en QS." & Environment.NewLine & "Pulsa sobre la ventana de QS y usa la tecla [Control]" & Environment.NewLine & "¿Paramos la macro?", _
    '                        "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '                    If Respuesta = DialogResult.Yes Then
    '                        Return True
    '                    Else
    '                        If (oMensajesQS.WaitForInputReady(TiempoEspera)) Then
    '                            oQS.SendKeys(Teclas)
    '                            Return False
    '                        Else
    '                            Respuesta = MessageBox.Show("Sigue existiendo un error esperando en QS." & Environment.NewLine & "Pulsa sobre la ventana de QS y usa la tecla [Control]" & Environment.NewLine & "¿Paramos la macro?", _
    '                                        "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '                            If Respuesta = DialogResult.Yes Then
    '                                Return True
    '                            Else
    '                                If (oMensajesQS.WaitForInputReady(TiempoEspera)) Then
    '                                    oQS.SendKeys(Teclas)
    '                                    Return False
    '                                Else
    '                                    MessageBox.Show("Sigue existiendo un error esperando en QS." & Environment.NewLine & "La macro se detiene", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                                    Return True
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            End If
    '        Else
    '            oQS.SendKeys(Teclas)
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Return True
    '    End Try
    'End Function
End Class
