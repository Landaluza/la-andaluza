Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlIncidencias_Causas
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboControlIncidencias_Causas As DBO_ControlIncidencias_Causas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spControlIncidencias_Causas, MaestroID)
        InitializeComponent()

        dboControlIncidencias_Causas = New DBO_ControlIncidencias_Causas


        MyBase.newRegForm = New frmEntControlIncidencias_Causas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then
            dboControlIncidencias_Causas = New DBO_ControlIncidencias_Causas
            dboControlIncidencias_Causas.Id_control_incidencia = Me.m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboControlIncidencias_Causas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboControlIncidencias_Causas = CType(sp, spControlIncidencias_Causas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboControlIncidencias_Causas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboControlIncidencias_Causas)
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
                .FormatoColumna("Causa", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)

            End With
        End If



    End Sub

End Class
