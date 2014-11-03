Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmGrupos_riesgo
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboGrupos_riesgo As DBO_Grupos_riesgo

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spGrupos_riesgo, MaestroID)
        InitializeComponent()

        dboGrupos_riesgo = New DBO_Grupos_riesgo


        MyBase.newRegForm = New frmEntGrupos_riesgo(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboGrupos_riesgo)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboGrupos_riesgo = CType(sp, spGrupos_riesgo).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboGrupos_riesgo Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboGrupos_riesgo)
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
                .Columns("id").Visible = False
                .FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
