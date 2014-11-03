Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmReconocimientosMedicosSolicitudes
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboReconocimientosMedicosSolicitudes As DBO_ReconocimientosMedicosSolicitudes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spReconocimientosMedicosSolicitudes, MaestroID)
        InitializeComponent()

        dboReconocimientosMedicosSolicitudes = New DBO_ReconocimientosMedicosSolicitudes


        MyBase.newRegForm = New frmEntReconocimientosMedicosSolicitudes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicosSolicitudes)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboReconocimientosMedicosSolicitudes = CType(sp, spReconocimientosMedicosSolicitudes).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboReconocimientosMedicosSolicitudes Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicosSolicitudes)
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
                .FormatoColumna("FechaSolicitud", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("FechaDeseadaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If
    End Sub

End Class
