Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmIncidenciasCalidadGeneral_tiposIncEnv
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboTiposIncidencias As DBO_TiposIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposIncidencias, MaestroID)
        InitializeComponent()

        dboTiposIncidencias = New DBO_TiposIncidencias


        MyBase.newRegForm = New frmEntIncidenciasCalidadGenral_tiposIncEnv(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboTiposIncidencias = New DBO_TiposIncidencias
        If m_MaestroID <> 0 Then dboTiposIncidencias.Id_IncidenciaCalidadGeneral = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboTiposIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboTiposIncidencias = CType(sp, spTiposIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
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

    Public Overrides Sub Eliminar(Optional ByVal campoId As String = "Id")
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvGeneral.Rows.Count > 0 Then
                Dim spTipos As New spTiposIncidencias
                Dim dtb As New BasesParaCompatibilidad.DataBase
                Dim DBO_TiposIncidencias As DBO_TiposIncidencias = spTipos.Select_Record(Me.dgvGeneral.CurrentRow.Cells(campoId).Value, dtb)
                DBO_TiposIncidencias.Id_IncidenciaCalidadGeneral = Nothing

                If spTipos.Grabar(DBO_TiposIncidencias, dtb) Then
                    dgvFill()
                Else
                    MessageBox.Show("No se pudo completar la acción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("No se pudo eliminar el registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class