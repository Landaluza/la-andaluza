Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposUsuarios
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboTiposUsuarios As DBO_TiposUsuarios

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposUsuarios, MaestroID)
        InitializeComponent()

        dboTiposUsuarios = New DBO_TiposUsuarios


        MyBase.newRegForm = New frmEntTiposUsuarios(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposUsuarios)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposUsuarios = CType(sp, spTiposUsuarios).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboTiposUsuarios Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposUsuarios)
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
                .Columns("permisos").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If



    End Sub

End Class
