Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCamionesTipos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboCamionesTipos As DBO_CamionesTipos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spCamionesTipos, MaestroID)
        InitializeComponent()

        dboCamionesTipos = New DBO_CamionesTipos


        MyBase.newRegForm = CType(New frmEntCamionesTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboCamionesTipos, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboCamionesTipos = CType(sp, spCamionesTipos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboCamionesTipos Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboCamionesTipos, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 400)
            End With
        End If
    End Sub
End Class
