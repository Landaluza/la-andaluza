Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosEtiquetasTipos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboArticulosEtiquetasTipos As DBO_ArticulosEtiquetasTipos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spArticulosEtiquetasTipos, MaestroID)
        InitializeComponent()

        dboArticulosEtiquetasTipos = New DBO_ArticulosEtiquetasTipos

        MyBase.newRegForm = CType(New frmEntArticulosEtiquetasTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboArticulosEtiquetasTipos, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboArticulosEtiquetasTipos = CType(sp, spArticulosEtiquetasTipos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboArticulosEtiquetasTipos Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboArticulosEtiquetasTipos, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Utilizacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub





End Class
