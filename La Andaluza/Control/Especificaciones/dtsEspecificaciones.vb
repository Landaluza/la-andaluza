Partial Class dtsEspecificaciones
    Partial Class EspecificacionesDataTable

    End Class

    Partial Class ValoresEspecificacionesDataTable



        Private Sub ValoresEspecificacionesDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.UnidadMedidaColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
