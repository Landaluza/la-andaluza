Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProtocolosMedicos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboProtocolosMedicos As DBO_ProtocolosMedicos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProtocolosMedicos, MaestroID)
        InitializeComponent()

        dboProtocolosMedicos = New DBO_ProtocolosMedicos


        MyBase.newRegForm = New frmEntProtocolosMedicos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboProtocolosMedicos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboProtocolosMedicos = CType(sp, spProtocolosMedicos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboProtocolosMedicos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboProtocolosMedicos)
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
                .FormatoColumna("Referencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("FechaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("FechaFinal", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Medico", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
