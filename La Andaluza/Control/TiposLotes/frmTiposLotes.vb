Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposLotes
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboTiposLotes As DBO_TiposLotes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposLotes, MaestroID)
        InitializeComponent()

        dboTiposLotes = New DBO_TiposLotes


        MyBase.newRegForm = New frmEntTiposLotes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposLotes)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposLotes = CType(sp, spTiposLotes).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposLotes Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposLotes)
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
                .FormatoColumna("Abreviatura", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Orden", BasesParaCompatibilidad.TiposColumna.Miles, 50)

            End With
        End If

    End Sub

End Class
