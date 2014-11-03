Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDDDProductos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboDDDProductos As DBO_DDDProductos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spDDDProductos, MaestroID)
        InitializeComponent()

        dboDDDProductos = New DBO_DDDProductos


        MyBase.newRegForm = New frmEntDDDProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboDDDProductos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboDDDProductos = CType(sp, spDDDProductos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboDDDProductos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboDDDProductos)
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
                .FormatoColumna("RutaFicha", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
