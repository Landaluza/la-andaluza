Public Class PlanesGeneralesHigiene
    Private AguaPotable As AguaPotable
    Private PlanesDDD As PlanesDDD

    Public Sub New()
        InitializeComponent()
        PlanesDDD = New PlanesDDD
        AguaPotable = New AguaPotable
    End Sub
    
    Private Sub PlanesGeneralesHigiene_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(AguaPotable, GroupBox2)
        Engine_LA.FormEnPestaña(PlanesDDD, GroupBox1)
    End Sub
End Class