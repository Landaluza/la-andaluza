Public Class frmWstepIDI
    Implements wizardable


    Public Function comprobarCampos() As Boolean Implements wizardable.comprobarCampos
        Return False
    End Function

    Public Sub EstablecerValores() Implements wizardable.EstablecerValores

    End Sub

    Public Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean Implements wizardable.grabarDatos
        Return False
    End Function

    Public Function recuperarValor(nombre As String) As Object Implements wizardable.recuperarValor
        Return Nothing
    End Function
End Class