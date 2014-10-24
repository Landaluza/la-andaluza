Public Class frmAsistenteMateriasPrimas
    Inherits wizard

    Private frmArticulos1 As frmWstepArticulos1
    Private frmMateriasPrimas As frmWstepMateriasPrimas

    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.title = "Asistente de creación de materias primas"


        Me.frmArticulos1 = New frmWstepArticulos1(True, Nothing)
        MyBase.forms.Add(Me.frmArticulos1)
        Me.titles.Add("Detalles genericos del articulo")

        Me.frmMateriasPrimas = New frmWstepMateriasPrimas()
        MyBase.forms.Add(Me.frmMateriasPrimas)
        Me.titles.Add("Detalles especificos del articulo")

    End Sub

    Private Sub cambioPanel(ByRef panel As Windows.Forms.Form) Handles Me.PanelChanged
        If Me.wizardStep = 1 Then
            Me.frmArticulos1.TipoArticulo = 1
        End If
    End Sub

    Private Sub finished() Handles Me.FinishWizard
        If MyBase.guardar(Me.dtb) Then
            Me.Close()
        Else
            MessageBox.Show("No se ha podido guardar. Vuelva a intentarlos en unos segundos o revise los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmAsistenteMateriasPrimas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.cambiarPanel(1)
    End Sub
End Class