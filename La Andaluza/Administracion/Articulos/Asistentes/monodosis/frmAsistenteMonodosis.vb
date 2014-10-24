Public Class frmAsistenteMonodosis
    Inherits wizard

    Private frmArticulos1 As frmWstepArticulos1
    Private frmPrimario As frmWstepPrimario

    Public Sub New(ByVal TipoArticulo As Integer)
        InitializeComponent()

        Me.title = "Asistente de creación de artículo para envasado"


        Me.frmArticulos1 = New frmWstepArticulos1(True, TipoArticulo)
        MyBase.forms.Add(Me.frmArticulos1)
        Me.titles.Add("Detalles del artículo")

        Me.frmPrimario = New frmWstepPrimario(0, 0)
        MyBase.forms.Add(Me.frmPrimario)
        Me.titles.Add("Detalles del artículo primario")
    End Sub

    Private Sub cambioPanel(ByRef panel As Windows.Forms.Form) Handles Me.PanelChanged

    End Sub

    Private Sub finished() Handles Me.FinishWizard
        If MyBase.guardar(Me.dtb) Then
            Me.Close()
        Else
            MessageBox.Show("No se ha podido guardar. Vuelva a intentarlos en unos segundos o revise los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmAsistenteMonodosis_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.cambiarPanel(1)
    End Sub
End Class