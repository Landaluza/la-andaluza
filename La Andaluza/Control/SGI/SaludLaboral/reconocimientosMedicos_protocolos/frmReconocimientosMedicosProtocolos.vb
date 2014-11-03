Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmReconocimientosMedicosProtocolos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboReconocimientosMedicosProtocolos As DBO_ReconocimientosMedicosProtocolos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spReconocimientosMedicosProtocolos, MaestroID)
        InitializeComponent()

        dboReconocimientosMedicosProtocolos = New DBO_ReconocimientosMedicosProtocolos


        MyBase.newRegForm = New frmEntReconocimientosMedicosProtocolos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicosProtocolos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboReconocimientosMedicosProtocolos = CType(sp, spReconocimientosMedicosProtocolos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboReconocimientosMedicosProtocolos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicosProtocolos)
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
                .FormatoColumna("FechaRealizado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Referencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
