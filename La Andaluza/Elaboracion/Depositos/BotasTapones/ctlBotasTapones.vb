Public Class ctlBotasTapones
    Private clsbotTap As New clsBotasTapones



    Public Sub SetBotaTaponID(ByVal ID As Integer)
        clsbotTap._BotaTaponID = ID
    End Sub



    Public Sub mostrarTodosBotasTapones(ByRef dtb As BasesParaCompatibilidad.DataBase, ByRef dts As dtsBotasTapones.BotasTaponesDataTable)
        Dim tabla As New DataTable
        tabla = clsbotTap.Devolver(dtb)
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

    Public Sub GuardarBotaTapon(ByRef dtb As BasesParaCompatibilidad.DataBase, _
               ByVal Descripcion As String)
        clsbotTap._Descripcion = Descripcion
        If clsbotTap._BotaTaponID = 0 Then
            clsbotTap.Insertar(dtb)
        Else
            clsbotTap.Modificar(dtb)
        End If
    End Sub

    Public Sub EliminarBotaTapon()
        clsbotTap.Eliminar()
    End Sub


    Public Function devolverBotasTaponesPorDescripcion() As DataTable
        Return clsbotTap.devolverBotasTaponesPorDescripcion()
    End Function
  
End Class
