Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposProductos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposProductos As DBO_TiposProductos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposProductos, MaestroID)
        InitializeComponent()

        dboTiposProductos = New DBO_TiposProductos


        MyBase.newRegForm = New frmEntTiposProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposProductos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboTiposProductos = CType(sp, spTiposProductos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposProductos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposProductos)
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
                .FormatoColumna("Abreviatura", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Medida", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("NC", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
