Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCategoriaIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboCategoriaIncidencias As DBO_CategoriaIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spCategoriaIncidencias, MaestroID)
        InitializeComponent()

        dboCategoriaIncidencias = New DBO_CategoriaIncidencias


        MyBase.newRegForm = New frmEntCategoriaIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboCategoriaIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboCategoriaIncidencias = CType(sp, spCategoriaIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboCategoriaIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboCategoriaIncidencias)
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

            End With
        End If



    End Sub

End Class
