Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmIncidenciasCalidadGeneral
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboIncidenciasCalidadGeneral As DBO_IncidenciasCalidadGeneral




    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spIncidenciasCalidadGeneral, MaestroID)
        InitializeComponent()

        dboIncidenciasCalidadGeneral = New DBO_IncidenciasCalidadGeneral


        MyBase.newRegForm = New frmEntIncidenciasCalidadGeneral(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboIncidenciasCalidadGeneral)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboIncidenciasCalidadGeneral = CType(sp, spIncidenciasCalidadGeneral).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboIncidenciasCalidadGeneral Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboIncidenciasCalidadGeneral)
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
                .FormatoColumna("FechaApertura", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("CriterioFrecuenciaBaja", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("CriterioFrecuenciaMedia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("CriterioFrecuenciaAlta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("CriterioGravedadLeve", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("CriterioGravedadModerada", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("CriterioGravedadGrave", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Detalles", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
