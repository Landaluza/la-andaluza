Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAgenciasTransportes
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAgenciasTransportes As DBO_AgenciasTransportes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAgenciasTransportes, MaestroID)
        InitializeComponent()

        dboAgenciasTransportes = New DBO_AgenciasTransportes


        MyBase.newRegForm = CType(New frmEntAgenciasTransportes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboAgenciasTransportes, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboAgenciasTransportes = CType(sp, spAgenciasTransportes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboAgenciasTransportes Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboAgenciasTransportes, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 400)
            End With
        End If
    End Sub
End Class
