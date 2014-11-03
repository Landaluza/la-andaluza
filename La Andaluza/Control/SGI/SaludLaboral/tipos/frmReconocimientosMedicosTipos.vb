Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmReconocimientosMedicosTipos
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboReconocimientosMedicosTipos As DBO_ReconocimientosMedicosTipos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spReconocimientosMedicosTipos, MaestroID)
        InitializeComponent()

        dboReconocimientosMedicosTipos = New DBO_ReconocimientosMedicosTipos


        MyBase.newRegForm = New frmEntReconocimientosMedicosTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicosTipos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboReconocimientosMedicosTipos = CType(sp, spReconocimientosMedicosTipos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboReconocimientosMedicosTipos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboReconocimientosMedicosTipos)
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

            End With
        End If



    End Sub

End Class
