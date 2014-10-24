Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposReuniones
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboTiposReuniones As DBO_TiposReuniones

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposReuniones, MaestroID)
        InitializeComponent()

        dboTiposReuniones = New DBO_TiposReuniones


        MyBase.newRegForm = New frmEntTiposReuniones(ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboTiposReuniones = New DBO_TiposReuniones
        If m_MaestroID <> 0 Then dboTiposReuniones.nombre = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboTiposReuniones)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposReuniones = CType(sp, spTiposReuniones).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposReuniones Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposReuniones)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        GeneralBindingSource.DataSource = dataSource ' DataTableFill(Me.sp.DataGridViewStoredProcedure)

        If Not GeneralBindingSource.DataSource Is Nothing Then
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
