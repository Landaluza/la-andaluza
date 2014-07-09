Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProcessosCalidad_Clasesenvasado
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboClasesIncidencias As DBO_ClasesIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spClasesIncidencias, MaestroID)
        InitializeComponent()

        dboClasesIncidencias = New DBO_ClasesIncidencias


        MyBase.newRegForm = New frmEntProcessosCalidad_Clasesenvasado(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then dboClasesIncidencias.id_procesoCalidad = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboClasesIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboClasesIncidencias = CType(sp, spClasesIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboClasesIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboClasesIncidencias)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Overrides Sub Eliminar(Optional ByVal campoId As String = "Id")
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor

            If Me.dgvGeneral.Rows.Count > 0 Then
                Dim spClases As New spClasesIncidencias
                Dim DBO_ClasesIncidencias As DBO_ClasesIncidencias = spClases.Select_Record(Me.dgvGeneral.CurrentRow.Cells(campoId).Value)
                DBO_ClasesIncidencias.id_procesoCalidad = Nothing

                If spClases.Grabar(DBO_ClasesIncidencias) Then
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