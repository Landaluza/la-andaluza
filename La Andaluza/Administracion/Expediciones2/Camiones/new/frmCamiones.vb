Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCamiones
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboCamiones As DBO_Camiones

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spCamiones, MaestroID)
        InitializeComponent()

        dboCamiones = New DBO_Camiones


        MyBase.newRegForm = CType(New frmEntCamiones(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboCamiones, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboCamiones = CType(sp, spCamiones).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboCamiones Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboCamiones, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Agencia", BasesParaCompatibilidad.TiposColumna.Izquierda, 200)
                .FormatoColumna("Conductor", BasesParaCompatibilidad.TiposColumna.Izquierda, 220)
                .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, 80)
                .FormatoColumna("MatriculaCabeza", "Cabeza", BasesParaCompatibilidad.TiposColumna.Izquierda, 80)
                .FormatoColumna("MatriculaRemolque", "Remolque", BasesParaCompatibilidad.TiposColumna.Izquierda, 80)
                .FormatoColumna("Tara", BasesParaCompatibilidad.TiposColumna.Miles, 80)
                .FormatoColumna("PesoMaximo", "Maximo", BasesParaCompatibilidad.TiposColumna.Miles, 80)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 400)
            End With
        End If
    End Sub
End Class
