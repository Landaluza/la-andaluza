Public Class MacroOperation

    Public TextoBuscar As String
    Public fila As Integer
    Public columna As Integer
    Public pulsacion As String

    Public Sub New(Buscar As String, fila As Integer, col As Integer, pulsacion As String)
        Me.fila = fila
        Me.columna = col
        Me.pulsacion = pulsacion
        Me.TextoBuscar = Buscar
    End Sub
End Class
