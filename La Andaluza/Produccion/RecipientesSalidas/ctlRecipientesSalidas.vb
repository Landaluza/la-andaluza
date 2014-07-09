Public Class ctlRecipientesSalidas
    Dim clsRec As New clsRecipientesSalidas

    Public Function GetRecipienteSalidaID() As Integer
        Return clsRec._RecipienteSalidaID
    End Function

    Public Sub SetRecipienteSalidaID(ByVal ID As Integer)
        clsRec._RecipienteSalidaID = ID
    End Sub

    Public Function devolverRecipientesSalidas() As DataTable
        Return clsRec.Devolver()
    End Function

    Public Sub mostrarTodosRecipientesSalidas(ByRef dts As dtsRecipientesSalidas.RecipientesSalidasDataTable)
        Dim tabla As New DataTable
        tabla = clsRec.Devolver()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsRecipientesSalidas.RecipientesSalidasRow
        While i < tabla.Rows.Count
            reg = dts.NewRecipientesSalidasRow
            reg.RecipienteSalidaID = tabla.Rows(i).Item(0)
            reg.Descripcion = tabla.Rows(i).Item(1)
            dts.AddRecipientesSalidasRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Sub GuardarRecipienteSalida( _
               ByVal Descripcion As String)
        clsRec._Descripcion = Descripcion
        If clsRec._RecipienteSalidaID = 0 Then
            clsRec.Insertar()
        Else
            clsRec.Modificar()
        End If
    End Sub

    Public Sub EliminarRecipienteSalida()
        clsRec.Eliminar()
    End Sub
End Class
