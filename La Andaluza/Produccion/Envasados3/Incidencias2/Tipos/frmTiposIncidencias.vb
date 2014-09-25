Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposIncidencias As DBO_TiposIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposIncidencias, MaestroID)
        InitializeComponent()

        dboTiposIncidencias = New DBO_TiposIncidencias


        MyBase.newRegForm = New frmEntTiposIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboTiposIncidencias = New DBO_TiposIncidencias
        If m_MaestroID <> "0" And m_MaestroID <> "" Then
            dboTiposIncidencias.Id_IncidenciaCalidadGeneral = m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboTiposIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposIncidencias = CType(sp, spTiposIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboTiposIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposIncidencias)
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
                .FormatoColumna("Maquina", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Clase", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Categoria", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Duracion", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("IncidenciaCalidad", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
