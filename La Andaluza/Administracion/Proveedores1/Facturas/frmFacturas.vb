Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmFacturas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboFacturas As DBO_Facturas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spFacturas, MaestroID)
        InitializeComponent()

        dboFacturas = New DBO_Facturas


        MyBase.newRegForm = New frmEntFacturas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboFacturas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboFacturas = CType(sp, spFacturas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboFacturas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboFacturas)
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
                .FormatoColumna("numero", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("archivo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
