Public Class GS1
    Public Codigo1 As String
    Public Codugo2 As String
    Public control As String

    Public Const FNC1 As String = "È"

    Public ReadOnly Property SSCC As String
        Get
            Return FNC1 & Codigo1 & control & Codugo2
        End Get
    End Property

    Public ReadOnly Property Empresa As String
        Get
            Return FNC1 & Codigo1 & Codugo2
        End Get
    End Property
End Class
