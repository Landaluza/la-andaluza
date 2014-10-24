Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposBotellas
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboTiposBotellas As DBO_TiposBotellas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposBotellas, MaestroID)
        InitializeComponent()
        dboTiposBotellas = New DBO_TiposBotellas


        MyBase.newRegForm = CType(New frmEntTiposBotellas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposBotellas, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposBotellas = CType(sp, spTiposBotellas).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboTiposBotellas Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboTiposBotellas, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("CodigoQS", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Capacidad", BasesParaCompatibilidad.TiposColumna.Double2, 50)
                .FormatoColumna("Envase", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Medida", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
