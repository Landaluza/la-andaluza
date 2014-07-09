Public Class frmWstepIDI
    Implements  BasesParaCompatibilidad.wizardable


    Public Function comprobarCampos() As Boolean Implements  BasesParaCompatibilidad.wizardable.comprobarCampos
        Return False
    End Function

    Public Sub EstablecerValores() Implements  BasesParaCompatibilidad.wizardable.EstablecerValores

    End Sub

    Public Function grabarDatos() As Boolean Implements  BasesParaCompatibilidad.wizardable.grabarDatos
        Return False
    End Function

    Public Function recuperarValor(nombre As String) As Object Implements  BasesParaCompatibilidad.wizardable.recuperarValor
        Return Nothing
    End Function
End Class