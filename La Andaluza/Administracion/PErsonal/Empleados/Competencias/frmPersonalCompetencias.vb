Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPersonalCompetencias
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboPersonalCompetencias As DBO_PersonalCompetencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPersonalCompetencias, MaestroID)
        InitializeComponent()

        dboPersonalCompetencias = New DBO_PersonalCompetencias


        MyBase.newRegForm = New frmEntPersonalCompetencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        AddHandler MyBase.newRegForm.afterSave, AddressOf gfill
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboPersonalCompetencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPersonalCompetencias = CType(sp, spPersonalCompetencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboPersonalCompetencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboPersonalCompetencias)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub gfill()
        dgvFill()
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 300)
            End With
        End If
    End Sub
End Class
