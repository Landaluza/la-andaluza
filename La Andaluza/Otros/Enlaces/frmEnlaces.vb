Public Class frmEnlaces
    Private titulo As String
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal titulo As String, ByVal link As String, Optional ByVal parametros As String = "")
        InitializeComponent()

        cargar(titulo, link, parametros)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If Me.WebBrowser1.DocumentTitle = "" Then
            Me.Text = titulo
        Else
            Me.Text = Me.WebBrowser1.DocumentTitle
        End If
    End Sub

    Public Sub cargar(ByVal titulo As String, ByVal link As String, Optional ByVal parametros As String = "")
        Me.titulo = titulo

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