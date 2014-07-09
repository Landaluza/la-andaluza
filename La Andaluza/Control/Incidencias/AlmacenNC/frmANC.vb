Public Class frmANC
    Private maestroID As Integer

    Private frmArticulos_AlmacenNoConforme As frmArticulos_AlmacenNoConforme
    Private frmArticulos_AlmacenNoConforme_PaletsProducidos As frmArticulos_AlmacenNoConforme_PaletsProducidos
    Private frmArticulos_AlmacenNoConforme_seguimiento As frmArticulos_AlmacenNoConforme_seguimiento

    Public Sub New(ByVal maestro As Integer)

        InitializeComponent()

        Me.maestroID = maestro
        frmArticulos_AlmacenNoConforme = New frmArticulos_AlmacenNoConforme(maestroID)
        frmArticulos_AlmacenNoConforme_PaletsProducidos = New frmArticulos_AlmacenNoConforme_PaletsProducidos(Nothing)
        frmArticulos_AlmacenNoConforme_seguimiento = New frmArticulos_AlmacenNoConforme_seguimiento(Nothing)

        AddHandler frmArticulos_AlmacenNoConforme.Index_change, AddressOf Me.recargar_detalles

        Engine_LA.FormEnPestaña(Me.frmArticulos_AlmacenNoConforme, Me.splitPrincipal.Panel1)
        Engine_LA.FormEnPestaña(Me.frmArticulos_AlmacenNoConforme_PaletsProducidos, Me.PanPalets)
        Engine_LA.FormEnPestaña(Me.frmArticulos_AlmacenNoConforme_seguimiento, Me.panSeguimiento)
    End Sub

    Private Sub recargar_detalles(ByVal id As Integer)
        frmArticulos_AlmacenNoConforme_seguimiento.refrescar(id)
        frmArticulos_AlmacenNoConforme_PaletsProducidos.refrescar(id)
    End Sub
End Class
