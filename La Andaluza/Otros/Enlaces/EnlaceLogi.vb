Public Class EnlaceLogi
    Private frm As frmEnlaces
    Private enlace As String
    Private col As Collection
    Public Sub New()
        enlace = "https://www.logifruit.es/clientes/clientes_ident_dos.php"
        'Dim postdata As String = "txtLogin=jerez999&txtClave=jerez&Aceptar=Aceptar"

        col = New Collection
        col.Add("{TAB}")
        col.Add("{TAB}")
        col.Add("{TAB}")
        col.Add("{TAB}")
        col.Add("jrsabater")
        col.Add("{TAB}")
        col.Add("boñynzcx")
        col.Add("{ENTER}")

        cargar()
    End Sub

    Public Sub cargar()
        frm = New frmEnlaces("Chep", enlace, col)
        'AddHandler frm.completed, AddressOf terminado
        GUImain.añadirPestaña(frm)
    End Sub

End Class
