Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPedidosProveedoresEstados
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboPedidosProveedoresEstados As DBO_PedidosProveedoresEstados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPedidosProveedoresEstados, MaestroID)
        InitializeComponent()

        dboPedidosProveedoresEstados = New DBO_PedidosProveedoresEstados


        MyBase.newRegForm = CType(New frmEntPedidosProveedoresEstados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboPedidosProveedoresEstados, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPedidosProveedoresEstados = CType(sp, spPedidosProveedoresEstados).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboPedidosProveedoresEstados Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboPedidosProveedoresEstados, BasesParaCompatibilidad.DataBussines))
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
