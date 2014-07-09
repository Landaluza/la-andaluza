Public Class frmEnvasados
    Inherits BasesParaCompatibilidad.GridSimpleForm



    Private dboEnvasados As DBO_Envasados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spEnvasados, MaestroID)
        InitializeComponent()
        Me.bdnGeneral.Visible = False
        Me.components.Remove(dgvGeneral)

        dboEnvasados = New DBO_Envasados


        MyBase.newRegForm = New frmEntEnvasados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, sp)
    End Sub



    Overrides Sub ToExcel()
    End Sub

    Overrides Sub ToWord()
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboEnvasados)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        'dboEnvasados = sp.Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboEnvasados Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboEnvasados)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then

        End If


    End Sub

End Class
