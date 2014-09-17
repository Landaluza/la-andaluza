Public Class frmTiposProductoMain
    Private frmTiposProductos As frmTiposProductos
    Private frmFamiliaProducto As frmFamiliaProducto
    Private frmMedidasProductos As frmMedidasProductos
    Private frmClases As frmClasesProductos

    Public Sub New()
        InitializeComponent()

        frmTiposProductos = New frmTiposProductos
        frmFamiliaProducto = New frmFamiliaProducto
        frmMedidasProductos = New frmMedidasProductos
        frmClases = New frmClasesProductos

        Engine_LA.FormEnPestaña(frmTiposProductos, tpProductos)
        Engine_LA.FormEnPestaña(frmFamiliaProducto, tpFamilia)
        Engine_LA.FormEnPestaña(frmMedidasProductos, tpMedidas)
        Engine_LA.FormEnPestaña(frmClases, tpClases)
    End Sub

End Class