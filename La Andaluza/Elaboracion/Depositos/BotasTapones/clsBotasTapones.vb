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

    Public Function devolverBotasTaponesPorDescripcion(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select BotaTaponID,Descripcion from BotasTapones where BotaTaponID > 0 order by Descripcion")
        Return dtb.Consultar()
    End Function

    Public Function Devolver(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select BotasTapones.BotaTaponID,BotasTapones.Descripcion from BotasTapones")
        Return dtb.Consultar
    End Function

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        Try

            dtb.ConsultaAlteraciones(" update BotasTapones set " & _
                               "Descripcion='" & Descripcion & "'" & _
                               " where BotaTaponID=" & Convert.ToString(BotaTaponID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.ConsultaAlteraciones("insert into BotasTapones values(" & _
                              "'" & Descripcion & "','" & _
                             BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)) + "'," + BasesParaCompatibilidad.Config.User.ToString + ")")

            dtb.PrepararConsulta("select max(BotaTaponID) from BotasTapones")
            BotaTaponID = dtb.Consultar().Rows(0).Item(0)
            Return BotaTaponID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        Try
            dtb.PrepararConsulta("delete from BotasTapones where BotaTaponID = @id")
            dtb.AñadirParametroConsulta("@id", BotaTaponID)
            If dtb.Execute Then
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
