Public Class Form1

    Public Sub New(ByVal dt As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataGridView1.DataSource = dt
    End Sub
End Class