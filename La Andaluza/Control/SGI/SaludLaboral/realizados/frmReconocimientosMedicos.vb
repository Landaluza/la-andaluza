Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmReconocimientosMedicos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboReconocimientosMedicos As DBO_ReconocimientosMedicos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spReconocimientosMedicos, MaestroID)
        InitializeComponent()

        dboReconocimientosMedicos = New DBO_ReconocimientosMedicos


        MyBase.newRegForm = New frmEntReconocimientosMedicos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboReconocimientosMedicos = CType(sp, spReconocimientosMedicos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboReconocimientosMedicos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicos)
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
                .Columns("ReconocimientoMedicoSolicitudEmpleadoID").Visible = False
                .FormatoColumna("FechaRealizado", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Grupo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Medico", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                '
            End With
        End If



    End Sub

End Class
