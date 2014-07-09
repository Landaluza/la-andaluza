Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposControlesLotesPlantilla
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposControlesLotesPlantilla As DBO_TiposControlesLotesPlantilla

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposControlesLotesPlantilla, MaestroID)
        InitializeComponent()

        dboTiposControlesLotesPlantilla = New DBO_TiposControlesLotesPlantilla


        MyBase.newRegForm = CType(New frmEntTiposControlesLotesPlantilla(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        Dim f As New frmEntTiposControlesLotesPlantilla(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        MyBase.newRegForm = CType(f, BasesParaCompatibilidad.DetailedSimpleForm)
        AddHandler newRegForm.afterSave, AddressOf dgvFill
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposControlesLotesPlantilla, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposControlesLotesPlantilla = CType(sp, spTiposControlesLotesPlantilla).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboTiposControlesLotesPlantilla Is Nothing Then
            Dim f As New frmEntTiposControlesLotesPlantilla(BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, sp)
            MyBase.newRegForm = CType(f, BasesParaCompatibilidad.DetailedSimpleForm)
            AddHandler newRegForm.afterSave, AddressOf dgvFill
            newRegForm.SetDataBussinesObject(CType(Me.dboTiposControlesLotesPlantilla, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Control", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("TipoLote", "Tipo lote", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Producto", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Frecuencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Procedimiento", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
