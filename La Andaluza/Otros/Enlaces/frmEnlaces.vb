Public Class frmEnlaces

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
    End Sub
    Public Sub New(ByVal link As String, Optional ByVal parametros As String = "")
        InitializeComponent()


        cargar(link, parametros)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.Text = Me.WebBrowser1.DocumentTitle
    End Sub

    Public Sub cargar(ByVal link As String, Optional ByVal parametros As String = "")
        If parametros = "" Then
            Me.WebBrowser1.Navigate(link)
        Else
            'Dim postdata As String = "txtLogin=asdasd&txtClave=asdas&Aceptar=Aceptar"
            Dim a As New System.Text.ASCIIEncoding()
            Dim byte1 As Byte() = a.GetBytes(parametros)

            Me.WebBrowser1.Navigate(link, "_self", byte1, "Content-Type: application/x-www-form-urlencoded" & Environment.NewLine)
        End If
    End Sub
End Class