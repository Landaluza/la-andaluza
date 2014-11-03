Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAccionesInmediatas_ControlIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboAccionesInmediatas_ControlIncidencias As DBO_AccionesInmediatas_ControlIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAccionesInmediatas_ControlIncidencias, MaestroID)
        InitializeComponent()

        dboAccionesInmediatas_ControlIncidencias = New DBO_AccionesInmediatas_ControlIncidencias


        MyBase.newRegForm = New frmEntAccionesInmediatas_ControlIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then
            dboAccionesInmediatas_ControlIncidencias = New DBO_AccionesInmediatas_ControlIncidencias
            dboAccionesInmediatas_ControlIncidencias.Id_ControlIncidencias = Me.m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboAccionesInmediatas_ControlIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboAccionesInmediatas_ControlIncidencias = CType(sp, spAccionesInmediatas_ControlIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboAccionesInmediatas_ControlIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAccionesInmediatas_ControlIncidencias)
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
                .FormatoColumna("AccionInmediata", "Accion inmediata", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
