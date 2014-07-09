Public Class frmVisitasMain
    Private frmVisitasTipos As frmVisitasTipos
    Private frmVisitasNombres1 As frmVisitasNombres1
    Private frmVisitasMotivos As frmVisitasMotivos
    Private frmVisitasRegistros As frmVisitasRegistros

    Public Sub New()
        InitializeComponent()
        frmVisitasTipos = New frmVisitasTipos
        frmVisitasNombres1 = New frmVisitasNombres1
        frmVisitasMotivos = New frmVisitasMotivos
        frmVisitasRegistros = New frmVisitasRegistros

        Engine_LA.FormEnPestaña(frmVisitasRegistros, TabPage1)
        Engine_LA.FormEnPestaña(frmVisitasTipos, TabPage4)
        Engine_LA.FormEnPestaña(frmVisitasNombres1, TabPage2)
        Engine_LA.FormEnPestaña(frmVisitasMotivos, TabPage3)
    End Sub
End Class