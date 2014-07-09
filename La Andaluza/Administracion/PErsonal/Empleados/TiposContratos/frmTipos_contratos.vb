Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTipos_contratos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTipos_contratos As DBO_Tipos_contratos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTipos_contratos, MaestroID)
        InitializeComponent()


        dboTipos_contratos = New DBO_Tipos_contratos


        MyBase.newRegForm = New frmEntTipos_contratos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTipos_contratos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTipos_contratos = CType(sp, spTipos_contratos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboTipos_contratos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTipos_contratos)
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
                .FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
            End With
        End If
    End Sub
End Class
