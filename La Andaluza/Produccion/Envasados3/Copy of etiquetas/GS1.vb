Public Class GS1
    Public Codigo1 As String
    Public Codugo2 As String
    'Public control As String

    Public Const FNC1 As String = "È"

    Public ReadOnly Property SSCC As String
        Get
            Return FNC1 & Codigo1 & Codugo2
        End Get
    End Property


    Public ReadOnly Property Empresa As String
        Get
            Dim lote As String = Codugo2
            If lote.Length Mod 2 <> 0 Then
                Dim lot1 As String = lote.Substring(0, lote.Length - 1)
                Dim lot2 As String = lote.Substring(lote.Length - 1, 1)
                lote = lot1 & "B" & lot2
            End If

            Return FNC1 & Codigo1 & lote
        End Get
    End Property
End Class
