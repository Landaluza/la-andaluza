Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPosiciones
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboPosiciones As DBO_Posiciones

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPosiciones, MaestroID)
        InitializeComponent()

        dboPosiciones = New DBO_Posiciones

        MyBase.newRegForm = CType(New frmEntPosiciones(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboPosiciones, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPosiciones = CType(sp, spPosiciones).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboPosiciones Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboPosiciones, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
