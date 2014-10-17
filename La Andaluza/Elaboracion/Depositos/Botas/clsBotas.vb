Public Class clsBotas

#Region "Atributos"
    Private BotaID As Integer
    Private BotaTaponID As String
    Private PosicionID As String
#End Region

#Region "Propiedades"
    Public Property _BotaID() As Integer
        Get
            Return BotaID
        End Get

        Set(ByVal value As Integer)
            BotaID = value
        End Set
    End Property

    Public Property _BotaTaponID() As Integer
        Get
            Return BotaTaponID
        End Get

        Set(ByVal value As Integer)
            BotaTaponID = value
        End Set
    End Property

    Public Property _PosicionID() As Integer
        Get
            Return PosicionID
        End Get

        Set(ByVal value As Integer)
            PosicionID = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function Devolver() As DataTable

        Return Deprecated.ConsultaVer("Botas.BotaID,Botas.FechaLlegada,BotasTapones.Descripcion As BotasTapones,Posiciones.Descripcion As Posiciones", "Botas LEFT JOIN BotasTapones On Botas.BotaTaponID = BotasTapones.BotaTaponID LEFT JOIN Posiciones On Botas.PosicionID = Posiciones.PosicionID")
    End Function

    Public Sub Cargar()

        Dim tabla As New DataTable
        tabla = Deprecated.ConsultaVer("BotaTaponID,PosicionID", "Botas", "BotaID=" & Convert.ToString(BotaID))
        Try
            BotaTaponID = tabla.Rows(0).Item(0)
            PosicionID = tabla.Rows(0).Item(1)
        Catch ex As Exception
            BotaTaponID = 0
            PosicionID = 0
        End Try
    End Sub

    Public Function Modificar() As Integer


        Try
            Deprecated.ConsultaModificar("Botas", _
                              "BotaTaponID=" & Convert.ToString(BotaTaponID) & "," & _
                              "PosicionID=" & Convert.ToString(PosicionID) & "", _
                              "BotaID=" & Convert.ToString(BotaID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer


        Try
            Deprecated.ConsultaInsertar( _
                             "" & Convert.ToString(BotaTaponID) & "," & _
                             "" & Convert.ToString(PosicionID) & "", _
                             "Botas")
            BotaID = Deprecated.ConsultaVer("max(BotaID)", "Botas").Rows(0).Item(0)
            Return BotaID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)

        Try
            dtb.PrepararConsulta("delete from Botas where BotaID = @id")
            dtb.AñadirParametroConsulta("@id", BotaID)
            If dtb.Consultar(True) Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar Bota, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return 0
            End If

            'If (BasesParaCompatibilidad.BD.ConsultaEliminar("Botas", "BotaID = " & Convert.ToString(BotaID)) = 0) Then
            '    MessageBox.Show("no se puede eliminar Bota, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            'BotaID = 0
            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
