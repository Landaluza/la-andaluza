Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProcesosCalidad
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboProcesosCalidad As DBO_ProcesosCalidad

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProcesosCalidad, MaestroID)
        InitializeComponent()

        dboProcesosCalidad = New DBO_ProcesosCalidad


        MyBase.newRegForm = New frmEntProcesosCalidad(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboProcesosCalidad)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboProcesosCalidad = CType(sp, spProcesosCalidad).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboProcesosCalidad Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboProcesosCalidad)
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
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("DescripcionIngles", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
