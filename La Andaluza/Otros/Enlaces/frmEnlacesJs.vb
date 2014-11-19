Public Class frmEnlaces
    Private ejecutar As Boolean


    Private titulo As String
    Private ACtions As Collection
    Private ActiveX As SHDocVw.WebBrowser_V1

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal titulo As String, ByVal link As String, Optional ByVal acciones As Collection = Nothing)
        InitializeComponent()

        Me.ActiveX = Me.WebBrowser1.ActiveXInstance
        AddHandler Me.ActiveX.NewWindow, AddressOf NuevaVentana
        ' Me.WebBrowser1.Navigate("http://localhost:81/new-window-test.html")

        Me.ACtions = acciones
        ejecutar = True
        cargar(titulo, link)


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If Me.WebBrowser1.DocumentTitle = "" Then
            Me.Text = titulo
        Else
            Me.Text = Me.WebBrowser1.DocumentTitle
        End If
        Me.WebBrowser1.Document.Focus()

        If ejecutar Then
            Dim cs As New BasesParaCompatibilidad.Consola

            For Each ob As String In Me.ACtions
                cs.Teclea(ob, True)
            Next

            ejecutar = False

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

    Private Sub NuevaVentana(URL As String,
                              Flags As Integer,
                              TargetFrameName As String,
                              ByRef PostData As Object,
                              Headers As String,
                              ByRef Processed As Boolean)
        Processed = True
        System.Threading.SynchronizationContext.Current.Post(AddressOf NavigateOnNewWindow, URL)
    End Sub

    Private Sub NavigateOnNewWindow(url As Object)
        Me.ActiveX.Navigate(url.ToString())
    End Sub
End Class