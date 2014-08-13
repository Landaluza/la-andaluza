Public Class ListadoBatch
    Inherits MacroBatch
    Public Sub New(ByVal m_fecha As String, ByVal articulo As String)

        Me.Add("Area de Gestión", 7, 8, "12[enter]")
        Me.Add("Gestión de Almacén", 8, 8, "12[enter]")
        Me.Add("Stocks", 14, 43, "35[enter]")
        Me.Add("Almacén", 4, 29, "A")
        Me.Add("Código", 5, 2, "1")
        Me.Add("Información", 6, 9, "0")
        Me.Add("Fecha", 6, 51, m_fecha + "[tab]")
        Me.Add("Valorado", 7, 2, "1[tab]")
        Me.Add("Exist.", 8, 7, "S")
        Me.Add("Negativas", 8, 31, "S")
        Me.Add("Cero", 8, 48, "N")
        Me.Add("Und.Artículo", 9, 3, "2[tab][tab]")
        Me.Add("Almacén", 12, 14, "10[tab]10[tab]")
        Me.Add("Artículo", 13, 13, articulo)
        Me.Add("F3=Finalizar", 23, 2, "[enter][enter]")
        Me.Add("F17=Contraseña", 23, 2, "[pf12][pf12]")

    End Sub
End Class
