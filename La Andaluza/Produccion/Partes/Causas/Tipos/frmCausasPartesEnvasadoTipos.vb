Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCausasPartesEnvasadoTipos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboCausasPartesEnvasadoTipos As DBO_CausasPartesEnvasadoTipos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spCausasPartesEnvasadoTipos, MaestroID)
        InitializeComponent()

        dboCausasPartesEnvasadoTipos = New DBO_CausasPartesEnvasadoTipos


        MyBase.newRegForm = New frmEntCausasPartesEnvasadoTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboCausasPartesEnvasadoTipos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboCausasPartesEnvasadoTipos = CType(sp, spCausasPartesEnvasadoTipos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboCausasPartesEnvasadoTipos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboCausasPartesEnvasadoTipos)
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

            End With
        End If



    End Sub

End Class
