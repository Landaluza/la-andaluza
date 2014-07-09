Public Class clsToneles

#Region "Atributos"
    Private TonelID As Integer
    Private Descripcion As String
    Private ContenidoHabitual As String
#End Region

#Region "Propiedades"
    Public Property _TonelID() As Integer
        Get
            Return TonelID
        End Get

        Set(ByVal value As Integer)
            TonelID = value
        End Set
    End Property


    Public Property _Descripcion() As String
        Get
            Return Descripcion
        End Get

        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

    Public Property _ContenidoHabitual() As String
        Get
            Return ContenidoHabitual
        End Get

        Set(ByVal value As String)
            ContenidoHabitual = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Devolver() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("Toneles.TonelID,Toneles.Descripcion, ContenidoHabitual", "Toneles")

    End Function

    Public Sub Cargar()

        Dim tabla As New DataTable
        tabla = BasesParaCompatibilidad.BD.ConsultaVer("Toneles.Descripcion, ContenidoHabitual", "Toneles", "TonelID=" & TonelID)
        Try
            Descripcion = tabla.Rows(0).Item(0)
            ContenidoHabitual = tabla.Rows(0).Item(1)
        Catch ex As Exception
            Descripcion = ""
            ContenidoHabitual = ""
        End Try
    End Sub

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Toneles", _
                               "Descripcion='" & Descripcion & "', ContenidoHabitual='" & ContenidoHabitual & "'", _
                               "TonelID=" & Convert.ToString(TonelID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer

        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                              "'" & Descripcion & "','" & ContenidoHabitual & "'", _
                              "Toneles")
            TonelID = BasesParaCompatibilidad.BD.ConsultaVer("max(TonelID)", "Toneles").Rows(0).Item(0)
            Return TonelID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If (BasesParaCompatibilidad.BD.ConsultaEliminar("Toneles", "TonelID = " & Convert.ToString(TonelID)) = 0) Then
                MessageBox.Show("no se puede eliminar Tonel, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            TonelID = 0
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
