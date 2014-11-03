Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEmpleados_competencias
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboEmpleados_competencias As DBO_Empleados_competencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spEmpleados_competencias, MaestroID)
        InitializeComponent()

        dboEmpleados_competencias = New DBO_Empleados_competencias


        MyBase.newRegForm = New frmEntEmpleados_competencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
        Me.butEliminar.Visible = False
        Me.butEliminar.Enabled = False
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then dboEmpleados_competencias.id_empleado = Me.m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboEmpleados_competencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboEmpleados_competencias = CType(sp, spEmpleados_competencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboEmpleados_competencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboEmpleados_competencias)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            'GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = dataSource
                .Columns("Id").Visible = False
                .Columns("id_personalCompetencia").Visible = False
                .FormatoColumna("Competencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
