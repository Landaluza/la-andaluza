Public Class EnlaceChep
    Private frm As frmEnlaces
    Private enlace As String
    Private col As Collection
    Public Sub New()
        enlace = "http://www.chep.com/es/"
        'Dim postdata As String = "txtLogin=jerez999&txtClave=jerez&Aceptar=Aceptar"

        col = New Collection
        col.Add("{TAB}")
        col.Add("{TAB}")
        col.Add("{TAB}")
        col.Add("pp-martinmi")
        col.Add("{TAB}")
        col.Add("12345617")
        col.Add("{ENTER}")

        cargar()
    End Sub

    Public Sub cargar()
        frm = New frmEnlaces("Chep", enlace, col)
        'AddHandler frm.completed, AddressOf terminado
        GUImain.añadirPestaña(frm)
    End Sub

End Class
