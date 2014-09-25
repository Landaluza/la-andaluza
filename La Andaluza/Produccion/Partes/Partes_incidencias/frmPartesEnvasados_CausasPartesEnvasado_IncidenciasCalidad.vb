Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad As DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad, MaestroID)
        InitializeComponent()

        dboPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad = New DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad


        MyBase.newRegForm = New frmEntPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad = New DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad

        If m_MaestroID <> 0 Then
            dboPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad.Id_ParteEnvasado_causaParteEnvasado = m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad = CType(sp, spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad)
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
                .FormatoColumna("HoraInicio", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Id_ParteEnvasado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
