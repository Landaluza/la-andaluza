Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPuestosTrabajos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboPuestosTrabajos As DBO_PuestosTrabajos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPuestosTrabajos, MaestroID)
        InitializeComponent()

        dboPuestosTrabajos = New DBO_PuestosTrabajos


        MyBase.newRegForm = New frmEntPuestosTrabajos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboPuestosTrabajos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPuestosTrabajos = CType(sp, spPuestosTrabajos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboPuestosTrabajos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboPuestosTrabajos)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
            End With
        End If
    End Sub
End Class
