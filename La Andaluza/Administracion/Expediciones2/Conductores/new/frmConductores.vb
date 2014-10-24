Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmConductores
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboConductores As DBO_Conductores

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spConductores, MaestroID)
        InitializeComponent()

        dboConductores = New DBO_Conductores


        MyBase.newRegForm = CType(New frmEntConductores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboConductores, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboConductores = CType(sp, spConductores).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboConductores Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboConductores, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, 220)
                .FormatoColumna("Apodo", BasesParaCompatibilidad.TiposColumna.Izquierda, 155)
                .FormatoColumna("DNI", BasesParaCompatibilidad.TiposColumna.Derecha, 80)
                .FormatoColumna("Movil", BasesParaCompatibilidad.TiposColumna.Derecha, 80)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 400)
            End With

        End If
    End Sub
End Class
