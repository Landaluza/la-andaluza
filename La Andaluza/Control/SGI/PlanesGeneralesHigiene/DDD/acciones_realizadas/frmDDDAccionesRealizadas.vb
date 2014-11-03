Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDDDAccionesRealizadas
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboDDDAccionesRealizadas As DBO_DDDAccionesRealizadas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spDDDAccionesRealizadas, MaestroID)
        InitializeComponent()

        dboDDDAccionesRealizadas = New DBO_DDDAccionesRealizadas


        MyBase.newRegForm = New frmEntDDDAccionesRealizadas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboDDDAccionesRealizadas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboDDDAccionesRealizadas = CType(sp, spDDDAccionesRealizadas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboDDDAccionesRealizadas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboDDDAccionesRealizadas)
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
                .FormatoColumna("Plan", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("FechaPlanificada", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("FechaEjecutada", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Producto", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Accion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("RutaParteTrabajo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
