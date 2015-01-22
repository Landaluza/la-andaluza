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

    Public Sub Cargar(ByRef dtb As BasesParaCompatibilidad.DataBase)

        Dim tabla As New DataTable
        dtb.PrepararConsulta("select BotaTaponID,PosicionID from Botas where BotaID=" & Convert.ToString(BotaID))
        tabla = dtb.Consultar()
        Try
            BotaTaponID = tabla.Rows(0).Item(0)
            PosicionID = tabla.Rows(0).Item(1)
        Catch ex As Exception
            BotaTaponID = 0
            PosicionID = 0
        End Try
    End Sub

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer


        Try

            dtb.PrepararConsulta("update Botas set BotaTaponID= @bot , PosicionID= @pos where BotaID= @id")
            dtb.AñadirParametroConsulta("@bot", BotaTaponID)
            dtb.AñadirParametroConsulta("@pos", PosicionID)
            dtb.AñadirParametroConsulta("@id", BotaID)

            
            If dtb.Execute Then Return 1

            Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer


        Try
            dtb.PrepararConsulta("insert into Botas values( @tapon , @pos , @fecha , @user )")
            dtb.AñadirParametroConsulta("@tapon", BotaTaponID)
            dtb.AñadirParametroConsulta("@pos", PosicionID)
            dtb.AñadirParametroConsulta("@fecha", BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)))
            dtb.AñadirParametroConsulta("@user", BasesParaCompatibilidad.Config.User)

            If Not dtb.Execute Then Throw New Exception("Error al guardar")


            dtb.PrepararConsulta("select max(BotaID) from Botas")
            BotaID = dtb.Consultar().Rows(0).Item(0)
            Return BotaID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        Try
            dtb.PrepararConsulta("delete from Botas where BotaID = @id")
            dtb.AñadirParametroConsulta("@id", BotaID)
            If dtb.Execute Then
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
