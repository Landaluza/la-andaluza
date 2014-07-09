Public Class frmCom
    Private frmnoticias As frmNoticias
    Private frmComunicaciones As frmComunicaciones

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        frmnoticias = New frmNoticias
        frmComunicaciones = New frmComunicaciones
    End Sub

    Private Sub frmCom_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Engine_LA.FormEnPestaña(frmnoticias, tpCircular)
        Engine_LA.FormEnPestaña(frmComunicaciones, tpConmtacto)
    End Sub
End Class