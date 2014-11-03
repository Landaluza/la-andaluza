Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlIncidencias_AccionesPreventivas
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboControlIncidencias_AccionesPreventivas As DBO_ControlIncidencias_AccionesPreventivas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spControlIncidencias_AccionesPreventivas, MaestroID)
        InitializeComponent()

        dboControlIncidencias_AccionesPreventivas = New DBO_ControlIncidencias_AccionesPreventivas


        MyBase.newRegForm = New frmEntControlIncidencias_AccionesPreventivas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then
            dboControlIncidencias_AccionesPreventivas = New DBO_ControlIncidencias_AccionesPreventivas
            dboControlIncidencias_AccionesPreventivas.Id_ControlIncidencias = Me.m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboControlIncidencias_AccionesPreventivas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboControlIncidencias_AccionesPreventivas = CType(sp, spControlIncidencias_AccionesPreventivas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboControlIncidencias_AccionesPreventivas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboControlIncidencias_AccionesPreventivas)
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
                .FormatoColumna("AccionPreventiva", "Accion preventiva", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("FechaPrevista", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("FechaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Resultados", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
