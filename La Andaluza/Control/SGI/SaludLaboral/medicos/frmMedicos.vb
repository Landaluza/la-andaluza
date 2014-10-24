Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmMedicos
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboMedicos As DBO_Medicos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spMedicos, MaestroID)
        InitializeComponent()

        dboMedicos = New DBO_Medicos


        MyBase.newRegForm = New frmEntMedicos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboMedicos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboMedicos = CType(sp, spMedicos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboMedicos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboMedicos)
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
                .Columns("id").Visible = False
                .FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("apellido", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("apellido2", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
