Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDDDPersonasAutorizadas
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboDDDPersonasAutorizadas As DBO_DDDPersonasAutorizadas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spDDDPersonasAutorizadas, MaestroID)
        InitializeComponent()

        dboDDDPersonasAutorizadas = New DBO_DDDPersonasAutorizadas


        MyBase.newRegForm = New frmEntDDDPersonasAutorizadas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboDDDPersonasAutorizadas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboDDDPersonasAutorizadas = CType(sp, spDDDPersonasAutorizadas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboDDDPersonasAutorizadas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboDDDPersonasAutorizadas)
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
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("RutaCarnetManipulador", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
