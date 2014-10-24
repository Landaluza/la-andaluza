Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposMateriales
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposMateriales As DBO_TiposMateriales

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposMateriales, MaestroID)
        InitializeComponent()

        dboTiposMateriales = New DBO_TiposMateriales


        MyBase.newRegForm = New frmEntTiposMateriales(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposMateriales)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposMateriales = CType(sp, spTiposMateriales).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposMateriales Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposMateriales)
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
