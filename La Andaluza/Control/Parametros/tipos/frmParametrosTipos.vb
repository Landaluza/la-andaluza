Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmParametrosTipos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboParametrosTipos As DBO_ParametrosTipos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spParametrosTipos, MaestroID)
        InitializeComponent()

        dboParametrosTipos = New DBO_ParametrosTipos


        MyBase.newRegForm = New frmEntParametrosTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboParametrosTipos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboParametrosTipos = CType(sp, spParametrosTipos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboParametrosTipos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboParametrosTipos)
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
                .FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
