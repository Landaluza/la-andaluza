Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmClasesIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboClasesIncidencias As DBO_ClasesIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spClasesIncidencias, MaestroID)
        InitializeComponent()
        If m_MaestroID = "" Then m_MaestroID = 0
        dboClasesIncidencias = New DBO_ClasesIncidencias
        MyBase.newRegForm = New frmEntClasesIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboClasesIncidencias = New DBO_ClasesIncidencias
        If m_MaestroID <> 0 Then dboClasesIncidencias.id_procesoCalidad = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboClasesIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboClasesIncidencias = CType(sp, spClasesIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboClasesIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboClasesIncidencias)
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
                .FormatoColumna("Proceso", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
