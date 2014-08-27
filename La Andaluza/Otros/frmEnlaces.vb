Public Class frmEnlaces

    Public Sub New(ByVal link As String)
        InitializeComponent()
        Me.WebBrowser1.Navigate(link)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.Text = Me.WebBrowser1.DocumentTitle
    End Sub
End Class