Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposFormatosLineas_TiposFormatos
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboTiposFormatosLineas_TiposFormatos As DBO_TiposFormatosLineas_TiposFormatos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposFormatosLineas_TiposFormatos, MaestroID)
        InitializeComponent()

        dboTiposFormatosLineas_TiposFormatos = New DBO_TiposFormatosLineas_TiposFormatos


        MyBase.newRegForm = New frmEntTiposFormatosLineas_TiposFormatos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)

        If MaestroID <> Nothing Then
            Me.dgvGeneral.ContextMenuStrip = MyBase.ContextMenuStrip1
            Dim cms As ToolStripItem = MyBase.ContextMenuStrip1.Items.Add("Modificar velocidad y personal")
            AddHandler cms.Click, AddressOf modificarEnLote
        End If
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboTiposFormatosLineas_TiposFormatos = New DBO_TiposFormatosLineas_TiposFormatos
        If m_MaestroID <> 0 Then dboTiposFormatosLineas_TiposFormatos.TipoFormatoLineaID = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboTiposFormatosLineas_TiposFormatos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposFormatosLineas_TiposFormatos = CType(sp, spTiposFormatosLineas_TiposFormatos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboTiposFormatosLineas_TiposFormatos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposFormatosLineas_TiposFormatos)
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
                .FormatoColumna("FormatoEnvasado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Velocidad", BasesParaCompatibilidad.TiposColumna.Miles, 90)
                .FormatoColumna("PersonalRecomendado", "Personal recomendado", BasesParaCompatibilidad.TiposColumna.Miles, 90)
                .Columns("FormatoLinea").Visible = False
                .Columns("TipoFormatoID").Visible = False
                .Columns("Id").Visible = False

            End With
        End If



    End Sub

    Private Sub modificarEnLote()
        Dim spTiposFormatosLineas_TiposFormatos As New spTiposFormatosLineas_TiposFormatos
        Dim frm As New frmModLoteTiposFormatosLineas_TiposFormatos
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

        If frm.retorno = DialogResult.OK Then
            Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
            dtb.EmpezarTransaccion()
            Try
                If frm.velocidad_modificada And frm.personal_modificado Then
                    For Each row As DataGridViewRow In Me.dgvGeneral.SelectedRows
                        If Not spTiposFormatosLineas_TiposFormatos.modificar_personal_y_velocidad(dtb, row.Cells("Id").Value, frm.personal, frm.velocidad) Then
                            Throw New Exception("Fallo al realizar una operacion")
                        End If
                    Next
                Else
                    If frm.velocidad_modificada Then
                        For Each row As DataGridViewRow In Me.dgvGeneral.SelectedRows
                            If Not spTiposFormatosLineas_TiposFormatos.modificar_velocidad(dtb, row.Cells("Id").Value, frm.velocidad) Then
                                Throw New Exception("Fallo al realizar una operacion")
                            End If
                        Next
                    Else
                        If frm.personal_modificado Then
                            For Each row As DataGridViewRow In Me.dgvGeneral.SelectedRows
                                If Not spTiposFormatosLineas_TiposFormatos.modificar_personal(dtb, row.Cells("Id").Value, frm.personal) Then
                                    Throw New Exception("Fallo al realizar una operacion")
                                End If
                            Next
                        End If
                    End If
                End If


                dtb.TerminarTransaccion()
            Catch ex As Exception
                dtb.CancelarTransaccion()
                MessageBox.Show("Error en la operacion. Detalles:" & Environment.NewLine & ex.Message)
            End Try

            dgvFill()
        End If
    End Sub
End Class

