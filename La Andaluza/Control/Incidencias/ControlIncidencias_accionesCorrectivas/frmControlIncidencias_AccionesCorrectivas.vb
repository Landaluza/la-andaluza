Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlIncidencias_AccionesCorrectivas
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboControlIncidencias_AccionesCorrectivas As DBO_ControlIncidencias_AccionesCorrectivas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spControlIncidencias_AccionesCorrectivas, MaestroID)
        InitializeComponent()

        dboControlIncidencias_AccionesCorrectivas = New DBO_ControlIncidencias_AccionesCorrectivas


        MyBase.newRegForm = New frmEntControlIncidencias_AccionesCorrectivas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then
            dboControlIncidencias_AccionesCorrectivas = New DBO_ControlIncidencias_AccionesCorrectivas
            dboControlIncidencias_AccionesCorrectivas.Id_control_incidencia = Me.m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboControlIncidencias_AccionesCorrectivas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboControlIncidencias_AccionesCorrectivas = CType(sp, spControlIncidencias_AccionesCorrectivas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboControlIncidencias_AccionesCorrectivas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboControlIncidencias_AccionesCorrectivas)
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
                .FormatoColumna("AccionCorrectiva", "Accion correctiva", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("FechaPrevista", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Resultados", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
