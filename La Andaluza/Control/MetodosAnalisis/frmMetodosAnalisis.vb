Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmMetodosAnalisis
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboMetodosAnalisis As DBO_MetodosAnalisis

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spMetodosAnalisis, MaestroID)
        InitializeComponent()

        dboMetodosAnalisis = New DBO_MetodosAnalisis


        MyBase.newRegForm = CType(New frmEntMetodosAnalisis(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboMetodosAnalisis, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboMetodosAnalisis = CType(sp, spMetodosAnalisis).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboMetodosAnalisis Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboMetodosAnalisis, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        ' dataSource = dtb.Consultar(Me.sp.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub


End Class
