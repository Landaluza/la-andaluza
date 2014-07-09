Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosTipos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboArticulosTipos As DBO_ArticulosTipos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spArticulosTipos, MaestroID)
        InitializeComponent()
        dboArticulosTipos = New DBO_ArticulosTipos


        MyBase.newRegForm = New frmEntArticulosTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboArticulosTipos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboArticulosTipos = CType(sp, spArticulosTipos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboArticulosTipos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboArticulosTipos)
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
                .FormatoColumna("Nombre", "Responsable", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Utilizacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Codificacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
