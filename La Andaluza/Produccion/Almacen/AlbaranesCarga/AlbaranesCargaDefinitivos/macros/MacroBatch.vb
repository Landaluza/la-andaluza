Public Class MacroBatch
    Public Const ERROR_CONECTANDO As Byte = 1
    Public Const ERROR_TECLEANDO As Byte = 2
    Public Const ERROR_DESCONECTANDO As Byte = 3
    Public Const CORRECTO As Byte = 0

    Private operaciones As Collection
    Private sender As MacroSender
    Public ReadOnly Property OperacionesMacro As Collection
        Get
            Return operaciones
        End Get
    End Property
    Public Sub New()
        operaciones = New Collection
        Me.sender = New MacroSender
    End Sub

    Public Sub Add(ByVal TextoBuscar As String, ByVal fila As Integer, ByVal columna As Integer, ByVal textoIntroducir As String)
        Me.operaciones.Add(New MacroOperation(TextoBuscar, fila, columna, textoIntroducir))
    End Sub
    Public Function run() As Byte
        If Not Me.sender.conectar() Then
            'MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Exit Function
            Return ERROR_CONECTANDO
        End If

        My.Computer.Clipboard.Clear()

        For Each operacion As MacroOperation In Me.OperacionesMacro
            If Me.sender.SiExisteTextoTeclea(operacion.TextoBuscar, operacion.fila, operacion.columna, operacion.pulsacion) Then
                'MessageBox.Show("No se pudo enviar las pulsaciones", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Exit Function
                Return ERROR_TECLEANDO
            End If
        Next

        If Not Me.sender.desconectar() Then
            'MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Exit Function
            Return ERROR_DESCONECTANDO
        End If

        Return CORRECTO
    End Function
End Class
