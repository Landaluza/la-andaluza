Public Class PlanesDDD
    Private frmDDDProductos As frmDDDProductos
    Private frmDDDAcciones As frmDDDAcciones
    Private frmDDDPersonasAutorizadas As frmDDDPersonasAutorizadas
    Private frmDDDPlanes As frmDDDPlanes
    Private frmDDDAccionesRealizadas As frmDDDAccionesRealizadas

    Public Sub New()
        InitializeComponent()
        frmDDDProductos = New frmDDDProductos
        frmDDDAcciones = New frmDDDAcciones
        frmDDDPersonasAutorizadas = New frmDDDPersonasAutorizadas
        frmDDDPlanes = New frmDDDPlanes
        frmDDDAccionesRealizadas = New frmDDDAccionesRealizadas
    End Sub


    Private Sub PlanesDDD_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(frmDDDProductos, tpProductos)
        Engine_LA.FormEnPestaña(frmDDDAcciones, tpAcciones)
        Engine_LA.FormEnPestaña(frmDDDPersonasAutorizadas, tpPersonas)
        Engine_LA.FormEnPestaña(frmDDDPlanes, tpPlanes)
        Engine_LA.FormEnPestaña(frmDDDAccionesRealizadas, tpAccionesRealizadas)
    End Sub
End Class