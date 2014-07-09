Public Class ctlBotasTapones
    Dim clsbotTap As New clsBotasTapones

    Public Function GetBotaTaponID() As Integer
        Return clsbotTap._BotaTaponID
    End Function

    Public Sub SetBotaTaponID(ByVal ID As Integer)
        clsbotTap._BotaTaponID = ID
    End Sub

    Public Function devolverBotasTapones() As DataTable
        Return clsbotTap.Devolver()
    End Function

    Public Sub mostrarTodosBotasTapones(ByRef dts As dtsBotasTapones.BotasTaponesDataTable)
        Dim tabla As New DataTable
        tabla = clsbotTap.Devolver()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsBotasTapones.BotasTaponesRow
        While i < tabla.Rows.Count
            reg = dts.NewBotasTaponesRow
            reg.BotaTaponID = tabla.Rows(i).Item(0)
            reg.Descripcion = tabla.Rows(i).Item(1)
            dts.AddBotasTaponesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Sub GuardarBotaTapon( _
               ByVal Descripcion As String)
        clsbotTap._Descripcion = Descripcion
        If clsbotTap._BotaTaponID = 0 Then
            clsbotTap.Insertar()
        Else
            clsbotTap.Modificar()
        End If
    End Sub

    Public Sub EliminarBotaTapon()
        clsbotTap.Eliminar()
    End Sub


    Public Function devolverBotasTaponesPorDescripcion() As DataTable
        Return clsbotTap.devolverBotasTaponesPorDescripcion()
    End Function
  
End Class
