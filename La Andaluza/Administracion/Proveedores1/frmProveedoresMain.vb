Public Class frmProveedoresMain

    Private frmProveedores As frmProveedores
    Private frmProveedoresTipos As frmProveedoresTipos
    Private frmMotivosCeseServicio As frmMotivosCeseServicio
    Private frmPeriodosServicio As frmPeriodosServicio
    Private frmReuniones As frmReuniones

    Public Sub New()


        InitializeComponent()

        frmProveedores = New frmProveedores
        frmProveedoresTipos = New frmProveedoresTipos
        frmMotivosCeseServicio = New frmMotivosCeseServicio
        frmPeriodosServicio = New frmPeriodosServicio
        frmReuniones = New frmReuniones

        Engine_LA.FormEnPestaña(frmProveedores, TabPage1)
        Engine_LA.FormEnPestaña(frmProveedoresTipos, TabPage2)
        Engine_LA.FormEnPestaña(frmMotivosCeseServicio, TabPage3)
        Engine_LA.FormEnPestaña(frmPeriodosServicio, TabPage4)
        Engine_LA.FormEnPestaña(frmReuniones, TabPage5)
    End Sub


End Class