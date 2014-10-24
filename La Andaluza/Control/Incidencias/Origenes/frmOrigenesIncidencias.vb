Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmOrigenesIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboOrigenesIncidencias As DBO_OrigenesIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spOrigenesIncidencias, MaestroID)
        InitializeComponent()

        dboOrigenesIncidencias = New DBO_OrigenesIncidencias


        MyBase.newRegForm = New frmEntOrigenesIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboOrigenesIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboOrigenesIncidencias = CType(sp, spOrigenesIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboOrigenesIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboOrigenesIncidencias)
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
