Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPedidosClientesNecesidades
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboPedidosClientesNecesidades As DBO_PedidosClientesNecesidades

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPedidosClientesNecesidades, MaestroID)
        InitializeComponent()

        dboPedidosClientesNecesidades = New DBO_PedidosClientesNecesidades


        MyBase.newRegForm = CType(New frmEntPedidosClientesNecesidades(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboPedidosClientesNecesidades, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboPedidosClientesNecesidades = CType(sp, spPedidosClientesNecesidades).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboPedidosClientesNecesidades Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboPedidosClientesNecesidades, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
