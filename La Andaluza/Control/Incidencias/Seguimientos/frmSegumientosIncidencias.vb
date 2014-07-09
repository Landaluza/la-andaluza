Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmSegumientosIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboSegumientosIncidencias As DBO_SegumientosIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spSegumientosIncidencias, MaestroID)
        InitializeComponent()

        dboSegumientosIncidencias = New DBO_SegumientosIncidencias


        MyBase.newRegForm = New frmEntSegumientosIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then
            dboSegumientosIncidencias = New DBO_SegumientosIncidencias
            dboSegumientosIncidencias.Id_ControlIncidencia = m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboSegumientosIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboSegumientosIncidencias = CType(sp, spSegumientosIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboSegumientosIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboSegumientosIncidencias)
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
                .FormatoColumna("Responsable", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
