Public Class frmVistaGestiones
    Private maestro As Integer
    Private frmGestionesPendientes As frmGestionesPendientes
    Private frmDEtallesgestionesPendientes As frmDetallesGestionesPendientes

    Public Sub New(ByVal maestroid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        refreshDetails(maestroid)
    End Sub

    Public Sub refreshDetails(ByVal maestroid As Integer)
        Me.maestro = maestroid
        frmGestionesPendientes = New frmGestionesPendientes(Me.maestro)

        Engine_LA.FormEnPestaña(frmGestionesPendientes, Me.SplitContainer1.Panel1)

        AddHandler frmGestionesPendientes.ValueChanged, AddressOf changed
    End Sub

    Private Sub changed()
        frmDEtallesgestionesPendientes = New frmDetallesGestionesPendientes(frmGestionesPendientes.Id)
        Engine_LA.FormEnPestaña(frmDEtallesgestionesPendientes, Me.SplitContainer1.Panel2)
    End Sub
End Class