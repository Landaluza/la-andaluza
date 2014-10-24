Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDDDAcciones
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboDDDAcciones As DBO_DDDAcciones

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spDDDAcciones, MaestroID)
        InitializeComponent()

        dboDDDAcciones = New DBO_DDDAcciones


        MyBase.newRegForm = New frmEntDDDAcciones(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboDDDAcciones)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboDDDAcciones = CType(sp, spDDDAcciones).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboDDDAcciones Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboDDDAcciones)
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
