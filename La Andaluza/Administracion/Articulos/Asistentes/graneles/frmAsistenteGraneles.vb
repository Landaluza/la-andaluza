﻿Public Class frmAsistenteGraneles
    Inherits wizard

    Private frmArticulos1 As frmWstepArticulos1
    Private frmgraneles As frmWstepGraneles


    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.title = "Asistente de creación de articulos graneles"


        Me.frmArticulos1 = New frmWstepArticulos1(True, Nothing)
        MyBase.forms.Add(Me.frmArticulos1)
        Me.titles.Add("Detalles genericos del articulo")

        Me.frmgraneles = New frmWstepGraneles()
        MyBase.forms.Add(Me.frmgraneles)
        Me.titles.Add("Detalles especificos del articulo")

    End Sub

    Private Sub cambioPanel(ByRef sender As Object, e As EventArgs) Handles Me.PanelChanged
        If Me.wizardStep = 1 Then
            Me.frmArticulos1.TipoArticulo = 4
        End If
    End Sub

    Private Sub frmAsistenteArticulosEnvasados_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.cambiarPanel(1)
    End Sub

    Private Sub finished() Handles Me.FinishWizard
        If MyBase.guardar(Me.dtb) Then
            Me.Close()
        Else
            MessageBox.Show("No se ha podido guardar. Vuelva a intentarlos en unos segundos o revise los datos.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class