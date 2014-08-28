Public Class SessionEtiquetas
    Implements RemoteSession

    Private servidor As String
    Private pass As String
    Private usuario As String
    Private dominio As String
    Private puerto As String
    Private nombre As String
    Public Sub New()
        servidor = "192.168.1.106"
        puerto = "5555"
        pass = ""
        usuario = "etiquetas"
        dominio = ""
        nombre = "Etiquetas"
    End Sub

    Public ReadOnly Property Server As String Implements RemoteSession.Server
        Get
            Return servidor
        End Get
    End Property

    Public ReadOnly Property User As String Implements RemoteSession.User
        Get
            Return usuario
        End Get
    End Property

    Public ReadOnly Property Domain As String Implements RemoteSession.Domain
        Get
            Return dominio
        End Get
    End Property

    Public ReadOnly Property Password As String Implements RemoteSession.Password
        Get
            Return pass
        End Get
    End Property

    Public ReadOnly Property Port As String Implements RemoteSession.Port
        Get
            Return puerto
        End Get
    End Property

    Public ReadOnly Property Name As String Implements RemoteSession.Name
        Get
            Return nombre
        End Get
    End Property
End Class
