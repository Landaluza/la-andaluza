Public Class clsBotasTapones

#Region "Atributos"
    Private BotaTaponID As Integer
    Private Descripcion As String
#End Region

#Region "Propiedades"
    Public Property _BotaTaponID() As Integer
        Get
            Return BotaTaponID
        End Get

        Set(ByVal value As Integer)
            BotaTaponID = value
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

#End Region

#Region "Metodos"

    Public Function devolverBotasTaponesPorDescripcion() As DataTable

        Return Deprecated.ConsultaVer("BotaTaponID,Descripcion", "BotasTapones", "BotaTaponID > 0 order by Descripcion")

    End Function

    Public Function Devolver() As DataTable

        Return Deprecated.ConsultaVer("BotasTapones.BotaTaponID,BotasTapones.Descripcion", "BotasTapones")

    End Function

    Public Function Modificar() As Integer

        Try
            Deprecated.ConsultaModificar("BotasTapones", _
                               "Descripcion='" & Descripcion & "'", _
                               "BotaTaponID=" & Convert.ToString(BotaTaponID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            Deprecated.ConsultaInsertar( _
                              "'" & Descripcion & "'", _
                              "BotasTapones")
            BotaTaponID = Deprecated.ConsultaVer("max(BotaTaponID)", "BotasTapones").Rows(0).Item(0)
            Return BotaTaponID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)

        Try
            dtb.PrepararConsulta("delete from BotasTapones where BotaTaponID = @id")
            dtb.AñadirParametroConsulta("@id", BotaTaponID)
            If dtb.Consultar(True) Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar Bota tapon, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return 0
            End If

            'If (BasesParaCompatibilidad.BD.ConsultaEliminar("BotasTapones", "BotaTaponID = " & Convert.ToString(BotaTaponID)) = 0) Then
            '    MessageBox.Show("no se puede eliminar Bota Tapon, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
