Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsMovimientosTipos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboPaletsMovimientosTipos As DBO_PaletsMovimientosTipos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPaletsMovimientosTipos, MaestroID)
        InitializeComponent()

        dboPaletsMovimientosTipos = New DBO_PaletsMovimientosTipos


        MyBase.newRegForm = New frmEntPaletsMovimientosTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboPaletsMovimientosTipos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPaletsMovimientosTipos = CType(sp, spPaletsMovimientosTipos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboPaletsMovimientosTipos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboPaletsMovimientosTipos)
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
                .FormatoColumna("Utilizacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
