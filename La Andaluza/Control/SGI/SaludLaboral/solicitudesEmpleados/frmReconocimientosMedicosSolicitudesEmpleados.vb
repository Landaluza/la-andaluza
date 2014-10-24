Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmReconocimientosMedicosSolicitudesEmpleados
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboReconocimientosMedicosSolicitudesEmpleados As DBO_ReconocimientosMedicosSolicitudesEmpleados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spReconocimientosMedicosSolicitudesEmpleados, MaestroID)
        InitializeComponent()

        dboReconocimientosMedicosSolicitudesEmpleados = New DBO_ReconocimientosMedicosSolicitudesEmpleados


        MyBase.newRegForm = New frmEntReconocimientosMedicosSolicitudesEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicosSolicitudesEmpleados)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboReconocimientosMedicosSolicitudesEmpleados = CType(sp, spReconocimientosMedicosSolicitudesEmpleados).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboReconocimientosMedicosSolicitudesEmpleados Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicosSolicitudesEmpleados)
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
                .Columns("EmpleadoID").Visible = False
                .Columns("ReconocimientoMedicoSolicitudID").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
