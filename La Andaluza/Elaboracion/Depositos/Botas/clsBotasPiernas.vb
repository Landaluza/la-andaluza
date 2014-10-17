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

    Public Sub Cargar()

        Dim tabla As New DataTable
        tabla = Deprecated.ConsultaVer("BotasPiernas.Descripcion, ContenidoHabitual", "BotasPiernas", "BotaPiernaID=" & BotaPiernaID)
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
            Deprecated.ConsultaModificar("BotasPiernas", _
                               "Descripcion='" & Descripcion & "', ContenidoHabitual='" & ContenidoHabitual & "'", _
                               "BotaPiernaID=" & Convert.ToString(BotaPiernaID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer

        Try
            Deprecated.ConsultaInsertar( _
                              "'" & Descripcion & "','" & ContenidoHabitual & "'", _
                              "BotasPiernas")
            BotaPiernaID = Deprecated.ConsultaVer("max(BotaPiernaID)", "BotasPiernas").Rows(0).Item(0)
            Return BotaPiernaID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)

        Try
            dtb.PrepararConsulta("delete from BotasPiernas where BotaPiernaID = @id")
            dtb.AñadirParametroConsulta("@id", BotaPiernaID)
            If dtb.Consultar(True) Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar Tonel, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return 0
            End If
            'If (BasesParaCompatibilidad.BD.ConsultaEliminar("BotasPiernas", "BotaPiernaID = " & Convert.ToString(BotaPiernaID)) = 0) Then
            '    MessageBox.Show("no se puede eliminar Tonel, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            'BotaPiernaID = 0
            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
