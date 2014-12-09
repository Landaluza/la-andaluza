Public Class InformeMovimientos
    Private frmPaletSCC As frmPaletSCC
    Private frm2 As frmListadoDestruccion
    Private frm3 As frmStock
    Private frm4 As frmStock2

    Public Sub New()

        InitializeComponent()

        frmPaletSCC = New frmPaletSCC
        Engine_LA.FormEnPestaña(frmPaletSCC, TabPage1)
        frm2 = New frmListadoDestruccion
        Engine_LA.FormEnPestaña(frm2, TabPage2)
        frm3 = New frmStock
        Engine_LA.FormEnPestaña(frm3, TabPage3)
        frm4 = New frmStock2
        Engine_LA.FormEnPestaña(frm4, TabPage4)
    End Sub




End Class