Public Class frmAsistenteArticuloSimple
    Inherits wizard

    Private frmArticulos1 As frmWstepArticulos1

    Public Sub New(ByVal TipoArticulo As Integer)
        InitializeComponent()

        Me.title = "Asistente de creación de artículo para envasado"


        Me.frmArticulos1 = New frmWstepArticulos1(True, TipoArticulo)
        MyBase.forms.Add(Me.frmArticulos1)
        Me.titles.Add("Detalles del artículo")
    End Sub

    Private Sub cambioPanel(ByRef panel As Windows.Forms.Form) Handles Me.PanelChanged
        
    End Sub

    Private Sub finished() Handles Me.FinishWizard
        If MyBase.guardar Then
            Me.Close()
        Else
            messagebox.show("No se ha podido guardar. Vuelva a intentarlos en unos segundos o revise los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmAsistenteArticuloSimple_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.cambiarPanel(1)
    End Sub
End Class