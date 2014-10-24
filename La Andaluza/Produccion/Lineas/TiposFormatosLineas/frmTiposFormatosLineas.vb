Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposFormatosLineas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboTiposFormatosLineas As DBO_TiposFormatosLineas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposFormatosLineas, MaestroID)
        InitializeComponent()

        dboTiposFormatosLineas = New DBO_TiposFormatosLineas


        MyBase.newRegForm = New frmEntTiposFormatosLineas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposFormatosLineas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposFormatosLineas = CType(sp, spTiposFormatosLineas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposFormatosLineas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposFormatosLineas)
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
                .FormatoColumna("LineaEnvasadoID", "Linea", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
