Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEstadosControlesIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboEstadosControlesIncidencias As DBO_EstadosControlesIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spEstadosControlesIncidencias, MaestroID)
        InitializeComponent()

        dboEstadosControlesIncidencias = New DBO_EstadosControlesIncidencias


        MyBase.newRegForm = New frmEntEstadosControlesIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboEstadosControlesIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboEstadosControlesIncidencias = CType(sp, spEstadosControlesIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboEstadosControlesIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboEstadosControlesIncidencias)
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
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Valor", BasesParaCompatibilidad.TiposColumna.Miles, 50)

            End With
        End If



    End Sub

End Class
