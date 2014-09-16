Public Class frmTiposProductoMain
    Private frmTiposProductos As frmTiposProductos
    Private frmFamiliaProducto As frmFamiliaProducto
    Private frmMedidasProductos As frmMedidasProductos

    Public Sub New()
        InitializeComponent()

        frmTiposProductos = New frmTiposProductos
        frmFamiliaProducto = New frmFamiliaProducto
        frmMedidasProductos = New frmMedidasProductos

        Engine_LA.FormEnPestaña(frmTiposProductos, tpProductos)
        Engine_LA.FormEnPestaña(frmFamiliaProducto, tpFamilia)
        Engine_LA.FormEnPestaña(frmMedidasProductos, tpMedidas)
    End Sub

End Class