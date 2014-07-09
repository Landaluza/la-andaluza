Public Class frmSeleccionIncidencia
    Private frmControlIncidencias As frmDetallelIncidencias
    Public Id As Integer

    Public Sub New()

        InitializeComponent()

        frmControlIncidencias = New frmDetallelIncidencias
        AddHandler frmControlIncidencias.SeleccionHecha, AddressOf Recuperardato
        Engine_LA.FormEnPestaña(frmControlIncidencias, Panel2)
    End Sub

    Private Sub Recuperardato()
        id = frmControlIncidencias.SelectedItem
        Me.Close()
    End Sub
End Class