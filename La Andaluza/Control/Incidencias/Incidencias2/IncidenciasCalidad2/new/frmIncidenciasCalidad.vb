Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmIncidenciasCalidad
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboIncidenciasCalidad As DBO_IncidenciasCalidad

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spIncidenciasCalidad, MaestroID)
        InitializeComponent()

        dboIncidenciasCalidad = New DBO_IncidenciasCalidad


        MyBase.newRegForm = New frmEntIncidenciasCalidad(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboIncidenciasCalidad = New DBO_IncidenciasCalidad
        If m_MaestroID <> 0 Then dboIncidenciasCalidad.IncidenciaID = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboIncidenciasCalidad)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboIncidenciasCalidad = CType(sp, spIncidenciasCalidad).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboIncidenciasCalidad Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboIncidenciasCalidad)
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
                .FormatoColumna("HoraInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("HoraFin", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Lote", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("RutaDocumento", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Material", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
