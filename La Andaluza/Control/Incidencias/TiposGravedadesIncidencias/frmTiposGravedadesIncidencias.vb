Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposGravedadesIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposGravedadesIncidencias As DBO_TiposGravedadesIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposGravedadesIncidencias, MaestroID)
        InitializeComponent()

        dboTiposGravedadesIncidencias = New DBO_TiposGravedadesIncidencias


        MyBase.newRegForm = New frmEntTiposGravedadesIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposGravedadesIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposGravedadesIncidencias = CType(sp, spTiposGravedadesIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboTiposGravedadesIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposGravedadesIncidencias)
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
                .FormatoColumna("descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Valores", BasesParaCompatibilidad.TiposColumna.Double2, 50)

            End With
        End If



    End Sub

End Class
