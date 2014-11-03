Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposAcciones
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboTiposAcciones As DBO_TiposAcciones

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposAcciones, MaestroID)
        InitializeComponent()

        dboTiposAcciones = New DBO_TiposAcciones


        MyBase.newRegForm = New frmEntTiposAcciones(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub





    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposAcciones)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboTiposAcciones = CType(sp, spTiposAcciones).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposAcciones Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposAcciones)
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
