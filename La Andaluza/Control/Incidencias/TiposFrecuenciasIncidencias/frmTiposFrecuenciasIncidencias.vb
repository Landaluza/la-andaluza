Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposFrecuenciasIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposFrecuenciasIncidencias As DBO_TiposFrecuenciasIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposFrecuenciasIncidencias, MaestroID)
        InitializeComponent()

        dboTiposFrecuenciasIncidencias = New DBO_TiposFrecuenciasIncidencias


        MyBase.newRegForm = New frmEntTiposFrecuenciasIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposFrecuenciasIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposFrecuenciasIncidencias = CType(sp, spTiposFrecuenciasIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposFrecuenciasIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposFrecuenciasIncidencias)
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
                .FormatoColumna("Valor", BasesParaCompatibilidad.TiposColumna.Double2, 50)

            End With
        End If



    End Sub

End Class
