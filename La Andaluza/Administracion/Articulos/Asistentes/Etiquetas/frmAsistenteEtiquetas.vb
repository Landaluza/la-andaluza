Public Class frmAsistenteEtiquetas
    Inherits wizard

    Private frmArticulos1 As frmWstepArticulos1
    Private frmEtiquetas As frmWstepEtiquetas


    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.title = "Asistente de creación de articulos graneles"


        Me.frmArticulos1 = New frmWstepArticulos1(True, Nothing)
        MyBase.forms.Add(Me.frmArticulos1)
        Me.titles.Add("Detalles genericos del articulo")

        Me.frmEtiquetas = New frmWstepEtiquetas()
        MyBase.forms.Add(Me.frmEtiquetas)
        Me.titles.Add("Detalles especificos del articulo")

    End Sub

    Private Sub cambioPanel(ByRef panel As Windows.Forms.Form) Handles Me.PanelChanged
        If Me.wizardStep = 1 Then
            Me.frmArticulos1.TipoArticulo = 26
        End If
    End Sub

    Private Sub frmAsistenteArticulosEnvasados_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.cambiarPanel(1)
    End Sub

    Private Sub finished() Handles Me.FinishWizard
        If MyBase.guardar Then
            Me.Close()
        Else
            messagebox.show("No se ha podido guardar. Vuelva a intentarlos en unos segundos o revise los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class