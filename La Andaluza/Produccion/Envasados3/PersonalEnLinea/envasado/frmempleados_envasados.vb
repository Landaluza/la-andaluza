Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmempleados_envasados
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboempleados_envasados As DBO_empleados_envasados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spempleados_envasados, MaestroID)
        InitializeComponent()

        dboempleados_envasados = New DBO_empleados_envasados


        MyBase.newRegForm = New frmEntempleados_envasados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboempleados_envasados)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboempleados_envasados = CType(sp, spempleados_envasados).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboempleados_envasados Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboempleados_envasados)
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
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
