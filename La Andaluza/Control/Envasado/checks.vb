Public Class checks
    Private frmCkeckProduccion As frmCheckeoProduccion
    Private frmChekeModificacionPalets As frmChekeModificacionPalets
    Private frmMediaProduccion As frmMediaProduccion

    Private frmEspera As BasesParaCompatibilidad.frmEspera
    Public Sub New()

        InitializeComponent()

        Me.frmCkeckProduccion = New frmCheckeoProduccion
        Me.frmChekeModificacionPalets = New frmChekeModificacionPalets
        frmMediaProduccion = New frmMediaProduccion
    End Sub

    Private Sub checks_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(Me.frmCkeckProduccion, Me.tpChProduccion)
        Engine_LA.FormEnPestaña(Me.frmChekeModificacionPalets, Me.tpchMoidificacion)
        Engine_LA.FormEnPestaña(Me.frmMediaProduccion, Me.tpMediaProduccion)
    End Sub

 
End Class
