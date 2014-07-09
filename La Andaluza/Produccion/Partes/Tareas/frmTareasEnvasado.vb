Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTareasEnvasado
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTareasEnvasado As DBO_TareasEnvasado

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTareasEnvasado, MaestroID)
        InitializeComponent()

        dboTareasEnvasado = New DBO_TareasEnvasado


        MyBase.newRegForm = New frmEntTareasEnvasado(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTareasEnvasado)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTareasEnvasado = CType(sp, spTareasEnvasado).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboTareasEnvasado Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTareasEnvasado)
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
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
