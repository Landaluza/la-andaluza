Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposProveedoresCero
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboTiposProveedoresCero As DBO_TiposProveedoresCero

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposProveedoresCero, MaestroID)
        InitializeComponent()

        dboTiposProveedoresCero = New DBO_TiposProveedoresCero


        MyBase.newRegForm = New frmEntTiposProveedoresCero(ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboTiposProveedoresCero = New DBO_TiposProveedoresCero
        If m_MaestroID <> 0 Then dboTiposProveedoresCero.Nombre = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboTiposProveedoresCero)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposProveedoresCero = CType(sp, spTiposProveedoresCero).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposProveedoresCero Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposProveedoresCero)
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
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
