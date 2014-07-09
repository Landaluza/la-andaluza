Public Class frmInformesAlmacen
    Private frmEntradasInforme As frmAlmacenEntradasInforme
    Private frmSalidasAlmacen As frmInformeSalidasAlmacen
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        frmEntradasInforme = New frmAlmacenEntradasInforme
        frmSalidasAlmacen = New frmInformeSalidasAlmacen
    End Sub


    Private Sub frmInformesAlmacen_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(Me.frmSalidasAlmacen, tpSalidas)
        Engine_LA.FormEnPestaña(Me.frmEntradasInforme, tpEntradas)
    End Sub
End Class