Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTareasEnvasado_LineasEnvasado
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboTareasEnvasado_LineasEnvasado As DBO_TareasEnvasado_LineasEnvasado

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTareasEnvasado_LineasEnvasado, MaestroID)
        InitializeComponent()

        dboTareasEnvasado_LineasEnvasado = New DBO_TareasEnvasado_LineasEnvasado


        MyBase.newRegForm = New frmEntTareasEnvasado_LineasEnvasado(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboTareasEnvasado_LineasEnvasado = New DBO_TareasEnvasado_LineasEnvasado
        If m_MaestroID <> 0 Then dboTareasEnvasado_LineasEnvasado.Id_LineaEnvasado = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboTareasEnvasado_LineasEnvasado)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTareasEnvasado_LineasEnvasado = CType(sp, spTareasEnvasado_LineasEnvasado).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTareasEnvasado_LineasEnvasado Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTareasEnvasado_LineasEnvasado)
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
                .Columns("Linea").Visible = False
                .FormatoColumna("Tarea", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
