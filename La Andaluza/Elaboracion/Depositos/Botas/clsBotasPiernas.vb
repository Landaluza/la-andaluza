Public Class clsBotasPiernas

#Region "Atributos"
    Private BotaPiernaID As Integer
    Private Descripcion As String
    Private ContenidoHabitual As String
#End Region

#Region "Propiedades"
    Public Property _BotaPiernaID() As Integer
        Get
            Return BotaPiernaID
        End Get

        Set(ByVal value As Integer)
            BotaPiernaID = value
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

        Return BasesParaCompatibilidad.BD.ConsultaVer("BotasPiernas.BotaPiernaID,BotasPiernas.Descripcion, ContenidoHabitual", "BotasPiernas")

    End Function

    Public Sub Cargar()

        Dim tabla As New DataTable
        tabla = BasesParaCompatibilidad.BD.ConsultaVer("BotasPiernas.Descripcion, ContenidoHabitual", "BotasPiernas", "BotaPiernaID=" & BotaPiernaID)
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
            BasesParaCompatibilidad.BD.ConsultaModificar("BotasPiernas", _
                               "Descripcion='" & Descripcion & "', ContenidoHabitual='" & ContenidoHabitual & "'", _
                               "BotaPiernaID=" & Convert.ToString(BotaPiernaID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer

        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                              "'" & Descripcion & "','" & ContenidoHabitual & "'", _
                              "BotasPiernas")
            BotaPiernaID = BasesParaCompatibilidad.BD.ConsultaVer("max(BotaPiernaID)", "BotasPiernas").Rows(0).Item(0)
            Return BotaPiernaID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If (BasesParaCompatibilidad.BD.ConsultaEliminar("BotasPiernas", "BotaPiernaID = " & Convert.ToString(BotaPiernaID)) = 0) Then
                MessageBox.Show("no se puede eliminar Tonel, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            BotaPiernaID = 0
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
