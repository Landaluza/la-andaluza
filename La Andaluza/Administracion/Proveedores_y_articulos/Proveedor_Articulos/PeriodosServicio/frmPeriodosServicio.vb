Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPeriodosServicio
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboPeriodosServicio As DBO_PeriodosServicio

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPeriodosServicio, MaestroID)
        InitializeComponent()

        dboPeriodosServicio = New DBO_PeriodosServicio


        MyBase.newRegForm = CType(New frmEntPeriodosServicio(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboPeriodosServicio, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPeriodosServicio = CType(sp, spPeriodosServicio).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboPeriodosServicio Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboPeriodosServicio, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Desde", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Hasta", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
