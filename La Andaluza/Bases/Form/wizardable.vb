Public Interface wizardable
    Function comprobarCampos() As Boolean
    Function recuperarValor(ByVal nombre As String) As Object
    Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
    Sub EstablecerValores()

End Interface
