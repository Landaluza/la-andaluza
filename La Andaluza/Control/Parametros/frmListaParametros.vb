Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmListaParametros
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboListaParametros As DBO_ListaParametros

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spListaParametros, MaestroID)
        InitializeComponent()

        dboListaParametros = New DBO_ListaParametros


        MyBase.newRegForm = New frmEntListaParametros(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboListaParametros)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboListaParametros = CType(sp, spListaParametros).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboListaParametros Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboListaParametros)
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
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Abreviatura", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
